using POO23A_CGJR.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_CGJR
{
    
    //Clase que representa una figura.
    //CGJR. 14/marzo/23
     
    public class CFiguraGeometrica : CFigura
    {
        //Atributos
        protected double Area;
        protected bool AreaCalculada;
        //Constructor
        public CFiguraGeometrica(Color Color, string Nombre) : base(Color, Nombre)
        {
            Area = 0;
            AreaCalculada = false;
        }

        //Obtiene el área de una figura geométrica
        public double GetArea()
        {
            //NOTA: Regresará -1 en caso de no haber sido calculado.
            //De lo contrario regresará el área de la figura.
            if (AreaCalculada)
            {
                return Area;
            }
            else
            {
                return -1;
            }
        }

        //Obtiene el área de la figura geométrica.
        public virtual void CalculaArea()
        {
            AreaCalculada = true;
        }
    }
}
