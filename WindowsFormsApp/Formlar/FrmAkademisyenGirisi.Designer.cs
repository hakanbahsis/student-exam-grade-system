namespace WindowsFormsApp.Formlar
{
    partial class FrmAkademisyenGirisi
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
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnGiris = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-4, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 46);
            this.label2.TabIndex = 22;
            this.label2.Text = "Okul Not Sistemi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(280, 32);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 50);
            this.button1.TabIndex = 21;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(80, 216);
            this.btnGiris.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(238, 51);
            this.btnGiris.TabIndex = 18;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 179);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Şifre";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSifre
            // 
            this.txtSifre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.ForeColor = System.Drawing.Color.White;
            this.txtSifre.Location = new System.Drawing.Point(79, 177);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(239, 27);
            this.txtSifre.TabIndex = 17;
            this.txtSifre.UseSystemPasswordChar = true;
            // 
            // txtNumara
            // 
            this.txtNumara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.txtNumara.ForeColor = System.Drawing.Color.White;
            this.txtNumara.Location = new System.Drawing.Point(79, 131);
            this.txtNumara.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtNumara.Mask = "00000";
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(236, 28);
            this.txtNumara.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(0, 131);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Numara";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FrmAkademisyenGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(325, 282);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAkademisyenGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAkademisyenGirisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.MaskedTextBox txtNumara;
        private System.Windows.Forms.Label label3;
    }
}