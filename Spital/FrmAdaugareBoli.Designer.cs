namespace Spital
{
    partial class FrmAdaugareBoli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdaugareBoli));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdaugareBoli = new System.Windows.Forms.Button();
            this.tbCodBoala = new System.Windows.Forms.TextBox();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.tbDurataInternare = new System.Windows.Forms.TextBox();
            this.listViewBoli = new System.Windows.Forms.ListView();
            this.btbRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(105, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "COD BOALA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(105, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "DENUMIRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "DURATA MEDIE INTERNARE";
            // 
            // btnAdaugareBoli
            // 
            this.btnAdaugareBoli.BackColor = System.Drawing.Color.White;
            this.btnAdaugareBoli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAdaugareBoli.Location = new System.Drawing.Point(167, 334);
            this.btnAdaugareBoli.Name = "btnAdaugareBoli";
            this.btnAdaugareBoli.Size = new System.Drawing.Size(111, 45);
            this.btnAdaugareBoli.TabIndex = 1;
            this.btnAdaugareBoli.Text = "ADAUGARE";
            this.btnAdaugareBoli.UseVisualStyleBackColor = false;
            this.btnAdaugareBoli.Click += new System.EventHandler(this.btnAdaugareBoli_Click);
            // 
            // tbCodBoala
            // 
            this.tbCodBoala.BackColor = System.Drawing.Color.White;
            this.tbCodBoala.ForeColor = System.Drawing.Color.Gray;
            this.tbCodBoala.Location = new System.Drawing.Point(224, 66);
            this.tbCodBoala.Name = "tbCodBoala";
            this.tbCodBoala.Size = new System.Drawing.Size(133, 20);
            this.tbCodBoala.TabIndex = 2;
            this.tbCodBoala.Text = "B*";
            this.tbCodBoala.Enter += new System.EventHandler(this.tbCodBoala_Enter);
            this.tbCodBoala.Leave += new System.EventHandler(this.tbCodBoala_Leave);
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(224, 151);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(133, 20);
            this.tbDenumire.TabIndex = 2;
            // 
            // tbDurataInternare
            // 
            this.tbDurataInternare.Location = new System.Drawing.Point(248, 235);
            this.tbDurataInternare.Name = "tbDurataInternare";
            this.tbDurataInternare.Size = new System.Drawing.Size(109, 20);
            this.tbDurataInternare.TabIndex = 2;
            // 
            // listViewBoli
            // 
            this.listViewBoli.Font = new System.Drawing.Font("Verdana", 9F);
            this.listViewBoli.GridLines = true;
            this.listViewBoli.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewBoli.Location = new System.Drawing.Point(417, 65);
            this.listViewBoli.Name = "listViewBoli";
            this.listViewBoli.Size = new System.Drawing.Size(244, 346);
            this.listViewBoli.TabIndex = 3;
            this.listViewBoli.UseCompatibleStateImageBehavior = false;
          
            // btbRefresh
            // 
            this.btbRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btbRefresh.BackgroundImage")));
            this.btbRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btbRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btbRefresh.Location = new System.Drawing.Point(511, 437);
            this.btbRefresh.Name = "btbRefresh";
            this.btbRefresh.Size = new System.Drawing.Size(56, 53);
            this.btbRefresh.TabIndex = 4;
            this.btbRefresh.UseVisualStyleBackColor = true;
            this.btbRefresh.Click += new System.EventHandler(this.btbRefresh_Click);
            // 
            // FrmAdaugareBoli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Spital.Properties.Resources.shutterstock_131191718v2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(691, 521);
            this.Controls.Add(this.btbRefresh);
            this.Controls.Add(this.listViewBoli);
            this.Controls.Add(this.tbDurataInternare);
            this.Controls.Add(this.tbDenumire);
            this.Controls.Add(this.tbCodBoala);
            this.Controls.Add(this.btnAdaugareBoli);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAdaugareBoli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdaugareBoli;
        private System.Windows.Forms.TextBox tbCodBoala;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.TextBox tbDurataInternare;
        private System.Windows.Forms.ListView listViewBoli;
        private System.Windows.Forms.Button btbRefresh;
    }
}