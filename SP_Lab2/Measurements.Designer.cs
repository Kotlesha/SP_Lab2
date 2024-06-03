namespace SP_Lab2
{
    partial class Measurements
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Measurements));
            this.label1 = new System.Windows.Forms.Label();
            this.ArraySize = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Threads = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.K = new System.Windows.Forms.NumericUpDown();
            this.Delta_threads = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Delta_K = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.processorCoresCount = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.processorClockSpeed = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Calculate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.timeWithoutMultithreadingThreadPerTime = new System.Windows.Forms.NumericUpDown();
            this.timeWithMultithreadingThreadPerTime = new System.Windows.Forms.NumericUpDown();
            this.timeWithoutMultithreadingKPerTime = new System.Windows.Forms.NumericUpDown();
            this.timeWithMultithreadingKPerTime = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.ArraySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Threads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.K)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delta_threads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delta_K)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processorCoresCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorClockSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeWithoutMultithreadingThreadPerTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeWithMultithreadingThreadPerTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeWithoutMultithreadingKPerTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeWithMultithreadingKPerTime)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество элементов";
            // 
            // ArraySize
            // 
            this.ArraySize.Location = new System.Drawing.Point(18, 36);
            this.ArraySize.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ArraySize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ArraySize.Name = "ArraySize";
            this.ArraySize.Size = new System.Drawing.Size(235, 22);
            this.ArraySize.TabIndex = 1;
            this.ArraySize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ArraySize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество потоков";
            // 
            // Threads
            // 
            this.Threads.Location = new System.Drawing.Point(18, 89);
            this.Threads.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Threads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Threads.Name = "Threads";
            this.Threads.Size = new System.Drawing.Size(235, 22);
            this.Threads.TabIndex = 3;
            this.Threads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Threads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Threads.ValueChanged += new System.EventHandler(this.Threads_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Шаг изменения кол-ва потоков";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Параметр сложности";
            // 
            // K
            // 
            this.K.Location = new System.Drawing.Point(18, 142);
            this.K.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.K.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(235, 22);
            this.K.TabIndex = 6;
            this.K.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.K.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Delta_threads
            // 
            this.Delta_threads.Location = new System.Drawing.Point(18, 196);
            this.Delta_threads.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Delta_threads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Delta_threads.Name = "Delta_threads";
            this.Delta_threads.Size = new System.Drawing.Size(235, 22);
            this.Delta_threads.TabIndex = 7;
            this.Delta_threads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Delta_threads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Delta_threads.ValueChanged += new System.EventHandler(this.Delta_threads_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Шаг изменения сложности";
            // 
            // Delta_K
            // 
            this.Delta_K.Location = new System.Drawing.Point(18, 250);
            this.Delta_K.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.Delta_K.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Delta_K.Name = "Delta_K";
            this.Delta_K.Size = new System.Drawing.Size(235, 22);
            this.Delta_K.TabIndex = 9;
            this.Delta_K.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Delta_K.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Delta_K.ValueChanged += new System.EventHandler(this.Delta_K_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ArraySize);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Threads);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.K);
            this.panel1.Controls.Add(this.Delta_threads);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Delta_K);
            this.panel1.Location = new System.Drawing.Point(12, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 297);
            this.panel1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Основная информация";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.processorCoresCount);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.processorClockSpeed);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(12, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 136);
            this.panel2.TabIndex = 12;
            // 
            // processorCoresCount
            // 
            this.processorCoresCount.Enabled = false;
            this.processorCoresCount.Location = new System.Drawing.Point(18, 93);
            this.processorCoresCount.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.processorCoresCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.processorCoresCount.Name = "processorCoresCount";
            this.processorCoresCount.Size = new System.Drawing.Size(235, 22);
            this.processorCoresCount.TabIndex = 16;
            this.processorCoresCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.processorCoresCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Количество ядер";
            // 
            // processorClockSpeed
            // 
            this.processorClockSpeed.Enabled = false;
            this.processorClockSpeed.Location = new System.Drawing.Point(18, 35);
            this.processorClockSpeed.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.processorClockSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.processorClockSpeed.Name = "processorClockSpeed";
            this.processorClockSpeed.Size = new System.Drawing.Size(235, 22);
            this.processorClockSpeed.TabIndex = 10;
            this.processorClockSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.processorClockSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Тактовая частота(МГц)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 327);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Системная информация";
            // 
            // chart1
            // 
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.Title = "Количество потоков";
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.Title = "Время выполнения(мс)";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(307, 17);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Blue;
            series1.Legend = "Legend1";
            series1.LegendText = "Без многопоточности";
            series1.MarkerSize = 7;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.LegendText = "С многопоточностью";
            series2.MarkerSize = 7;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(362, 435);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.Title = "Параметр сложности K";
            chartArea2.AxisY.MajorGrid.Enabled = false;
            chartArea2.AxisY.Title = "Время выполнения(мс)";
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(698, 17);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series3.Legend = "Legend1";
            series3.LegendText = "Без многопоточности";
            series3.MarkerSize = 7;
            series3.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series3.Name = "Series1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.LegendText = "С многопточностью";
            series4.MarkerSize = 7;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "Series2";
            this.chart2.Series.Add(series3);
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(362, 435);
            this.chart2.TabIndex = 15;
            this.chart2.Text = "chart2";
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(87, 490);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(112, 23);
            this.Calculate.TabIndex = 16;
            this.Calculate.Text = "Рассчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(306, 462);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Время без многопоточности";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 493);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 16);
            this.label11.TabIndex = 19;
            this.label11.Text = "Время с многопоточностью";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(697, 462);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 16);
            this.label12.TabIndex = 21;
            this.label12.Text = "Время без многопоточности";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(697, 493);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(186, 16);
            this.label13.TabIndex = 24;
            this.label13.Text = "Время с многопоточностью";
            // 
            // timeWithoutMultithreadingThreadPerTime
            // 
            this.timeWithoutMultithreadingThreadPerTime.Enabled = false;
            this.timeWithoutMultithreadingThreadPerTime.Location = new System.Drawing.Point(506, 460);
            this.timeWithoutMultithreadingThreadPerTime.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.timeWithoutMultithreadingThreadPerTime.Name = "timeWithoutMultithreadingThreadPerTime";
            this.timeWithoutMultithreadingThreadPerTime.Size = new System.Drawing.Size(163, 22);
            this.timeWithoutMultithreadingThreadPerTime.TabIndex = 25;
            this.timeWithoutMultithreadingThreadPerTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeWithMultithreadingThreadPerTime
            // 
            this.timeWithMultithreadingThreadPerTime.Enabled = false;
            this.timeWithMultithreadingThreadPerTime.Location = new System.Drawing.Point(506, 491);
            this.timeWithMultithreadingThreadPerTime.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.timeWithMultithreadingThreadPerTime.Name = "timeWithMultithreadingThreadPerTime";
            this.timeWithMultithreadingThreadPerTime.Size = new System.Drawing.Size(163, 22);
            this.timeWithMultithreadingThreadPerTime.TabIndex = 29;
            this.timeWithMultithreadingThreadPerTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeWithoutMultithreadingKPerTime
            // 
            this.timeWithoutMultithreadingKPerTime.Enabled = false;
            this.timeWithoutMultithreadingKPerTime.Location = new System.Drawing.Point(897, 460);
            this.timeWithoutMultithreadingKPerTime.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.timeWithoutMultithreadingKPerTime.Name = "timeWithoutMultithreadingKPerTime";
            this.timeWithoutMultithreadingKPerTime.Size = new System.Drawing.Size(163, 22);
            this.timeWithoutMultithreadingKPerTime.TabIndex = 30;
            this.timeWithoutMultithreadingKPerTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timeWithMultithreadingKPerTime
            // 
            this.timeWithMultithreadingKPerTime.Enabled = false;
            this.timeWithMultithreadingKPerTime.Location = new System.Drawing.Point(897, 491);
            this.timeWithMultithreadingKPerTime.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.timeWithMultithreadingKPerTime.Name = "timeWithMultithreadingKPerTime";
            this.timeWithMultithreadingKPerTime.Size = new System.Drawing.Size(163, 22);
            this.timeWithMultithreadingKPerTime.TabIndex = 31;
            this.timeWithMultithreadingKPerTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Measurements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 525);
            this.Controls.Add(this.timeWithMultithreadingKPerTime);
            this.Controls.Add(this.timeWithoutMultithreadingKPerTime);
            this.Controls.Add(this.timeWithMultithreadingThreadPerTime);
            this.Controls.Add(this.timeWithoutMultithreadingThreadPerTime);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Measurements";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Измерения с использованием многопоточности и без неё";
            ((System.ComponentModel.ISupportInitialize)(this.ArraySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Threads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.K)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delta_threads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Delta_K)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.processorCoresCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.processorClockSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeWithoutMultithreadingThreadPerTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeWithMultithreadingThreadPerTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeWithoutMultithreadingKPerTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeWithMultithreadingKPerTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ArraySize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Threads;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown K;
        private System.Windows.Forms.NumericUpDown Delta_threads;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown Delta_K;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown processorCoresCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown processorClockSpeed;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown timeWithoutMultithreadingThreadPerTime;
        private System.Windows.Forms.NumericUpDown timeWithMultithreadingThreadPerTime;
        private System.Windows.Forms.NumericUpDown timeWithoutMultithreadingKPerTime;
        private System.Windows.Forms.NumericUpDown timeWithMultithreadingKPerTime;
    }
}

