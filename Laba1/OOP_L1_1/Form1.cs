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
            FiguresList.Add(new Line(new Pen(Color.Blue, 6), new Point(10, 10), new Point(10, 100)));
            FiguresList.Add(new Line(new Pen(Color.Blue, 4), new Point(10, 10), new Point(100, 100)));
            FiguresList.Add(new Line(new Pen(Color.Black, 5), new Point(100, 100), new Point(200, 100)));
            FiguresList.Add(new Line(new Pen(Color.Green, 15), new Point(100, 100), new Point(200, 140)));
            FiguresList.Add(new Line(new Pen(Color.Green, 15), new Point(100, 100), new Point(200, 240)));
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
