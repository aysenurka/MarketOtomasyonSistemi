namespace Market.WFA
{
    partial class YeniUrunDetayForm
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
            this.cmbYeniCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUrunCategory = new System.Windows.Forms.ComboBox();
            this.btnYeniUrunEkle = new System.Windows.Forms.Button();
            this.nuUrunAdetBilgisi = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nuUrunKoliFiyati = new System.Windows.Forms.NumericUpDown();
            this.btnYeniKategori = new System.Windows.Forms.Button();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.pnUrunBilgileri = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.nuAdet = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nuUrunKarOranı = new System.Windows.Forms.NumericUpDown();
            this.nuYeniUrunKdvDegeri = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nuYeniUrunIndirim = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuUrunAdetBilgisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUrunKoliFiyati)).BeginInit();
            this.pnUrunBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuAdet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUrunKarOranı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuYeniUrunKdvDegeri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuYeniUrunIndirim)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbYeniCategory
            // 
            this.cmbYeniCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYeniCategory.FormattingEnabled = true;
            this.cmbYeniCategory.Location = new System.Drawing.Point(173, 23);
            this.cmbYeniCategory.Name = "cmbYeniCategory";
            this.cmbYeniCategory.Size = new System.Drawing.Size(121, 24);
            this.cmbYeniCategory.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Urun Categorisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Urun Sec";
            // 
            // cmbUrunCategory
            // 
            this.cmbUrunCategory.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUrunCategory.FormattingEnabled = true;
            this.cmbUrunCategory.Location = new System.Drawing.Point(173, 53);
            this.cmbUrunCategory.Name = "cmbUrunCategory";
            this.cmbUrunCategory.Size = new System.Drawing.Size(121, 24);
            this.cmbUrunCategory.TabIndex = 3;
            // 
            // btnYeniUrunEkle
            // 
            this.btnYeniUrunEkle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeniUrunEkle.Location = new System.Drawing.Point(341, 48);
            this.btnYeniUrunEkle.Name = "btnYeniUrunEkle";
            this.btnYeniUrunEkle.Size = new System.Drawing.Size(145, 26);
            this.btnYeniUrunEkle.TabIndex = 4;
            this.btnYeniUrunEkle.Text = "Yeni Urun Ekle";
            this.btnYeniUrunEkle.UseVisualStyleBackColor = true;
            this.btnYeniUrunEkle.Click += new System.EventHandler(this.btnYeniUrunEkle_Click);
            // 
            // nuUrunAdetBilgisi
            // 
            this.nuUrunAdetBilgisi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuUrunAdetBilgisi.Location = new System.Drawing.Point(258, 111);
            this.nuUrunAdetBilgisi.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nuUrunAdetBilgisi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuUrunAdetBilgisi.Name = "nuUrunAdetBilgisi";
            this.nuUrunAdetBilgisi.Size = new System.Drawing.Size(123, 23);
            this.nuUrunAdetBilgisi.TabIndex = 5;
            this.nuUrunAdetBilgisi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Urun Birim Adet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(38, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Urun  Koli veya birim fiyatı Fiyatı";
            // 
            // nuUrunKoliFiyati
            // 
            this.nuUrunKoliFiyati.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuUrunKoliFiyati.Location = new System.Drawing.Point(258, 169);
            this.nuUrunKoliFiyati.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nuUrunKoliFiyati.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuUrunKoliFiyati.Name = "nuUrunKoliFiyati";
            this.nuUrunKoliFiyati.Size = new System.Drawing.Size(123, 23);
            this.nuUrunKoliFiyati.TabIndex = 8;
            this.nuUrunKoliFiyati.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnYeniKategori
            // 
            this.btnYeniKategori.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYeniKategori.Location = new System.Drawing.Point(341, 16);
            this.btnYeniKategori.Name = "btnYeniKategori";
            this.btnYeniKategori.Size = new System.Drawing.Size(145, 26);
            this.btnYeniKategori.TabIndex = 16;
            this.btnYeniKategori.Text = "Yeni Kategori Ekle";
            this.btnYeniKategori.UseVisualStyleBackColor = true;
            this.btnYeniKategori.Click += new System.EventHandler(this.btnYeniKategori_Click);
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBarkodNo.Location = new System.Drawing.Point(73, 12);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(154, 22);
            this.txtBarkodNo.TabIndex = 24;
            // 
            // pnUrunBilgileri
            // 
            this.pnUrunBilgileri.Controls.Add(this.label10);
            this.pnUrunBilgileri.Controls.Add(this.nuAdet);
            this.pnUrunBilgileri.Controls.Add(this.label9);
            this.pnUrunBilgileri.Controls.Add(this.nuUrunKarOranı);
            this.pnUrunBilgileri.Controls.Add(this.nuYeniUrunKdvDegeri);
            this.pnUrunBilgileri.Controls.Add(this.label11);
            this.pnUrunBilgileri.Controls.Add(this.nuYeniUrunIndirim);
            this.pnUrunBilgileri.Controls.Add(this.label14);
            this.pnUrunBilgileri.Controls.Add(this.nuUrunKoliFiyati);
            this.pnUrunBilgileri.Controls.Add(this.btnKaydet);
            this.pnUrunBilgileri.Controls.Add(this.btnYeniUrunEkle);
            this.pnUrunBilgileri.Controls.Add(this.cmbYeniCategory);
            this.pnUrunBilgileri.Controls.Add(this.label1);
            this.pnUrunBilgileri.Controls.Add(this.label2);
            this.pnUrunBilgileri.Controls.Add(this.cmbUrunCategory);
            this.pnUrunBilgileri.Controls.Add(this.nuUrunAdetBilgisi);
            this.pnUrunBilgileri.Controls.Add(this.btnYeniKategori);
            this.pnUrunBilgileri.Controls.Add(this.label3);
            this.pnUrunBilgileri.Controls.Add(this.label4);
            this.pnUrunBilgileri.Location = new System.Drawing.Point(12, 41);
            this.pnUrunBilgileri.Name = "pnUrunBilgileri";
            this.pnUrunBilgileri.Size = new System.Drawing.Size(504, 369);
            this.pnUrunBilgileri.TabIndex = 25;
            this.pnUrunBilgileri.Paint += new System.Windows.Forms.PaintEventHandler(this.pnUrunBilgileri_Paint);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(36, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Adet Sayisi";
            // 
            // nuAdet
            // 
            this.nuAdet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuAdet.Location = new System.Drawing.Point(258, 140);
            this.nuAdet.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nuAdet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuAdet.Name = "nuAdet";
            this.nuAdet.Size = new System.Drawing.Size(123, 23);
            this.nuAdet.TabIndex = 31;
            this.nuAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Kar Fiyatı";
            // 
            // nuUrunKarOranı
            // 
            this.nuUrunKarOranı.DecimalPlaces = 2;
            this.nuUrunKarOranı.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuUrunKarOranı.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nuUrunKarOranı.Location = new System.Drawing.Point(260, 256);
            this.nuUrunKarOranı.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuUrunKarOranı.Name = "nuUrunKarOranı";
            this.nuUrunKarOranı.Size = new System.Drawing.Size(123, 23);
            this.nuUrunKarOranı.TabIndex = 29;
            // 
            // nuYeniUrunKdvDegeri
            // 
            this.nuYeniUrunKdvDegeri.DecimalPlaces = 2;
            this.nuYeniUrunKdvDegeri.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuYeniUrunKdvDegeri.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nuYeniUrunKdvDegeri.Location = new System.Drawing.Point(260, 227);
            this.nuYeniUrunKdvDegeri.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuYeniUrunKdvDegeri.Name = "nuYeniUrunKdvDegeri";
            this.nuYeniUrunKdvDegeri.Size = new System.Drawing.Size(123, 23);
            this.nuYeniUrunKdvDegeri.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 234);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "KDV Degeri";
            // 
            // nuYeniUrunIndirim
            // 
            this.nuYeniUrunIndirim.DecimalPlaces = 2;
            this.nuYeniUrunIndirim.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuYeniUrunIndirim.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nuYeniUrunIndirim.Location = new System.Drawing.Point(258, 198);
            this.nuYeniUrunIndirim.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuYeniUrunIndirim.Name = "nuYeniUrunIndirim";
            this.nuYeniUrunIndirim.Size = new System.Drawing.Size(123, 23);
            this.nuYeniUrunIndirim.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(38, 205);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 16);
            this.label14.TabIndex = 26;
            this.label14.Text = "Urun İndirim Fiyatı";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.Location = new System.Drawing.Point(214, 285);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(167, 66);
            this.btnKaydet.TabIndex = 24;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 16);
            this.label15.TabIndex = 26;
            this.label15.Text = "Barkod";
            // 
            // YeniUrunDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(602, 469);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pnUrunBilgileri);
            this.Controls.Add(this.txtBarkodNo);
            this.Name = "YeniUrunDetayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.YeniUrunForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuUrunAdetBilgisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUrunKoliFiyati)).EndInit();
            this.pnUrunBilgileri.ResumeLayout(false);
            this.pnUrunBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuAdet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUrunKarOranı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuYeniUrunKdvDegeri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuYeniUrunIndirim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnYeniUrunEkle;
        private System.Windows.Forms.NumericUpDown nuUrunAdetBilgisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nuUrunKoliFiyati;
        private System.Windows.Forms.Button btnYeniKategori;
        public System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.NumericUpDown nuYeniUrunIndirim;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nuYeniUrunKdvDegeri;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        public System.Windows.Forms.ComboBox cmbYeniCategory;
        public System.Windows.Forms.Panel pnUrunBilgileri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nuUrunKarOranı;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nuAdet;
        public System.Windows.Forms.ComboBox cmbUrunCategory;
    }
}