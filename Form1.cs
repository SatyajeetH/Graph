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

namespace Graph_Add
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

        public static BindingList<double> blistX = new BindingList<double>();
        public static BindingList<double> blistY = new BindingList<double>();


        public Dictionary<string, int> XYMap = new Dictionary<string, int>{
            {"x1",1},{"x2",2},{"x3",3},{"x4",4},{"x5",5},{"x6",6},{"x7",7},{"x8",8},{"x9",9},{"x10",10},
            {"y1",1},{"y2",2},{"y3",3},{"y4",4},{"y5",5},{"y6",6 },{"y7",7},{"y8",8},{"y9",9},{"y10",10}
        };

        private void Form1_Load(object sender, EventArgs e)
            {
                for (int i = 1; i <= 10; i++)
                {
                    string tempX = $"x{i}";
                    string tempY = $"y{i}";

                    var ctrlX = this.Controls.Find(tempX, true)[0] as NumericUpDown;
                    var ctrlY = this.Controls.Find(tempY, true)[0] as NumericUpDown;
                blistX.Add((double)ctrlX.Value);
                blistY.Add((double)ctrlY.Value);
            }
            }

        private void UpdateCoordinates(decimal val, string name)
        {
            if (name.StartsWith("x"))
            {
                blistX[XYMap[name] - 1] = (double)val;
            }
            else if (name.StartsWith("y")) {
                blistY[XYMap[name] - 1] =(double)val;
            }
            Form2.chart.Series[0].Points.DataBindXY(blistX, blistY);
        }

            private void numericUpDown3_ValueChanged(object sender, EventArgs e)
            {
                decimal val = x2.Value;
                string name = x2.Name;
                UpdateCoordinates(val, name);
            }

            private void numericUpDown15_ValueChanged(object sender, EventArgs e)
            {
                decimal val = y4.Value;
                string name = y4.Name;
                UpdateCoordinates(val, name);
            }

            private void numericUpDown14_ValueChanged(object sender, EventArgs e)
            {
                decimal val = y3.Value;
                string name = y3.Name;
                UpdateCoordinates(val, name);
            }

            private void numericUpDown5_ValueChanged(object sender, EventArgs e)
            {
                decimal val = x4.Value;
                string name = x4.Name;
                UpdateCoordinates(val, name);
            }

            private void numericUpDown2_ValueChanged(object sender, EventArgs e)
            {
                decimal val = x1.Value;
                string name = x1.Name;
                UpdateCoordinates(val, name);
            }

            private void numericUpDown1_ValueChanged(object sender, EventArgs e)
            {
                decimal val = y6.Value;
                string name = y6.Name;
                UpdateCoordinates(val, name);
            }

            private void numericUpDown19_ValueChanged(object sender, EventArgs e)
            {
                decimal val = y9.Value;
                string name = y9.Name;
                UpdateCoordinates(val, name);
            }

            private void numericUpDown16_ValueChanged(object sender, EventArgs e)
            {
                decimal val = y5.Value;
                string name = y5.Name;
                UpdateCoordinates(val, name);
            }

            private void numericUpDown6_ValueChanged(object sender, EventArgs e)
            {
                decimal val = x5.Value;
                string name = x5.Name;
                UpdateCoordinates(val, name);
            }

            private void numericUpDown17_ValueChanged(object sender, EventArgs e)
            {
                decimal val = y7.Value;
                string name = y7.Name;
                UpdateCoordinates(val, name);
            }

            private void numericUpDown4_ValueChanged(object sender, EventArgs e)
            {
                decimal val = x3.Value;
                string name = x3.Name;
                UpdateCoordinates(val, name);
            }

            private void numericUpDown8_ValueChanged(object sender, EventArgs e)
            {
                decimal val = x7.Value;
                string name = x7.Name;
                UpdateCoordinates(val, name);
            }

            private void numericUpDown10_ValueChanged(object sender, EventArgs e)
            {
                decimal val = x9.Value;
                string name = x9.Name;
                UpdateCoordinates(val, name);
            }

            private void numericUpDown18_ValueChanged(object sender, EventArgs e)
            {
                decimal val = y8.Value;
                string name = y8.Name;
                UpdateCoordinates(val, name);
            }

            private void numericUpDown12_ValueChanged(object sender, EventArgs e)
            {
                decimal val = y1.Value;
                string name = y1.Name;
                UpdateCoordinates(val, name);
            }

            private void numericUpDown7_ValueChanged(object sender, EventArgs e)
            {
                decimal val = x6.Value;
                string name = x6.Name;
                UpdateCoordinates(val, name);
            }

            private void numericUpDown9_ValueChanged(object sender, EventArgs e)
            {
                decimal val = x8.Value;
                string name = x8.Name;
                UpdateCoordinates(val, name);
            }

            private void numericUpDown11_ValueChanged(object sender, EventArgs e)
            {
                decimal val = x10.Value;
                string name = x10.Name;
                UpdateCoordinates(val, name);
            }

            private void numericUpDown20_ValueChanged(object sender, EventArgs e)
            {
                decimal val = y10.Value;
                string name = y10.Name;
                UpdateCoordinates(val, name);
            }

            private void numericUpDown13_ValueChanged(object sender, EventArgs e)
            {
                decimal val = y2.Value;
                string name = y2.Name;
                UpdateCoordinates(val, name);
            }

            private void btnGraph_Click(object sender, EventArgs e)
            {
                Form2 graphForm = new Form2();
                graphForm.Show();
            }
        }
    }
