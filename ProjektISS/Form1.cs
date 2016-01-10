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
using System.Diagnostics;

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

        private Timer timerLong = new Timer();
        private Stopwatch stopwatch = new Stopwatch();
        private bool recording = false;
        private double timeStartRecording = 0;
        private int iteration = 0;
        private bool stopped = false;

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
            double[] Xarray, Yarray;
            #region HR
            try {
                var documentHR = XDocument.Load("HR.xml");
                Xarray = documentHR.Descendants("X").Select(g => Math.Round((double)g, 3)).ToArray();
                Yarray = documentHR.Descendants("Y").Select(g => (double)g).ToArray();

                for (int i = 0; i < Xarray.Count(); i++)
                {
                    this.dataHR.Add(new DataPoint() { X = Xarray[i], Y = Yarray[i] });
                }
            }
            catch { }
            #endregion
            #region BR
            try {
                var documentBR = XDocument.Load("BR.xml");
                Xarray = documentBR.Descendants("X").Select(g => Math.Round((double)g, 3)).ToArray();
                Yarray = documentBR.Descendants("Y").Select(g => (double)g).ToArray();

                for (int i = 0; i < Xarray.Count(); i++)
                {
                    this.dataBR.Add(new DataPoint() { X = Xarray[i], Y = Yarray[i] });
                }
            }
            catch { }
            #endregion
            #region ECG
            try {
                var documentECG = XDocument.Load("ECG.xml");
                Xarray = documentECG.Descendants("X").Select(g => Math.Round((double)g, 3)).ToArray();
                Yarray = documentECG.Descendants("Y").Select(g => (double)g).ToArray();

                for (int i = 0; i < Xarray.Count(); i++)
                {
                    this.dataEKG.Add(new DataPoint() { X = Xarray[i], Y = Yarray[i] });
                }
            }
            catch { }
            #endregion

            #region EMG
            try {
                var documentEMG = XDocument.Load("EMG.xml");
                Xarray = documentEMG.Descendants("X").Select(g => Math.Round((double)g, 3)).ToArray();
                Yarray = documentEMG.Descendants("Y").Select(g => (double)g).ToArray();

                for (int i = 3; i < Xarray.Count(); i++)
                {
                    this.dataEMG.Add(new DataPoint() { X = Xarray[i], Y = Yarray[i] });
                }
            }
            catch { }
            #endregion
            #region RESP
            try {
                var documentRESP = XDocument.Load("RESP.xml");
                Xarray = documentRESP.Descendants("X").Select(g => Math.Round((double)g, 3)).ToArray();
                Yarray = documentRESP.Descendants("Y").Select(g => (double)g).ToArray();

                for (int i = 3; i < Xarray.Count(); i++)
                {
                    this.dataRESP.Add(new DataPoint() { X = Xarray[i], Y = Yarray[i] });
                }
            }
            catch { }
            #endregion
            #region ST
            try {
                var documentST = XDocument.Load("ST.xml");
                Xarray = documentST.Descendants("X").Select(g => Math.Round((double)g, 3)).ToArray();
                Yarray = documentST.Descendants("Y").Select(g => (double)g).ToArray();

                for (int i = 3; i < Xarray.Count(); i++)
                {
                    this.dataST.Add(new DataPoint() { X = Xarray[i], Y = Yarray[i] });
                }
            }
            catch { }
            #endregion
            #region GSR
            try {
                var documentGSR = XDocument.Load("GSR.xml");
                Xarray = documentGSR.Descendants("X").Select(g => Math.Round((double)g, 3)).ToArray();
                Yarray = documentGSR.Descendants("Y").Select(g => (double)g).ToArray();

                for (int i = 3; i < Xarray.Count(); i++)
                {
                    this.dataGSR.Add(new DataPoint() { X = Xarray[i], Y = Yarray[i] });
                }
            }
            catch { }
            #endregion
        }

        private void buttonSimStart_Click(object sender, EventArgs e)
        {
            if (this.stopwatch.IsRunning == false && this.stopped==false)
            {
                if (timerLong.Interval == 100)
                {
                    timerLong.Interval = 125;
                    timerLong.Tick += new EventHandler(TimerEventProcessor1);
                }
                timerLong.Start();
                stopwatch.Start();
            }
        }
        private void TimerEventProcessor1(Object myObject,EventArgs myEventArgs)
        {
            this.label5.Text = String.Format("{0:0.00} s",this.stopwatch.Elapsed.TotalSeconds);
            if (this.recording && zedGraphControlHR.GraphPane.CurveList.Count<3)
            {
                this.label6.Text = String.Format("{0:0.00} s", this.stopwatch.Elapsed.TotalSeconds-this.timeStartRecording);
            }
            AddPointLong();
            AddPointShort();
        }


        private void AddPointShort()
        {
            int numberOfPoints = 31;
            if (this.iteration % 4 == 0)
            {
                numberOfPoints = 32;
            }

            if (this.dataEKG.Count > 32)
            {
                LineItem curve = zedGraphControlEKG.GraphPane.CurveList[0] as LineItem;
                IPointListEdit list = curve.Points as IPointListEdit;

                for (int i = 0; i <= numberOfPoints; i++)
                {
                    list.Add(this.dataEKG[0].X, this.dataEKG[0].Y);
                    this.dataEKG.RemoveAt(0);
                }
                zedGraphControlEKG.Invalidate();

                double maxX = list[list.Count - 1].X;
                zedGraphControlEKG.ScrollMaxX = maxX;

                double width = zedGraphControlEKG.GraphPane.XAxis.Scale.Max - zedGraphControlEKG.GraphPane.XAxis.Scale.Min;
                zedGraphControlEKG.GraphPane.XAxis.Scale.Max = list[list.Count - 1].X;
                zedGraphControlEKG.GraphPane.XAxis.Scale.Min = list[list.Count - 1].X - width;
                zedGraphControlEKG.AxisChange();
            }
            if (this.dataEMG.Count > 32)
            {
                LineItem curve = zedGraphControlEMG.GraphPane.CurveList[0] as LineItem;
                IPointListEdit list = curve.Points as IPointListEdit;

                for (int i = 0; i <= numberOfPoints; i++)
                {
                    list.Add(this.dataEMG[0].X, this.dataEMG[0].Y);
                    this.dataEMG.RemoveAt(0);
                }
                zedGraphControlEMG.Invalidate();

                double maxX = list[list.Count - 1].X;
                zedGraphControlEMG.ScrollMaxX = maxX;

                double width = zedGraphControlEMG.GraphPane.XAxis.Scale.Max - zedGraphControlEMG.GraphPane.XAxis.Scale.Min;
                zedGraphControlEMG.GraphPane.XAxis.Scale.Max = list[list.Count - 1].X;
                zedGraphControlEMG.GraphPane.XAxis.Scale.Min = list[list.Count - 1].X - width;
                zedGraphControlEMG.AxisChange();
            }
            if (this.dataGSR.Count > 32)
            {
                LineItem curve = zedGraphControlGSR.GraphPane.CurveList[0] as LineItem;
                IPointListEdit list = curve.Points as IPointListEdit;

                for (int i = 0; i <= numberOfPoints; i++)
                {
                    list.Add(this.dataGSR[0].X, this.dataGSR[0].Y);
                    this.dataGSR.RemoveAt(0);
                }
                zedGraphControlGSR.Invalidate();

                double maxX = list[list.Count - 1].X;
                zedGraphControlGSR.ScrollMaxX = maxX;

                double width = zedGraphControlGSR.GraphPane.XAxis.Scale.Max - zedGraphControlGSR.GraphPane.XAxis.Scale.Min;
                zedGraphControlGSR.GraphPane.XAxis.Scale.Max = list[list.Count - 1].X;
                zedGraphControlGSR.GraphPane.XAxis.Scale.Min = list[list.Count - 1].X - width;
                zedGraphControlGSR.AxisChange();
            }
            if (this.dataST.Count > 32)
            {
                LineItem curve = zedGraphControlST.GraphPane.CurveList[0] as LineItem;
                IPointListEdit list = curve.Points as IPointListEdit;

                for (int i = 0; i <= numberOfPoints; i++)
                {
                    list.Add(this.dataST[0].X, this.dataST[0].Y);
                    this.dataST.RemoveAt(0);
                }
                zedGraphControlST.Invalidate();

                double maxX = list[list.Count - 1].X;
                zedGraphControlST.ScrollMaxX = maxX;

                double width = zedGraphControlST.GraphPane.XAxis.Scale.Max - zedGraphControlST.GraphPane.XAxis.Scale.Min;
                zedGraphControlST.GraphPane.XAxis.Scale.Max = list[list.Count - 1].X;
                zedGraphControlST.GraphPane.XAxis.Scale.Min = list[list.Count - 1].X - width;
                zedGraphControlST.AxisChange();
            }
            if (this.dataRESP.Count > 32)
            {
                LineItem curve = zedGraphControlRESP.GraphPane.CurveList[0] as LineItem;
                IPointListEdit list = curve.Points as IPointListEdit;

                for (int i = 0; i <= numberOfPoints; i++)
                {
                    list.Add(this.dataRESP[0].X, this.dataRESP[0].Y);
                    this.dataRESP.RemoveAt(0);
                }
                zedGraphControlRESP.Invalidate();

                double maxX = list[list.Count - 1].X;
                zedGraphControlRESP.ScrollMaxX = maxX;

                double width = zedGraphControlRESP.GraphPane.XAxis.Scale.Max - zedGraphControlRESP.GraphPane.XAxis.Scale.Min;
                zedGraphControlRESP.GraphPane.XAxis.Scale.Max = list[list.Count - 1].X;
                zedGraphControlRESP.GraphPane.XAxis.Scale.Min = list[list.Count - 1].X - width;
                zedGraphControlRESP.AxisChange();
            }
            this.iteration++;
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
            if (e.KeyValue == ' ' && zedGraphControlHR.GraphPane.CurveList.Count==1 || e.KeyValue == ' ' && zedGraphControlHR.GraphPane.CurveList.Count==2)
             {
                GraphPane myPaneHR = zedGraphControlHR.GraphPane;
                GraphPane myPaneBR = zedGraphControlBR.GraphPane;
                GraphPane myPaneEKG = zedGraphControlEKG.GraphPane;
                GraphPane myPaneST = zedGraphControlST.GraphPane;
                GraphPane myPaneRESP = zedGraphControlRESP.GraphPane;
                GraphPane myPaneGSR = zedGraphControlGSR.GraphPane;
                GraphPane myPaneEMG = zedGraphControlEMG.GraphPane;

                double time = stopwatch.Elapsed.TotalSeconds;

                LineItem line = new LineItem(String.Empty, new[] { time, time },
                                new[] { (double)-99999, (double)99999 },
                                Color.Red, SymbolType.None);
                line.Line.Width = 5;
                line.IsVisible = false;

                myPaneHR.CurveList.Add(line);
                myPaneBR.CurveList.Add(line);
                myPaneEKG.CurveList.Add(line);
                myPaneEMG.CurveList.Add(line);
                myPaneST.CurveList.Add(line);
                myPaneRESP.CurveList.Add(line);
                myPaneGSR.CurveList.Add(line);

                this.recording = !this.recording;
                this.timeStartRecording = time;
            }
        }

        private void buttonSimStop_Click(object sender, EventArgs e)
        {
            this.stopped = true;
            timerLong.Stop();
            stopwatch.Stop();

            GraphPane myPaneHR = zedGraphControlHR.GraphPane;
            GraphPane myPaneBR = zedGraphControlBR.GraphPane;
            GraphPane myPaneEKG = zedGraphControlEKG.GraphPane;
            GraphPane myPaneST = zedGraphControlST.GraphPane;
            GraphPane myPaneRESP = zedGraphControlRESP.GraphPane;
            GraphPane myPaneGSR = zedGraphControlGSR.GraphPane;
            GraphPane myPaneEMG = zedGraphControlEMG.GraphPane;

            if (myPaneHR.CurveList.Count > 1)
            {
                myPaneHR.CurveList[1].IsVisible = true;
                myPaneBR.CurveList[1].IsVisible = true;
                myPaneEKG.CurveList[1].IsVisible = true;
                myPaneST.CurveList[1].IsVisible = true;
                myPaneRESP.CurveList[1].IsVisible = true;
                myPaneGSR.CurveList[1].IsVisible = true;
                myPaneEMG.CurveList[1].IsVisible = true;
            }
            if (myPaneHR.CurveList.Count == 3)
            {
                myPaneHR.CurveList[2].IsVisible = true;
                myPaneBR.CurveList[2].IsVisible = true;
                myPaneEKG.CurveList[2].IsVisible = true;
                myPaneST.CurveList[2].IsVisible = true;
                myPaneRESP.CurveList[2].IsVisible = true;
                myPaneGSR.CurveList[2].IsVisible = true;
                myPaneEMG.CurveList[2].IsVisible = true;
            }

            zedGraphControlEKG.Invalidate();
            zedGraphControlST.Invalidate();
            zedGraphControlRESP.Invalidate();
            zedGraphControlGSR.Invalidate();
            zedGraphControlEMG.Invalidate();
        }
    }
}
