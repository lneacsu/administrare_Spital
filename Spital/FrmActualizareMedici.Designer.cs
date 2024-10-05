namespace Spital
{
    partial class FrmActualizareMedici
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgMedici = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnAnulare = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCautare = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgMedici)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMedici
            // 
            this.dgMedici.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgMedici.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgMedici.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgMedici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMedici.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgMedici.EnableHeadersVisualStyles = false;
            this.dgMedici.Location = new System.Drawing.Point(13, 130);
            this.dgMedici.Margin = new System.Windows.Forms.Padding(4);
            this.dgMedici.Name = "dgMedici";
            this.dgMedici.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgMedici.RowTemplate.Height = 25;
            this.dgMedici.Size = new System.Drawing.Size(537, 400);
            this.dgMedici.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 126);
            this.label1.TabIndex = 1;
            this.label1.Text = "- Actualizare Informatii Medici -";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(389, 79);
            this.btnSalvare.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(154, 37);
            this.btnSalvare.TabIndex = 2;
            this.btnSalvare.Text = "Salvare Modificari";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnAnulare
            // 
            this.btnAnulare.Location = new System.Drawing.Point(22, 79);
            this.btnAnulare.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnulare.Name = "btnAnulare";
            this.btnAnulare.Size = new System.Drawing.Size(124, 37);
            this.btnAnulare.TabIndex = 3;
            this.btnAnulare.Text = "Anulare";
            this.btnAnulare.UseVisualStyleBackColor = true;
            this.btnAnulare.Click += new System.EventHandler(this.btnAnulare_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cauta:";
            // 
            // tbCautare
            // 
            this.tbCautare.Location = new System.Drawing.Point(247, 85);
            this.tbCautare.Margin = new System.Windows.Forms.Padding(4);
            this.tbCautare.Name = "tbCautare";
            this.tbCautare.Size = new System.Drawing.Size(91, 26);
            this.tbCautare.TabIndex = 5;
            this.tbCautare.TextChanged += new System.EventHandler(this.tbCautare_TextChanged);
            // 
            // FrmActualizareMedici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(556, 536);
            this.Controls.Add(this.tbCautare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAnulare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgMedici);
            this.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmActualizareMedici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmActualizareMedici";       
            ((System.ComponentModel.ISupportInitialize)(this.dgMedici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgMedici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnAnulare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCautare;
    }
}