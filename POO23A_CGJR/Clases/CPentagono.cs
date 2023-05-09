using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_CGJR
{
    //Clase que representa una figura.
    //CGJR. 14/marzo/23

    public class CPentagono : CPoligono
    {
        //Atributos

        //Constructor
        public CPentagono() : base(Color.Black, "Pentagono")
        {
            NumLados = 5;
        }
    }
}
