using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZPK_HardwareMonitor
{
    public partial class graph : UserControl
    {
        public graph()
        {
            InitializeComponent();
        }

        public void drawGraph(List<double> data, Color bgColor, Color borderColor, Color linesColor, String type, int ramTotal = 0)
        {
            //this.BackColor
            // DRAW BG
            this.CreateGraphics().Clear(bgColor);

            Point a = new Point(0, 0);
            Point b = new Point(100, 100);

            List<int> normalizedData = NormalizeDataPoints(data, type, ramTotal);

            // DRAW GRAPH LINES
            for (var i = 0; i <= 99; i++)
            {
                if (i >= (100 - data.Count))
                {
                    a = new Point(i * 2, 50 - normalizedData.ElementAt(i - 100 + data.Count));
                    b = new Point(i * 2, 50);
                }
                else
                {
                    a = new Point(i * 2, 51);
                    b = new Point(i * 2, 50);
                }

                this.CreateGraphics().DrawLine(new Pen(linesColor, 1), a, b);
            }

            // DRAW BORDER
            this.CreateGraphics().DrawLine(new Pen(borderColor, 1), new Point(0, 0), new Point(200, 0));
            this.CreateGraphics().DrawLine(new Pen(borderColor, 1), new Point(200, 0), new Point(200, 50));

            this.CreateGraphics().DrawLine(new Pen(borderColor, 1), new Point(0, 0), new Point(0, 50));
            this.CreateGraphics().DrawLine(new Pen(borderColor, 1), new Point(0, 50), new Point(200, 50));

            // 200 x 50
        }

        private List<int> NormalizeDataPoints(List<double> data, String type, int ramTotal = 0)
        {
            // range 0 - 50
            double max = 0;
            switch (type)
            {
                case "usage":
                    max = 100; // 100%
                    break;
                case "temp":
                    max = 100; // 100 C
                    break;
                case "ram":
                    max = ramTotal; //
                    break;
                default:
                    max = 100;
                    break;
            }

            List<int> newPoints = new List<int>();

            double point;

            for (var i = 0; i <= data.Count - 1; i++)
            {
                if (type == "ram")
                {
                    point = ((max - data.ElementAt(i)) * 50) / max;

                } else
                {
                    point = (data.ElementAt(i) * 50) / max;
                }
                
                newPoints.Add(Convert.ToInt32(point));
            }

            return newPoints;
        }
    }
}
