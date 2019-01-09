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
            this.lstCategoryiSec = new System.Windows.Forms.ListBox();
            this.btnKategoriVazgec = new System.Windows.Forms.Button();
            this.btnYeniKategoriEkle = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKategoriOzet = new System.Windows.Forms.RichTextBox();
            this.txtYeniKategoriAdi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCategoryiSec
            // 
            this.lstCategoryiSec.FormattingEnabled = true;
            this.lstCategoryiSec.Location = new System.Drawing.Point(295, 32);
            this.lstCategoryiSec.Name = "lstCategoryiSec";
            this.lstCategoryiSec.Size = new System.Drawing.Size(127, 199);
            this.lstCategoryiSec.TabIndex = 34;
            // 
            // btnKategoriVazgec
            // 
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
            this.btnYeniKategoriEkle.Location = new System.Drawing.Point(36, 227);
            this.btnYeniKategoriEkle.Name = "btnYeniKategoriEkle";
            this.btnYeniKategoriEkle.Size = new System.Drawing.Size(107, 47);
            this.btnYeniKategoriEkle.TabIndex = 32;
            this.btnYeniKategoriEkle.Text = "Kategori Kaydet";
            this.btnYeniKategoriEkle.UseVisualStyleBackColor = true;
            this.btnYeniKategoriEkle.Click += new System.EventHandler(this.btnYeniKategoriEkle_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Açıklama";
            // 
            // txtKategoriOzet
            // 
            this.txtKategoriOzet.Location = new System.Drawing.Point(115, 59);
            this.txtKategoriOzet.Name = "txtKategoriOzet";
            this.txtKategoriOzet.Size = new System.Drawing.Size(125, 56);
            this.txtKategoriOzet.TabIndex = 30;
            this.txtKategoriOzet.Text = "";
            // 
            // txtYeniKategoriAdi
            // 
            this.txtYeniKategoriAdi.Location = new System.Drawing.Point(115, 32);
            this.txtYeniKategoriAdi.Name = "txtYeniKategoriAdi";
            this.txtYeniKategoriAdi.Size = new System.Drawing.Size(125, 20);
            this.txtYeniKategoriAdi.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Kategori Adı";
            // 
            // KategoriEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 467);
            this.Controls.Add(this.lstCategoryiSec);
            this.Controls.Add(this.btnKategoriVazgec);
            this.Controls.Add(this.btnYeniKategoriEkle);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtKategoriOzet);
            this.Controls.Add(this.txtYeniKategoriAdi);
            this.Controls.Add(this.label9);
            this.Name = "KategoriEkleForm";
            this.Text = "KategoriEkleForm";
            this.Load += new System.EventHandler(this.KategoriEkleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCategoryiSec;
        private System.Windows.Forms.Button btnKategoriVazgec;
        private System.Windows.Forms.Button btnYeniKategoriEkle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox txtKategoriOzet;
        private System.Windows.Forms.TextBox txtYeniKategoriAdi;
        private System.Windows.Forms.Label label9;
    }
}