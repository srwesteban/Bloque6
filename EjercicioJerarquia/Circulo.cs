using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJerarquia
{
    public class Circulo
    {
        public double radio { get; set; }

        public Circulo()
        {

        }
        public void Leer(double radio)
        {
            this.radio = radio;
        }
        public double Area()
        {
            return Math.PI* Math.Pow(radio,2) ;

        }
        public double Circunferencia()
        {
            return 2 * Math.PI * radio;
        }
        public override string ToString()
        {
            return $"El area del circulo es: {Area()} y la circunferencia es: {Circunferencia()}";
        }
    }
}
