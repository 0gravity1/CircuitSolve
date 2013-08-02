using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CircuitSolver
{
    public partial class Form1 : Form
    {
        static float lineWidth = 2.0F;
        static float backgroundLineWidth = 2.0F;
        static Pen pen = new Pen(Color.Yellow, lineWidth);
        static Pen backgroundPen = new Pen(Color.LightGray, backgroundLineWidth);
        private bool drawBackground = true;
        private List<Resistor> resistors = new List<Resistor>();
        private Point[] resistorPoints;        

        public Form1()
        {
            InitializeComponent();
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = canvas.CreateGraphics();           

            if (drawBackground)
            {
                Console.WriteLine("Drawing background...");
                draw_Background(g, backgroundPen);
            }

            if (resistors != null)
            {
                foreach (Resistor r in resistors)
                {
                    resistorPoints = r.Draw();                                        
                }
            }            

            //Point one = new Point(0, 0);
            //Point two = new Point(200, 200);
            g.DrawLine(pen, 0, 0, 100, 100);
        }

        private void draw_Background(Graphics g, Pen pen)
        {            
            for (int i = 0; i < canvas.Width; i += 10)
            {
                g.DrawLine(pen, new Point(i, 0), new Point(i, canvas.Height));          
            }
            for (int j = 0; j < canvas.Height; j += 10)
            {
                g.DrawLine(pen, new Point(0, j), new Point(canvas.Width, j));
            }

            drawBackground = false;
        }

        private void addResistor_Click(object sender, EventArgs e)
        {
            resistors.Add(new Resistor());
            Console.WriteLine("Added a Resistor...");            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
