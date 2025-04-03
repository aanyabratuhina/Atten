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
            button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart_circular.Series[0].Points.Clear();
            
            chart_circular.ChartAreas[0].AxisX.Title = "Частота f, ГГц"; // Подпись для оси X
            chart_circular.ChartAreas[0].AxisY.Title = "Ослабление γ, дБ/км"; // Подпись для оси Y


            double f_from = Convert.ToDouble(textBox_frequency_from.Text.Replace(".", ","));
            double f_to = Convert.ToDouble(textBox_frequency_to.Text.Replace(".", ","));
            double R = Convert.ToDouble(textBox_IntensityOfTheRain.Text.Replace(".", ","));
            double track_angle = Convert.ToDouble(textBox_track_angle.Text.Replace(".", ",")) * (Math.PI / 180);
            double tilt_angle = Convert.ToDouble(textBox_tilt_angle.Text.Replace(".", ",")) * (Math.PI / 180);
          
            for (double h = f_from; h <= f_to; h++)
            {
                double osl = RainCalc.Attenuation(h, track_angle, tilt_angle, R);

                if (double.IsInfinity(osl))
                {
                    osl = double.NaN;
                }
                    
                chart_circular.Series[0].Points.AddXY(h, osl);
            }
        }


        private void textBox_frequency_from_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            
            if (e.KeyChar == '.' && textBox_frequency_from.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void textBox_frequency_to_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }


            if (e.KeyChar == '.' && textBox_frequency_to.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void textBox_IntensityOfTheRain_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }


            if (e.KeyChar == '.' && textBox_IntensityOfTheRain.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void textBox_track_angle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }


            if (e.KeyChar == '.' && textBox_track_angle.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void textBox_tilt_angle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
            {
                e.Handled = true;
            }


            if (e.KeyChar == '.' && textBox_tilt_angle.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void CheckTextBoxes()
        {
            button1.Enabled = !string.IsNullOrWhiteSpace(textBox_frequency_from.Text) &&
                              !string.IsNullOrWhiteSpace(textBox_frequency_to.Text) &&
                              !string.IsNullOrWhiteSpace(textBox_IntensityOfTheRain.Text) &&
                              !string.IsNullOrWhiteSpace(textBox_track_angle.Text) &&
                              !string.IsNullOrWhiteSpace(textBox_tilt_angle.Text);
           
        }

        private void smthChanged(object sender, EventArgs e)
        {
            CheckTextBoxes();
        }
    }  
}
