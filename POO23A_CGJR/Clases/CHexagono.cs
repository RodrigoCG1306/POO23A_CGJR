using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_CGJR
{
    //Clase que representa una figura.
    //CGJR. 14/marzo/23
    public class CHexagono : CPoligono
    {
        //Atributos

        //Constructor
        public CHexagono() : base(Color.Black, "Hexagono")
        {
            NumLados = 6;
        }
    }
}
