using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiveChartDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cartesianChart1.Series = new SeriesCollection
            {
                
                new LineSeries
                {
                    Values=new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(1,1),
                        new ObservablePoint(4,7),
                        new ObservablePoint(5,3),
                        new ObservablePoint(7,6),
                        new ObservablePoint(10,8),
                        new ObservablePoint(12,1)
                    },
                    PointGeometrySize=15
                },
                new LineSeries
                {
                    Values=new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(1,1),
                        new ObservablePoint(0,7),
                        new ObservablePoint(5,3),
                        new ObservablePoint(1,6),
                        new ObservablePoint(2,8),
                        new ObservablePoint(9,1)
                    },
                    PointGeometrySize=15
                }
            };
        }
    }
}
