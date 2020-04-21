using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_L1_1
{
    public partial class Form1 : Form
    {
        Graphics GraphicImage;
        private readonly List<Shape> FiguresList =new List<Shape>();
        private readonly Dictionary<String, Shape> ShapesDictionary = new Dictionary<String, Shape>();
        Pen PenColor = new Pen(Color.Black, 7);
        int Thickness;
        Color ShapeColor = Color.Black;
        Point FirstPoint, SecondPoint;
        String Key = "Line";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicImage = pBoxDrawing.CreateGraphics();
            FiguresList.Add(new Line(new Pen(Color.Blue, 5), new Point(10, 10), new Point(10, 140)));
            FiguresList.Add(new Circle(new Pen(Color.Blue, 5), new Point(30, 10), new Point(130, 80)));
            FiguresList.Add(new Ellipse(new Pen(Color.Blue, 6), new Point(150, 10), new Point(250, 70)));
            FiguresList.Add(new Rectangle(new Pen(Color.Blue, 6), new Point(270, 10), new Point(390, 70)));
            FiguresList.Add(new Square(new Pen(Color.Blue, 6), new Point(400, 10), new Point(520, 70)));
            FiguresList.Add(new Triangle(new Pen(Color.Blue, 6), new Point(530, 10), new Point(650, 130)));
            ShapesDictionary.Add("Line", new Line(PenColor, FirstPoint, SecondPoint));
            ShapesDictionary.Add("Circle", new Circle(PenColor, FirstPoint, SecondPoint));
            ShapesDictionary.Add("Ellipse", new Ellipse(PenColor, FirstPoint, SecondPoint));
            ShapesDictionary.Add("Rectangle", new Rectangle(PenColor, FirstPoint, SecondPoint));
            ShapesDictionary.Add("Square", new Square(PenColor, FirstPoint, SecondPoint));
            ShapesDictionary.Add("Triangle", new Triangle(PenColor, FirstPoint, SecondPoint));
        }
  
        private void BtnDraw_Click(object sender, EventArgs e)
        {
            foreach (Shape Figure in FiguresList)
            {
                Figure.Draw(GraphicImage);
            }
        }

        private void pBoxColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) 
            {
                pBoxColor.BackColor = colorDialog1.Color;
                PenColor.Color = colorDialog1.Color;
            }
        }

        private void pBoxDrawing_MouseDown(object sender, MouseEventArgs e)
        {
            FirstPoint.X = e.X;
            FirstPoint.Y = e.Y;
        }

        private void pBoxDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            SecondPoint.X = e.X;
            SecondPoint.Y = e.Y;
            Shape NewShape = ShapesDictionary[Key];
            NewShape.FirstPoint = FirstPoint;
            NewShape.SecondPoint = SecondPoint;
            NewShape.PenColor = PenColor;
            NewShape.Draw(GraphicImage);
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            Key = "Line";
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            Key = "Circle";
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            Key = "Ellipse";
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            Key = "Rectangle";
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            Key = "Square";
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            Key = "Triangle";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            GraphicImage.Clear(Color.WhiteSmoke);
        }

        private void trackBarThickness_ValueChanged(object sender, EventArgs e)
        {
            Thickness = trackBarThickness.Value;
            PenColor.Width = Thickness;
            labelThickness.Text = "Толщина кисти = " + Thickness.ToString();
        }
    }
}
