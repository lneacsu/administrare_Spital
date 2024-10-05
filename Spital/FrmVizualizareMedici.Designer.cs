namespace Spital
{
    partial class FrmVizualizareMedici
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCautareMedic = new System.Windows.Forms.TextBox();
            this.lbVizMedici = new System.Windows.Forms.ListView();
            this.cbCategorii = new System.Windows.Forms.ComboBox();
            this.lbCategorie = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro SmBd", 18.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vizualizare Medici";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(433, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cauta:";
            // 
            // tbCautareMedic
            // 
            this.tbCautareMedic.Location = new System.Drawing.Point(485, 32);
            this.tbCautareMedic.Name = "tbCautareMedic";
            this.tbCautareMedic.Size = new System.Drawing.Size(130, 20);
            this.tbCautareMedic.TabIndex = 3;
            this.tbCautareMedic.TextChanged += new System.EventHandler(this.tbCautareMedic_TextChanged);
            // 
            // lbVizMedici
            // 
            this.lbVizMedici.Location = new System.Drawing.Point(32, 81);
            this.lbVizMedici.Name = "lbVizMedici";
            this.lbVizMedici.Size = new System.Drawing.Size(583, 299);
            this.lbVizMedici.TabIndex = 4;
            this.lbVizMedici.UseCompatibleStateImageBehavior = false;
            // 
            // cbCategorii
            // 
            this.cbCategorii.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorii.FormattingEnabled = true;
            this.cbCategorii.Location = new System.Drawing.Point(325, 31);
            this.cbCategorii.Name = "cbCategorii";
            this.cbCategorii.Size = new System.Drawing.Size(90, 21);
            this.cbCategorii.TabIndex = 5;
            
            // 
            // lbCategorie
            // 
            this.lbCategorie.AutoSize = true;
            this.lbCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lbCategorie.Location = new System.Drawing.Point(249, 36);
            this.lbCategorie.Name = "lbCategorie";
            this.lbCategorie.Size = new System.Drawing.Size(70, 16);
            this.lbCategorie.TabIndex = 6;
            this.lbCategorie.Text = "Categorie:";
            // 
            // FrmVizualizareMedici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(646, 403);
            this.Controls.Add(this.lbCategorie);
            this.Controls.Add(this.cbCategorii);
            this.Controls.Add(this.lbVizMedici);
            this.Controls.Add(this.tbCautareMedic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmVizualizareMedici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.FrmVizualizareMedici_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCautareMedic;
        private System.Windows.Forms.ListView lbVizMedici;
        private System.Windows.Forms.ComboBox cbCategorii;
        private System.Windows.Forms.Label lbCategorie;
    }
}