using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;
using System.Globalization;

namespace Project
{
    internal class FullRainCalc
    {

        private static List<double> latitudes = new List<double>();
        private static List<double> longitudes = new List<double>();
        private static double[,] h0Grid;

        public static void LoadGridData(string h0File, string latFile, string lonFile)
        {
            try
            {
                // Загрузка широт (от 90 до -90 с шагом 1.5)
                string latContent = File.ReadAllText(latFile).Replace("\r\n", " ").Replace("\n", " ").Replace(',', '.');

                string[] latValues = latContent.Split(
                    new[] { ' ', '\t' },
                    StringSplitOptions.RemoveEmptyEntries
                );

                latitudes = latValues
                    .Select(v => double.Parse(v, NumberStyles.Any, CultureInfo.InvariantCulture))
                    .Distinct() // Убираем дубликаты
                    .OrderByDescending(v => v) // Сортировка от 90 до -90
                    .ToList();

                // Проверка количества широт (должно быть 121)
                if (latitudes.Count != 121)
                    throw new InvalidDataException($"Некорректное количество широт: {latitudes.Count} (ожидалось 121).");

                // Загрузка долгот (от 0 до 360 с шагом 1.5)
                string lonContent = File.ReadAllText(lonFile)
                    .Replace("\r\n", " ")
                    .Replace("\n", " ")
                    .Replace(',', '.');

                string[] lonValues = lonContent.Split(
                    new[] { ' ', '\t' },
                    StringSplitOptions.RemoveEmptyEntries
                );

                longitudes = lonValues
                    .Select(v => double.Parse(v, NumberStyles.Any, CultureInfo.InvariantCulture))
                    .Distinct()
                    .OrderBy(v => v)
                    .ToList();

                // Проверка количества долгот (должно быть 241)
                if (longitudes.Count != 241)
                    throw new InvalidDataException($"Некорректное количество долгот: {longitudes.Count} (ожидалось 241).");

                // Загрузка h0
                string h0Content = File.ReadAllText(h0File)
                    .Replace("\r\n", " ")
                    .Replace("\n", " ")
                    .Replace(',', '.');

                string[] h0Values = h0Content.Split(
                    new[] { ' ', '\t' },
                    StringSplitOptions.RemoveEmptyEntries
                );

                // Ожидаемое количество значений: 121 * 241 = 29,161
                int expectedH0Count = latitudes.Count * longitudes.Count;
                if (h0Values.Length != expectedH0Count)
                    throw new InvalidDataException(
                        $"Ожидалось {expectedH0Count} значений h0, получено {h0Values.Length}."
                    );

                // Заполнение сетки h0
                h0Grid = new double[latitudes.Count, longitudes.Count];
                int index = 0;
                for (int i = 0; i < latitudes.Count; i++)
                    for (int j = 0; j < longitudes.Count; j++)
                        h0Grid[i, j] = double.Parse(h0Values[index++], CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Ошибка загрузки данных: {ex.Message}");
            }
        }

        public static (double h0, double hR) CalculateRainHeight(double targetLat, double targetLon)
        {
            if (latitudes.Count == 0 || longitudes.Count == 0)
                throw new InvalidOperationException("Данные не загружены");

            int latIndex = FindNearestIndex(latitudes, targetLat);
            int lonIndex = FindNearestIndex(longitudes, targetLon);

            double h0 = h0Grid[latIndex, lonIndex];
            double hR = h0 + 0.36;

            return (h0, hR);
        }

        private static int FindNearestIndex(List<double> list, double value)
        {
            int nearestIndex = 0;
            double minDiff = double.MaxValue;
            for (int i = 0; i < list.Count; i++)
            {
                double diff = Math.Abs(list[i] - value);
                if (diff < minDiff)
                {
                    minDiff = diff;
                    nearestIndex = i;
                }
            }
            return nearestIndex;
        }

        public static double CalculateEffectivePathLength(double track_angle,
                                           double latitude, double longitude/*, double R*/)
        {
            // Получаем высоту дождевого слоя
            var (h0, hR) = CalculateRainHeight(latitude, longitude);
            double Re = 8500;

            //// Расчет вертикальной проекции
            //double verticalProjection = (hR /*- h0*/) / Math.Sin(track_angle);

            //// Коэффициент уменьшения (для углов > 5 градусов)
            ////double reductionFactor = 1.0;
            ////if (track_angle <= 5)
            ////{
            //double l0 = (35 * Math.Exp(-0.015 * R)) / (1 + track_angle / 45);
            //double reductionFactor = 1 / (1 + verticalProjection / l0);
            ////}

            //// Эффективная длина пути (формула ITU-R P.618-13)
            //var effectiveLength = verticalProjection * reductionFactor;

            var effectiveLength = Math.Sqrt(Math.Pow(Re, 2) * Math.Pow(Math.Sin(track_angle), 2) + 2 * Re * hR) - Re * Math.Sin(track_angle);


            return effectiveLength;
        }
        public static double CalculateFulAtten(double osl, double track_angle,
                                           double latitude, double longitude, double R)
        {

            var FulOsl = osl * CalculateEffectivePathLength(track_angle, latitude, longitude/*, R*/);

            return FulOsl;
        }
    }
}


