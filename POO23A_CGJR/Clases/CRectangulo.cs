using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_CGJR
{
    //Clase que representa una figura.
    //CGJR. 14/marzo/23

    public class CRectangulo : CCuadrilatero
    {
        //Atributos

        //Cosntructor
        public CRectangulo(Color Color, double Lado1, double Lado2) : base(Color, "Rectangulo", Lado1, Lado2)
        {

        }
    }
}
