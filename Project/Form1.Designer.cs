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
            this.txtLat = new System.Windows.Forms.TextBox();
            this.txtLon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHR = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.numericUpDown_tilt_angle.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDown_tilt_angle.Name = "numericUpDown_tilt_angle";
            this.numericUpDown_tilt_angle.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown_tilt_angle.TabIndex = 135;
            this.numericUpDown_tilt_angle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.numericUpDown_tilt_angle.ValueChanged += new System.EventHandler(this.Culc);
            // 
            // numericUpDown_track_angle
            // 
            this.numericUpDown_track_angle.Location = new System.Drawing.Point(189, 96);
            this.numericUpDown_track_angle.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDown_track_angle.Name = "numericUpDown_track_angle";
            this.numericUpDown_track_angle.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown_track_angle.TabIndex = 134;
            this.numericUpDown_track_angle.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_track_angle.ValueChanged += new System.EventHandler(this.Culc);
            // 
            // numericUpDown_IntensityOfTheRain
            // 
            this.numericUpDown_IntensityOfTheRain.DecimalPlaces = 2;
            this.numericUpDown_IntensityOfTheRain.Location = new System.Drawing.Point(189, 70);
            this.numericUpDown_IntensityOfTheRain.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDown_IntensityOfTheRain.Name = "numericUpDown_IntensityOfTheRain";
            this.numericUpDown_IntensityOfTheRain.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown_IntensityOfTheRain.TabIndex = 133;
            this.numericUpDown_IntensityOfTheRain.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_IntensityOfTheRain.ValueChanged += new System.EventHandler(this.Culc);
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
            1000,
            0,
            0,
            0});
            this.numericUpDown_frequency_to.ValueChanged += new System.EventHandler(this.Culc);
            // 
            // numericUpDown_frequency_from
            // 
            this.numericUpDown_frequency_from.Location = new System.Drawing.Point(71, 44);
            this.numericUpDown_frequency_from.Name = "numericUpDown_frequency_from";
            this.numericUpDown_frequency_from.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown_frequency_from.TabIndex = 127;
            this.numericUpDown_frequency_from.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_frequency_from.ValueChanged += new System.EventHandler(this.Culc);
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(68, 177);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(100, 20);
            this.txtLat.TabIndex = 143;
            this.txtLat.Text = "47";
            this.txtLat.TextChanged += new System.EventHandler(this.Culc);
            // 
            // txtLon
            // 
            this.txtLon.Location = new System.Drawing.Point(68, 206);
            this.txtLon.Name = "txtLon";
            this.txtLon.Size = new System.Drawing.Size(100, 20);
            this.txtLon.TabIndex = 144;
            this.txtLon.Text = "39";
            this.txtLon.TextChanged += new System.EventHandler(this.Culc);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 145;
            this.label1.Text = "Широта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 146;
            this.label2.Text = "Долгота";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 151;
            this.label3.Text = "Высота дождевого слоя ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(574, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 20);
            this.label6.TabIndex = 155;
            this.label6.Text = "Полное ослабление в дожде";
            // 
            // lblHR
            // 
            this.lblHR.AutoSize = true;
            this.lblHR.Location = new System.Drawing.Point(160, 244);
            this.lblHR.Name = "lblHR";
            this.lblHR.Size = new System.Drawing.Size(35, 13);
            this.lblHR.TabIndex = 156;
            this.lblHR.Text = "label4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(160, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 162;
            this.label8.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 164;
            this.label4.Text = "Эффективная длина пути";
            // 
            // chart1
            // 
            chartArea1.AxisX.IsLogarithmic = true;
            chartArea1.AxisY.IsLogarithmic = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(384, 44);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "А, дБ";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(645, 467);
            this.chart1.TabIndex = 163;
            this.chart1.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1689, 798);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblHR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLon);
            this.Controls.Add(this.txtLat);
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
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Culc);
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
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.TextBox txtLon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

