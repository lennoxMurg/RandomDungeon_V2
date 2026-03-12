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
        public fom_Spiel()
        {
            InitializeComponent();
            btn_Hinzufuegen.Enabled = false;
        }

        private void btn_Hinzufuegen_Click(object sender, EventArgs e)
        {
            
            







        }

        private void txt_EingabeFeld_TextChanged(object sender, EventArgs e)
        {
            btn_Hinzufuegen.Enabled = true;
            if (string.IsNullOrWhiteSpace(txt_EingabeFeld.Text) || txt_EingabeFeld.Text.Length > 3)
            {
                btn_Hinzufuegen.Enabled = false;
            }
            else
            {
                btn_Hinzufuegen.Enabled = true;
            }
        }
    }
}
