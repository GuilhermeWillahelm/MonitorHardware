namespace MonitorHardware
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.pRam = new System.Diagnostics.PerformanceCounter();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarCpu = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressBarRam = new MetroFramework.Controls.MetroProgressBar();
            this.lblCpu = new MetroFramework.Controls.MetroLabel();
            this.lblRam = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // pRam
            // 
            this.pRam.CategoryName = "Memory";
            this.pRam.CounterName = "% Committed Bytes In Use";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(32, 94);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(35, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "CPU";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(32, 137);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "RAM";
            // 
            // metroProgressBarCpu
            // 
            this.metroProgressBarCpu.Location = new System.Drawing.Point(73, 90);
            this.metroProgressBarCpu.Name = "metroProgressBarCpu";
            this.metroProgressBarCpu.Size = new System.Drawing.Size(371, 23);
            this.metroProgressBarCpu.TabIndex = 2;
            // 
            // metroProgressBarRam
            // 
            this.metroProgressBarRam.Location = new System.Drawing.Point(73, 133);
            this.metroProgressBarRam.Name = "metroProgressBarRam";
            this.metroProgressBarRam.Size = new System.Drawing.Size(371, 23);
            this.metroProgressBarRam.TabIndex = 3;
            // 
            // lblCpu
            // 
            this.lblCpu.AutoSize = true;
            this.lblCpu.Location = new System.Drawing.Point(460, 94);
            this.lblCpu.Name = "lblCpu";
            this.lblCpu.Size = new System.Drawing.Size(31, 19);
            this.lblCpu.TabIndex = 4;
            this.lblCpu.Text = "0 %";
            // 
            // lblRam
            // 
            this.lblRam.AutoSize = true;
            this.lblRam.Location = new System.Drawing.Point(460, 137);
            this.lblRam.Name = "lblRam";
            this.lblRam.Size = new System.Drawing.Size(31, 19);
            this.lblRam.TabIndex = 5;
            this.lblRam.Text = "0 %";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(73, 195);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(371, 212);
            this.chart1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(553, 439);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.lblCpu);
            this.Controls.Add(this.metroProgressBarRam);
            this.Controls.Add(this.metroProgressBarCpu);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Form1";
            this.Text = "CPU AND RAM";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Diagnostics.PerformanceCounter pRam;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarCpu;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarRam;
        private MetroFramework.Controls.MetroLabel lblCpu;
        private MetroFramework.Controls.MetroLabel lblRam;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

