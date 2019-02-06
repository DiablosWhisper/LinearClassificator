using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace LinearClassificator
{
    public partial class Form1 : Form
    {
        private void DrawPoints_Click(object sender, EventArgs e)
        {
            Graphics Line = Box.CreateGraphics();

            foreach(Point Point in Points)
            {
                Point.Draw();
            }

            Line.DrawLine(new Pen(Color.Black), 0, 0, Box.Width, Box.Height);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LinearClassificator = new Perceptron(2);

            Points = new Point[200];

            for (int Index = 0; Index < Points.Length; Index++)
            {
                Points[Index] = new Point(Box);

                Thread.Sleep(100);
            }
        }
        private void Train_Click(object sender, EventArgs e)
        {
            foreach (Point Point in Points)
            {
                double[] Inputs = { Point.CoordinateX, Point.CoordinateY };

                LinearClassificator.Train(Inputs, Point.Target);

                if(LinearClassificator.MakeDesicion(Inputs).Equals(Point.Target))
                {
                    Point.Draw(Color.Green, Point.CoordinateX + 7, Point.CoordinateY + 7, 6, 3);
                }
                else
                {
                    Point.Draw(Color.Red, Point.CoordinateX + 7, Point.CoordinateY + 7, 6, 3);
                }

                Thread.Sleep(100);
            }
        }
        private Perceptron LinearClassificator { get; set; }
        private Point[] Points { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
    }

    public class Perceptron
    {
        public void Train(double[] Inputs, int Target)
        {
            int Error = Target - MakeDesicion(Inputs);

            for(int Index = 0; Index < Inputs.Length; Index++)
            {
                Weights[Index] += Inputs[Index] * Error * LearningRate;
            }
        }
        public int MakeDesicion(double[] Inputs)
        {
            double GlobalSum = 0;

            for (int Index = 0; Index < Inputs.Length; Index++)
            {
                GlobalSum += Inputs[Index] * Weights[Index];
            }

            return Math.Sign(GlobalSum);
        }
        public double[] Weights { get; private set; }
        public Perceptron(int NumberOfInputs)
        {
            LearningRate = 0.1;

            Randomizer = new Random();

            Weights = new double[NumberOfInputs];

            for (int Index = 0; Index < Weights.Length; Index++)
            {
                Weights[Index] = Randomizer.NextDouble() - Randomizer.NextDouble();
            }
        }
        private Random Randomizer { get; set; }
        public double LearningRate { get; set; }
    }

    public class Point
    {
        public void Draw(Color Color, int CoordinateX, int CoordinateY, int Size, int Thickness)
        {
            Shape.DrawEllipse(new Pen(Color, Thickness), CoordinateX, CoordinateY, Size, Size);
        }
        public int CoordinateY { get; private set; }
        public int CoordinateX { get; private set; }
        private Random Randomizer { get; set; }
        public int Target { get; private set; }
        private Graphics Shape { get; set; }
        private PictureBox Box { get; set; }
        public Point(PictureBox Box)
        {
            Randomizer = new Random();

            CoordinateX = Randomizer.Next(0, Box.Width);

            CoordinateY = Randomizer.Next(0, Box.Height);

            this.Box = Box;
        }
        public void Draw()
        {
            Shape = Box.CreateGraphics();

            Shape.SmoothingMode = SmoothingMode.HighQuality;

            if (CoordinateX > CoordinateY)
            {
                Shape.DrawEllipse(new Pen(Color.Blue), CoordinateX, CoordinateY, 20, 20);

                Target = 1;
            }
            else
            {
                Shape.DrawEllipse(new Pen(Color.Red), CoordinateX, CoordinateY, 20, 20);

                Target = -1;
            }
        }
    }
}
