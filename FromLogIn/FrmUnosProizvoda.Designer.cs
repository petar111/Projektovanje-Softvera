namespace FromLogIn
{
    partial class FrmUnosProizvoda
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
            this.cboxProizvodjaci = new System.Windows.Forms.ComboBox();
            this.lblProizvodjaci = new System.Windows.Forms.Label();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.lblCena = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboxProizvodjaci
            // 
            this.cboxProizvodjaci.DropDownWidth = 128;
            this.cboxProizvodjaci.FormattingEnabled = true;
            this.cboxProizvodjaci.Location = new System.Drawing.Point(111, 291);
            this.cboxProizvodjaci.Name = "cboxProizvodjaci";
            this.cboxProizvodjaci.Size = new System.Drawing.Size(128, 21);
            this.cboxProizvodjaci.TabIndex = 0;
            // 
            // lblProizvodjaci
            // 
            this.lblProizvodjaci.AutoSize = true;
            this.lblProizvodjaci.Location = new System.Drawing.Point(13, 294);
            this.lblProizvodjaci.Name = "lblProizvodjaci";
            this.lblProizvodjaci.Size = new System.Drawing.Size(65, 13);
            this.lblProizvodjaci.TabIndex = 1;
            this.lblProizvodjaci.Text = "Proizvodjac:";
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(111, 235);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(128, 20);
            this.txtCena.TabIndex = 2;
            // 
            // lblCena
            // 
            this.lblCena.AutoSize = true;
            this.lblCena.Location = new System.Drawing.Point(13, 238);
            this.lblCena.Name = "lblCena";
            this.lblCena.Size = new System.Drawing.Size(35, 13);
            this.lblCena.TabIndex = 3;
            this.lblCena.Text = "Cena:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(13, 192);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(37, 13);
            this.lblNaziv.TabIndex = 4;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(13, 152);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(21, 13);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID:";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(111, 184);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(128, 20);
            this.txtNaziv.TabIndex = 6;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(111, 144);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(128, 20);
            this.txtID.TabIndex = 7;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(298, 364);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(75, 23);
            this.btnSacuvaj.TabIndex = 8;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // FrmUnosProizvoda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblNaziv);
            this.Controls.Add(this.lblCena);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.lblProizvodjaci);
            this.Controls.Add(this.cboxProizvodjaci);
            this.Name = "FrmUnosProizvoda";
            this.Text = "FrmUnosProizvoda";
            this.Load += new System.EventHandler(this.FrmUnosProizvoda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboxProizvodjaci;
        private System.Windows.Forms.Label lblProizvodjaci;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.Label lblCena;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSacuvaj;
    }
}