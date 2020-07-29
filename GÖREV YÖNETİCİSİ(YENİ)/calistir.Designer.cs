namespace GÖREV_YÖNETİCİSİ_YENİ_
{
    partial class calistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calistir));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tx_komut = new System.Windows.Forms.TextBox();
            this.btn_calistir = new MetroFramework.Controls.MetroTextBox.MetroTextButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 82);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(197, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "ENTER A COMMAND (EX: cmd)";
            // 
            // tx_komut
            // 
            this.tx_komut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tx_komut.Location = new System.Drawing.Point(90, 116);
            this.tx_komut.Multiline = true;
            this.tx_komut.Name = "tx_komut";
            this.tx_komut.Size = new System.Drawing.Size(163, 31);
            this.tx_komut.TabIndex = 3;
            // 
            // btn_calistir
            // 
            this.btn_calistir.Image = null;
            this.btn_calistir.Location = new System.Drawing.Point(90, 165);
            this.btn_calistir.Name = "btn_calistir";
            this.btn_calistir.Size = new System.Drawing.Size(146, 41);
            this.btn_calistir.TabIndex = 19;
            this.btn_calistir.Text = "RUN";
            this.btn_calistir.UseSelectable = true;
            this.btn_calistir.UseVisualStyleBackColor = true;
            this.btn_calistir.Click += new System.EventHandler(this.btn_calistir_Click);
            // 
            // calistir
            // 
            this.AcceptButton = this.btn_calistir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 244);
            this.Controls.Add(this.btn_calistir);
            this.Controls.Add(this.tx_komut);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "calistir";
            this.Text = "RUN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.TextBox tx_komut;
        private MetroFramework.Controls.MetroTextBox.MetroTextButton btn_calistir;
    }
}