namespace Market.WFA
{
    partial class UrunEkleForm
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
            this.pnYeniUrunEkle = new System.Windows.Forms.Panel();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUrunVazgec = new System.Windows.Forms.Button();
            this.btnUrunKaydet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nuYeniUrunTaneFiyat = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.txtYeniUrunAdi = new System.Windows.Forms.TextBox();
            this.pnYeniUrunEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuYeniUrunTaneFiyat)).BeginInit();
            this.SuspendLayout();
            // 
            // pnYeniUrunEkle
            // 
            this.pnYeniUrunEkle.Controls.Add(this.cmbKategoriler);
            this.pnYeniUrunEkle.Controls.Add(this.label1);
            this.pnYeniUrunEkle.Controls.Add(this.btnUrunVazgec);
            this.pnYeniUrunEkle.Controls.Add(this.btnUrunKaydet);
            this.pnYeniUrunEkle.Controls.Add(this.label8);
            this.pnYeniUrunEkle.Controls.Add(this.label6);
            this.pnYeniUrunEkle.Controls.Add(this.label5);
            this.pnYeniUrunEkle.Controls.Add(this.nuYeniUrunTaneFiyat);
            this.pnYeniUrunEkle.Controls.Add(this.label7);
            this.pnYeniUrunEkle.Controls.Add(this.txtYeniUrunAdi);
            this.pnYeniUrunEkle.Location = new System.Drawing.Point(12, 12);
            this.pnYeniUrunEkle.Name = "pnYeniUrunEkle";
            this.pnYeniUrunEkle.Size = new System.Drawing.Size(566, 255);
            this.pnYeniUrunEkle.TabIndex = 19;
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(142, 89);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(121, 21);
            this.cmbKategoriler.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kategoriler";
            // 
            // btnUrunVazgec
            // 
            this.btnUrunVazgec.Location = new System.Drawing.Point(178, 162);
            this.btnUrunVazgec.Name = "btnUrunVazgec";
            this.btnUrunVazgec.Size = new System.Drawing.Size(109, 47);
            this.btnUrunVazgec.TabIndex = 16;
            this.btnUrunVazgec.Text = "Vazgec";
            this.btnUrunVazgec.UseVisualStyleBackColor = true;
            this.btnUrunVazgec.Click += new System.EventHandler(this.btnUrunVazgec_Click);
            // 
            // btnUrunKaydet
            // 
            this.btnUrunKaydet.Location = new System.Drawing.Point(46, 164);
            this.btnUrunKaydet.Name = "btnUrunKaydet";
            this.btnUrunKaydet.Size = new System.Drawing.Size(109, 47);
            this.btnUrunKaydet.TabIndex = 15;
            this.btnUrunKaydet.Text = "Urun Kaydet";
            this.btnUrunKaydet.UseVisualStyleBackColor = true;
            this.btnUrunKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Kategorisi Yanda secilen kategoriden alıncak";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Yeni Ürün Tane Fiyat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Yeni Urün Adı";
            // 
            // nuYeniUrunTaneFiyat
            // 
            this.nuYeniUrunTaneFiyat.Location = new System.Drawing.Point(142, 50);
            this.nuYeniUrunTaneFiyat.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nuYeniUrunTaneFiyat.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuYeniUrunTaneFiyat.Name = "nuYeniUrunTaneFiyat";
            this.nuYeniUrunTaneFiyat.Size = new System.Drawing.Size(121, 20);
            this.nuYeniUrunTaneFiyat.TabIndex = 12;
            this.nuYeniUrunTaneFiyat.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Stok Otomatik Default 0 atanıcak";
            // 
            // txtYeniUrunAdi
            // 
            this.txtYeniUrunAdi.Location = new System.Drawing.Point(142, 15);
            this.txtYeniUrunAdi.Name = "txtYeniUrunAdi";
            this.txtYeniUrunAdi.Size = new System.Drawing.Size(121, 20);
            this.txtYeniUrunAdi.TabIndex = 10;
            // 
            // UrunEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 287);
            this.Controls.Add(this.pnYeniUrunEkle);
            this.Name = "UrunEkleForm";
            this.Text = "UrunEkleForm";
            this.Load += new System.EventHandler(this.UrunEkleForm_Load);
            this.pnYeniUrunEkle.ResumeLayout(false);
            this.pnYeniUrunEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuYeniUrunTaneFiyat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnYeniUrunEkle;
        private System.Windows.Forms.Button btnUrunVazgec;
        private System.Windows.Forms.Button btnUrunKaydet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nuYeniUrunTaneFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtYeniUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKategoriler;
    }
}