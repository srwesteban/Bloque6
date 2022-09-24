using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioShape
{
    public class Circulo: Shape
    {
        private double radius { get; set; }

        public Circulo()
        {
            radius = 1.0;
        }
        public Circulo(double radius)
        {
            this.radius = radius;
        }
        public Circulo(double radius,string color,bool filled):base(color,filled)
        {
            this.radius=radius;
            this.color = color;
            this.filled = filled;
        }
        public double area()
        {
            return Math.PI * Math.Pow(radius,2);
        }
        public override string ToString()
        {
            return $"Forma: Circulo, color:  {color}, llenado: {filled}, radio: {radius} area: {area()} ";
        }
    }
}
