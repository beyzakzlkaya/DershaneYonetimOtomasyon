
namespace dershaneOtomasyon
{
    partial class frm_öğretmen_ders_istatistik
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
            this.lblogretmen = new System.Windows.Forms.Label();
            this.lblders = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "GÜNCEL ÖĞRETMEN SAYISI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "AKTİF DERS SAYISI :";
            // 
            // lblogretmen
            // 
            this.lblogretmen.AutoSize = true;
            this.lblogretmen.Location = new System.Drawing.Point(200, 42);
            this.lblogretmen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblogretmen.Name = "lblogretmen";
            this.lblogretmen.Size = new System.Drawing.Size(13, 13);
            this.lblogretmen.TabIndex = 2;
            this.lblogretmen.Text = "0";
            // 
            // lblders
            // 
            this.lblders.AutoSize = true;
            this.lblders.Location = new System.Drawing.Point(200, 84);
            this.lblders.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblders.Name = "lblders";
            this.lblders.Size = new System.Drawing.Size(13, 13);
            this.lblders.TabIndex = 3;
            this.lblders.Text = "0";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(52, 158);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "AKTİF KAYIT";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(412, 245);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // frm_öğretmen_ders_istatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 436);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblders);
            this.Controls.Add(this.lblogretmen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_öğretmen_ders_istatistik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÖĞRETMEN/ DERS İSTATİSTİK";
            this.Load += new System.EventHandler(this.frm_öğretmen_ders_istatistik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblogretmen;
        private System.Windows.Forms.Label lblders;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}