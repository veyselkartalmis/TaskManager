using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace GÖREV_YÖNETİCİSİ_YENİ_
{
    public partial class calistir : MetroForm
    {
        public calistir()
        {
            InitializeComponent();
        }

        private void btn_calistir_Click(object sender, EventArgs e)
        {
            try
            {
                string komut = tx_komut.Text.ToLower();
                System.Diagnostics.Process.Start(komut);
                tx_komut.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("WRONG!", "WRONG", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tx_komut.Clear();
            }
        }
       
    }
}
