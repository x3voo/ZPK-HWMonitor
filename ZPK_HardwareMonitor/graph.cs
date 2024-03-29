﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ZPK_HardwareMonitor
{
    public partial class Graph : UserControl
    {
        // Zdefiniowanie zmiennych prywatnych
        private Color _pointColor;
        private Color _bgColor;
        private Color _borderColor;

        private Graphics _graphics;
        private Graphics _graphicsBuffer;
        private Bitmap _bitmapBuffer;

        public Graph()
        {
            InitializeComponent();

            // Inicjalizacja zmiennych prywatnych
            _pointColor = Color.Black;
            _bgColor = Color.White;
            _borderColor = Color.Black;

            InitializeGraphicsBuffer();
        }

        private void InitializeGraphicsBuffer()
        {
            _graphics = this.CreateGraphics();
            _graphics.Clear(_bgColor);
            _bitmapBuffer = new Bitmap(this.Width, this.Height);
            _graphicsBuffer = Graphics.FromImage(_bitmapBuffer);
        }

        // [Niefunkcjonalny] Zmiana koloru próbek
        public void SetPointColor(Color kolorProbek)
        {
            _pointColor = kolorProbek;
        }

        // [Niefunkcjonalny] Zmiana koloru tła
        public void SetBackgroundColor(Color kolorTla)
        {
            _bgColor = kolorTla;
        }

        // [Niefunkcjonalny] Zmiana koloru ramki
        public void SetBorderColor(Color kolorRamki)
        {
            _borderColor = kolorRamki;
        }

        // [Funkcjonalny] Rysowanie wykresu
        public void DrawGraph(List<Double> data, String type, UInt64 numMax = 0)
        {
            Point a = new Point();
            Point b = new Point();

            // "normalizacja" wykresu
            List<Int32> normalizedData = NormalizeDataPoints(data, type, numMax); //~0ms

            // Rysowanie tła
            _graphicsBuffer.Clear(_bgColor);

            // Rysowanie próbek
            for (Int32 i = 0; i <= 99; i++)
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

                _graphicsBuffer.DrawLine(new Pen(_pointColor), a, b);
            }

            // Rysowanie ramki
            _graphicsBuffer.DrawLine(new Pen(_borderColor, 1), new Point(0, 0), new Point(200, 0));
            _graphicsBuffer.DrawLine(new Pen(_borderColor, 1), new Point(200, 0), new Point(200, 50));

            _graphicsBuffer.DrawLine(new Pen(_borderColor, 1), new Point(0, 0), new Point(0, 50));
            _graphicsBuffer.DrawLine(new Pen(_borderColor, 1), new Point(0, 50), new Point(200, 50));

            _graphics.DrawImage(_bitmapBuffer, 0, 0);
        }

        private List<int> NormalizeDataPoints(List<Double> data, String type, UInt64 numMax = 0)
        {
            // range 0 - 50
            Double max = 0;
            List<Int32> newPoints = new List<Int32>();
            Double point;

            switch (type)
            {
                case "percentage":
                    max = 100;
                    break;
                case "number":
                    max = numMax;
                    break;
                default:
                    max = 100;
                    break;
            }

            for (Int32 i = 0; i <= data.Count - 1; i++)
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
