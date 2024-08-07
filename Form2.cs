using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Graph_Add
{
    public partial class Form2 : Form
    {
        public static Chart chart;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            chart = new Chart();
            chart.Dock = DockStyle.Fill;

            ChartArea chartArea = new ChartArea();
            chart.ChartAreas.Add(chartArea);

            Series series = new Series
            {
                Name = "DataSeries",
                ChartType = SeriesChartType.Line,
            };

            //for (int i = 0; i < 10; i++)
            //{
            //    series.Points.AddXY(Form1.blistX[i], Form1.blistY[i]);
            //}
            series.Points.DataBindXY(Form1.blistX, Form1.blistY);

            chart.Series.Add(series);

            this.Controls.Add(chart);
        }
    }
}
