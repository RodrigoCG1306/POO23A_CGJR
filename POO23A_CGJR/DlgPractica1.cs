using System.Runtime.Intrinsics.X86;

namespace POO23A_CGJR
{
    //-------------------------------------------------------------------------
    //Dialogo de la práctica 1
    //CAGR. 07/febrero/23
    //-------------------------------------------------------------------------

    public partial class DlgPractica1 : Form
    {
        //-------------------------------------------------------------------------
        //Atributos
        //-------------------------------------------------------------------------

        //-------------------------------------------------------------------------
        //Constructor
        //-------------------------------------------------------------------------

        public DlgPractica1()
        {
            InitializeComponent();
        }

        //-------------------------------------------------------------------------
        //Crea un objeto calculadora para pruebas
        //-------------------------------------------------------------------------

        private void BtnCalculadora_Click(object sender, EventArgs e)
        {
            CCalculadoraBasica MiCalculadora1, MiCalculadora2, MiCalculadora3;

            // Se crean las calculadoras

            MiCalculadora1 = new CCalculadoraBasica(3, 4);
            MiCalculadora2 = new CCalculadoraBasica(5, 6);
            MiCalculadora3 = new CCalculadoraBasica(7, 8);

            // Se crea la lista
            List<CCalculadoraBasica> MiLista;
            MiLista = new List<CCalculadoraBasica>();

            //Se hace la operación
            MessageBox.Show(MiCalculadora1.Mult().ToString());
            MessageBox.Show(MiCalculadora2.Mult().ToString());
            MessageBox.Show(MiCalculadora3.Mult().ToString());

            //Se agregan a la lista
            MiLista.Add(MiCalculadora1);
            MiLista.Add(MiCalculadora2);
            MiLista.Add(MiCalculadora3);

            double sumatoria = 0;

            foreach(CCalculadoraBasica CalculadoraAux in MiLista)
            {
                sumatoria = sumatoria + CalculadoraAux.getResultado();
            }

            MessageBox.Show("El resultado de los resultados de las calculadoras es " + sumatoria);

        }

        private void Btn100Calc_Click(object sender, EventArgs e)
        {
            CCalculadoraBasica MiCalculadora;

            double Aux = 1, Resultado;

            List <CCalculadoraBasica> MiLista;
            MiLista = new List<CCalculadoraBasica>();
            
            // Se crean las 100 calculadoras
            for (int i = 0; i < 100; i++)
            {
                MiCalculadora = new CCalculadoraBasica(Aux, Aux + 1);

                Resultado = MiCalculadora.Mult();
                MiLista.Add(MiCalculadora);

                Aux = Aux + 2;
            }

            double sumatoria = 0;

            foreach (CCalculadoraBasica CalculadoraAux in MiLista)
            {
                sumatoria = sumatoria + CalculadoraAux.getResultado();
            }

            MessageBox.Show("El resultado de los resultados de las calculadoras es " + sumatoria);
        }

        private void BtnFigura_Click(object sender, EventArgs e)
        {
            int HashCode;
            double Resultado;
            string Nombre;
            string ResultadoMV;
            CTriangulo MiTriangulo;
            CCuadrado MiCuadrado;
            CRectangulo MiRectangulo;
            CPentagono MiPentagono;
            CHexagono MiHexagono;

            MiCuadrado = new CCuadrado(Color.Red, 10);
            MiCuadrado.CalculaArea();
            Nombre = MiCuadrado.GetNombre();
            Resultado = MiCuadrado.GetArea();
            MessageBox.Show("Hola, soy un " + Nombre +" y esta es mi áre " + Resultado.ToString());

            MiRectangulo = new CRectangulo(Color.Blue, 10, 20);
            MiRectangulo.CalculaArea();
            Nombre = MiRectangulo.GetNombre();
            Resultado = MiRectangulo.GetArea();
            MessageBox.Show("Hola, soy un "+ Nombre + " y esta es mi áre " + Resultado.ToString());

            MiTriangulo = new CTrianguloEscaleno(Color.Green, 30, 50);
            MiTriangulo.CalculaArea();
            Nombre = MiTriangulo.GetNombre();
            Resultado = MiTriangulo.GetArea();
            MessageBox.Show("Hola, soy un " + Nombre + " y esta es mi áre " + Resultado);

            MiTriangulo = new CTrianguloIsoceles(Color.Green, 60, 75);
            MiTriangulo.CalculaArea();
            Nombre = MiTriangulo.GetNombre();
            Resultado = MiTriangulo.GetArea();
            MessageBox.Show("Hola, soy un " + Nombre + " y esta es mi áre " + Resultado);

            MiTriangulo = new CTrianguloEquilatero(Color.White, 400, 230);
            MiTriangulo.CalculaArea();
            Nombre = MiTriangulo.GetNombre();
            Resultado = MiTriangulo.GetArea();
            MessageBox.Show("Hola, soy un " + Nombre + " y esta es mi áre " + Resultado);


            /* MiTriangulo = new CTriangulo();
             HashCode = MiTriangulo.GetHashCode();
             MessageBox.Show("El codigo hash del Triangulo es " + HashCode.ToString());

             MiCuadrado = new CCuadrado(5);
             MiCuadrado.CalculaArea();
             MessageBox.Show("El codigo hash del Cuadrado es " + HashCode.ToString());

             MiRectangulo = new CRectangulo(3, 6);
             MiRectangulo.CalculaArea();
             MessageBox.Show("El codigo hash del Rectangulo es " + HashCode.ToString());

             MiPentagono = new CPentagono();
             HashCode = MiPentagono.GetHashCode();
             MessageBox.Show("El codigo hash del Pentagono es " + HashCode.ToString());

             MiHexagono = new CHexagono();
             HashCode = MiHexagono.GetHashCode();
             MessageBox.Show("El codigo hash del Hexagono es " + HashCode.ToString());
            */

            //Método Virtual
            /* Resultado = MiCuadrado.CalculaArea();
             MessageBox.Show("Cuadrado " + Resultado);

             Resultado = MiRectangulo.CalculaArea();
             MessageBox.Show("Rectangulo " + Resultado);*/

        }
    }
}
