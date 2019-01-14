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
            this.btnUrunAl = new System.Windows.Forms.Button();
            this.btnStokSiparis = new System.Windows.Forms.Button();
            this.pnUrunKabul = new System.Windows.Forms.Panel();
            this.pnUrunStok = new System.Windows.Forms.Panel();
            this.btnSiparisVer = new System.Windows.Forms.Button();
            this.nuSiparisAdet = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnUrunKabul.SuspendLayout();
            this.pnUrunStok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuSiparisAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(36, 95);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 152);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // btnBarkodUret
            // 
            this.btnBarkodUret.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarkodUret.Location = new System.Drawing.Point(234, 6);
            this.btnBarkodUret.Name = "btnBarkodUret";
            this.btnBarkodUret.Size = new System.Drawing.Size(120, 62);
            this.btnBarkodUret.TabIndex = 26;
            this.btnBarkodUret.Text = "Barkod Olustur Ve Ara";
            this.btnBarkodUret.UseVisualStyleBackColor = true;
            this.btnBarkodUret.Click += new System.EventHandler(this.btnBarkodUret_Click);
           
            // 
            // txtBarkod
            // 
            this.txtBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarkod.Location = new System.Drawing.Point(36, 13);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(152, 22);
            this.txtBarkod.TabIndex = 25;
            this.txtBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarkod_KeyDown);
            // 
            // lstStokdaAzalanUrunler
            // 
            this.lstStokdaAzalanUrunler.FormattingEnabled = true;
            this.lstStokdaAzalanUrunler.Location = new System.Drawing.Point(19, 13);
            this.lstStokdaAzalanUrunler.Name = "lstStokdaAzalanUrunler";
            this.lstStokdaAzalanUrunler.Size = new System.Drawing.Size(292, 303);
            this.lstStokdaAzalanUrunler.TabIndex = 28;
            this.lstStokdaAzalanUrunler.SelectedIndexChanged += new System.EventHandler(this.lstStokdaAzalanUrunler_SelectedIndexChanged);
            // 
            // btnUrunAl
            // 
            this.btnUrunAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUrunAl.Location = new System.Drawing.Point(483, 100);
            this.btnUrunAl.Name = "btnUrunAl";
            this.btnUrunAl.Size = new System.Drawing.Size(114, 60);
            this.btnUrunAl.TabIndex = 29;
            this.btnUrunAl.Text = "Ürün Kabul";
            this.btnUrunAl.UseVisualStyleBackColor = true;
            this.btnUrunAl.Click += new System.EventHandler(this.btnUrunAl_Click);
            // 
            // btnStokSiparis
            // 
            this.btnStokSiparis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStokSiparis.Location = new System.Drawing.Point(483, 176);
            this.btnStokSiparis.Name = "btnStokSiparis";
            this.btnStokSiparis.Size = new System.Drawing.Size(114, 60);
            this.btnStokSiparis.TabIndex = 30;
            this.btnStokSiparis.Text = "Stok Kontrol ve Sipariş";
            this.btnStokSiparis.UseVisualStyleBackColor = true;
            this.btnStokSiparis.Click += new System.EventHandler(this.btnStokSiparis_Click);
            // 
            // pnUrunKabul
            // 
            this.pnUrunKabul.Controls.Add(this.pictureBox1);
            this.pnUrunKabul.Controls.Add(this.txtBarkod);
            this.pnUrunKabul.Controls.Add(this.btnBarkodUret);
            this.pnUrunKabul.Location = new System.Drawing.Point(29, 44);
            this.pnUrunKabul.Name = "pnUrunKabul";
            this.pnUrunKabul.Size = new System.Drawing.Size(404, 277);
            this.pnUrunKabul.TabIndex = 31;
            this.pnUrunKabul.Visible = false;
            // 
            // pnUrunStok
            // 
            this.pnUrunStok.Controls.Add(this.btnSiparisVer);
            this.pnUrunStok.Controls.Add(this.nuSiparisAdet);
            this.pnUrunStok.Controls.Add(this.label1);
            this.pnUrunStok.Controls.Add(this.lstStokdaAzalanUrunler);
            this.pnUrunStok.Location = new System.Drawing.Point(681, 44);
            this.pnUrunStok.Name = "pnUrunStok";
            this.pnUrunStok.Size = new System.Drawing.Size(563, 337);
            this.pnUrunStok.TabIndex = 32;
            this.pnUrunStok.Visible = false;
            // 
            // btnSiparisVer
            // 
            this.btnSiparisVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisVer.Location = new System.Drawing.Point(356, 95);
            this.btnSiparisVer.Name = "btnSiparisVer";
            this.btnSiparisVer.Size = new System.Drawing.Size(160, 45);
            this.btnSiparisVer.TabIndex = 33;
            this.btnSiparisVer.Text = "Siparis Ver";
            this.btnSiparisVer.UseVisualStyleBackColor = true;
            this.btnSiparisVer.Click += new System.EventHandler(this.btnSiparisVer_Click);
            // 
            // nuSiparisAdet
            // 
            this.nuSiparisAdet.Location = new System.Drawing.Point(356, 56);
            this.nuSiparisAdet.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nuSiparisAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuSiparisAdet.Name = "nuSiparisAdet";
            this.nuSiparisAdet.Size = new System.Drawing.Size(160, 20);
            this.nuSiparisAdet.TabIndex = 30;
            this.nuSiparisAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 29;
            this.label1.Text = "Siparis Sayisini Giriniz";
            // 
            // BarkodAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1256, 497);
            this.Controls.Add(this.pnUrunStok);
            this.Controls.Add(this.pnUrunKabul);
            this.Controls.Add(this.btnStokSiparis);
            this.Controls.Add(this.btnUrunAl);
            this.Name = "BarkodAnaForm";
            this.Text = "BarkodAnaForm";
            this.Load += new System.EventHandler(this.BarkodAnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnUrunKabul.ResumeLayout(false);
            this.pnUrunKabul.PerformLayout();
            this.pnUrunStok.ResumeLayout(false);
            this.pnUrunStok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuSiparisAdet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBarkodUret;
        public System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.ListBox lstStokdaAzalanUrunler;
        private System.Windows.Forms.Button btnUrunAl;
        private System.Windows.Forms.Button btnStokSiparis;
        private System.Windows.Forms.Panel pnUrunKabul;
        private System.Windows.Forms.Panel pnUrunStok;
        private System.Windows.Forms.Button btnSiparisVer;
        private System.Windows.Forms.NumericUpDown nuSiparisAdet;
        private System.Windows.Forms.Label label1;
    }
}