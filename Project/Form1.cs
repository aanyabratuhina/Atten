using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Collections;
using System.Xml;

namespace Project
{
    public partial class Form1 : Form
    {
        private readonly FullRainCalc calculator = new FullRainCalc();
        public Form1()
        {
            InitializeComponent();
            try
            {
                FullRainCalc.LoadGridData("h0.txt", "Lat.txt", "Lon.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        private void Culc(object sender, EventArgs e)
        {

            chart1.Series[0].Points.Clear();

            chart1.ChartAreas[0].AxisX.Title = "Частота f, ГГц"; // Подпись для оси X
            chart1.ChartAreas[0].AxisY.Title = "Ослабление А, дБ"; // Подпись для оси Y

            double f_from = Convert.ToDouble(numericUpDown_frequency_from.Text.Replace(".", ","));
            double f_to = Convert.ToDouble(numericUpDown_frequency_to.Text.Replace(".", ","));
            double R = Convert.ToDouble(numericUpDown_IntensityOfTheRain.Text.Replace(".", ","));
            double track_angle = Convert.ToDouble(numericUpDown_track_angle.Text.Replace(".", ",")) * (Math.PI / 180);
            double tilt_angle = Convert.ToDouble(numericUpDown_tilt_angle.Text.Replace(".", ",")) * (Math.PI / 180);

            List <double> values_R = new List<double> { 5, 30, 50 , 100};

            List<double> values_Tit = new List<double> { 0, 45, 90 };
            chart1.ChartAreas[0].AxisX.Minimum = f_from;
            chart1.ChartAreas[0].AxisX.Maximum = f_to;
        
            if (!double.TryParse(txtLat.Text, out double lat) ||
            !double.TryParse(txtLon.Text, out double lon) ||
            lat < -90 || lat > 90 || lon < 0 || lon > 360)
            {
                MessageBox.Show("Некорректные координаты!\nШирота: -90...90\nДолгота: 0...360");
                return;
            }

            try
            {
                var result = FullRainCalc.CalculateRainHeight(lat, lon);
               lblHR.Text = $"{result.hR:F3} км";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка расчёта: {ex.Message}");
            }

            label8.Text = $"{(Math.Round(FullRainCalc.CalculateEffectivePathLength(track_angle, lat, lon), 3).ToString())} км";

            for (double h = f_from; h <= f_to; h++)
            {
                double osl = RainCalc.Attenuation(h, track_angle, tilt_angle, R);

                double FulOSl = FullRainCalc.CalculateFulAtten(osl, track_angle, lat, lon, R);
                chart1.Series[0].Points.AddXY(h, FulOSl);

            }
           



        }

    }
}
