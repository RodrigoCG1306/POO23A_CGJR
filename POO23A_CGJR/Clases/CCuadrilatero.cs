using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_CGJR
{
    //Clase que representa una figura de 4 lados.
    //CGJR. 14/marzo/23
    public class CCuadrilatero : CPoligono
    {
        //Atributos
        private double Lado1, Lado2;

        //CCosntructor
        public CCuadrilatero(Color Color, string Nombre, double Lado1, double Lado2) : base(Color, Nombre)
        {
            this.Lado1 = Lado1;
            this.Lado2 = Lado2;

            NumLados = 4;
        }

        //Calcula el área del cuadrilatero
        public double CalculaAreaOriginal()
        {
            Area = Lado1 * Lado2;
            AreaCalculada = true;

            return Area;
        }       

        //Asigna el valor de los lados del cuadrilatero
        public void SetLado(double Lado1, double Lado2)
        {
            this.Lado1 = Lado1;
            this.Lado2 = Lado2;
        }

        //Obtiene el área del cuadrilatero.
        public override void CalculaArea()
        {
            base.CalculaArea();

            Area = Lado1 * Lado1;
        }

    }
}
