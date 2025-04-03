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
            this.label36 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.numericUpDown_tilt_angle = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_track_angle = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_IntensityOfTheRain = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.numericUpDown_frequency_to = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_frequency_from = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tilt_angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_track_angle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IntensityOfTheRain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frequency_to)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frequency_from)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(13, 141);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(155, 13);
            this.label36.TabIndex = 142;
            this.label36.Text = "по отношению к горизонтали";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(286, 129);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(11, 13);
            this.label30.TabIndex = 141;
            this.label30.Text = "°";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(13, 124);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(170, 13);
            this.label31.TabIndex = 140;
            this.label31.Text = "Угол наклона оси поляризации ";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(286, 98);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(11, 13);
            this.label32.TabIndex = 139;
            this.label32.Text = "°";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(13, 98);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(106, 13);
            this.label33.TabIndex = 138;
            this.label33.Text = "Угол места трассы";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(286, 72);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(33, 13);
            this.label34.TabIndex = 137;
            this.label34.Text = "мм/ч";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(13, 72);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(120, 13);
            this.label35.TabIndex = 136;
            this.label35.Text = "Интенсивность дождя";
            // 
            // numericUpDown_tilt_angle
            // 
            this.numericUpDown_tilt_angle.Location = new System.Drawing.Point(189, 122);
            this.numericUpDown_tilt_angle.Name = "numericUpDown_tilt_angle";
            this.numericUpDown_tilt_angle.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown_tilt_angle.TabIndex = 135;
            this.numericUpDown_tilt_angle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // numericUpDown_track_angle
            // 
            this.numericUpDown_track_angle.Location = new System.Drawing.Point(189, 96);
            this.numericUpDown_track_angle.Name = "numericUpDown_track_angle";
            this.numericUpDown_track_angle.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown_track_angle.TabIndex = 134;
            this.numericUpDown_track_angle.Value = new decimal(new int[] {
            35,
            0,
            0,
            0});
            // 
            // numericUpDown_IntensityOfTheRain
            // 
            this.numericUpDown_IntensityOfTheRain.Location = new System.Drawing.Point(189, 70);
            this.numericUpDown_IntensityOfTheRain.Name = "numericUpDown_IntensityOfTheRain";
            this.numericUpDown_IntensityOfTheRain.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown_IntensityOfTheRain.TabIndex = 133;
            this.numericUpDown_IntensityOfTheRain.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(164, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 132;
            this.label10.Text = "до";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(47, 46);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(18, 13);
            this.label18.TabIndex = 131;
            this.label18.Text = "от";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(201, 24);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(25, 13);
            this.label21.TabIndex = 130;
            this.label21.Text = "ГГц";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(101, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 13);
            this.label22.TabIndex = 129;
            this.label22.Text = "Диапазон частот";
            // 
            // numericUpDown_frequency_to
            // 
            this.numericUpDown_frequency_to.Location = new System.Drawing.Point(189, 44);
            this.numericUpDown_frequency_to.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_frequency_to.Name = "numericUpDown_frequency_to";
            this.numericUpDown_frequency_to.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown_frequency_to.TabIndex = 128;
            this.numericUpDown_frequency_to.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDown_frequency_from
            // 
            this.numericUpDown_frequency_from.Location = new System.Drawing.Point(71, 44);
            this.numericUpDown_frequency_from.Name = "numericUpDown_frequency_from";
            this.numericUpDown_frequency_from.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown_frequency_from.TabIndex = 127;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(495, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(272, 20);
            this.label5.TabIndex = 126;
            this.label5.Text = "Погонное ослабление в дожде";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(403, 35);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(490, 335);
            this.chart1.TabIndex = 125;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 448);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.numericUpDown_tilt_angle);
            this.Controls.Add(this.numericUpDown_track_angle);
            this.Controls.Add(this.numericUpDown_IntensityOfTheRain);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.numericUpDown_frequency_to);
            this.Controls.Add(this.numericUpDown_frequency_from);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tilt_angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_track_angle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_IntensityOfTheRain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frequency_to)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_frequency_from)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.NumericUpDown numericUpDown_tilt_angle;
        private System.Windows.Forms.NumericUpDown numericUpDown_track_angle;
        private System.Windows.Forms.NumericUpDown numericUpDown_IntensityOfTheRain;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.NumericUpDown numericUpDown_frequency_to;
        private System.Windows.Forms.NumericUpDown numericUpDown_frequency_from;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

