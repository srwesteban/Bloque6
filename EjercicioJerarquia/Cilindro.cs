using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJerarquia
{
    public class Cilindro:Circulo
    {
        public double altura { get; set; }
        public Cilindro()
        {

        }
        public void Leer(double radio,double altura)
        {
            this.radio = radio;
            this.altura = altura;
        }
        new public double Area()
        {

            return 2 * Math.PI * radio * altura + 2 * Math.PI * Math.Pow(radio, 2);

        }
        new public double Circunferencia()
        {
            return 2 * Math.PI * radio;
        }
        public double volumen()
        {
            return Math.PI * Math.Pow(radio,2) * altura;
        }
        public override string ToString()
        {
            return $"El area del cilindro es: {Area()} el volumen es: {volumen()} " +
                $"y la circunferencia es: {Circunferencia()}";
        }

    }
}
