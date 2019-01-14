namespace Market.WFA
{
    partial class RaporForm
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
            this.dgvRapor = new System.Windows.Forms.DataGridView();
            this.btnGunluk = new System.Windows.Forms.Button();
            this.btnHaftalik = new System.Windows.Forms.Button();
            this.btnAylik = new System.Windows.Forms.Button();
            this.btnYillik = new System.Windows.Forms.Button();
            this.dtpTarihSec = new System.Windows.Forms.DateTimePicker();
            this.btnKategori = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRapor
            // 
            this.dgvRapor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRapor.Location = new System.Drawing.Point(-2, 55);
            this.dgvRapor.Name = "dgvRapor";
            this.dgvRapor.Size = new System.Drawing.Size(985, 438);
            this.dgvRapor.TabIndex = 0;
            // 
            // btnGunluk
            // 
            this.btnGunluk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGunluk.Location = new System.Drawing.Point(12, 12);
            this.btnGunluk.Name = "btnGunluk";
            this.btnGunluk.Size = new System.Drawing.Size(99, 34);
            this.btnGunluk.TabIndex = 1;
            this.btnGunluk.Text = "Günlük";
            this.btnGunluk.UseVisualStyleBackColor = true;
            this.btnGunluk.Click += new System.EventHandler(this.btnGunluk_Click);
            // 
            // btnHaftalik
            // 
            this.btnHaftalik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHaftalik.Location = new System.Drawing.Point(117, 12);
            this.btnHaftalik.Name = "btnHaftalik";
            this.btnHaftalik.Size = new System.Drawing.Size(99, 34);
            this.btnHaftalik.TabIndex = 2;
            this.btnHaftalik.Text = "Haftalık";
            this.btnHaftalik.UseVisualStyleBackColor = true;
            this.btnHaftalik.Click += new System.EventHandler(this.btnHaftalik_Click);
            // 
            // btnAylik
            // 
            this.btnAylik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAylik.Location = new System.Drawing.Point(222, 12);
            this.btnAylik.Name = "btnAylik";
            this.btnAylik.Size = new System.Drawing.Size(99, 34);
            this.btnAylik.TabIndex = 3;
            this.btnAylik.Text = "Aylık";
            this.btnAylik.UseVisualStyleBackColor = true;
            this.btnAylik.Click += new System.EventHandler(this.btnAylik_Click);
            // 
            // btnYillik
            // 
            this.btnYillik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYillik.Location = new System.Drawing.Point(327, 12);
            this.btnYillik.Name = "btnYillik";
            this.btnYillik.Size = new System.Drawing.Size(99, 34);
            this.btnYillik.TabIndex = 4;
            this.btnYillik.Text = "Yıllık";
            this.btnYillik.UseVisualStyleBackColor = true;
            this.btnYillik.Click += new System.EventHandler(this.btnYillik_Click);
            // 
            // dtpTarihSec
            // 
            this.dtpTarihSec.Location = new System.Drawing.Point(446, 17);
            this.dtpTarihSec.Name = "dtpTarihSec";
            this.dtpTarihSec.Size = new System.Drawing.Size(200, 20);
            this.dtpTarihSec.TabIndex = 5;
            // 
            // btnKategori
            // 
            this.btnKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategori.Location = new System.Drawing.Point(677, 12);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(99, 34);
            this.btnKategori.TabIndex = 6;
            this.btnKategori.Text = "Kategori";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 492);
            this.Controls.Add(this.btnKategori);
            this.Controls.Add(this.dtpTarihSec);
            this.Controls.Add(this.btnYillik);
            this.Controls.Add(this.btnAylik);
            this.Controls.Add(this.btnHaftalik);
            this.Controls.Add(this.btnGunluk);
            this.Controls.Add(this.dgvRapor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaporForm";
            this.Load += new System.EventHandler(this.RaporForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRapor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRapor;
        private System.Windows.Forms.Button btnGunluk;
        private System.Windows.Forms.Button btnHaftalik;
        private System.Windows.Forms.Button btnAylik;
        private System.Windows.Forms.Button btnYillik;
        private System.Windows.Forms.DateTimePicker dtpTarihSec;
        private System.Windows.Forms.Button btnKategori;
    }
}