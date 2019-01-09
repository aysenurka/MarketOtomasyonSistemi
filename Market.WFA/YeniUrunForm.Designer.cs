namespace Market.WFA
{
    partial class YeniUrunForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtYeniUrunAdi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nuYeniUrunTaneFiyat = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUrunKaydet = new System.Windows.Forms.Button();
            this.btnYeniKategori = new System.Windows.Forms.Button();
            this.pnYeniUrunEkle = new System.Windows.Forms.Panel();
            this.btnUrunVazgec = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.pnUrunBilgileri = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.nuYeniUrunIndirim = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtYeniKategoriAdi = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnYeniKategoriEkle = new System.Windows.Forms.Button();
            this.trKategoriEkleme = new System.Windows.Forms.TreeView();
            this.btnKategoriVazgec = new System.Windows.Forms.Button();
            this.pnKategoriEkle = new System.Windows.Forms.Panel();
            this.nuYeniUrunKdvDegeri = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nuUrunAdetBilgisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUrunKoliFiyati)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuYeniUrunTaneFiyat)).BeginInit();
            this.pnYeniUrunEkle.SuspendLayout();
            this.pnUrunBilgileri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuYeniUrunIndirim)).BeginInit();
            this.pnKategoriEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuYeniUrunKdvDegeri)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbYeniCategory
            // 
            this.cmbYeniCategory.FormattingEnabled = true;
            this.cmbYeniCategory.Location = new System.Drawing.Point(98, 15);
            this.cmbYeniCategory.Name = "cmbYeniCategory";
            this.cmbYeniCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbYeniCategory.TabIndex = 0;
            this.cmbYeniCategory.SelectedIndexChanged += new System.EventHandler(this.cmbYeniCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Urun Categorisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Urun Sec";
            this.label2.Visible = false;
            // 
            // cmbUrunCategory
            // 
            this.cmbUrunCategory.FormattingEnabled = true;
            this.cmbUrunCategory.Location = new System.Drawing.Point(98, 45);
            this.cmbUrunCategory.Name = "cmbUrunCategory";
            this.cmbUrunCategory.Size = new System.Drawing.Size(121, 21);
            this.cmbUrunCategory.TabIndex = 3;
            this.cmbUrunCategory.Visible = false;
            // 
            // btnYeniUrunEkle
            // 
            this.btnYeniUrunEkle.Location = new System.Drawing.Point(236, 40);
            this.btnYeniUrunEkle.Name = "btnYeniUrunEkle";
            this.btnYeniUrunEkle.Size = new System.Drawing.Size(110, 26);
            this.btnYeniUrunEkle.TabIndex = 4;
            this.btnYeniUrunEkle.Text = "Yeni Urun Ekle";
            this.btnYeniUrunEkle.UseVisualStyleBackColor = true;
            this.btnYeniUrunEkle.Visible = false;
            this.btnYeniUrunEkle.Click += new System.EventHandler(this.btnYeniUrunEkle_Click);
            // 
            // nuUrunAdetBilgisi
            // 
            this.nuUrunAdetBilgisi.Location = new System.Drawing.Point(100, 98);
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
            this.nuUrunAdetBilgisi.Size = new System.Drawing.Size(123, 20);
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
            this.label3.Location = new System.Drawing.Point(5, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Urun Adet Sayısı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Urun  Koli Fiyatı";
            // 
            // nuUrunKoliFiyati
            // 
            this.nuUrunKoliFiyati.Location = new System.Drawing.Point(100, 72);
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
            this.nuUrunKoliFiyati.Size = new System.Drawing.Size(123, 20);
            this.nuUrunKoliFiyati.TabIndex = 8;
            this.nuUrunKoliFiyati.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Yeni Urün Adı";
            // 
            // txtYeniUrunAdi
            // 
            this.txtYeniUrunAdi.Location = new System.Drawing.Point(144, 12);
            this.txtYeniUrunAdi.Name = "txtYeniUrunAdi";
            this.txtYeniUrunAdi.Size = new System.Drawing.Size(117, 20);
            this.txtYeniUrunAdi.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Yeni Ürün Tane Fiyat";
            // 
            // nuYeniUrunTaneFiyat
            // 
            this.nuYeniUrunTaneFiyat.Location = new System.Drawing.Point(140, 49);
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
            this.label7.Location = new System.Drawing.Point(78, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Stok Otomatik Default 0 atanıcak";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(78, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(219, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Kategorisi Yanda secilen kategoriden alıncak";
            // 
            // btnUrunKaydet
            // 
            this.btnUrunKaydet.Location = new System.Drawing.Point(44, 161);
            this.btnUrunKaydet.Name = "btnUrunKaydet";
            this.btnUrunKaydet.Size = new System.Drawing.Size(109, 47);
            this.btnUrunKaydet.TabIndex = 15;
            this.btnUrunKaydet.Text = "Urun Kaydet";
            this.btnUrunKaydet.UseVisualStyleBackColor = true;
            this.btnUrunKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
            // 
            // btnYeniKategori
            // 
            this.btnYeniKategori.Location = new System.Drawing.Point(236, 8);
            this.btnYeniKategori.Name = "btnYeniKategori";
            this.btnYeniKategori.Size = new System.Drawing.Size(110, 26);
            this.btnYeniKategori.TabIndex = 16;
            this.btnYeniKategori.Text = "Yeni Kategori Ekle";
            this.btnYeniKategori.UseVisualStyleBackColor = true;
            this.btnYeniKategori.Click += new System.EventHandler(this.btnYeniKategori_Click);
            // 
            // pnYeniUrunEkle
            // 
            this.pnYeniUrunEkle.Controls.Add(this.btnUrunVazgec);
            this.pnYeniUrunEkle.Controls.Add(this.btnUrunKaydet);
            this.pnYeniUrunEkle.Controls.Add(this.label8);
            this.pnYeniUrunEkle.Controls.Add(this.label6);
            this.pnYeniUrunEkle.Controls.Add(this.label5);
            this.pnYeniUrunEkle.Controls.Add(this.nuYeniUrunTaneFiyat);
            this.pnYeniUrunEkle.Controls.Add(this.label7);
            this.pnYeniUrunEkle.Controls.Add(this.txtYeniUrunAdi);
            this.pnYeniUrunEkle.Location = new System.Drawing.Point(436, 41);
            this.pnYeniUrunEkle.Name = "pnYeniUrunEkle";
            this.pnYeniUrunEkle.Size = new System.Drawing.Size(305, 228);
            this.pnYeniUrunEkle.TabIndex = 18;
            this.pnYeniUrunEkle.Visible = false;
            // 
            // btnUrunVazgec
            // 
            this.btnUrunVazgec.Location = new System.Drawing.Point(176, 159);
            this.btnUrunVazgec.Name = "btnUrunVazgec";
            this.btnUrunVazgec.Size = new System.Drawing.Size(109, 47);
            this.btnUrunVazgec.TabIndex = 16;
            this.btnUrunVazgec.Text = "Vazgec";
            this.btnUrunVazgec.UseVisualStyleBackColor = true;
            this.btnUrunVazgec.Click += new System.EventHandler(this.btnUrunVazgec_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(249, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Kutu icindeki Adet";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(249, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Alış Fiyatı";
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(12, 12);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.ReadOnly = true;
            this.txtBarkodNo.Size = new System.Drawing.Size(154, 20);
            this.txtBarkodNo.TabIndex = 24;
            // 
            // pnUrunBilgileri
            // 
            this.pnUrunBilgileri.Controls.Add(this.nuYeniUrunKdvDegeri);
            this.pnUrunBilgileri.Controls.Add(this.label11);
            this.pnUrunBilgileri.Controls.Add(this.nuYeniUrunIndirim);
            this.pnUrunBilgileri.Controls.Add(this.label14);
            this.pnUrunBilgileri.Controls.Add(this.btnKaydet);
            this.pnUrunBilgileri.Controls.Add(this.btnYeniUrunEkle);
            this.pnUrunBilgileri.Controls.Add(this.cmbYeniCategory);
            this.pnUrunBilgileri.Controls.Add(this.label13);
            this.pnUrunBilgileri.Controls.Add(this.label1);
            this.pnUrunBilgileri.Controls.Add(this.label12);
            this.pnUrunBilgileri.Controls.Add(this.label2);
            this.pnUrunBilgileri.Controls.Add(this.cmbUrunCategory);
            this.pnUrunBilgileri.Controls.Add(this.nuUrunAdetBilgisi);
            this.pnUrunBilgileri.Controls.Add(this.btnYeniKategori);
            this.pnUrunBilgileri.Controls.Add(this.label3);
            this.pnUrunBilgileri.Controls.Add(this.nuUrunKoliFiyati);
            this.pnUrunBilgileri.Controls.Add(this.label4);
            this.pnUrunBilgileri.Location = new System.Drawing.Point(12, 41);
            this.pnUrunBilgileri.Name = "pnUrunBilgileri";
            this.pnUrunBilgileri.Size = new System.Drawing.Size(374, 247);
            this.pnUrunBilgileri.TabIndex = 25;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(98, 182);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(121, 46);
            this.btnKaydet.TabIndex = 24;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // nuYeniUrunIndirim
            // 
            this.nuYeniUrunIndirim.DecimalPlaces = 2;
            this.nuYeniUrunIndirim.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nuYeniUrunIndirim.Location = new System.Drawing.Point(100, 123);
            this.nuYeniUrunIndirim.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuYeniUrunIndirim.Name = "nuYeniUrunIndirim";
            this.nuYeniUrunIndirim.Size = new System.Drawing.Size(123, 20);
            this.nuYeniUrunIndirim.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 13);
            this.label14.TabIndex = 26;
            this.label14.Text = "Urun İndirim Fiyatı";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Kategori Adı";
            // 
            // txtYeniKategoriAdi
            // 
            this.txtYeniKategoriAdi.Location = new System.Drawing.Point(87, 8);
            this.txtYeniKategoriAdi.Name = "txtYeniKategoriAdi";
            this.txtYeniKategoriAdi.Size = new System.Drawing.Size(125, 20);
            this.txtYeniKategoriAdi.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(87, 35);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(125, 56);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Açıklama";
            // 
            // btnYeniKategoriEkle
            // 
            this.btnYeniKategoriEkle.Location = new System.Drawing.Point(23, 159);
            this.btnYeniKategoriEkle.Name = "btnYeniKategoriEkle";
            this.btnYeniKategoriEkle.Size = new System.Drawing.Size(107, 47);
            this.btnYeniKategoriEkle.TabIndex = 20;
            this.btnYeniKategoriEkle.Text = "Kategori Kaydet";
            this.btnYeniKategoriEkle.UseVisualStyleBackColor = true;
            this.btnYeniKategoriEkle.Click += new System.EventHandler(this.btnYeniKategoriEkle_Click);
            // 
            // trKategoriEkleme
            // 
            this.trKategoriEkleme.Location = new System.Drawing.Point(279, 3);
            this.trKategoriEkleme.Name = "trKategoriEkleme";
            this.trKategoriEkleme.Size = new System.Drawing.Size(167, 200);
            this.trKategoriEkleme.TabIndex = 25;
            // 
            // btnKategoriVazgec
            // 
            this.btnKategoriVazgec.Location = new System.Drawing.Point(164, 159);
            this.btnKategoriVazgec.Name = "btnKategoriVazgec";
            this.btnKategoriVazgec.Size = new System.Drawing.Size(109, 47);
            this.btnKategoriVazgec.TabIndex = 26;
            this.btnKategoriVazgec.Text = "Vazgec";
            this.btnKategoriVazgec.UseVisualStyleBackColor = true;
            this.btnKategoriVazgec.Click += new System.EventHandler(this.btnKategoriVazgec_Click);
            // 
            // pnKategoriEkle
            // 
            this.pnKategoriEkle.Controls.Add(this.btnKategoriVazgec);
            this.pnKategoriEkle.Controls.Add(this.trKategoriEkleme);
            this.pnKategoriEkle.Controls.Add(this.btnYeniKategoriEkle);
            this.pnKategoriEkle.Controls.Add(this.label10);
            this.pnKategoriEkle.Controls.Add(this.richTextBox1);
            this.pnKategoriEkle.Controls.Add(this.txtYeniKategoriAdi);
            this.pnKategoriEkle.Controls.Add(this.label9);
            this.pnKategoriEkle.Location = new System.Drawing.Point(768, 41);
            this.pnKategoriEkle.Name = "pnKategoriEkle";
            this.pnKategoriEkle.Size = new System.Drawing.Size(483, 225);
            this.pnKategoriEkle.TabIndex = 19;
            this.pnKategoriEkle.Visible = false;
            // 
            // nuYeniUrunKdvDegeri
            // 
            this.nuYeniUrunKdvDegeri.DecimalPlaces = 2;
            this.nuYeniUrunKdvDegeri.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nuYeniUrunKdvDegeri.Location = new System.Drawing.Point(100, 149);
            this.nuYeniUrunKdvDegeri.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nuYeniUrunKdvDegeri.Name = "nuYeniUrunKdvDegeri";
            this.nuYeniUrunKdvDegeri.Size = new System.Drawing.Size(123, 20);
            this.nuYeniUrunKdvDegeri.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "KDV Degeri";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(182, 12);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "label15";
            // 
            // YeniUrunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 512);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pnUrunBilgileri);
            this.Controls.Add(this.txtBarkodNo);
            this.Controls.Add(this.pnKategoriEkle);
            this.Controls.Add(this.pnYeniUrunEkle);
            this.Name = "YeniUrunForm";
            this.Text = "YeniUrunForm";
            this.Load += new System.EventHandler(this.YeniUrunForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuUrunAdetBilgisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuUrunKoliFiyati)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuYeniUrunTaneFiyat)).EndInit();
            this.pnYeniUrunEkle.ResumeLayout(false);
            this.pnYeniUrunEkle.PerformLayout();
            this.pnUrunBilgileri.ResumeLayout(false);
            this.pnUrunBilgileri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuYeniUrunIndirim)).EndInit();
            this.pnKategoriEkle.ResumeLayout(false);
            this.pnKategoriEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuYeniUrunKdvDegeri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbYeniCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUrunCategory;
        private System.Windows.Forms.Button btnYeniUrunEkle;
        private System.Windows.Forms.NumericUpDown nuUrunAdetBilgisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nuUrunKoliFiyati;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYeniUrunAdi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nuYeniUrunTaneFiyat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUrunKaydet;
        private System.Windows.Forms.Button btnYeniKategori;
        private System.Windows.Forms.Panel pnYeniUrunEkle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        public System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Button btnUrunVazgec;
        private System.Windows.Forms.Panel pnUrunBilgileri;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.NumericUpDown nuYeniUrunIndirim;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown nuYeniUrunKdvDegeri;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtYeniKategoriAdi;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnYeniKategoriEkle;
        private System.Windows.Forms.TreeView trKategoriEkleme;
        private System.Windows.Forms.Button btnKategoriVazgec;
        private System.Windows.Forms.Panel pnKategoriEkle;
        private System.Windows.Forms.Label label15;
    }
}