using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_CGJR
{
    //-----------------------------
    //Clase que representa un zombie romero
    //CGJR 09/05/23
    //-----------------------------


    public class CZombiRomero : CZombie
    {
        //Atributos

        //Constructor
        public CZombiRomero(Control AreaDesplazamiento) : base (AreaDesplazamiento)
        {
            Velocidad = 1;
        }

        //--------------
        // Colorea el zombi romero al momento de nacer
        //--------------

        protected override Color ColorNacimiento()
        {
            /* Aleatorio = new Random();

            R = Aleatorio.Next(1, 255);
            G = Aleatorio.Next(1, 255);
            B = Aleatorio.Next(1, 255); */

            return Color.FromArgb(255, 0, 0);
        }
    }
}
