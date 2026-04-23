using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomDungeonGEnerator_v2
{
    public partial class fom_Spiel : Form
    {
        //Variablen wleche im ganzen Projekt gebraucht werden
        static int dungeon_breite;
        static int dungeon_hoehe;

        static char[,] dungeon;

        static Random rng;


        //Sprites & Texturen
        static char[] tile_arten;
        static Image[] tile_sprites;

        //Sonstiges & einstellungen
        static int tile_groesse = 16;



        public fom_Spiel()
        {
            InitializeComponent();
            btn_Hinzufuegen.Enabled = false;
            TestDungeon();
        }

        private void btn_Hinzufuegen_Click(object sender, EventArgs e)
        {

        }

        private void txt_EingabeFeld_TextChanged(object sender, EventArgs e)
        {
            // Abfangen von falschen Eingaben wie Buchstaben oder Sonderzeichen
            if (string.IsNullOrWhiteSpace(txt_EingabeFeld.Text) ||
                txt_EingabeFeld.Text.Length > 3 ||
                !int.TryParse(txt_EingabeFeld.Text, out _))
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
            ZeichneDungeon(pbox_dungeon);

        }

        //-------------------------------------------------------------Methoden-------------------------------------------------------------//

        static void TestDungeon()
        {
            dungeon_breite = 5;
            dungeon_hoehe = 5;
            dungeon = new char[dungeon_hoehe, dungeon_breite];

            dungeon = new char[,]
            {
                { '#', '#', '#', '#', '#' },
                { '#', 'S', '.', '.', '#' },
                { '#', '.', '#', '.', '#' },
                { '#', '.', '.', 'E', '#' },
                { '#', '#', '#', '#', '#' }
            };
        }

        static void ZeichneDungeon(PictureBox pbox)
        {
            Bitmap bmp_dungeon = new Bitmap(dungeon_breite * tile_groesse, dungeon_hoehe * tile_groesse); //Erstellt eine Bitmap basierend auf der Dungeongröße und der Tilegröße

            Graphics g = Graphics.FromImage(bmp_dungeon);

            for (int y = 0; y < dungeon_hoehe; y++)
            {
                for (int x = 0; x < dungeon_breite; x++)
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

                    g.FillRectangle(new SolidBrush(farbe), x * tile_groesse, y * tile_groesse, tile_groesse, tile_groesse);
                }
            }

            pbox.Image = bmp_dungeon;
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
            lbl_Score.Location = new System.Drawing.Point(pbX + pbWidth - 60, margin);
        }

        private void fom_Spiel_Load(object sender, EventArgs e)
        {
            fom_Spiel_Resize(sender, e);
        }
    }
}
