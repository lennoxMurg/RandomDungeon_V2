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
            this.SuspendLayout();
            // 
            // btn_Generieren
            // 
            this.btn_Generieren.Location = new System.Drawing.Point(13, 342);
            this.btn_Generieren.Name = "btn_Generieren";
            this.btn_Generieren.Size = new System.Drawing.Size(75, 23);
            this.btn_Generieren.TabIndex = 0;
            this.btn_Generieren.Text = "Generieren";
            this.btn_Generieren.UseVisualStyleBackColor = true;
            // 
            // btn_Einstellungen
            // 
            this.btn_Einstellungen.Location = new System.Drawing.Point(13, 415);
            this.btn_Einstellungen.Name = "btn_Einstellungen";
            this.btn_Einstellungen.Size = new System.Drawing.Size(75, 23);
            this.btn_Einstellungen.TabIndex = 0;
            this.btn_Einstellungen.Text = "Einstellungen";
            this.btn_Einstellungen.UseVisualStyleBackColor = true;
            // 
            // lbl_EingabeAufforderung
            // 
            this.lbl_EingabeAufforderung.AutoSize = true;
            this.lbl_EingabeAufforderung.Location = new System.Drawing.Point(23, 22);
            this.lbl_EingabeAufforderung.Name = "lbl_EingabeAufforderung";
            this.lbl_EingabeAufforderung.Size = new System.Drawing.Size(89, 13);
            this.lbl_EingabeAufforderung.TabIndex = 1;
            this.lbl_EingabeAufforderung.Text = "Bitte xy Eingeben";
            // 
            // fom_Spiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_EingabeAufforderung);
            this.Controls.Add(this.btn_Einstellungen);
            this.Controls.Add(this.btn_Generieren);
            this.Name = "fom_Spiel";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Generieren;
        private System.Windows.Forms.Button btn_Einstellungen;
        private System.Windows.Forms.Label lbl_EingabeAufforderung;
    }
}

