using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Cilindro:Circulo
    {
        public double height { get; set; }

        public Cilindro():base()
        {

        }
        public Cilindro(double radio):base(radio)
        {
            this.radio = radio;
            this.height = 1.0;

        }
        public Cilindro(double radio, double height) : base(radio)
        {
            this.radio = radio;
            this.height = height;
        }
        public Cilindro(double radio,string color,double height) : base(radio,color)
        {
            this.radio = radio;
            this.color = color;
            this.height = height;          

        }
        public double getVolumen()
        {
            return Math.PI*height*Math.Pow(radio,2);
        }
        public override string ToString()
        {
            return $"Volmen del cilindro {getVolumen()} color {color}";
        }
    }
}
