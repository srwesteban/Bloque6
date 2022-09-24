using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioShape
{
    public class Rectangle:Shape
    {
        public double width { get; set; }
        public double length { get; set; }

        public Rectangle()
        {
            width = 1.0;
            length = 1.0;
        }
        public Rectangle(double width, double length)
        {
            this.width = width;
            this.length = length;
        }
        public Rectangle(double width, double length,string color,bool filled) : base(color,filled)
        {
            this.width=width;
            this.length=length; 
            this.filled=filled;
            this.color=color;
        }
        public double area()
        {
            return width * length;
        }
        public double perimeter()
        {
            return  (2 * length) + (2 * width);
        }
        public override string ToString()
        {
            return $"Forma: Rectangulo, color: {color}, llenado {filled}," +
                $" ancho {width}, Largo: {length}, area: {area()}, perimetro: {perimeter()} ";
        }
    }
}
