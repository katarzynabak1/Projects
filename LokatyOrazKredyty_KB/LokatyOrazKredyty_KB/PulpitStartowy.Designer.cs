namespace LokatyOrazKredyty_KB
{
    partial class PulpitStartowy
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
            this.lblKalkulatorBankowy = new System.Windows.Forms.Label();
            this.btnLokaty = new System.Windows.Forms.Button();
            this.btnKredyty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKalkulatorBankowy
            // 
            this.lblKalkulatorBankowy.AutoSize = true;
            this.lblKalkulatorBankowy.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblKalkulatorBankowy.Location = new System.Drawing.Point(328, 73);
            this.lblKalkulatorBankowy.Name = "lblKalkulatorBankowy";
            this.lblKalkulatorBankowy.Size = new System.Drawing.Size(319, 41);
            this.lblKalkulatorBankowy.TabIndex = 0;
            this.lblKalkulatorBankowy.Text = "Kalkulator bankowy";
            // 
            // btnLokaty
            // 
            this.btnLokaty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLokaty.Location = new System.Drawing.Point(177, 176);
            this.btnLokaty.Name = "btnLokaty";
            this.btnLokaty.Size = new System.Drawing.Size(169, 119);
            this.btnLokaty.TabIndex = 1;
            this.btnLokaty.Text = "Rozliczanie lokat\r\n bankowych";
            this.btnLokaty.UseVisualStyleBackColor = true;
            this.btnLokaty.Click += new System.EventHandler(this.btnLokaty_Click);
            // 
            // btnKredyty
            // 
            this.btnKredyty.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnKredyty.Location = new System.Drawing.Point(576, 176);
            this.btnKredyty.Name = "btnKredyty";
            this.btnKredyty.Size = new System.Drawing.Size(164, 119);
            this.btnKredyty.TabIndex = 2;
            this.btnKredyty.Text = "Rozliczanie kredytów \r\nbankowych";
            this.btnKredyty.UseVisualStyleBackColor = true;
            this.btnKredyty.Click += new System.EventHandler(this.btnKredyty_Click);
            // 
            // PulpitStartowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 540);
            this.Controls.Add(this.btnKredyty);
            this.Controls.Add(this.btnLokaty);
            this.Controls.Add(this.lblKalkulatorBankowy);
            this.Name = "PulpitStartowy";
            this.Text = "PulpitStartowy";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKalkulatorBankowy;
        private System.Windows.Forms.Button btnLokaty;
        private System.Windows.Forms.Button btnKredyty;
    }
}