using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioShape
{
    public class Shape
    {
        public string color { get; set; }
        public bool filled;

        public Shape()
        {
            color = "Red";
            filled = true;
        }
        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }   
        public bool isFilled(bool v)
        {
            return this.filled;
        }
        public override string ToString()
        {
            return $"Forma: Color: {color} Esta llenado?: {filled}";
        }
    }
}
