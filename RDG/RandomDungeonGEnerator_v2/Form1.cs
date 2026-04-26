using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace RandomDungeonGEnerator_v2
{
    public partial class fom_Spiel : Form
    {
        //Variablen wleche im ganzen Projekt gebraucht werden
        static int breite = 0;
        static int hoehe = 0;

        static char[,] dungeon;

        static Random rng;

        //Sonstiges & einstellungen
        static int tile_groesse = 16; //Wird benötigt, wenn wir Sprites über einer GRöße von 16x16 nehmen, da sonst die Skalierung zu problemen führt.
                                      //Laut einer KI welche mir die PictureBox erklärte, kann die PictureBox sonst das Bild Ziehen oder Schrumpfen


        //-------------------------------------------------------------Events-------------------------------------------------------------//


        public fom_Spiel()
        {
            InitializeComponent();
            btn_Hinzufuegen.Enabled = false;
            lbl_Informationen.Text = "Höhe bträgt " + hoehe + " | Breite bträgt " + breite;
        }


        private void btn_Hinzufuegen_Click(object sender, EventArgs e)
        {
            int eingabe = Convert.ToInt32(txt_EingabeFeld.Text);

            if (CheckGroeße(eingabe) == true)
            {
                if (breite == 0)
                {
                    breite = eingabe;
                    lbl_EingabeAufforderung.Text = "Bitte Höhe eingeben";
                }
                else
                {
                    hoehe = eingabe;
                }
            }
            else
            {
                MessageBox.Show("Fehler! Diese Eingabe ist nicht Gültig!\n\nDie Eingabe muss mindestens 15 betragen und darf maximal 100 betragen",
                                "Ungültige Eingabe", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

            lbl_Informationen.Text = "Höhe bträgt " + hoehe + " | Breite bträgt " + breite;
        }


        private void txt_EingabeFeld_TextChanged(object sender, EventArgs e)
        {
            // Abfangen von falschen Eingaben wie Buchstaben oder Sonderzeichen
            if (string.IsNullOrWhiteSpace(txt_EingabeFeld.Text) || txt_EingabeFeld.Text.Length > 3 || !int.TryParse(txt_EingabeFeld.Text, out _))
            {
                btn_Hinzufuegen.Enabled = false;
            }
            else
            {
                btn_Hinzufuegen.Enabled = true;
            }
        }


        private void btn_Generieren_Click(object sender, EventArgs e)
        {
            DungeonGenerierung();

            ZeichneDungeon(pbox_dungeon);
        }

        private void fom_Spiel_Load(object sender, EventArgs e)
        {
            fom_Spiel_Resize(sender, e);
        }


        private void fom_Spiel_Resize(object sender, EventArgs e)
        {
            int leftColumnWidth = 150;
            int margin = 10;

            int pbX = leftColumnWidth + margin;
            int pbY = 40;
            int pbWidth = this.ClientSize.Width - pbX - margin;
            int pbHeight = this.ClientSize.Height - pbY - margin;

            pbox_dungeon.SetBounds(pbX, pbY, pbWidth, pbHeight);

            lbl_Informationen.Location = new System.Drawing.Point(pbX + pbWidth / 2, margin);
        }


        //-------------------------------------------------------------Methoden-------------------------------------------------------------//


        static bool CheckGroeße(int eingabe)
        {
            bool istKorrekt = true;

            if (eingabe < 15)
            {
                istKorrekt = false;
            }
            else if (eingabe > 100)
            {
                istKorrekt = false;
            }

            return istKorrekt;
        }


        static void DungeonGenerierung()
        {
            rng = new Random();
            dungeon = new char[hoehe, breite];

            // 1. Alles als Wand initialisieren
            for (int y = 0; y < hoehe; y++)
            {
                for (int x = 0; x < breite; x++)
                {
                    dungeon[y, x] = '#';
                }
            }

            // 2. Räume erzeugen
            List<(int x, int y, int b, int h)> raeume = new List<(int, int, int, int)>();

            int raumAnzahl = Math.Max(1, (breite * hoehe) / 100);

            for (int i = 0; i < raumAnzahl; i++)
            {
                // Raumgrößen abhängig von Dungeon-Größe
                int minGroesse = Math.Max(3, breite / 10);
                int maxGroesse = Math.Max(4, breite / 5);

                int rngBreite = rng.Next(minGroesse, maxGroesse);
                int rngHoehe = rng.Next(minGroesse, maxGroesse);

                int rngBreite2 = rng.Next(1, breite - rngBreite - 1);
                int rngHoehe2 = rng.Next(1, hoehe - rngHoehe - 1);

                var neuerRaum = (rngBreite2, rngHoehe2, rngBreite, rngHoehe);

                bool kollidiert = false;

                foreach (var r in raeume)
                {
                    if (Ueberschneidet(r, neuerRaum))
                    {
                        kollidiert = true;
                        break;
                    }
                }

                if (kollidiert)
                    continue;

                // Raum einzeichnen
                for (int y = rngHoehe2; y < rngHoehe2 + rngHoehe; y++)
                {
                    for (int x = rngBreite2; x < rngBreite2 + rngBreite; x++)
                    {
                        dungeon[y, x] = '.';
                    }
                }

                raeume.Add(neuerRaum);
            }

            // 3. Räume verbinden
            for (int i = 1; i < raeume.Count; i++)
            {
                var r1 = raeume[i - 1];
                var r2 = raeume[i];

                int x1 = r1.x + r1.b / 2;
                int y1 = r1.y + r1.h / 2;
                int x2 = r2.x + r2.b / 2;
                int y2 = r2.y + r2.h / 2;

                // Horizontal
                for (int x = Math.Min(x1, x2); x <= Math.Max(x1, x2); x++)
                    dungeon[y1, x] = '.';

                // Vertikal
                for (int y = Math.Min(y1, y2); y <= Math.Max(y1, y2); y++)
                    dungeon[y, x2] = '.';
            }

            // 4. Start und Ende setzen
            SetzeStartUndEnde();
        }

        static bool Ueberschneidet((int x, int y, int b, int h) a, (int x, int y, int b, int h) b)
        {
            return !(a.x + a.b < b.x || b.x + b.b < a.x || a.y + a.h < b.y || b.y + b.h < a.y);
        }

        static void SetzeStartUndEnde()
        {
            List<(int x, int y)> floor = new List<(int, int)>();

            for (int y = 1; y < hoehe - 1; y++)
                for (int x = 1; x < breite - 1; x++)
                    if (dungeon[y, x] == '.')
                        floor.Add((x, y));

            if (floor.Count < 2) return;

            var s = floor[rng.Next(floor.Count)];
            var e = floor[rng.Next(floor.Count)];

            dungeon[s.y, s.x] = 'S';
            dungeon[e.y, e.x] = 'E';
        }

        static void ZeichneDungeon(PictureBox pbox)
        {
            //Erstellt eine Bitmap basierend auf der Dungeongröße und der Tilegröße
            Bitmap bmp_dungeon = new Bitmap(breite * tile_groesse, hoehe * tile_groesse);

            Graphics grafik = Graphics.FromImage(bmp_dungeon);

            for (int y = 0; y < hoehe; y++)
            {
                for (int x = 0; x < breite; x++)
                {
                    Color farbe;

                    switch (dungeon[y, x])  //TODO: Tausche diese Veränderung zu Farben, mit Sprites aus
                    {
                        case '#':
                            farbe = Color.DarkGray; break;
                        case '.':
                            farbe = Color.SaddleBrown; break;
                        case 'S':
                            farbe = Color.Green; break;
                        case 'E':
                            farbe = Color.Red; break;
                        default:
                            farbe = Color.Black; break;
                    }

                    grafik.FillRectangle(new SolidBrush(farbe), x * tile_groesse, y * tile_groesse, tile_groesse, tile_groesse);
                }
            }

            pbox.Image = bmp_dungeon;
        }
    }
}
