namespace FromLogIn
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.proizvodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uslugeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblPrijavljeniKorisnik = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proizvodToolStripMenuItem,
            this.uslugeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // proizvodToolStripMenuItem
            // 
            this.proizvodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosProizvodaToolStripMenuItem,
            this.pretragaProizvodaToolStripMenuItem});
            this.proizvodToolStripMenuItem.Name = "proizvodToolStripMenuItem";
            this.proizvodToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.proizvodToolStripMenuItem.Text = "Proizvod";
            // 
            // unosProizvodaToolStripMenuItem
            // 
            this.unosProizvodaToolStripMenuItem.Name = "unosProizvodaToolStripMenuItem";
            this.unosProizvodaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.unosProizvodaToolStripMenuItem.Text = "Unos proizvoda";
            this.unosProizvodaToolStripMenuItem.Click += new System.EventHandler(this.unosProizvodaToolStripMenuItem_Click);
            // 
            // pretragaProizvodaToolStripMenuItem
            // 
            this.pretragaProizvodaToolStripMenuItem.Name = "pretragaProizvodaToolStripMenuItem";
            this.pretragaProizvodaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pretragaProizvodaToolStripMenuItem.Text = "Pretraga proizvoda";
            // 
            // uslugeToolStripMenuItem
            // 
            this.uslugeToolStripMenuItem.Name = "uslugeToolStripMenuItem";
            this.uslugeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.uslugeToolStripMenuItem.Text = "Usluge";
            // 
            // lblPrijavljeniKorisnik
            // 
            this.lblPrijavljeniKorisnik.AutoSize = true;
            this.lblPrijavljeniKorisnik.Location = new System.Drawing.Point(552, 394);
            this.lblPrijavljeniKorisnik.Name = "lblPrijavljeniKorisnik";
            this.lblPrijavljeniKorisnik.Size = new System.Drawing.Size(31, 13);
            this.lblPrijavljeniKorisnik.TabIndex = 1;
            this.lblPrijavljeniKorisnik.Text = "Yaya";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPrijavljeniKorisnik);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Main Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem proizvodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosProizvodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pretragaProizvodaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uslugeToolStripMenuItem;
        private System.Windows.Forms.Label lblPrijavljeniKorisnik;
    }
}