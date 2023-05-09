using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_CGJR
{
    //-------------------------------------------------------------------------
    //Dialogo de la práctica 1
    //CAGR. 21/febrero/23
    //-------------------------------------------------------------------------
    public class CTeclado
    {
        //Atributos
        private int TipoDeTeclado; //1.- Mécanico, 2.- Membrana, 3.- Ergonómico
        private int TipoSwitches; //En caso de Mécanico: 1.- Red, 2.- Blue, 3.- Brown
        private int Conexion; //1.- Alámbrico, 2.- Inalámbrico, 3.- Híbrido
        private int Compatibilidad; //1.- Windows, 2.- Mac, 3.- Linux
        private char[] CColor;
        private int Tamaño; //1.- 60%, 2.- 85%, 3.- 100%
        private int Inclinacion; //1.- 33°, 2.- 40°, 3.- 45°
        private int Distribuicion; //1.- Lat, 2.- USA, 3.- EUR

        private int Error; //0.- No hay error, 1.- Falla de conexión, 2.- Baja batería, 3.- Falla del sistema, 4.- Falla switch.

        //Constructor
        public CTeclado(int TipoDeTeclado, int Tamaño, int Distribuicion)
        {
            //Recibe atributos
            this.TipoDeTeclado = TipoDeTeclado;
            this.Tamaño = Tamaño;
            this.Distribuicion = Distribuicion;

            //Inicializa objetos
            CColor = new char[6];

            //Inicializa Atributos
            Conexion = 1;
            TipoSwitches = 1;
            CColor[0] = '0';
            Compatibilidad = 1;
            Inclinacion = 2;
        }

        //Encender el teclado (Puede ser por switch o conexión)
        public int Encender()
        {
            return 0;
        }

        //Obtener último error
        public int GetError()
        {
            return 0;
        }
    }
}
