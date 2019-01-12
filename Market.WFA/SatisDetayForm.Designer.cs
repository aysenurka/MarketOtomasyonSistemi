namespace Market.WFA
{
    partial class SatisDetayForm
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
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.lblToplam = new System.Windows.Forms.Label();
            this.pnlOdeme = new System.Windows.Forms.Panel();
            this.rbKart = new System.Windows.Forms.RadioButton();
            this.rbNakit = new System.Windows.Forms.RadioButton();
            this.lblOdeme = new System.Windows.Forms.Label();
            this.btnOde = new System.Windows.Forms.Button();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.txtNakit = new System.Windows.Forms.TextBox();
            this.lblNakit = new System.Windows.Forms.Label();
            this.lblParaUstu = new System.Windows.Forms.Label();
            this.nuPoset = new System.Windows.Forms.NumericUpDown();
            this.cbPoset = new System.Windows.Forms.CheckBox();
            this.pnlNakit = new System.Windows.Forms.Panel();
            this.pnlOdeme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPoset)).BeginInit();
            this.pnlNakit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstUrunler
            // 
            this.lstUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.ItemHeight = 20;
            this.lstUrunler.Location = new System.Drawing.Point(12, 12);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(227, 244);
            this.lstUrunler.TabIndex = 0;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(245, 12);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(93, 37);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lstSepet
            // 
            this.lstSepet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.ItemHeight = 20;
            this.lstSepet.Location = new System.Drawing.Point(442, 12);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(346, 244);
            this.lstSepet.TabIndex = 2;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplam.Location = new System.Drawing.Point(442, 287);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(72, 20);
            this.lblToplam.TabIndex = 3;
            this.lblToplam.Text = "Toplam:";
            this.lblToplam.Visible = false;
            // 
            // pnlOdeme
            // 
            this.pnlOdeme.Controls.Add(this.rbKart);
            this.pnlOdeme.Controls.Add(this.rbNakit);
            this.pnlOdeme.Controls.Add(this.lblOdeme);
            this.pnlOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlOdeme.Location = new System.Drawing.Point(541, 316);
            this.pnlOdeme.Name = "pnlOdeme";
            this.pnlOdeme.Size = new System.Drawing.Size(247, 37);
            this.pnlOdeme.TabIndex = 4;
            this.pnlOdeme.Visible = false;
            // 
            // rbKart
            // 
            this.rbKart.AutoSize = true;
            this.rbKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbKart.Location = new System.Drawing.Point(110, 9);
            this.rbKart.Name = "rbKart";
            this.rbKart.Size = new System.Drawing.Size(60, 24);
            this.rbKart.TabIndex = 5;
            this.rbKart.TabStop = true;
            this.rbKart.Text = "Kart";
            this.rbKart.UseVisualStyleBackColor = true;
            this.rbKart.CheckedChanged += new System.EventHandler(this.rbKart_CheckedChanged);
            // 
            // rbNakit
            // 
            this.rbNakit.AutoSize = true;
            this.rbNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbNakit.Location = new System.Drawing.Point(176, 9);
            this.rbNakit.Name = "rbNakit";
            this.rbNakit.Size = new System.Drawing.Size(68, 24);
            this.rbNakit.TabIndex = 6;
            this.rbNakit.TabStop = true;
            this.rbNakit.Text = "Nakit";
            this.rbNakit.UseVisualStyleBackColor = true;
            this.rbNakit.CheckedChanged += new System.EventHandler(this.rbNakit_CheckedChanged);
            // 
            // lblOdeme
            // 
            this.lblOdeme.AutoSize = true;
            this.lblOdeme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOdeme.Location = new System.Drawing.Point(3, 9);
            this.lblOdeme.Name = "lblOdeme";
            this.lblOdeme.Size = new System.Drawing.Size(109, 20);
            this.lblOdeme.TabIndex = 4;
            this.lblOdeme.Text = "Odeme Tipi: ";
            // 
            // btnOde
            // 
            this.btnOde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOde.Location = new System.Drawing.Point(442, 316);
            this.btnOde.Name = "btnOde";
            this.btnOde.Size = new System.Drawing.Size(93, 37);
            this.btnOde.TabIndex = 5;
            this.btnOde.Text = "Ode";
            this.btnOde.UseVisualStyleBackColor = true;
            this.btnOde.Visible = false;
            this.btnOde.Click += new System.EventHandler(this.btnOde_Click);
            // 
            // btnTamamla
            // 
            this.btnTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamamla.Location = new System.Drawing.Point(692, 441);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(93, 37);
            this.btnTamamla.TabIndex = 6;
            this.btnTamamla.Text = "Tamamla";
            this.btnTamamla.UseVisualStyleBackColor = true;
            this.btnTamamla.Visible = false;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // txtNakit
            // 
            this.txtNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNakit.Location = new System.Drawing.Point(123, 6);
            this.txtNakit.MaxLength = 6;
            this.txtNakit.Name = "txtNakit";
            this.txtNakit.Size = new System.Drawing.Size(121, 26);
            this.txtNakit.TabIndex = 7;
            this.txtNakit.Visible = false;
            // 
            // lblNakit
            // 
            this.lblNakit.AutoSize = true;
            this.lblNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNakit.Location = new System.Drawing.Point(3, 9);
            this.lblNakit.Name = "lblNakit";
            this.lblNakit.Size = new System.Drawing.Size(101, 20);
            this.lblNakit.TabIndex = 8;
            this.lblNakit.Text = "Nakit Girisi:";
            this.lblNakit.Visible = false;
            // 
            // lblParaUstu
            // 
            this.lblParaUstu.AutoSize = true;
            this.lblParaUstu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblParaUstu.Location = new System.Drawing.Point(3, 48);
            this.lblParaUstu.Name = "lblParaUstu";
            this.lblParaUstu.Size = new System.Drawing.Size(94, 20);
            this.lblParaUstu.TabIndex = 9;
            this.lblParaUstu.Text = "Para Ustu:";
            this.lblParaUstu.Visible = false;
            // 
            // nuPoset
            // 
            this.nuPoset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nuPoset.Location = new System.Drawing.Point(548, 446);
            this.nuPoset.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nuPoset.Name = "nuPoset";
            this.nuPoset.Size = new System.Drawing.Size(75, 26);
            this.nuPoset.TabIndex = 11;
            this.nuPoset.Visible = false;
            this.nuPoset.ValueChanged += new System.EventHandler(this.nuPoset_ValueChanged);
            // 
            // cbPoset
            // 
            this.cbPoset.AutoSize = true;
            this.cbPoset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbPoset.Location = new System.Drawing.Point(446, 448);
            this.cbPoset.Name = "cbPoset";
            this.cbPoset.Size = new System.Drawing.Size(79, 24);
            this.cbPoset.TabIndex = 12;
            this.cbPoset.Text = "Poset:";
            this.cbPoset.UseVisualStyleBackColor = true;
            this.cbPoset.Visible = false;
            this.cbPoset.CheckedChanged += new System.EventHandler(this.cbPoset_CheckedChanged);
            // 
            // pnlNakit
            // 
            this.pnlNakit.Controls.Add(this.lblNakit);
            this.pnlNakit.Controls.Add(this.txtNakit);
            this.pnlNakit.Controls.Add(this.lblParaUstu);
            this.pnlNakit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnlNakit.Location = new System.Drawing.Point(541, 355);
            this.pnlNakit.Name = "pnlNakit";
            this.pnlNakit.Size = new System.Drawing.Size(247, 80);
            this.pnlNakit.TabIndex = 13;
            this.pnlNakit.Visible = false;
            // 
            // SatisDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.pnlNakit);
            this.Controls.Add(this.cbPoset);
            this.Controls.Add(this.nuPoset);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.btnOde);
            this.Controls.Add(this.pnlOdeme);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstUrunler);
            this.Name = "SatisDetayForm";
            this.Text = "SatisDetayForm";
            this.Load += new System.EventHandler(this.SatisDetayForm_Load);
            this.pnlOdeme.ResumeLayout(false);
            this.pnlOdeme.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuPoset)).EndInit();
            this.pnlNakit.ResumeLayout(false);
            this.pnlNakit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Panel pnlOdeme;
        private System.Windows.Forms.RadioButton rbKart;
        private System.Windows.Forms.RadioButton rbNakit;
        private System.Windows.Forms.Label lblOdeme;
        private System.Windows.Forms.Button btnOde;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.TextBox txtNakit;
        private System.Windows.Forms.Label lblNakit;
        private System.Windows.Forms.Label lblParaUstu;
        private System.Windows.Forms.NumericUpDown nuPoset;
        private System.Windows.Forms.CheckBox cbPoset;
        private System.Windows.Forms.Panel pnlNakit;
    }
}