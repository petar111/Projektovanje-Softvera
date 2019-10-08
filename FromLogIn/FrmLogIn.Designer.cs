namespace FromLogIn
{
    partial class FrmLogIn
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
            this.txtKorsinickoIme = new System.Windows.Forms.TextBox();
            this.lblKorisnickoIme = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKorsinickoIme
            // 
            this.txtKorsinickoIme.Location = new System.Drawing.Point(142, 37);
            this.txtKorsinickoIme.Name = "txtKorsinickoIme";
            this.txtKorsinickoIme.Size = new System.Drawing.Size(100, 20);
            this.txtKorsinickoIme.TabIndex = 0;
            // 
            // lblKorisnickoIme
            // 
            this.lblKorisnickoIme.AutoSize = true;
            this.lblKorisnickoIme.Location = new System.Drawing.Point(14, 37);
            this.lblKorisnickoIme.Name = "lblKorisnickoIme";
            this.lblKorisnickoIme.Size = new System.Drawing.Size(76, 13);
            this.lblKorisnickoIme.TabIndex = 1;
            this.lblKorisnickoIme.Text = "Korisnicko Ime";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLogIn);
            this.panel1.Controls.Add(this.lblPassword);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.lblKorisnickoIme);
            this.panel1.Controls.Add(this.txtKorsinickoIme);
            this.panel1.Location = new System.Drawing.Point(92, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 187);
            this.panel1.TabIndex = 2;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(142, 129);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(100, 23);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "Log in";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(17, 76);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(142, 76);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // FrmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "FrmLogIn";
            this.Text = "Form Log In";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKorsinickoIme;
        private System.Windows.Forms.Label lblKorisnickoIme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogIn;
    }
}

