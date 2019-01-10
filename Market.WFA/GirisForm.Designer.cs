namespace Market.WFA
{
    partial class GirisForm
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
            this.msIslemler = new System.Windows.Forms.MenuStrip();
            this.alisIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alisIslemleriToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.satisIslemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.msIslemler.SuspendLayout();
            this.SuspendLayout();
            // 
            // msIslemler
            // 
            this.msIslemler.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alisIslemleriToolStripMenuItem});
            this.msIslemler.Location = new System.Drawing.Point(0, 0);
            this.msIslemler.Name = "msIslemler";
            this.msIslemler.Size = new System.Drawing.Size(858, 24);
            this.msIslemler.TabIndex = 0;
            this.msIslemler.Text = "menuStrip1";
            // 
            // alisIslemleriToolStripMenuItem
            // 
            this.alisIslemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alisIslemleriToolStripMenuItem1,
            this.satisIslemleriToolStripMenuItem});
            this.alisIslemleriToolStripMenuItem.Name = "alisIslemleriToolStripMenuItem";
            this.alisIslemleriToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.alisIslemleriToolStripMenuItem.Text = "Islemler";
            // 
            // alisIslemleriToolStripMenuItem1
            // 
            this.alisIslemleriToolStripMenuItem1.Name = "alisIslemleriToolStripMenuItem1";
            this.alisIslemleriToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.alisIslemleriToolStripMenuItem1.Text = "Alis Islemleri";
            this.alisIslemleriToolStripMenuItem1.Click += new System.EventHandler(this.alisIslemleriToolStripMenuItem1_Click);
            // 
            // satisIslemleriToolStripMenuItem
            // 
            this.satisIslemleriToolStripMenuItem.Name = "satisIslemleriToolStripMenuItem";
            this.satisIslemleriToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.satisIslemleriToolStripMenuItem.Text = "Satis Islemleri";
            this.satisIslemleriToolStripMenuItem.Click += new System.EventHandler(this.satisIslemleriToolStripMenuItem_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Market.WFA.Properties.Resources.market;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(858, 484);
            this.Controls.Add(this.msIslemler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msIslemler;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GirisForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msIslemler.ResumeLayout(false);
            this.msIslemler.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msIslemler;
        private System.Windows.Forms.ToolStripMenuItem alisIslemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alisIslemleriToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem satisIslemleriToolStripMenuItem;
    }
}

