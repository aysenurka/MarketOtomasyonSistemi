namespace Market.WFA
{
    partial class KategoriEkleForm
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
            this.btnKategoriVazgec = new System.Windows.Forms.Button();
            this.btnYeniKategoriEkle = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.cmbKategoriler = new System.Windows.Forms.ComboBox();
            this.treeKategoriView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btnKategoriVazgec
            // 
            this.btnKategoriVazgec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriVazgec.Location = new System.Drawing.Point(169, 227);
            this.btnKategoriVazgec.Name = "btnKategoriVazgec";
            this.btnKategoriVazgec.Size = new System.Drawing.Size(109, 47);
            this.btnKategoriVazgec.TabIndex = 33;
            this.btnKategoriVazgec.Text = "Vazgec";
            this.btnKategoriVazgec.UseVisualStyleBackColor = true;
            this.btnKategoriVazgec.Click += new System.EventHandler(this.btnKategoriVazgec_Click);
            // 
            // btnYeniKategoriEkle
            // 
            this.btnYeniKategoriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKategoriEkle.Location = new System.Drawing.Point(36, 227);
            this.btnYeniKategoriEkle.Name = "btnYeniKategoriEkle";
            this.btnYeniKategoriEkle.Size = new System.Drawing.Size(107, 47);
            this.btnYeniKategoriEkle.TabIndex = 32;
            this.btnYeniKategoriEkle.Text = "Kategori Kaydet";
            this.btnYeniKategoriEkle.UseVisualStyleBackColor = true;
            this.btnYeniKategoriEkle.Click += new System.EventHandler(this.btnYeniKategoriEkle_Click);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAciklama.Location = new System.Drawing.Point(36, 71);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(162, 111);
            this.txtAciklama.TabIndex = 37;
            this.txtAciklama.Text = "";
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKategoriAdi.Location = new System.Drawing.Point(36, 44);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(162, 22);
            this.txtKategoriAdi.TabIndex = 36;
            // 
            // cmbKategoriler
            // 
            this.cmbKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbKategoriler.FormattingEnabled = true;
            this.cmbKategoriler.Location = new System.Drawing.Point(36, 16);
            this.cmbKategoriler.Name = "cmbKategoriler";
            this.cmbKategoriler.Size = new System.Drawing.Size(162, 24);
            this.cmbKategoriler.TabIndex = 35;
            // 
            // treeKategoriView
            // 
            this.treeKategoriView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.treeKategoriView.FullRowSelect = true;
            this.treeKategoriView.Location = new System.Drawing.Point(319, 16);
            this.treeKategoriView.Name = "treeKategoriView";
            this.treeKategoriView.Size = new System.Drawing.Size(208, 258);
            this.treeKategoriView.TabIndex = 38;
            // 
            // KategoriEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 353);
            this.Controls.Add(this.treeKategoriView);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtKategoriAdi);
            this.Controls.Add(this.cmbKategoriler);
            this.Controls.Add(this.btnKategoriVazgec);
            this.Controls.Add(this.btnYeniKategoriEkle);
            this.Name = "KategoriEkleForm";
            this.Text = "KategoriEkleForm";
            this.Load += new System.EventHandler(this.KategoriEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnKategoriVazgec;
        private System.Windows.Forms.Button btnYeniKategoriEkle;
        private System.Windows.Forms.RichTextBox txtAciklama;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private System.Windows.Forms.ComboBox cmbKategoriler;
        private System.Windows.Forms.TreeView treeKategoriView;
    }
}