using ZedGraph;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjektISS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.InitializeComponent();
        }

        // Respond to form 'Load' event
        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup the graph
            CreateGraph(zedGraphControl1);

        }

        // Build the Chart
        private void CreateGraph(ZedGraphControl zgc)
        {
            var document = XDocument.Load("HR.xml");
            double[] Xarray = document.Descendants("X").Select(g => Math.Round((double)g,3)).ToArray();
            double[] Yarray = document.Descendants("Y").Select(g => (double)g).ToArray();

            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;

            // Set the Titles
            myPane.Title.Text = "Heart Rate";
            myPane.XAxis.Title.Text = "seconds";
            myPane.YAxis.Title.Text = "bpm";
            myPane.Legend.IsVisible = false;

            // Make up some data arrays based on the Sine function
            double x, y1, y2;
            PointPairList list1 = new PointPairList();
            for (int i = 0; i < 36; i++)
            {
                x = (double)i;
                y1 = 1.5 + Math.Sin((double)i * 0.2);
                y2 = 3.0 * (1.5 + Math.Sin((double)i * 0.2));
                list1.Add(x, y1);
            }

            // Generate a red curve with diamond
            // symbols, and "Porsche" in the legend
            LineItem myCurve = myPane.AddCurve("HR",
                  list1, Color.Red, SymbolType.Square);
            
            // Tell ZedGraph to refigure the
            // axes since the data have changed
            zedGraphControl1.ScrollMinX = 0;
            zgc.AxisChange();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x, y1;
            LineItem curve = zedGraphControl1.GraphPane.CurveList[0] as LineItem;
            IPointListEdit list = curve.Points as IPointListEdit;

            for (int i = 1; i < 50; i++)
            {
                //System.Threading.Thread.Sleep(500);
                x = (int)list[list.Count - 1].X+ 1;
                y1 = 1.5 + Math.Sin(0.2*x);
                list.Add(x, y1);
                zedGraphControl1.Invalidate();
            }
            zedGraphControl1.ScrollMaxX = list[list.Count - 1].X;

            double width = zedGraphControl1.GraphPane.XAxis.Scale.Max - zedGraphControl1.GraphPane.XAxis.Scale.Min;
            zedGraphControl1.GraphPane.XAxis.Scale.Max = list[list.Count - 1].X;
            zedGraphControl1.GraphPane.XAxis.Scale.Min = zedGraphControl1.GraphPane.XAxis.Scale.Max-width;
        }
    }
}
