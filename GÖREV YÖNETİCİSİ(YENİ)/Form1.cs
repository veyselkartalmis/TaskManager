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
using System.Management;
using System.Runtime.InteropServices;

namespace GÖREV_YÖNETİCİSİ_YENİ_
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags); 
 
        public bool EmptyRecycleBin()
        {
            try
            {
                uint result = SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHERB_NOSOUND | RecycleFlags.SHERB_NOCONFIRMATION);
                if (result > 0)
                    return true;
                else
                    throw new Win32Exception(Marshal.GetLastWin32Error());
            }
            catch (Exception)
            {
                return false;
            }
        }

        enum RecycleFlags : uint
        {
            SHERB_NOCONFIRMATION = 0x00000001,
            SHERB_NOPROGRESSUI = 0x00000002,
            SHERB_NOSOUND = 0x00000004
        } 


        private void Form1_Load(object sender, EventArgs e)
        {
            saat.Start();
            ProgramlariListele();
            metro_yenile.Value = 50;
            metro_gorev.Value = 50; 
        }

        private void listView1_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = listView1.Columns[e.ColumnIndex].Width;
        }

        private void ProgramlariListele()
        {
            listView1.Items.Clear();
            int i = 0;

            foreach (Process p in Process.GetProcesses("."))
            {
                listView1.Items.Add(p.ProcessName);
                listView1.Items[i].SubItems.Add(p.Id.ToString());
                listView1.Items[i].SubItems.Add(Convert.ToInt32(Math.Round(Convert.ToDecimal(p.PrivateMemorySize64 / 1024))) + "KB");
                listView1.Items[i].SubItems.Add(p.Responding.ToString());
                i++;
            }
            lb_total.Text = listView1.Items.Count.ToString();
        }

        private void ProgramKapat(int pid)
        {
            Process.GetProcessById(pid).Kill();
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            metro_gorev.Visible = true;
            timer1.Start();
        }

        private void btn_yenile_Click(object sender, EventArgs e)
        {
            metro_yenile.Visible = true;
            ProgramlariListele();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 3000;
            try
            {
                ProgramKapat(Convert.ToInt32(listView1.SelectedItems[0].SubItems[1].Text));
            }
            catch
            {

            }
            ProgramlariListele();
            timer1.Stop();
            metro_gorev.Visible = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Interval = 2000;
            int i = 0;
            i++;
            if (i == 2)
            {
                ProgramlariListele();
                timer2.Stop();

            }
            metro_yenile.Visible = false;
        }

        private void cpu_Tick(object sender, EventArgs e)
        {
            try
            {
                ManagementObjectSearcher insManagementObjectSearcher = new System.Management.ManagementObjectSearcher(@"root\WMI", "SELECT * FROM MSAcpi_ThermalZoneTemperature");
                foreach (ManagementObject insManagementObject in insManagementObjectSearcher.Get())
                {
                    string s = ((Convert.ToInt32(insManagementObject["CurrentTemperature"]) - 2732) / 10).ToString();
                    lb_cpuısı.Text = s.ToString();

                }
            }
            catch (Exception)
            {
                lb_cpuısı.Text = "YOUR SYSTEM DOES NOT SUPPORT";
            } 
        }

        private void tmr_deger_Tick(object sender, EventArgs e)
        {
            try
            {
                float cpuYuzde = islemci.NextValue();
                lb_cpukullanımı.Text = "% " + cpuYuzde.ToString("N2");
                prg_cpukllnımı.Value = (int)cpuYuzde;
            }
            catch (Exception)
            {
                lb_cpukullanımı.Text = "YOUR SYSTEM DOES NOT SUPPORT";
            }

            try
            {
                float ramYuzde = ram.NextValue();
                lb_ramkllnma.Text = "% " + ramYuzde.ToString("N2");
                prg_ram.Value = (int)ramYuzde;
            }
            catch (Exception)
            {
                lb_ramkllnma.Text = "YOUR SYSTEM DOES NOT SUPPORT";
            }
        }

        private void saat_Tick(object sender, EventArgs e)
        {
            lb_saat.Text = DateTime.Now.ToLongTimeString();
        }

        private void sİSTEMBİLGİLERİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sistembilgileri sistem = new sistembilgileri();
            sistem.Show();
        }

        private void eKRANGÖRÜNTÜSÜALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ekrangörüntüsü ekr = new ekrangörüntüsü();
            ekr.Show();
        }

        private void nEKADAROLDUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nekadaroldu nekdr = new nekadaroldu();
            nekdr.Show();
        }

        private void çALIŞTIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calistir calis = new calistir();
            calis.Show();
        }

        private void btn_bosalt_Click(object sender, EventArgs e)
        {
            if (EmptyRecycleBin()) {}
            bildirimpaneli.ShowBalloonTip(3000, "CLEAN", "RECYCLING BOX CLEANED", ToolTipIcon.Info);
            pictureBox1.Visible = false;
            pictureBox3.Visible = true;
        }

        private void gÖSTERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void gİZLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void hAKKINDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bİLGİSAYARIKAPATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("ARE YOU SURE?", "SHUTDOWN", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("shutdown", "-f -s");
            }
        }

        private void yENİDENBAŞLATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("ARE YOU SURE?", "RESTART", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("shutDown", "/r -f -t 1");
            }
        }

        private void uYKUYAALToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("ARE YOU SURE?", "SLEEP", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                Application.SetSuspendState(PowerState.Suspend, false, false);
            }
        }

        private void oTURUMUKAPATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult soru = MessageBox.Show("ARE YOU SURE?", "SIGN OUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (soru == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("shutdown", "-l -f");
            }
        }

        
    }
}
