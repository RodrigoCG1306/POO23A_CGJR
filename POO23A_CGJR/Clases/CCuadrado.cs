using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_CGJR
{
    //Clase que representa una cuadrado.
    //CGJR. 14/marzo/23
    public class CCuadrado : CCuadrilatero
    {
        //Atributos

        //Constructor
        public CCuadrado(Color Color, double Lado) : base(Color, "Cuadrado", Lado, Lado)
        {
            
        }
    }
}
