using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graph_Add
{
    public class GraphCoordinates
    {
        public double x, y;
        //public decimal[] XCoordinates;
        //public decimal[] YCoordinates;
        //public BindingList<double> XCoordinates;
        //public BindingList<double> YCoordinates;
        //public DataTable dt = new DataTable("XYTable");

        //public Dictionary<string, int> XYMap = new Dictionary<string, int>{
        //    {"x1",1},{"x2",2},{"x3",3},{"x4",4},{"x5",5},{"x6",6},{"x7",7},{"x8",8},{"x9",9},{"x10",10},
        //    {"y1",1},{"y2",2},{"y3",3},{"y4",4},{"y5",5},{"y6",6 },{"y7",7},{"y8",8},{"y9",9},{"y10",10}
        //};

        public GraphCoordinates(double x, double y) {
            this.x = x;
            this.y = y;
            //XCoordinates = new decimal[x];
            //YCoordinates = new decimal[y];
            //XCoordinates = new List<decimal>();
            //YCoordinates = new List<decimal>();
            //dt.Columns.Add("Id", typeof(int));
            //dt.Columns.Add("X", typeof(double));
            //dt.Columns.Add ("Y", typeof(double));

            //dt.PrimaryKey = new DataColumn[] { dt.Columns["Id"] };
        }
    }
}
