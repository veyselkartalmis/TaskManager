using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GÖREV_YÖNETİCİSİ_YENİ_
{
    public partial class ekrangörüntüsü : MetroForm
    {
        public ekrangörüntüsü()
        {
            InitializeComponent();
        }

        Bitmap resim;
        Graphics gr;

        private void btn_cek_Click(object sender, EventArgs e)
        {
            this.Hide();
            System.Threading.Thread.Sleep(1000);
            resim = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            gr = Graphics.FromImage(resim);
            gr.CopyFromScreen(0, 0, 0, 0, new Size(resim.Width, resim.Height));
            pc_ekran.Image = resim;
            this.Show();
            btn_kaydet.Enabled = true;
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                kaydet.ShowDialog();
                resim.Save(kaydet.FileName + ".jpg", ImageFormat.Jpeg);
                MessageBox.Show("SAVED");
                pc_ekran.Image = null;
            }
            catch (Exception)
            {
                MessageBox.Show("WRONG!");
            }
           
        }

        private void ekrangörüntüsü_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
