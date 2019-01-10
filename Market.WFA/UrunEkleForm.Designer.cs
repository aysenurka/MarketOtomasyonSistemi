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
            this.label5 = new System.Windows.Forms.Label();
            this.txtYeniUrunAdi = new System.Windows.Forms.TextBox();
            this.pnYeniUrunEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnYeniUrunEkle
            // 
            this.pnYeniUrunEkle.Controls.Add(this.cmbKategoriler);
            this.pnYeniUrunEkle.Controls.Add(this.label1);
            this.pnYeniUrunEkle.Controls.Add(this.btnUrunVazgec);
            this.pnYeniUrunEkle.Controls.Add(this.btnUrunKaydet);
            this.pnYeniUrunEkle.Controls.Add(this.label5);
            this.pnYeniUrunEkle.Controls.Add(this.txtYeniUrunAdi);
            this.pnYeniUrunEkle.Location = new System.Drawing.Point(12, 12);
            this.pnYeniUrunEkle.Name = "pnYeniUrunEkle";
            this.pnYeniUrunEkle.Size = new System.Drawing.Size(566, 255);
            this.pnYeniUrunEkle.TabIndex = 19;
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(142, 51);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(121, 21);
            this.cmbKategoriler.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kategoriler";
            // 
            // btnUrunVazgec
            // 
            this.btnUrunVazgec.Location = new System.Drawing.Point(167, 92);
            this.btnUrunVazgec.Name = "btnUrunVazgec";
            this.btnUrunVazgec.Size = new System.Drawing.Size(109, 47);
            this.btnUrunVazgec.TabIndex = 16;
            this.btnUrunVazgec.Text = "Vazgec";
            this.btnUrunVazgec.UseVisualStyleBackColor = true;
            this.btnUrunVazgec.Click += new System.EventHandler(this.btnUrunVazgec_Click);
            // 
            // btnUrunKaydet
            // 
            this.btnUrunKaydet.Location = new System.Drawing.Point(35, 94);
            this.btnUrunKaydet.Name = "btnUrunKaydet";
            this.btnUrunKaydet.Size = new System.Drawing.Size(109, 47);
            this.btnUrunKaydet.TabIndex = 15;
            this.btnUrunKaydet.Text = "Urun Kaydet";
            this.btnUrunKaydet.UseVisualStyleBackColor = true;
            this.btnUrunKaydet.Click += new System.EventHandler(this.btnUrunKaydet_Click);
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
            this.ClientSize = new System.Drawing.Size(505, 280);
            this.Controls.Add(this.pnYeniUrunEkle);
            this.Name = "UrunEkleForm";
            this.Text = "UrunEkleForm";
            this.Load += new System.EventHandler(this.UrunEkleForm_Load);
            this.pnYeniUrunEkle.ResumeLayout(false);
            this.pnYeniUrunEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnYeniUrunEkle;
        private System.Windows.Forms.Button btnUrunVazgec;
        private System.Windows.Forms.Button btnUrunKaydet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYeniUrunAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbKategoriler;
    }
}