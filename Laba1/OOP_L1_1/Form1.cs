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
        Graphics graphic;
        private readonly List<Shape> FiguresList =new List<Shape>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            graphic = pBoxDrawing.CreateGraphics();
            FiguresList.Add(new Line(new Pen(Color.Blue, 5), new Point(10, 10), new Point(10, 140)));
            FiguresList.Add(new Circle(new Pen(Color.Blue, 5), new Point(30, 10), new Point(130, 80)));
            FiguresList.Add(new Ellipse(new Pen(Color.Blue, 6), new Point(150, 10), new Point(250, 70)));
            FiguresList.Add(new Rectangle(new Pen(Color.Blue, 6), new Point(270, 10), new Point(390, 70)));
            FiguresList.Add(new Square(new Pen(Color.Blue, 6), new Point(400, 10), new Point(520, 70)));
            FiguresList.Add(new Triangle(new Pen(Color.Blue, 6), new Point(530, 10), new Point(650, 130)));
        }
  
        private void BtnDraw_Click(object sender, EventArgs e)
        {
            foreach (Shape Figure in FiguresList)
            {
                Figure.Draw(graphic);
            }
        }      
    }
}
