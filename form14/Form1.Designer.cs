namespace form14
{
    partial class Form1
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
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblTaksit = new System.Windows.Forms.Label();
            this.lblborc = new System.Windows.Forms.Label();
            this.btnhesaplama = new System.Windows.Forms.Button();
            this.cmbTaksit = new System.Windows.Forms.ComboBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(35, 42);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(35, 13);
            this.lblTutar.TabIndex = 0;
            this.lblTutar.Text = "Tutar:";
            // 
            // lblTaksit
            // 
            this.lblTaksit.AutoSize = true;
            this.lblTaksit.Location = new System.Drawing.Point(35, 84);
            this.lblTaksit.Name = "lblTaksit";
            this.lblTaksit.Size = new System.Drawing.Size(36, 13);
            this.lblTaksit.TabIndex = 1;
            this.lblTaksit.Text = "Taksit";
            // 
            // lblborc
            // 
            this.lblborc.AutoSize = true;
            this.lblborc.Location = new System.Drawing.Point(35, 172);
            this.lblborc.Name = "lblborc";
            this.lblborc.Size = new System.Drawing.Size(71, 13);
            this.lblborc.TabIndex = 2;
            this.lblborc.Text = "Aylık ödenen:";
            // 
            // btnhesaplama
            // 
            this.btnhesaplama.Location = new System.Drawing.Point(325, 172);
            this.btnhesaplama.Name = "btnhesaplama";
            this.btnhesaplama.Size = new System.Drawing.Size(116, 64);
            this.btnhesaplama.TabIndex = 3;
            this.btnhesaplama.Text = "hesaplama";
            this.btnhesaplama.UseVisualStyleBackColor = true;
            this.btnhesaplama.Click += new System.EventHandler(this.btnhesaplama_Click);
            // 
            // cmbTaksit
            // 
            this.cmbTaksit.FormattingEnabled = true;
            this.cmbTaksit.Location = new System.Drawing.Point(99, 84);
            this.cmbTaksit.Name = "cmbTaksit";
            this.cmbTaksit.Size = new System.Drawing.Size(121, 21);
            this.cmbTaksit.TabIndex = 4;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(99, 35);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(121, 20);
            this.txtTutar.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 322);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.cmbTaksit);
            this.Controls.Add(this.btnhesaplama);
            this.Controls.Add(this.lblborc);
            this.Controls.Add(this.lblTaksit);
            this.Controls.Add(this.lblTutar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblTaksit;
        private System.Windows.Forms.Label lblborc;
        private System.Windows.Forms.Button btnhesaplama;
        private System.Windows.Forms.ComboBox cmbTaksit;
        private System.Windows.Forms.TextBox txtTutar;
    }
}

