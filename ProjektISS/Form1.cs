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
        private List<DataPoint> dataHR=new List<DataPoint>();
        private List<DataPoint> dataBR = new List<DataPoint>();
        private List<DataPoint> dataEKG = new List<DataPoint>();
        private List<DataPoint> dataEMG = new List<DataPoint>();
        private List<DataPoint> dataGSR = new List<DataPoint>();
        private List<DataPoint> dataST = new List<DataPoint>();
        private List<DataPoint> dataRESP = new List<DataPoint>();

        private int seconds=0;

        private bool timerStarted = false;
        public Form1()
        {
            this.InitializeComponent();
        }

        // Respond to form 'Load' event
        private void Form1_Load(object sender, EventArgs e)
        {
            // Setup the graph
            LoadData();
            CreateGraphHR(zedGraphControlHR);
            CreateGraphBR(zedGraphControlBR);
            CreateGraphEKG(zedGraphControlEKG);
            CreateGraphGSR(zedGraphControlGSR);
            CreateGraphEMG(zedGraphControlEMG);
            CreateGraphRESP(zedGraphControlRESP);
            CreateGraphST(zedGraphControlST);
        }

        // Build the Chart
        private void CreateGraphHR(ZedGraphControl zgc)
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

            PointPairList list1 = new PointPairList();

            LineItem myCurve = myPane.AddCurve("HR",
                  list1, Color.Red, SymbolType.Square);
            
            zedGraphControlHR.ScrollMinX = 0;
            zgc.AxisChange();
        }
        private void CreateGraphBR(ZedGraphControl zgc)
        {
            var document = XDocument.Load("BR.xml");
            double[] Xarray = document.Descendants("X").Select(g => Math.Round((double)g, 3)).ToArray();
            double[] Yarray = document.Descendants("Y").Select(g => (double)g).ToArray();

            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;

            // Set the Titles
            myPane.Title.Text = "Basal Rate";
            myPane.XAxis.Title.Text = "seconds";
            myPane.YAxis.Title.Text = "units/hour";
            myPane.Legend.IsVisible = false;

            PointPairList list1 = new PointPairList();

            LineItem myCurve = myPane.AddCurve("BR",
                  list1, Color.Blue, SymbolType.Triangle);

            zedGraphControlBR.ScrollMinX = 0;
            zgc.AxisChange();
        }
        private void CreateGraphEKG(ZedGraphControl zgc)
        {
            var document = XDocument.Load("ECG.xml");
            double[] Xarray = document.Descendants("X").Select(g => Math.Round((double)g, 3)).ToArray();
            double[] Yarray = document.Descendants("Y").Select(g => (double)g).ToArray();

            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;

            // Set the Titles
            myPane.Title.Text = "Electrocardiogram";
            myPane.XAxis.Title.Text = "seconds";
            myPane.YAxis.Title.Text = "milivolt";
            myPane.Legend.IsVisible = false;

            PointPairList list1 = new PointPairList();

            LineItem myCurve = myPane.AddCurve("EKG",
                  list1, Color.Violet, SymbolType.None);

            zedGraphControlEKG.ScrollMinX = 0;
            zgc.AxisChange();
        }
        private void CreateGraphEMG(ZedGraphControl zgc)
        {
            var document = XDocument.Load("EMG.xml");
            double[] Xarray = document.Descendants("X").Select(g => Math.Round((double)g, 3)).ToArray();
            double[] Yarray = document.Descendants("Y").Select(g => (double)g).ToArray();

            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;

            // Set the Titles
            myPane.Title.Text = "Electromyograph";
            myPane.XAxis.Title.Text = "seconds";
            myPane.YAxis.Title.Text = "milivolt";
            myPane.Legend.IsVisible = false;

            PointPairList list1 = new PointPairList();

            LineItem myCurve = myPane.AddCurve("EMG",
                  list1, Color.Violet, SymbolType.None);

            zedGraphControlEMG.ScrollMinX = 0;
            zgc.AxisChange();
        }
        private void CreateGraphGSR(ZedGraphControl zgc)
        {
            var document = XDocument.Load("GSR.xml");
            double[] Xarray = document.Descendants("X").Select(g => Math.Round((double)g, 3)).ToArray();
            double[] Yarray = document.Descendants("Y").Select(g => (double)g).ToArray();

            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;

            // Set the Titles
            myPane.Title.Text = "GSR";
            myPane.XAxis.Title.Text = "seconds";
            myPane.YAxis.Title.Text = "milivolt";
            myPane.Legend.IsVisible = false;

            PointPairList list1 = new PointPairList();

            LineItem myCurve = myPane.AddCurve("GSR",
                  list1, Color.Violet, SymbolType.None);

            zedGraphControlGSR.ScrollMinX = 0;
            zgc.AxisChange();
        }
        private void CreateGraphRESP(ZedGraphControl zgc)
        {
            var document = XDocument.Load("RESP.xml");
            double[] Xarray = document.Descendants("X").Select(g => Math.Round((double)g, 3)).ToArray();
            double[] Yarray = document.Descendants("Y").Select(g => (double)g).ToArray();

            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;

            // Set the Titles
            myPane.Title.Text = "RESP";
            myPane.XAxis.Title.Text = "seconds";
            myPane.YAxis.Title.Text = "milivolt";
            myPane.Legend.IsVisible = false;

            PointPairList list1 = new PointPairList();

            LineItem myCurve = myPane.AddCurve("RESP",
                  list1, Color.Blue, SymbolType.None);

            zedGraphControlRESP.ScrollMinX = 0;
            zgc.AxisChange();
        }
        private void CreateGraphST(ZedGraphControl zgc)
        {
            var document = XDocument.Load("ST.xml");
            double[] Xarray = document.Descendants("X").Select(g => Math.Round((double)g, 3)).ToArray();
            double[] Yarray = document.Descendants("Y").Select(g => (double)g).ToArray();

            // get a reference to the GraphPane
            GraphPane myPane = zgc.GraphPane;

            // Set the Titles
            myPane.Title.Text = "ST";
            myPane.XAxis.Title.Text = "seconds";
            myPane.YAxis.Title.Text = "milivolt";
            myPane.Legend.IsVisible = false;

            PointPairList list1 = new PointPairList();

            LineItem myCurve = myPane.AddCurve("ST",
                  list1, Color.Violet, SymbolType.None);

            zedGraphControlST.ScrollMinX = 0;
            zgc.AxisChange();
        }
        private void LoadData()
        {

            #region HR
            var documentHR = XDocument.Load("HR.xml");
            double[] Xarray = documentHR.Descendants("X").Select(g => Math.Round((double)g, 3)).ToArray();
            double[] Yarray = documentHR.Descendants("Y").Select(g => (double)g).ToArray();

            for (int i = 0; i < Xarray.Count(); i++)
            {
                this.dataHR.Add(new DataPoint() { X = Xarray[i], Y = Yarray[i] });
            }
            #endregion
            #region BR
            var documentBR = XDocument.Load("BR.xml");
            Xarray = documentBR.Descendants("X").Select(g => Math.Round((double)g, 3)).ToArray();
            Yarray = documentBR.Descendants("Y").Select(g => (double)g).ToArray();

            for (int i = 0; i < Xarray.Count(); i++)
            {
                this.dataBR.Add(new DataPoint() { X = Xarray[i], Y = Yarray[i] });
            }
#endregion
            #region ECG
            var documentECG = XDocument.Load("ECG.xml");
            Xarray = documentECG.Descendants("X").Select(g => Math.Round((double)g, 3)).ToArray();
            Yarray = documentECG.Descendants("Y").Select(g => (double)g).ToArray();

            for (int i = 0; i < Xarray.Count(); i++)
            {
                this.dataEKG.Add(new DataPoint() { X = Xarray[i], Y = Yarray[i] });
            }
#endregion

            #region EMG
            var documentEMG = XDocument.Load("EMG.xml");
            Xarray = documentEMG.Descendants("X").Select(g => Math.Round((double)g, 3)).ToArray();
            Yarray = documentEMG.Descendants("Y").Select(g => (double)g).ToArray();

            for (int i = 3; i < Xarray.Count(); i++)
            {
                this.dataEMG.Add(new DataPoint() { X = Xarray[i], Y = Yarray[i] });
            }
#endregion
            #region RESP
            var documentRESP = XDocument.Load("RESP.xml");
            Xarray = documentRESP.Descendants("X").Select(g => Math.Round((double)g, 3)).ToArray();
            Yarray = documentRESP.Descendants("Y").Select(g => (double)g).ToArray();

            for (int i = 3; i < Xarray.Count(); i++)
            {
                this.dataRESP.Add(new DataPoint() { X = Xarray[i], Y = Yarray[i] });
            }
#endregion
            #region ST
            var documentST = XDocument.Load("ST.xml");
            Xarray = documentST.Descendants("X").Select(g => Math.Round((double)g, 3)).ToArray();
            Yarray = documentST.Descendants("Y").Select(g => (double)g).ToArray();

            for (int i = 3; i < Xarray.Count(); i++)
            {
                this.dataST.Add(new DataPoint() { X = Xarray[i], Y = Yarray[i] });
            }
#endregion
            #region GSR
            var documentGSR = XDocument.Load("GSR.xml");
            Xarray = documentGSR.Descendants("X").Select(g => Math.Round((double)g, 3)).ToArray();
            Yarray = documentGSR.Descendants("Y").Select(g => (double)g).ToArray();

            for (int i = 3; i < Xarray.Count(); i++)
            {
                this.dataGSR.Add(new DataPoint() { X = Xarray[i], Y = Yarray[i] });
            }
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.timerStarted == false)
            {
                Timer timerLong = new Timer();
                timerLong.Interval = 125;
                timerLong.Tick += new EventHandler(TimerEventProcessor1);

                Timer clock = new Timer();
                clock.Interval = 1000;
                clock.Tick += new EventHandler(ClockProcessor);
                /*Timer timerShort = new Timer();
                timerShort.Interval = 4;
                timerShort.Tick += new EventHandler(TimerEventProcessor2);

                timerShort.Start();*/
                timerLong.Start();
                clock.Start();

                this.timerStarted = true;
            }
        }
        private void TimerEventProcessor1(Object myObject,EventArgs myEventArgs)
        {
            AddPointLong();
            AddPointShort();
        }
        private void TimerEventProcessor2(Object myObject, EventArgs myEventArgs)
        {
            AddPointShort();
        }
        private void ClockProcessor(Object myObject, EventArgs myEventArgs)
        {
            this.seconds++;
            label5.Text = this.seconds.ToString() + " s";
        }

        private void AddPointShort()
        {
            if (this.dataEKG.Count > 32)
            {
                LineItem curve = zedGraphControlEKG.GraphPane.CurveList[0] as LineItem;
                IPointListEdit list = curve.Points as IPointListEdit;

                list.Add(this.dataEKG[0].X, this.dataEKG[0].Y);
                zedGraphControlEKG.Invalidate();

                zedGraphControlEKG.ScrollMaxX = list[list.Count - 1].X;

                double width = zedGraphControlEKG.GraphPane.XAxis.Scale.Max - zedGraphControlEKG.GraphPane.XAxis.Scale.Min;

                zedGraphControlEKG.GraphPane.XAxis.Scale.Max = list[list.Count - 1].X;
                zedGraphControlEKG.GraphPane.XAxis.Scale.Min = zedGraphControlEKG.GraphPane.XAxis.Scale.Max - width;
                zedGraphControlEKG.AxisChange();

                this.dataEKG.RemoveAt(0);
            }
            if (this.dataGSR.Count > 0)
            {
                LineItem curve = zedGraphControlGSR.GraphPane.CurveList[0] as LineItem;
                IPointListEdit list = curve.Points as IPointListEdit;

                list.Add(this.dataGSR[0].X, this.dataGSR[0].Y);
                zedGraphControlGSR.Invalidate();

                zedGraphControlGSR.ScrollMaxX = list[list.Count - 1].X;

                double width = zedGraphControlGSR.GraphPane.XAxis.Scale.Max - zedGraphControlGSR.GraphPane.XAxis.Scale.Min;
                zedGraphControlGSR.GraphPane.XAxis.Scale.Max = list[list.Count - 1].X;
                zedGraphControlGSR.GraphPane.XAxis.Scale.Min = zedGraphControlGSR.GraphPane.XAxis.Scale.Max - width;
                zedGraphControlGSR.AxisChange();

                this.dataGSR.RemoveAt(0);
            }
            if (this.dataEMG.Count > 0)
            {
                LineItem curve = zedGraphControlEMG.GraphPane.CurveList[0] as LineItem;
                IPointListEdit list = curve.Points as IPointListEdit;

                list.Add(this.dataEMG[0].X, this.dataEMG[0].Y);
                zedGraphControlEMG.Invalidate();

                zedGraphControlEMG.ScrollMaxX = list[list.Count - 1].X;

                double width = zedGraphControlEMG.GraphPane.XAxis.Scale.Max - zedGraphControlEMG.GraphPane.XAxis.Scale.Min;
                zedGraphControlEMG.GraphPane.XAxis.Scale.Max = list[list.Count - 1].X;
                zedGraphControlEMG.GraphPane.XAxis.Scale.Min = zedGraphControlEMG.GraphPane.XAxis.Scale.Max - width;
                zedGraphControlEMG.AxisChange();

                this.dataEMG.RemoveAt(0);
            }
            if (this.dataRESP.Count > 0)
            {
                LineItem curve = zedGraphControlRESP.GraphPane.CurveList[0] as LineItem;
                IPointListEdit list = curve.Points as IPointListEdit;

                list.Add(this.dataRESP[0].X, this.dataRESP[0].Y);
                zedGraphControlRESP.Invalidate();

                zedGraphControlRESP.ScrollMaxX = list[list.Count - 1].X;

                double width = zedGraphControlRESP.GraphPane.XAxis.Scale.Max - zedGraphControlRESP.GraphPane.XAxis.Scale.Min;
                zedGraphControlRESP.GraphPane.XAxis.Scale.Max = list[list.Count - 1].X;
                zedGraphControlRESP.GraphPane.XAxis.Scale.Min = zedGraphControlRESP.GraphPane.XAxis.Scale.Max - width;
                zedGraphControlRESP.AxisChange();

                this.dataRESP.RemoveAt(0);
            }
            if (this.dataST.Count > 0)
            {
                LineItem curve = zedGraphControlST.GraphPane.CurveList[0] as LineItem;
                IPointListEdit list = curve.Points as IPointListEdit;

                list.Add(this.dataST[0].X, this.dataST[0].Y);
                zedGraphControlST.Invalidate();

                zedGraphControlST.ScrollMaxX = list[list.Count - 1].X;

                double width = zedGraphControlST.GraphPane.XAxis.Scale.Max - zedGraphControlST.GraphPane.XAxis.Scale.Min;
                zedGraphControlST.GraphPane.XAxis.Scale.Max = list[list.Count - 1].X;
                zedGraphControlST.GraphPane.XAxis.Scale.Min = zedGraphControlST.GraphPane.XAxis.Scale.Max - width;
                zedGraphControlST.AxisChange();

                this.dataST.RemoveAt(0);
            }
            else
            {
                return;
            }
        }

        public void AddPointLong()
        {
            if (this.dataHR.Count > 0)
            {
                LineItem curve = zedGraphControlHR.GraphPane.CurveList[0] as LineItem;
                IPointListEdit list = curve.Points as IPointListEdit;

                list.Add(this.dataHR[0].X, this.dataHR[0].Y);
                zedGraphControlHR.Invalidate();

                zedGraphControlHR.ScrollMaxX = list[list.Count - 1].X;

                double width = zedGraphControlHR.GraphPane.XAxis.Scale.Max - zedGraphControlHR.GraphPane.XAxis.Scale.Min;
                zedGraphControlHR.GraphPane.XAxis.Scale.Max = list[list.Count - 1].X;
                zedGraphControlHR.GraphPane.XAxis.Scale.Min = zedGraphControlHR.GraphPane.XAxis.Scale.Max - width;
                zedGraphControlHR.AxisChange();

                label1.Text = Math.Round(this.dataHR[0].Y, 0).ToString();

                this.dataHR.RemoveAt(0);
            }
            if (this.dataBR.Count > 0)
            {
                LineItem curve = zedGraphControlBR.GraphPane.CurveList[0] as LineItem;
                IPointListEdit list = curve.Points as IPointListEdit;

                list.Add(this.dataBR[0].X, this.dataBR[0].Y);
                zedGraphControlBR.Invalidate();

                zedGraphControlBR.ScrollMaxX = list[list.Count - 1].X;

                double width = zedGraphControlBR.GraphPane.XAxis.Scale.Max - zedGraphControlBR.GraphPane.XAxis.Scale.Min;
                zedGraphControlBR.GraphPane.XAxis.Scale.Max = list[list.Count - 1].X;
                zedGraphControlBR.GraphPane.XAxis.Scale.Min = zedGraphControlBR.GraphPane.XAxis.Scale.Max - width;
                zedGraphControlBR.AxisChange();

                label3.Text = Math.Round(this.dataBR[0].Y, 2).ToString();

                this.dataBR.RemoveAt(0);
            }
            else
            {
                return;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == ' ')
            {
                PointPairList userClickrList = new PointPairList();

                GraphPane myPane = zedGraphControlEKG.GraphPane;

                LineItem line = new LineItem(String.Empty, new[] { 0.1,  0.1},
                                new[] { myPane.YAxis.Scale.Min, 0.8*myPane.YAxis.Scale.Max },
                                Color.Red, SymbolType.None);
                line.Line.Width = 5;

                myPane.CurveList.Add(line);
                zedGraphControlHR.Refresh();
            }
        }
    }
}
