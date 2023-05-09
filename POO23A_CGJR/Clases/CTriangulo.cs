using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_CGJR
{
    //Clase que representa una figura.
    //CGJR. 14/marzo/23

    public class CTriangulo : CPoligono
    {
        //Atributos
        protected double Base, Altura;
        //Constructor
        public CTriangulo(Color Color, string Nombre, double Base, double Altura) : base(Color, Nombre)
        {
            this.Base = Base;
            this.Altura = Altura;
            NumLados = 3;
        }

        //Obtiene el área del triángulo.
        public override void CalculaArea()
        {
            base.CalculaArea();

            Area = Base * Altura / 2;
        }
    }
       
}
