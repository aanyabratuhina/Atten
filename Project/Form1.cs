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
        public Form1()
        {
            InitializeComponent();

        }

        private void Culc(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            chart1.ChartAreas[0].AxisX.Title = "Частота f, ГГц"; // Подпись для оси X
            chart1.ChartAreas[0].AxisY.Title = "Ослабление γ, дБ/км"; // Подпись для оси Y

            double f_from = Convert.ToDouble(numericUpDown_frequency_from.Text.Replace(".", ","));
            double f_to = Convert.ToDouble(numericUpDown_frequency_to.Text.Replace(".", ","));
            double R = Convert.ToDouble(numericUpDown_IntensityOfTheRain.Text.Replace(".", ","));
            double track_angle = Convert.ToDouble(numericUpDown_track_angle.Text.Replace(".", ",")) * (Math.PI / 180);
            double tilt_angle = Convert.ToDouble(numericUpDown_tilt_angle.Text.Replace(".", ",")) * (Math.PI / 180);


            chart1.ChartAreas[0].AxisX.Minimum = f_from;
            chart1.ChartAreas[0].AxisX.Maximum = f_to;


            for (double h = f_from; h <= f_to; h++)
            {
                double osl = RainCalc.Attenuation(h, track_angle, tilt_angle, R);
                chart1.Series[0].Points.AddXY(h, osl);

            }
        }
    }
}
