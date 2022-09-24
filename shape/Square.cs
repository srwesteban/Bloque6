using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioShape
{
    public class Square:Rectangle
    {
        private double side { get; set; }
        public Square()
        {
            this.side = 4;
        }
        public Square(double side)
        {
            this.side = 4;
        }
        public Square(double side,double width,double length,string color,bool filled):base(width,length,color,filled)
        {
            this.side = 4;
            this.width = width;
            this.length = width;
            this.color = color;
            this.filled = filled;
        }
        public override string ToString()
        {
            return $"Forma: Cuadrado, color: {color}, lleno: {filled}, ancho: {width} largo: {length} lados: {side}";
        }


    }
}
