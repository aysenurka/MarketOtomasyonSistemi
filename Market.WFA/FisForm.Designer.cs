namespace Market.WFA
{
    partial class FisForm
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
            this.lblFis = new System.Windows.Forms.Label();
            this.lblFisInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblFis
            // 
            this.lblFis.AutoSize = true;
            this.lblFis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFis.Location = new System.Drawing.Point(12, 9);
            this.lblFis.Name = "lblFis";
            this.lblFis.Size = new System.Drawing.Size(0, 16);
            this.lblFis.TabIndex = 0;
            // 
            // lblFisInfo
            // 
            this.lblFisInfo.AutoSize = true;
            this.lblFisInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFisInfo.Location = new System.Drawing.Point(12, 39);
            this.lblFisInfo.Name = "lblFisInfo";
            this.lblFisInfo.Size = new System.Drawing.Size(0, 16);
            this.lblFisInfo.TabIndex = 1;
            // 
            // FisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 368);
            this.Controls.Add(this.lblFisInfo);
            this.Controls.Add(this.lblFis);
            this.Name = "FisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FisForm";
            this.Load += new System.EventHandler(this.FisForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblFisInfo;
        public System.Windows.Forms.Label lblFis;
    }
}