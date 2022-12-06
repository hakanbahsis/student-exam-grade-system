namespace WindowsFormsApp.Formlar
{
    partial class FrmOkulGiris
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
            this.btnAkademisyenGiris = new System.Windows.Forms.Button();
            this.btnOgrenciGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 46);
            this.label2.TabIndex = 29;
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
            this.button1.Location = new System.Drawing.Point(246, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 36);
            this.button1.TabIndex = 28;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAkademisyenGiris
            // 
            this.btnAkademisyenGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.btnAkademisyenGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAkademisyenGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAkademisyenGiris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAkademisyenGiris.ForeColor = System.Drawing.Color.White;
            this.btnAkademisyenGiris.Location = new System.Drawing.Point(21, 85);
            this.btnAkademisyenGiris.Margin = new System.Windows.Forms.Padding(4);
            this.btnAkademisyenGiris.Name = "btnAkademisyenGiris";
            this.btnAkademisyenGiris.Size = new System.Drawing.Size(253, 37);
            this.btnAkademisyenGiris.TabIndex = 25;
            this.btnAkademisyenGiris.Text = "Akademisyen Girişi";
            this.btnAkademisyenGiris.UseVisualStyleBackColor = false;
            this.btnAkademisyenGiris.Click += new System.EventHandler(this.btnAkademisyenGiris_Click);
            // 
            // btnOgrenciGiris
            // 
            this.btnOgrenciGiris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(177)))), ((int)(((byte)(140)))));
            this.btnOgrenciGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOgrenciGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenciGiris.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnOgrenciGiris.ForeColor = System.Drawing.Color.White;
            this.btnOgrenciGiris.Location = new System.Drawing.Point(21, 130);
            this.btnOgrenciGiris.Margin = new System.Windows.Forms.Padding(4);
            this.btnOgrenciGiris.Name = "btnOgrenciGiris";
            this.btnOgrenciGiris.Size = new System.Drawing.Size(253, 37);
            this.btnOgrenciGiris.TabIndex = 25;
            this.btnOgrenciGiris.Text = "Öğrenci Girişi";
            this.btnOgrenciGiris.UseVisualStyleBackColor = false;
            this.btnOgrenciGiris.Click += new System.EventHandler(this.btnOgrenciGiris_Click);
            // 
            // FrmOkulGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(51)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(289, 185);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOgrenciGiris);
            this.Controls.Add(this.btnAkademisyenGiris);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmOkulGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOkulGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAkademisyenGiris;
        private System.Windows.Forms.Button btnOgrenciGiris;
    }
}