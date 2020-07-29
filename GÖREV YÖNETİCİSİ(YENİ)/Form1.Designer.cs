namespace GÖREV_YÖNETİCİSİ_YENİ_
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metro_yenile = new MetroFramework.Controls.MetroProgressSpinner();
            this.metro_gorev = new MetroFramework.Controls.MetroProgressSpinner();
            this.lb_total = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_yenile = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btn_kapat = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lb_cpukullanımı = new System.Windows.Forms.Label();
            this.prg_cpukllnımı = new MetroFramework.Controls.MetroProgressSpinner();
            this.lb_ramkullan = new MetroFramework.Controls.MetroLabel();
            this.lb_ramkllnma = new System.Windows.Forms.Label();
            this.prg_ram = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lb_cpuısı = new System.Windows.Forms.Label();
            this.prb_cpuısı = new MetroFramework.Controls.MetroProgressSpinner();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.cpu = new System.Windows.Forms.Timer(this.components);
            this.tmr_deger = new System.Windows.Forms.Timer(this.components);
            this.islemci = new System.Diagnostics.PerformanceCounter();
            this.ram = new System.Diagnostics.PerformanceCounter();
            this.saat = new System.Windows.Forms.Timer(this.components);
            this.lb_saat = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sİSTEMBİLGİLERİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eKRANGÖRÜNTÜSÜALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nEKADAROLDUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çALIŞTIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bİLGİSAYARIMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bİLGİSAYARIKAPATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yENİDENBAŞLATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uYKUYAALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oTURUMUKAPATToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_bosalt = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.bildirimpaneli = new System.Windows.Forms.NotifyIcon(this.components);
            this.notimenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gÖSTERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gİZLEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.islemci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.notimenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // metro_yenile
            // 
            this.metro_yenile.Location = new System.Drawing.Point(344, 611);
            this.metro_yenile.Maximum = 100;
            this.metro_yenile.Name = "metro_yenile";
            this.metro_yenile.Size = new System.Drawing.Size(41, 41);
            this.metro_yenile.TabIndex = 22;
            this.metro_yenile.UseSelectable = true;
            this.metro_yenile.Visible = false;
            // 
            // metro_gorev
            // 
            this.metro_gorev.Location = new System.Drawing.Point(344, 560);
            this.metro_gorev.Maximum = 100;
            this.metro_gorev.Name = "metro_gorev";
            this.metro_gorev.Size = new System.Drawing.Size(41, 41);
            this.metro_gorev.TabIndex = 23;
            this.metro_gorev.UseSelectable = true;
            this.metro_gorev.Visible = false;
            // 
            // lb_total
            // 
            this.lb_total.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lb_total.Location = new System.Drawing.Point(83, 597);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(40, 33);
            this.lb_total.TabIndex = 20;
            this.lb_total.Text = "0";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(34, 578);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(129, 19);
            this.metroLabel1.TabIndex = 21;
            this.metroLabel1.Text = "Running Application:";
            // 
            // btn_yenile
            // 
            this.btn_yenile.Image = null;
            this.btn_yenile.Location = new System.Drawing.Point(192, 611);
            this.btn_yenile.Name = "btn_yenile";
            this.btn_yenile.Size = new System.Drawing.Size(146, 41);
            this.btn_yenile.TabIndex = 18;
            this.btn_yenile.Text = "REFRESH";
            this.btn_yenile.UseSelectable = true;
            this.btn_yenile.UseVisualStyleBackColor = true;
            this.btn_yenile.Click += new System.EventHandler(this.btn_yenile_Click);
            // 
            // btn_kapat
            // 
            this.btn_kapat.Image = null;
            this.btn_kapat.Location = new System.Drawing.Point(192, 560);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(146, 41);
            this.btn_kapat.TabIndex = 19;
            this.btn_kapat.Text = "END TASK";
            this.btn_kapat.UseSelectable = true;
            this.btn_kapat.UseVisualStyleBackColor = true;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 106);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(315, 448);
            this.listView1.TabIndex = 17;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listView1_ColumnWidthChanging);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Programın Adı";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "CPU";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Çalışma";
            this.columnHeader4.Width = 57;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(438, 368);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(62, 19);
            this.metroLabel3.TabIndex = 32;
            this.metroLabel3.Text = "USE CPU";
            // 
            // lb_cpukullanımı
            // 
            this.lb_cpukullanımı.AutoSize = true;
            this.lb_cpukullanımı.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_cpukullanımı.Location = new System.Drawing.Point(461, 522);
            this.lb_cpukullanımı.Name = "lb_cpukullanımı";
            this.lb_cpukullanımı.Size = new System.Drawing.Size(23, 25);
            this.lb_cpukullanımı.TabIndex = 31;
            this.lb_cpukullanımı.Text = "0";
            // 
            // prg_cpukllnımı
            // 
            this.prg_cpukllnımı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.prg_cpukllnımı.Location = new System.Drawing.Point(429, 394);
            this.prg_cpukllnımı.Maximum = 100;
            this.prg_cpukllnımı.Name = "prg_cpukllnımı";
            this.prg_cpukllnımı.Size = new System.Drawing.Size(125, 125);
            this.prg_cpukllnımı.Speed = 5F;
            this.prg_cpukllnımı.Spinning = false;
            this.prg_cpukllnımı.Style = MetroFramework.MetroColorStyle.Red;
            this.prg_cpukllnımı.TabIndex = 30;
            this.prg_cpukllnımı.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prg_cpukllnımı.UseSelectable = true;
            // 
            // lb_ramkullan
            // 
            this.lb_ramkullan.AutoSize = true;
            this.lb_ramkullan.Location = new System.Drawing.Point(644, 142);
            this.lb_ramkullan.Name = "lb_ramkullan";
            this.lb_ramkullan.Size = new System.Drawing.Size(68, 19);
            this.lb_ramkullan.TabIndex = 29;
            this.lb_ramkullan.Text = "USE RAM:";
            // 
            // lb_ramkllnma
            // 
            this.lb_ramkllnma.AutoSize = true;
            this.lb_ramkllnma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_ramkllnma.Location = new System.Drawing.Point(639, 300);
            this.lb_ramkllnma.Name = "lb_ramkllnma";
            this.lb_ramkllnma.Size = new System.Drawing.Size(23, 25);
            this.lb_ramkllnma.TabIndex = 28;
            this.lb_ramkllnma.Text = "0";
            // 
            // prg_ram
            // 
            this.prg_ram.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.prg_ram.Location = new System.Drawing.Point(607, 168);
            this.prg_ram.Maximum = 100;
            this.prg_ram.Name = "prg_ram";
            this.prg_ram.Size = new System.Drawing.Size(125, 125);
            this.prg_ram.Spinning = false;
            this.prg_ram.Style = MetroFramework.MetroColorStyle.Red;
            this.prg_ram.TabIndex = 27;
            this.prg_ram.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prg_ram.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(434, 142);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(133, 19);
            this.metroLabel2.TabIndex = 26;
            this.metroLabel2.Text = "CPU TEMPERATURE :";
            // 
            // lb_cpuısı
            // 
            this.lb_cpuısı.AutoSize = true;
            this.lb_cpuısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_cpuısı.Location = new System.Drawing.Point(419, 278);
            this.lb_cpuısı.Name = "lb_cpuısı";
            this.lb_cpuısı.Size = new System.Drawing.Size(13, 13);
            this.lb_cpuısı.TabIndex = 25;
            this.lb_cpuısı.Text = "0";
            // 
            // prb_cpuısı
            // 
            this.prb_cpuısı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.prb_cpuısı.Location = new System.Drawing.Point(423, 168);
            this.prb_cpuısı.Maximum = 100;
            this.prb_cpuısı.Name = "prb_cpuısı";
            this.prb_cpuısı.Size = new System.Drawing.Size(125, 125);
            this.prb_cpuısı.Spinning = false;
            this.prb_cpuısı.Style = MetroFramework.MetroColorStyle.Red;
            this.prb_cpuısı.TabIndex = 24;
            this.prb_cpuısı.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prb_cpuısı.UseSelectable = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // cpu
            // 
            this.cpu.Enabled = true;
            this.cpu.Interval = 1000;
            this.cpu.Tick += new System.EventHandler(this.cpu_Tick);
            // 
            // tmr_deger
            // 
            this.tmr_deger.Enabled = true;
            this.tmr_deger.Tick += new System.EventHandler(this.tmr_deger_Tick);
            // 
            // islemci
            // 
            this.islemci.CategoryName = "İşlemci";
            this.islemci.CounterName = "% İşlemci Zamanı";
            this.islemci.InstanceName = "_Total";
            // 
            // ram
            // 
            this.ram.CategoryName = "Memory";
            this.ram.CounterName = "% Committed Bytes In Use";
            // 
            // saat
            // 
            this.saat.Tick += new System.EventHandler(this.saat_Tick);
            // 
            // lb_saat
            // 
            this.lb_saat.AutoSize = true;
            this.lb_saat.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_saat.Location = new System.Drawing.Point(713, 18);
            this.lb_saat.Name = "lb_saat";
            this.lb_saat.Size = new System.Drawing.Size(29, 31);
            this.lb_saat.TabIndex = 33;
            this.lb_saat.Text = "0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sİSTEMBİLGİLERİToolStripMenuItem,
            this.eKRANGÖRÜNTÜSÜALToolStripMenuItem,
            this.nEKADAROLDUToolStripMenuItem,
            this.çALIŞTIRToolStripMenuItem,
            this.bİLGİSAYARIMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 34;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sİSTEMBİLGİLERİToolStripMenuItem
            // 
            this.sİSTEMBİLGİLERİToolStripMenuItem.Name = "sİSTEMBİLGİLERİToolStripMenuItem";
            this.sİSTEMBİLGİLERİToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.sİSTEMBİLGİLERİToolStripMenuItem.Text = "SYSTEM INFORMATION";
            this.sİSTEMBİLGİLERİToolStripMenuItem.Click += new System.EventHandler(this.sİSTEMBİLGİLERİToolStripMenuItem_Click);
            // 
            // eKRANGÖRÜNTÜSÜALToolStripMenuItem
            // 
            this.eKRANGÖRÜNTÜSÜALToolStripMenuItem.Name = "eKRANGÖRÜNTÜSÜALToolStripMenuItem";
            this.eKRANGÖRÜNTÜSÜALToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.eKRANGÖRÜNTÜSÜALToolStripMenuItem.Text = "TAKE SCREENSHOT";
            this.eKRANGÖRÜNTÜSÜALToolStripMenuItem.Click += new System.EventHandler(this.eKRANGÖRÜNTÜSÜALToolStripMenuItem_Click);
            // 
            // nEKADAROLDUToolStripMenuItem
            // 
            this.nEKADAROLDUToolStripMenuItem.Name = "nEKADAROLDUToolStripMenuItem";
            this.nEKADAROLDUToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.nEKADAROLDUToolStripMenuItem.Text = "TIME";
            this.nEKADAROLDUToolStripMenuItem.Click += new System.EventHandler(this.nEKADAROLDUToolStripMenuItem_Click);
            // 
            // çALIŞTIRToolStripMenuItem
            // 
            this.çALIŞTIRToolStripMenuItem.Name = "çALIŞTIRToolStripMenuItem";
            this.çALIŞTIRToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.çALIŞTIRToolStripMenuItem.Text = "RUN";
            this.çALIŞTIRToolStripMenuItem.Click += new System.EventHandler(this.çALIŞTIRToolStripMenuItem_Click);
            // 
            // bİLGİSAYARIMToolStripMenuItem
            // 
            this.bİLGİSAYARIMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bİLGİSAYARIKAPATToolStripMenuItem,
            this.yENİDENBAŞLATToolStripMenuItem,
            this.uYKUYAALToolStripMenuItem,
            this.oTURUMUKAPATToolStripMenuItem});
            this.bİLGİSAYARIMToolStripMenuItem.Name = "bİLGİSAYARIMToolStripMenuItem";
            this.bİLGİSAYARIMToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.bİLGİSAYARIMToolStripMenuItem.Text = "COMPUTER";
            // 
            // bİLGİSAYARIKAPATToolStripMenuItem
            // 
            this.bİLGİSAYARIKAPATToolStripMenuItem.Name = "bİLGİSAYARIKAPATToolStripMenuItem";
            this.bİLGİSAYARIKAPATToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.bİLGİSAYARIKAPATToolStripMenuItem.Text = "TURN OF THE COMPUTER";
            this.bİLGİSAYARIKAPATToolStripMenuItem.Click += new System.EventHandler(this.bİLGİSAYARIKAPATToolStripMenuItem_Click);
            // 
            // yENİDENBAŞLATToolStripMenuItem
            // 
            this.yENİDENBAŞLATToolStripMenuItem.Name = "yENİDENBAŞLATToolStripMenuItem";
            this.yENİDENBAŞLATToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.yENİDENBAŞLATToolStripMenuItem.Text = "RESTART";
            this.yENİDENBAŞLATToolStripMenuItem.Click += new System.EventHandler(this.yENİDENBAŞLATToolStripMenuItem_Click);
            // 
            // uYKUYAALToolStripMenuItem
            // 
            this.uYKUYAALToolStripMenuItem.Name = "uYKUYAALToolStripMenuItem";
            this.uYKUYAALToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.uYKUYAALToolStripMenuItem.Text = "SLEEP";
            this.uYKUYAALToolStripMenuItem.Click += new System.EventHandler(this.uYKUYAALToolStripMenuItem_Click);
            // 
            // oTURUMUKAPATToolStripMenuItem
            // 
            this.oTURUMUKAPATToolStripMenuItem.Name = "oTURUMUKAPATToolStripMenuItem";
            this.oTURUMUKAPATToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.oTURUMUKAPATToolStripMenuItem.Text = "SIGN OUT";
            this.oTURUMUKAPATToolStripMenuItem.Click += new System.EventHandler(this.oTURUMUKAPATToolStripMenuItem_Click);
            // 
            // btn_bosalt
            // 
            this.btn_bosalt.Image = null;
            this.btn_bosalt.Location = new System.Drawing.Point(702, 578);
            this.btn_bosalt.Name = "btn_bosalt";
            this.btn_bosalt.Size = new System.Drawing.Size(157, 52);
            this.btn_bosalt.TabIndex = 35;
            this.btn_bosalt.Text = "CLEAN";
            this.btn_bosalt.UseSelectable = true;
            this.btn_bosalt.UseVisualStyleBackColor = true;
            this.btn_bosalt.Click += new System.EventHandler(this.btn_bosalt_Click);
            // 
            // bildirimpaneli
            // 
            this.bildirimpaneli.ContextMenuStrip = this.notimenu;
            this.bildirimpaneli.Icon = ((System.Drawing.Icon)(resources.GetObject("bildirimpaneli.Icon")));
            this.bildirimpaneli.Text = "GÖREV YÖNETİCİSİ";
            this.bildirimpaneli.Visible = true;
            // 
            // notimenu
            // 
            this.notimenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gÖSTERToolStripMenuItem,
            this.gİZLEToolStripMenuItem,
            this.sToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.notimenu.Name = "notimenu";
            this.notimenu.Size = new System.Drawing.Size(117, 76);
            // 
            // gÖSTERToolStripMenuItem
            // 
            this.gÖSTERToolStripMenuItem.Name = "gÖSTERToolStripMenuItem";
            this.gÖSTERToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.gÖSTERToolStripMenuItem.Text = "GÖSTER";
            this.gÖSTERToolStripMenuItem.Click += new System.EventHandler(this.gÖSTERToolStripMenuItem_Click);
            // 
            // gİZLEToolStripMenuItem
            // 
            this.gİZLEToolStripMenuItem.Name = "gİZLEToolStripMenuItem";
            this.gİZLEToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.gİZLEToolStripMenuItem.Text = "GİZLE ";
            this.gİZLEToolStripMenuItem.Click += new System.EventHandler(this.gİZLEToolStripMenuItem_Click);
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(113, 6);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GÖREV_YÖNETİCİSİ_YENİ_.Properties.Resources.recycle_bin;
            this.pictureBox1.Location = new System.Drawing.Point(702, 426);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GÖREV_YÖNETİCİSİ_YENİ_.Properties.Resources.trash_icon;
            this.pictureBox3.Location = new System.Drawing.Point(702, 426);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(160, 146);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 36;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 664);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_bosalt);
            this.Controls.Add(this.lb_saat);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.lb_cpukullanımı);
            this.Controls.Add(this.prg_cpukllnımı);
            this.Controls.Add(this.lb_ramkullan);
            this.Controls.Add(this.lb_ramkllnma);
            this.Controls.Add(this.prg_ram);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.lb_cpuısı);
            this.Controls.Add(this.prb_cpuısı);
            this.Controls.Add(this.metro_yenile);
            this.Controls.Add(this.metro_gorev);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btn_yenile);
            this.Controls.Add(this.btn_kapat);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "TASK MANAGER";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.islemci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.notimenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroProgressSpinner metro_yenile;
        private MetroFramework.Controls.MetroProgressSpinner metro_gorev;
        private MetroFramework.Controls.MetroLabel lb_total;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_yenile;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_kapat;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.Label lb_cpukullanımı;
        private MetroFramework.Controls.MetroProgressSpinner prg_cpukllnımı;
        private MetroFramework.Controls.MetroLabel lb_ramkullan;
        private System.Windows.Forms.Label lb_ramkllnma;
        private MetroFramework.Controls.MetroProgressSpinner prg_ram;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Label lb_cpuısı;
        private MetroFramework.Controls.MetroProgressSpinner prb_cpuısı;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer cpu;
        private System.Windows.Forms.Timer tmr_deger;
        private System.Diagnostics.PerformanceCounter islemci;
        private System.Diagnostics.PerformanceCounter ram;
        private System.Windows.Forms.Timer saat;
        private System.Windows.Forms.Label lb_saat;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sİSTEMBİLGİLERİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eKRANGÖRÜNTÜSÜALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nEKADAROLDUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çALIŞTIRToolStripMenuItem;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_bosalt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon bildirimpaneli;
        private System.Windows.Forms.ContextMenuStrip notimenu;
        private System.Windows.Forms.ToolStripMenuItem gÖSTERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bİLGİSAYARIMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bİLGİSAYARIKAPATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yENİDENBAŞLATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uYKUYAALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oTURUMUKAPATToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gİZLEToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator sToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

