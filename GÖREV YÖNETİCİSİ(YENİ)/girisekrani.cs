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

namespace GÖREV_YÖNETİCİSİ_YENİ_
{
    public partial class girisekrani : MetroForm
    {
        public girisekrani()
        {
            InitializeComponent();
        }

        private void girisekrani_Load(object sender, EventArgs e)
        {
            
        }

        private void giris_Tick(object sender, EventArgs e)
        {
            prb_giris.Increment(4);
            if (prb_giris.Value  == 100)
            {
                this.Close();
            }
            
        }
    }
}
