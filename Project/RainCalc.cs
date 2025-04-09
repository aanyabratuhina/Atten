using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class RainCalc
    {
        public static double Attenuation(double f_GHz, double track_angle, double tilt_angle, double R)
        {
            //hor
            List<double> lh = new List<double>();
            List<double> a1h = new List<double>();

            double kh0, kh, ah, lgh, ah0;

            double mkh = -0.18961;
            double ckh = 0.71147;
            double mah = 0.67849;
            double cah = -1.95537;

            double[] aj1h = { -5.33980, -0.35351, -0.23789, -0.94158 };
            double[] bj1h = { -0.10008, 1.26970, 0.86036, 0.64552 };
            double[] cj1h = { 1.13098, 0.45400, 0.15354, 0.16817 };

            double[] aj2h = { -0.14318, 0.29591, 0.32177, -5.37610, 16.1721 };
            double[] bj2h = { 1.82442, 0.77564, 0.63773, -0.96230, -3.29980 };
            double[] cj2h = { -0.55187, 0.19822, 0.13164, 1.47828, 3.43990 };

            //ver
            List<double> lv = new List<double>();
            List<double> a1v = new List<double>();

            double kv0, kv, av, lgv, av0;

            double mkv = -0.16398;
            double ckv = 0.63297;
            double mav = -0.053739;
            double cav = -0.83433;

            double[] aj1v = { -3.80595, -3.44965, -0.39902, -0.50167 };
            double[] bj1v = { 0.56934, -0.22911, 0.73042, 1.07319 };
            double[] cj1v = { 0.81061, 0.51059, 0.11899, 0.27195 };

            double[] aj2v = { -0.07771, 0.56727, -0.20238, -48.2991, 48.5833 };
            double[] bj2v = { 2.33840, 0.95545, 1.14520, 0.791669, 0.791459 };
            double[] cj2v = { -0.76284, 0.54039, 0.26809, 0.116226, 0.116479 };

            lh.Clear();
            for (int i = 0; i <= 3; i++)
            {
                lgh = aj1h[i] * Math.Exp(-Math.Pow(((Math.Log10(f_GHz) - bj1h[i]) / cj1h[i]), 2));
                lh.Add(lgh);
            }
            kh0 = lh.Sum() + mkh * Math.Log10(f_GHz) + ckh;
            kh = Math.Pow(10, kh0);

            a1h.Clear();
            for (int j = 0; j <= 4; j++)
            {
                ah0 = aj2h[j] * Math.Exp(-Math.Pow(((Math.Log10(f_GHz) - bj2h[j]) / cj2h[j]), 2));
                a1h.Add(ah0);
            }
            ah = a1h.Sum() + mah * Math.Log10(f_GHz) + cah;

            lv.Clear();
            for (int i = 0; i <= 3; i++)
            {
                lgv = aj1v[i] * Math.Exp(-Math.Pow(((Math.Log10(f_GHz) - bj1v[i]) / cj1v[i]), 2));
                lv.Add(lgv);
            }
            kv0 = lv.Sum() + mkv * Math.Log10(f_GHz) + ckv;
            kv = Math.Pow(10, kv0);

            a1v.Clear();
            for (int j = 0; j <= 4; j++)
            {
                av0 = aj2v[j] * Math.Exp(-Math.Pow(((Math.Log10(f_GHz) - bj2v[j]) / cj2v[j]), 2));
                a1v.Add(av0);
            }
            av = a1v.Sum() + mav * Math.Log10(f_GHz) + cav;

            var k = (kh + kv + (kh - kv) * Math.Pow(Math.Cos(track_angle), 2) * Math.Cos(2 * tilt_angle)) / 2;
            var a = (kh * ah + kv * av + (kh * ah - kv * av) * Math.Pow(Math.Cos(track_angle), 2) * Math.Cos(2 * tilt_angle)) / (2 * k);

            var osl = k * Math.Pow(R, a);

            return osl;

        }
    }
}
