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
    public partial class nekadaroldu : MetroForm
    {
        public nekadaroldu()
        {
            InitializeComponent();
        }

        public string getuptime()
        {

            String cevap = String.Empty;

            cevap += Convert.ToString(Environment.TickCount / 86400000) + " DAY";
            cevap += "\n";
            cevap += Convert.ToString(Environment.TickCount / 3600000 % 24) + " HOUR";
            cevap += "\n";
            cevap += Convert.ToString(Environment.TickCount / 120000 % 60) + " MINUTE";
            cevap += "\n";
            cevap += Convert.ToString(Environment.TickCount / 1000 % 60) + " SECOND";

            return cevap;

        }

        private void nekadaroldu_Load(object sender, EventArgs e)
        {
            tx_zaman.Text = getuptime();
        }       

        private void nekadaroldu_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
