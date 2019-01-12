namespace Market.WFA
{
    partial class BarkodAnaForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBarkodUret = new System.Windows.Forms.Button();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.lstStokdaAzalanUrunler = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(35, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 152);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnBarkodUret
            // 
            this.btnBarkodUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarkodUret.Location = new System.Drawing.Point(233, 17);
            this.btnBarkodUret.Name = "btnBarkodUret";
            this.btnBarkodUret.Size = new System.Drawing.Size(85, 29);
            this.btnBarkodUret.TabIndex = 26;
            this.btnBarkodUret.Text = "Barkod Tanı";
            this.btnBarkodUret.UseVisualStyleBackColor = true;
            this.btnBarkodUret.Click += new System.EventHandler(this.btnBarkodUret_Click);
            this.btnBarkodUret.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnBarkodUret_KeyDown);
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarkod.Location = new System.Drawing.Point(35, 24);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(152, 22);
            this.txtBarkod.TabIndex = 25;
            // 
            // lstStokdaAzalanUrunler
            // 
            this.lstStokdaAzalanUrunler.FormattingEnabled = true;
            this.lstStokdaAzalanUrunler.Location = new System.Drawing.Point(391, 17);
            this.lstStokdaAzalanUrunler.Name = "lstStokdaAzalanUrunler";
            this.lstStokdaAzalanUrunler.Size = new System.Drawing.Size(292, 303);
            this.lstStokdaAzalanUrunler.TabIndex = 28;
            this.lstStokdaAzalanUrunler.SelectedIndexChanged += new System.EventHandler(this.lstStokdaAzalanUrunler_SelectedIndexChanged);
            // 
            // BarkodAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1256, 497);
            this.Controls.Add(this.lstStokdaAzalanUrunler);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBarkodUret);
            this.Controls.Add(this.txtBarkod);
            this.Name = "BarkodAnaForm";
            this.Text = "BarkodAnaForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBarkodUret;
        public System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.ListBox lstStokdaAzalanUrunler;
    }
}