namespace RandomDungeonGEnerator_v2
{
    partial class fom_Spiel
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Generieren = new System.Windows.Forms.Button();
            this.btn_Einstellungen = new System.Windows.Forms.Button();
            this.lbl_EingabeAufforderung = new System.Windows.Forms.Label();
            this.lbl_Informationen = new System.Windows.Forms.Label();
            this.lbl_Score = new System.Windows.Forms.Label();
            this.btn_Hinzufuegen = new System.Windows.Forms.Button();
            this.txt_EingabeFeld = new System.Windows.Forms.TextBox();
            this.pbox_dungeon = new System.Windows.Forms.PictureBox();
            this.lstbox_Einstellungen = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_dungeon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Generieren
            // 
            this.btn_Generieren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Generieren.AutoSize = true;
            this.btn_Generieren.Location = new System.Drawing.Point(13, 277);
            this.btn_Generieren.Name = "btn_Generieren";
            this.btn_Generieren.Size = new System.Drawing.Size(86, 32);
            this.btn_Generieren.TabIndex = 0;
            this.btn_Generieren.Text = "Generieren";
            this.btn_Generieren.UseVisualStyleBackColor = true;
            this.btn_Generieren.Click += new System.EventHandler(this.btn_Generieren_Click);
            // 
            // btn_Einstellungen
            // 
            this.btn_Einstellungen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Einstellungen.Location = new System.Drawing.Point(13, 354);
            this.btn_Einstellungen.Name = "btn_Einstellungen";
            this.btn_Einstellungen.Size = new System.Drawing.Size(86, 28);
            this.btn_Einstellungen.TabIndex = 0;
            this.btn_Einstellungen.Text = "Einstellungen";
            this.btn_Einstellungen.UseVisualStyleBackColor = true;
            // 
            // lbl_EingabeAufforderung
            // 
            this.lbl_EingabeAufforderung.AutoSize = true;
            this.lbl_EingabeAufforderung.Location = new System.Drawing.Point(10, 22);
            this.lbl_EingabeAufforderung.Name = "lbl_EingabeAufforderung";
            this.lbl_EingabeAufforderung.Size = new System.Drawing.Size(89, 13);
            this.lbl_EingabeAufforderung.TabIndex = 1;
            this.lbl_EingabeAufforderung.Text = "Bitte xy Eingeben";
            // 
            // lbl_Informationen
            // 
            this.lbl_Informationen.AutoSize = true;
            this.lbl_Informationen.Location = new System.Drawing.Point(280, 22);
            this.lbl_Informationen.Name = "lbl_Informationen";
            this.lbl_Informationen.Size = new System.Drawing.Size(71, 13);
            this.lbl_Informationen.TabIndex = 2;
            this.lbl_Informationen.Text = "Informationen";
            this.lbl_Informationen.Visible = false;
            // 
            // lbl_Score
            // 
            this.lbl_Score.AutoSize = true;
            this.lbl_Score.Location = new System.Drawing.Point(381, 22);
            this.lbl_Score.Name = "lbl_Score";
            this.lbl_Score.Size = new System.Drawing.Size(35, 13);
            this.lbl_Score.TabIndex = 2;
            this.lbl_Score.Text = "Score";
            this.lbl_Score.Visible = false;
            // 
            // btn_Hinzufuegen
            // 
            this.btn_Hinzufuegen.Location = new System.Drawing.Point(12, 82);
            this.btn_Hinzufuegen.Name = "btn_Hinzufuegen";
            this.btn_Hinzufuegen.Size = new System.Drawing.Size(87, 23);
            this.btn_Hinzufuegen.TabIndex = 0;
            this.btn_Hinzufuegen.Text = "Hinzufügen";
            this.btn_Hinzufuegen.UseVisualStyleBackColor = true;
            this.btn_Hinzufuegen.Click += new System.EventHandler(this.btn_Hinzufuegen_Click);
            // 
            // txt_EingabeFeld
            // 
            this.txt_EingabeFeld.Location = new System.Drawing.Point(12, 56);
            this.txt_EingabeFeld.Name = "txt_EingabeFeld";
            this.txt_EingabeFeld.Size = new System.Drawing.Size(87, 20);
            this.txt_EingabeFeld.TabIndex = 3;
            this.txt_EingabeFeld.TextChanged += new System.EventHandler(this.txt_EingabeFeld_TextChanged);
            // 
            // pbox_dungeon
            // 
            this.pbox_dungeon.Location = new System.Drawing.Point(200, 60);
            this.pbox_dungeon.Name = "pbox_dungeon";
            this.pbox_dungeon.Size = new System.Drawing.Size(320, 320);
            this.pbox_dungeon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbox_dungeon.TabIndex = 4;
            this.pbox_dungeon.TabStop = false;
            // 
            // lstbox_Einstellungen
            // 
            this.lstbox_Einstellungen.AccessibleName = "";
            this.lstbox_Einstellungen.Cursor = System.Windows.Forms.Cursors.Default;
            this.lstbox_Einstellungen.FormattingEnabled = true;
            this.lstbox_Einstellungen.HorizontalScrollbar = true;
            this.lstbox_Einstellungen.Items.AddRange(new object[] {
            "Einstellungen",
            "Option1",
            "Option2",
            "Option3",
            "Option4",
            "Option5",
            "Option6",
            "Option7",
            "Option8",
            "Option9",
            "Option10"});
            this.lstbox_Einstellungen.Location = new System.Drawing.Point(12, 132);
            this.lstbox_Einstellungen.Name = "lstbox_Einstellungen";
            this.lstbox_Einstellungen.Size = new System.Drawing.Size(111, 139);
            this.lstbox_Einstellungen.TabIndex = 7;
            this.lstbox_Einstellungen.Visible = false;
            // 
            // fom_Spiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(548, 394);
            this.Controls.Add(this.lstbox_Einstellungen);
            this.Controls.Add(this.pbox_dungeon);
            this.Controls.Add(this.txt_EingabeFeld);
            this.Controls.Add(this.lbl_Score);
            this.Controls.Add(this.lbl_Informationen);
            this.Controls.Add(this.lbl_EingabeAufforderung);
            this.Controls.Add(this.btn_Einstellungen);
            this.Controls.Add(this.btn_Hinzufuegen);
            this.Controls.Add(this.btn_Generieren);
            this.Name = "fom_Spiel";
            this.Text = "Random Dungeon Generator";
            this.Load += new System.EventHandler(this.fom_Spiel_Load);
            this.Resize += new System.EventHandler(this.fom_Spiel_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbox_dungeon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Generieren;
        private System.Windows.Forms.Button btn_Einstellungen;
        private System.Windows.Forms.Label lbl_EingabeAufforderung;
        private System.Windows.Forms.Label lbl_Informationen;
        private System.Windows.Forms.Label lbl_Score;
        private System.Windows.Forms.Button btn_Hinzufuegen;
        private System.Windows.Forms.TextBox txt_EingabeFeld;
        private System.Windows.Forms.PictureBox pbox_dungeon;
        private System.Windows.Forms.CheckedListBox lstbox_Einstellungen;
    }
}

