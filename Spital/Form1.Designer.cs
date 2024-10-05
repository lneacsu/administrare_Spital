namespace Spital
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mediciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareMedici = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizareMedici = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualizareInformatiiPacienti = new System.Windows.Forms.ToolStripMenuItem();
            this.boliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareBoli = new System.Windows.Forms.ToolStripMenuItem();
            this.departamenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediciToolStripMenuItem,
            this.pacientiToolStripMenuItem,
            this.boliToolStripMenuItem,
            this.departamenteToolStripMenuItem,
            this.statisticiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 29);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mediciToolStripMenuItem
            // 
            this.mediciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualizareMedici,
            this.actualizareMedici});
            this.mediciToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mediciToolStripMenuItem.Name = "mediciToolStripMenuItem";
            this.mediciToolStripMenuItem.Size = new System.Drawing.Size(68, 25);
            this.mediciToolStripMenuItem.Text = "Medici";
            // 
            // vizualizareMedici
            // 
            this.vizualizareMedici.Name = "vizualizareMedici";
            this.vizualizareMedici.Size = new System.Drawing.Size(156, 26);
            this.vizualizareMedici.Text = "Vizualizare";
            this.vizualizareMedici.Click += new System.EventHandler(this.vizualizareMedici_Click);
            // 
            // actualizareMedici
            // 
            this.actualizareMedici.Name = "actualizareMedici";
            this.actualizareMedici.Size = new System.Drawing.Size(156, 26);
            this.actualizareMedici.Text = "Actualizare";
            this.actualizareMedici.Click += new System.EventHandler(this.actualizareMedici_Click);
            // 
            // pacientiToolStripMenuItem
            // 
            this.pacientiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actualizareInformatiiPacienti});
            this.pacientiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.pacientiToolStripMenuItem.Name = "pacientiToolStripMenuItem";
            this.pacientiToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.pacientiToolStripMenuItem.Text = "Pacienti";
            // 
            // actualizareInformatiiPacienti
            // 
            this.actualizareInformatiiPacienti.Name = "actualizareInformatiiPacienti";
            this.actualizareInformatiiPacienti.Size = new System.Drawing.Size(228, 26);
            this.actualizareInformatiiPacienti.Text = "Actualizare Informatii";
            this.actualizareInformatiiPacienti.Click += new System.EventHandler(this.actualizareInformatiiPacienti_Click);
            // 
            // boliToolStripMenuItem
            // 
            this.boliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareBoli});
            this.boliToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.boliToolStripMenuItem.Name = "boliToolStripMenuItem";
            this.boliToolStripMenuItem.Size = new System.Drawing.Size(48, 25);
            this.boliToolStripMenuItem.Text = "Boli";
            this.boliToolStripMenuItem.Click += new System.EventHandler(this.boliToolStripMenuItem_Click);
            // 
            // adaugareBoli
            // 
            this.adaugareBoli.Name = "adaugareBoli";
            this.adaugareBoli.Size = new System.Drawing.Size(147, 26);
            this.adaugareBoli.Text = "Adaugare";
            this.adaugareBoli.Click += new System.EventHandler(this.adaugareBoli_Click);
            // 
            // departamenteToolStripMenuItem
            // 
            this.departamenteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.departamenteToolStripMenuItem.Name = "departamenteToolStripMenuItem";
            this.departamenteToolStripMenuItem.Size = new System.Drawing.Size(121, 25);
            this.departamenteToolStripMenuItem.Text = "Departamente";
            this.departamenteToolStripMenuItem.Click += new System.EventHandler(this.departamenteToolStripMenuItem_Click);
            // 
            // statisticiToolStripMenuItem
            // 
            this.statisticiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statisticiToolStripMenuItem.Name = "statisticiToolStripMenuItem";
            this.statisticiToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            this.statisticiToolStripMenuItem.Text = "Statistici";
            this.statisticiToolStripMenuItem.Click += new System.EventHandler(this.statisticiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Spital.Properties.Resources.interior_spital_4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1200, 480);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mediciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareMedici;
        private System.Windows.Forms.ToolStripMenuItem actualizareMedici;
        private System.Windows.Forms.ToolStripMenuItem pacientiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualizareInformatiiPacienti;
        private System.Windows.Forms.ToolStripMenuItem boliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareBoli;
        private System.Windows.Forms.ToolStripMenuItem departamenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticiToolStripMenuItem;
    }
}

