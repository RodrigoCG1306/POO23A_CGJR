using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_CGJR.Clases
{
    //Clase que representa una figura.
    //CGJR. 14/marzo/23   
    public class CFigura : Object
    {
        //Atributos
        private string Nombre;
        private Color Color;

        //Constructor
        public CFigura(Color Color, string Nombre)
        {
            this.Color = Color;
            this.Nombre = Nombre;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        //Dibuja una figura
        public void Dibuja()
        {

        }
    }
}
