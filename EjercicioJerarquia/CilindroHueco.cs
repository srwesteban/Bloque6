using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioJerarquia
{
    public class CilindroHueco : Cilindro
    {

        public double hueco { get; set; }

        public CilindroHueco()
        {

        }
        public void Leer(double radio, double altura,double hueco)
        {
            this.radio = radio;
            this.altura = altura;
            this.hueco = hueco;
        }
        new public double Area()
        {

            return 2 * Math.PI * radio * altura + 2 * Math.PI * Math.Pow(radio, 2);

        }
        new public double Circunferencia()
        {
            return 2 * Math.PI * (Math.Pow(radio,2) - Math.Pow(hueco,2)) + 2*Math.PI* radio*altura + 2*Math.PI *altura;
        }
        new public double volumen()
        {
            return Math.PI * (Math.Pow(radio, 2) - Math.Pow(hueco,2)) * altura;
        }
        public override string ToString()
        {
            return $"El area del cilindro Hueco es: {Area()} " +
                $"el volumen es: {volumen()} " +
                $"y la circunferencia es: {Circunferencia()}";
        }
    }
}