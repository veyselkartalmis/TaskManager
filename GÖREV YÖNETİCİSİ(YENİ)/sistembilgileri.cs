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
using Microsoft.Win32;
using System.Net;
using System.Net.NetworkInformation;

namespace GÖREV_YÖNETİCİSİ_YENİ_
{
    public partial class sistembilgileri : MetroForm
    {
        public sistembilgileri()
        {
            InitializeComponent();
        }

        private void sistembilgileri_Load(object sender, EventArgs e)
        {
            RegistryKey Rkey = Registry.LocalMachine;
            Rkey = Rkey.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0");
            try
            {
                lb_cpu.Text = (string)Rkey.GetValue("ProcessorNameString").ToString();
            }
            catch (Exception)
            {
                lb_cpu.Text = "YOUR SYSTEM DOES NOT SUPPORT";
            }

            try
            {
                lb_isistem.Text = System.Environment.OSVersion.VersionString;
            }
            catch (Exception)
            {
                lb_isistem.Text = "YOUR SYSTEM DOES NOT SUPPORT";
            }

            try
            {
                lb_platform.Text = System.Environment.OSVersion.Platform.ToString();
            }
            catch (Exception)
            {
                lb_platform.Text = "YOUR SYSTEM DOES NOT SUPPORT";
            }

            try
            {
                lb_cekirdek.Text = System.Environment.ProcessorCount.ToString();
            }
            catch (Exception)
            {
                lb_cekirdek.Text = "YOUR SYSTEM DOES NOT SUPPORT";
            }


            ManagementObjectSearcher EkranKartiSorgu = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
            foreach (ManagementObject bilgi in EkranKartiSorgu.Get())
            {
                try
                {
                    lb_eversiyon.Text = bilgi["DriverVersion"].ToString() + " Date: " + bilgi["DriverDate"].ToString().Substring(0, 8);
                }
                catch (Exception)
                {
                    lb_eversiyon.Text = "YOUR SYSTEM DOES NOT SUPPORT";
                }

                try
                {
                    lb_ekartı.Text = bilgi["name"].ToString();
                }
                catch (Exception)
                {
                    lb_ekartı.Text = "YOUR SYSTEM DOES NOT SUPPORT";
                }

                try
                {
                    lb_eislemci.Text = bilgi["videoProcessor"].ToString();
                }
                catch (Exception)
                {
                    lb_eislemci.Text = "YOUR SYSTEM DOES NOT SUPPORT";
                }

            }

            //FOR RAM
            ManagementObjectSearcher Search = new ManagementObjectSearcher("Select * From Win32_ComputerSystem");
            foreach (ManagementObject Mobject in Search.Get())
            {
                try
                {
                    double Ram_Bytes = (Convert.ToDouble(Mobject["TotalPhysicalMemory"]));
                    double ramgb = Ram_Bytes / 1073741824;
                    double islem = Math.Ceiling(ramgb);
                    string mesaj = " GB";
                    lb_ram.Text = islem.ToString() + mesaj;
                }
                catch (Exception)
                {
                    lb_ram.Text = "YOUR SYSTEM DOES NOT SUPPORT";
                }


            }

            RegistryKey rkey = Registry.LocalMachine;
            rkey = rkey.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\BIOS");
            try
            {
                LB_sistem.Text = (string)rkey.GetValue("SystemVersion").ToString();
            }
            catch (Exception)
            {
                LB_sistem.Text = "YOUR SYSTEM DOES NOT SUPPORT";
            }

            try
            {
                lb_pcadi.Text = SystemInformation.UserName.ToString();
            }
            catch (Exception)
            {
                lb_pcadi.Text = "YOUR SYSTEM DOES NOT SUPPORT";
            }


            string host = Dns.GetHostName();
            IPHostEntry ip = Dns.GetHostByName(host);
            try
            {
                lb_ip.Text = ip.AddressList[0].ToString();
            }
            catch (Exception)
            {
                lb_ip.Text = "YOUR SYSTEM DOES NOT SUPPORT";
            }

        }
      

        private void sistembilgileri_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        
    }
}
