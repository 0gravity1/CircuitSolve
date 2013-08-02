using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace CircuitSolver
{
    public class Resistor
    {
        static private Point startingPoint;
        static Pen defaultPen;
        private Point[] points;

        public Resistor()
        {
            startingPoint.X = 100;
            startingPoint.Y = 100;

            defaultPen = new Pen(Color.Gray, 2.0F);

            points = new Point[] {
                new Point( 10,  10),
                new Point( 10, 100),
                new Point(200,  50),
                new Point(250, 300) 
            };
           
        }

        public Point[] Draw()
        {
            //mSymbol.moveTo(0.0F, 0.0F);
            //mSymbol.lineTo(0.0F, 50.0F);
            //mSymbol.lineTo(16.666666F, 58.333332F);
            //mSymbol.lineTo(-16.666666F, 75.0F);
            //mSymbol.lineTo(16.666666F, 91.666664F);
            //mSymbol.lineTo(-16.666666F, 108.33333F);
            //mSymbol.lineTo(16.666666F, 124.99999F);
            //mSymbol.lineTo(-16.666666F, 141.66666F);
            //mSymbol.lineTo(0.0F, 150.0F);
            //mSymbol.lineTo(0.0F, 200.0F);
            //mSymbol.offset(20, 10);

            return points;            
        }
    }
}
