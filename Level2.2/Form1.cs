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

namespace Level2._2
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Составить программы для решения указанных задач. Построить
        /// график функции z = f(x) при a ≤ x ≤ b, разбивая отрезок [a, b] на n частей.
        /// График начертить точками или отрезками прямых линий по указанию преподавателя,
        /// выполнив предварительно масштабирование. 
        /// При вычерчивании графика функции предусмотреть вывод координатных осей.
        /// z = x*sin x; a = 0, b = 3π, n = 20.
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
            
            for (double x = 0; x <= 3 * Math.PI; x += 3 * Math.PI / 20) 
            {
                mySeriesOfPoint.Points.AddXY(x, x * Math.Sin(x));
            }
            
            myChart.Series.Add(mySeriesOfPoint);
        }
    }
}