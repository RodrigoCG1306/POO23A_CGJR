using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_CGJR
{
    //Clase que representa una figura.
    //CGJR. 14/marzo/23
    public class CPoligono : CFiguraGeometrica
    {
        //Atributos
        protected int NumLados;

        //Constructor
        public CPoligono(Color Color, string Nombre) : base(Color, Nombre)
        {

        }
    }
}
