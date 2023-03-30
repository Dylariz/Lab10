using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Level2._5
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Составить программы для решения указанных задач. Построить
        /// график функции z = f(x) при a ≤ x ≤ b, разбивая отрезок [a, b] на n частей.
        /// График начертить точками или отрезками прямых линий по указанию преподавателя,
        /// выполнив предварительно масштабирование. 
        /// При вычерчивании графика функции предусмотреть вывод координатных осей.
        /// z = x^2 – 18x + 72; a = 5, b = 20, n = 40.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            Chart myChart = new Chart();
            
            myChart.Parent = this;
            myChart.Dock = DockStyle.Fill;
            myChart.ChartAreas.Add(new ChartArea("Math functions"));
            
            Series mySeriesOfPoint = new Series("MainFunc");
            mySeriesOfPoint.ChartType = SeriesChartType.Line;
            mySeriesOfPoint.ChartArea = "Math functions";
            
            for (double x = 5; x <= 20; x += 0.5) 
            {
                mySeriesOfPoint.Points.AddXY(x, Math.Pow(x, 2) - 18 * x + 75);
            }
            
            myChart.Series.Add(mySeriesOfPoint);
        }
    }
}