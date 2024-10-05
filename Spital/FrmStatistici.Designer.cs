namespace Spital
{
    partial class FrmStatistici
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbObtiune = new System.Windows.Forms.ComboBox();
            this.cbDiagrama = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alegeti optiunea dorita";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Minion Pro", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(529, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(246, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alegeti tip diagrama";
            // 
            // cbObtiune
            // 
            this.cbObtiune.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObtiune.FormattingEnabled = true;
            this.cbObtiune.Location = new System.Drawing.Point(49, 62);
            this.cbObtiune.Name = "cbObtiune";
            this.cbObtiune.Size = new System.Drawing.Size(157, 21);
            this.cbObtiune.TabIndex = 2;
            // 
            // cbDiagrama
            // 
            this.cbDiagrama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiagrama.FormattingEnabled = true;
            this.cbDiagrama.Location = new System.Drawing.Point(590, 62);
            this.cbDiagrama.Name = "cbDiagrama";
            this.cbDiagrama.Size = new System.Drawing.Size(157, 21);
            this.cbDiagrama.TabIndex = 2;
            this.cbDiagrama.SelectedIndexChanged += new System.EventHandler(this.cbDiagrama_SelectedIndexChanged);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(288, 110);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series2.BorderColor = System.Drawing.SystemColors.Control;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.IsVisibleInLegend = false;
            series2.LabelBorderColor = System.Drawing.Color.Transparent;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(526, 359);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(323, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "Vizualizare";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmStatistici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(817, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.cbDiagrama);
            this.Controls.Add(this.cbObtiune);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmStatistici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStatistici";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbObtiune;
        private System.Windows.Forms.ComboBox cbDiagrama;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
    }
}