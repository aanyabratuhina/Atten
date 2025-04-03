namespace Project
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_frequency_from = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_IntensityOfTheRain = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_frequency_to = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_track_angle = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_tilt_angle = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.chart_circular = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart_circular)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Диапазон частот";
            // 
            // textBox_frequency_from
            // 
            this.textBox_frequency_from.Location = new System.Drawing.Point(37, 28);
            this.textBox_frequency_from.Name = "textBox_frequency_from";
            this.textBox_frequency_from.Size = new System.Drawing.Size(50, 20);
            this.textBox_frequency_from.TabIndex = 1;
            this.textBox_frequency_from.TextChanged += new System.EventHandler(this.smthChanged);
            this.textBox_frequency_from.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_frequency_from_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ГГц";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "мм/ч";
            // 
            // textBox_IntensityOfTheRain
            // 
            this.textBox_IntensityOfTheRain.Location = new System.Drawing.Point(151, 63);
            this.textBox_IntensityOfTheRain.Name = "textBox_IntensityOfTheRain";
            this.textBox_IntensityOfTheRain.Size = new System.Drawing.Size(100, 20);
            this.textBox_IntensityOfTheRain.TabIndex = 7;
            this.textBox_IntensityOfTheRain.TextChanged += new System.EventHandler(this.smthChanged);
            this.textBox_IntensityOfTheRain.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_IntensityOfTheRain_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Интенсивность дождя";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "от";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(102, 31);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(19, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "до";
            // 
            // textBox_frequency_to
            // 
            this.textBox_frequency_to.Location = new System.Drawing.Point(127, 28);
            this.textBox_frequency_to.Name = "textBox_frequency_to";
            this.textBox_frequency_to.Size = new System.Drawing.Size(50, 20);
            this.textBox_frequency_to.TabIndex = 20;
            this.textBox_frequency_to.TextChanged += new System.EventHandler(this.smthChanged);
            this.textBox_frequency_to.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_frequency_to_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 59);
            this.button1.TabIndex = 22;
            this.button1.Text = "расчитать круговую поляризацию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(269, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "°";
            // 
            // textBox_track_angle
            // 
            this.textBox_track_angle.Location = new System.Drawing.Point(151, 89);
            this.textBox_track_angle.Name = "textBox_track_angle";
            this.textBox_track_angle.Size = new System.Drawing.Size(100, 20);
            this.textBox_track_angle.TabIndex = 24;
            this.textBox_track_angle.TextChanged += new System.EventHandler(this.smthChanged);
            this.textBox_track_angle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_track_angle_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(15, 92);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 13);
            this.label14.TabIndex = 23;
            this.label14.Text = "Угол места трассы";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(269, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "°";
            // 
            // textBox_tilt_angle
            // 
            this.textBox_tilt_angle.Location = new System.Drawing.Point(151, 128);
            this.textBox_tilt_angle.Name = "textBox_tilt_angle";
            this.textBox_tilt_angle.Size = new System.Drawing.Size(100, 20);
            this.textBox_tilt_angle.TabIndex = 27;
            this.textBox_tilt_angle.TextChanged += new System.EventHandler(this.smthChanged);
            this.textBox_tilt_angle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_tilt_angle_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 112);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(318, 13);
            this.label16.TabIndex = 26;
            this.label16.Text = "Угол наклона оси поляризации по отношению к горизонтали";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(749, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(272, 20);
            this.label17.TabIndex = 33;
            this.label17.Text = "Погонное ослабление в дожде";
            // 
            // chart_circular
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_circular.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_circular.Legends.Add(legend1);
            this.chart_circular.Location = new System.Drawing.Point(420, 28);
            this.chart_circular.Name = "chart_circular";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_circular.Series.Add(series1);
            this.chart_circular.Size = new System.Drawing.Size(1024, 789);
            this.chart_circular.TabIndex = 29;
            this.chart_circular.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.chart_circular);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox_tilt_angle);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.textBox_track_angle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_frequency_to);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_IntensityOfTheRain);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_frequency_from);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart_circular)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_frequency_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_IntensityOfTheRain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_frequency_to;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_track_angle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_tilt_angle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_circular;
    }
}

