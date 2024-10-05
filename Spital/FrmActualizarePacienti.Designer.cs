namespace Spital
{
    partial class FrmActualizarePacienti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActualizarePacienti));
            this.label1 = new System.Windows.Forms.Label();
            this.cbCNP = new System.Windows.Forms.ComboBox();
            this.dgPacienti = new System.Windows.Forms.DataGridView();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnAnulareMod = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDateContact = new System.Windows.Forms.DataGridView();
            this.btnDateContact = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdPacienti = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDateContact)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro Med", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))));
            this.label1.Location = new System.Drawing.Point(241, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduceti CNP:";
            // 
            // cbCNP
            // 
            this.cbCNP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbCNP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCNP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCNP.FormattingEnabled = true;
            this.cbCNP.Location = new System.Drawing.Point(208, 58);
            this.cbCNP.Name = "cbCNP";
            this.cbCNP.Size = new System.Drawing.Size(293, 33);
            this.cbCNP.TabIndex = 1;
            this.cbCNP.SelectedIndexChanged += new System.EventHandler(this.cbCNP_SelectedIndexChanged);
            // 
            // dgPacienti
            // 
            this.dgPacienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPacienti.Location = new System.Drawing.Point(30, 120);
            this.dgPacienti.Name = "dgPacienti";
            this.dgPacienti.Size = new System.Drawing.Size(654, 78);
            this.dgPacienti.TabIndex = 2;
            this.dgPacienti.Visible = false;
            this.dgPacienti.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPacienti_CellContentClick);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSalvare.Location = new System.Drawing.Point(568, 418);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(125, 42);
            this.btnSalvare.TabIndex = 3;
            this.btnSalvare.Text = "Salvare Modificari";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnAnulareMod
            // 
            this.btnAnulareMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAnulareMod.Location = new System.Drawing.Point(30, 418);
            this.btnAnulareMod.Name = "btnAnulareMod";
            this.btnAnulareMod.Size = new System.Drawing.Size(104, 38);
            this.btnAnulareMod.TabIndex = 4;
            this.btnAnulareMod.Text = "Anulare";
            this.btnAnulareMod.UseVisualStyleBackColor = true;
            this.btnAnulareMod.Click += new System.EventHandler(this.btnAnulareMod_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "DATE CONTACT";
            // 
            // dgvDateContact
            // 
            this.dgvDateContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDateContact.Location = new System.Drawing.Point(30, 264);
            this.dgvDateContact.Name = "dgvDateContact";
            this.dgvDateContact.Size = new System.Drawing.Size(512, 129);
            this.dgvDateContact.TabIndex = 6;
            this.dgvDateContact.Visible = false;
            // 
            // btnDateContact
            // 
            this.btnDateContact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDateContact.BackgroundImage")));
            this.btnDateContact.Location = new System.Drawing.Point(206, 220);
            this.btnDateContact.Name = "btnDateContact";
            this.btnDateContact.Size = new System.Drawing.Size(42, 38);
            this.btnDateContact.TabIndex = 7;
            this.btnDateContact.UseVisualStyleBackColor = true;
            this.btnDateContact.Click += new System.EventHandler(this.btnDateContact_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(27, 471);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(253, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "*Doar campurile colorate pot fi modificate";
            // 
            // btnAdPacienti
            // 
            this.btnAdPacienti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdPacienti.Location = new System.Drawing.Point(568, 356);
            this.btnAdPacienti.Name = "btnAdPacienti";
            this.btnAdPacienti.Size = new System.Drawing.Size(125, 37);
            this.btnAdPacienti.TabIndex = 10;
            this.btnAdPacienti.Text = "Adaugare Pacienti";
            this.btnAdPacienti.UseVisualStyleBackColor = true;
            this.btnAdPacienti.Click += new System.EventHandler(this.btnAdPacienti_Click);
            // 
            // FrmActualizarePacienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(716, 496);
            this.Controls.Add(this.btnAdPacienti);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDateContact);
            this.Controls.Add(this.dgvDateContact);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAnulareMod);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.dgPacienti);
            this.Controls.Add(this.cbCNP);
            this.Controls.Add(this.label1);
            this.Name = "FrmActualizarePacienti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmActualizarePacienti";
            ((System.ComponentModel.ISupportInitialize)(this.dgPacienti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDateContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCNP;
        private System.Windows.Forms.DataGridView dgPacienti;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnAnulareMod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDateContact;
        private System.Windows.Forms.Button btnDateContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdPacienti;
    }
}