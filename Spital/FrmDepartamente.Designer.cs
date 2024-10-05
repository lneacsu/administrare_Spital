namespace Spital
{
    partial class FrmDepartamente
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgDepartamente = new System.Windows.Forms.DataGridView();
            this.listViewDepartamente = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.chartDepartamente = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartamente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDepartamente)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDepartamente
            // 
            this.dgDepartamente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDepartamente.Location = new System.Drawing.Point(34, 498);
            this.dgDepartamente.Name = "dgDepartamente";
            this.dgDepartamente.Size = new System.Drawing.Size(842, 165);
            this.dgDepartamente.TabIndex = 0;
            this.dgDepartamente.Visible = false;
            // 
            // listViewDepartamente
            // 
            this.listViewDepartamente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listViewDepartamente.Location = new System.Drawing.Point(34, 98);
            this.listViewDepartamente.Name = "listViewDepartamente";
            this.listViewDepartamente.Size = new System.Drawing.Size(217, 314);
            this.listViewDepartamente.TabIndex = 1;
            this.listViewDepartamente.UseCompatibleStateImageBehavior = false;
            this.listViewDepartamente.SelectedIndexChanged += new System.EventHandler(this.listViewDepartamente_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Minion Pro", 20.25F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(258, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selectati un departament din lista";
            // 
            // chartDepartamente
            // 
            this.chartDepartamente.BackColor = System.Drawing.Color.Transparent;
            this.chartDepartamente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chartDepartamente.BackImageTransparentColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chartDepartamente.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartDepartamente.Legends.Add(legend1);
            this.chartDepartamente.Location = new System.Drawing.Point(381, 89);
            this.chartDepartamente.Name = "chartDepartamente";
            this.chartDepartamente.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.BackImageTransparentColor = System.Drawing.Color.Black;
            series1.BorderColor = System.Drawing.SystemColors.Control;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.White;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            this.chartDepartamente.Series.Add(series1);
            this.chartDepartamente.Size = new System.Drawing.Size(562, 403);
            this.chartDepartamente.TabIndex = 3;
            this.chartDepartamente.Text = "chart1";
            // 
            // FrmDepartamente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(929, 682);
            this.Controls.Add(this.chartDepartamente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewDepartamente);
            this.Controls.Add(this.dgDepartamente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FrmDepartamente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
      
            ((System.ComponentModel.ISupportInitialize)(this.dgDepartamente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDepartamente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDepartamente;
        private System.Windows.Forms.ListView listViewDepartamente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDepartamente;
    }
}