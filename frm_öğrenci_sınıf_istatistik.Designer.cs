
namespace dershaneOtomasyon
{
    partial class frm_öğrenci_sınıf_istatistik
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblogr = new System.Windows.Forms.Label();
            this.lblsinif = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GÜNCEL ÖĞRENCİ SAYISI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "GÜNCEL SINIF SAYISI :";
            // 
            // lblogr
            // 
            this.lblogr.AutoSize = true;
            this.lblogr.Location = new System.Drawing.Point(225, 46);
            this.lblogr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblogr.Name = "lblogr";
            this.lblogr.Size = new System.Drawing.Size(32, 13);
            this.lblogr.TabIndex = 2;
            this.lblogr.Text = "lblogr";
            // 
            // lblsinif
            // 
            this.lblsinif.AutoSize = true;
            this.lblsinif.Location = new System.Drawing.Point(225, 96);
            this.lblsinif.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsinif.Name = "lblsinif";
            this.lblsinif.Size = new System.Drawing.Size(35, 13);
            this.lblsinif.TabIndex = 3;
            this.lblsinif.Text = "label4";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(61, 187);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "SAY";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(399, 244);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // frm_öğrenci_sınıf_istatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 480);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblsinif);
            this.Controls.Add(this.lblogr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_öğrenci_sınıf_istatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci / Sınıf İstatistik";
            this.Load += new System.EventHandler(this.frm_öğrenci_sınıf_istatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblogr;
        private System.Windows.Forms.Label lblsinif;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}