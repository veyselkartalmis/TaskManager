namespace GÖREV_YÖNETİCİSİ_YENİ_
{
    partial class nekadaroldu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nekadaroldu));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tx_zaman = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(76, 108);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(192, 50);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "\r\nYour computer is on for";
            // 
            // tx_zaman
            // 
            this.tx_zaman.AutoSize = true;
            this.tx_zaman.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.tx_zaman.Location = new System.Drawing.Point(134, 177);
            this.tx_zaman.Name = "tx_zaman";
            this.tx_zaman.Size = new System.Drawing.Size(19, 25);
            this.tx_zaman.TabIndex = 1;
            this.tx_zaman.Text = "-";
            // 
            // nekadaroldu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 294);
            this.Controls.Add(this.tx_zaman);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "nekadaroldu";
            this.Text = "How long has it been?";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.nekadaroldu_FormClosing);
            this.Load += new System.EventHandler(this.nekadaroldu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel tx_zaman;
    }
}