using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Circulo
    {

        public double radio { get; set; }
        public string color { get; set; }

        public Circulo()
        {
            radio = 1.0;
            color = "Red";
        }
        public Circulo(double radio)
        {
            this.radio = radio;
            this.color = "Red";
        }
        public Circulo(double radio, string color)
        {
            this.radio = radio;
            this.color = color;
        }
        public double getArea()
        {
            return Math.PI*Math.Pow(radio,2);
        }
        public override string ToString()
        {
            return $"El area del circulo es de {getArea()} y es de color {color}";
        }

    }
}
