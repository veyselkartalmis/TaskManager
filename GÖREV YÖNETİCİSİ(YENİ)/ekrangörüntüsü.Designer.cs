namespace GÖREV_YÖNETİCİSİ_YENİ_
{
    partial class ekrangörüntüsü
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ekrangörüntüsü));
            this.pc_ekran = new System.Windows.Forms.PictureBox();
            this.btn_cek = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.btn_kaydet = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.kaydet = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pc_ekran)).BeginInit();
            this.SuspendLayout();
            // 
            // pc_ekran
            // 
            this.pc_ekran.Location = new System.Drawing.Point(184, 87);
            this.pc_ekran.Name = "pc_ekran";
            this.pc_ekran.Size = new System.Drawing.Size(783, 421);
            this.pc_ekran.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pc_ekran.TabIndex = 0;
            this.pc_ekran.TabStop = false;
            // 
            // btn_cek
            // 
            this.btn_cek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cek.Image = null;
            this.btn_cek.Location = new System.Drawing.Point(23, 245);
            this.btn_cek.Name = "btn_cek";
            this.btn_cek.Size = new System.Drawing.Size(155, 55);
            this.btn_cek.TabIndex = 1;
            this.btn_cek.Text = "TAKE";
            this.btn_cek.UseSelectable = true;
            this.btn_cek.UseVisualStyleBackColor = true;
            this.btn_cek.Click += new System.EventHandler(this.btn_cek_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Enabled = false;
            this.btn_kaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Image = null;
            this.btn_kaydet.Location = new System.Drawing.Point(23, 328);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(155, 55);
            this.btn_kaydet.TabIndex = 1;
            this.btn_kaydet.Text = "SAVE";
            this.btn_kaydet.UseSelectable = true;
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // ekrangörüntüsü
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 562);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_cek);
            this.Controls.Add(this.pc_ekran);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ekrangörüntüsü";
            this.Text = "TAKE SCREENSHOT";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ekrangörüntüsü_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pc_ekran)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pc_ekran;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_cek;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_kaydet;
        private System.Windows.Forms.SaveFileDialog kaydet;
    }
}