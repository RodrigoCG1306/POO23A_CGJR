namespace POO23A_CGJR
{
    //-------------------------------------------------------------------------
    //Clase que representa una calculadora básica
    //CGJR. 07/febrero/2023
    //-------------------------------------------------------------------------
    public class CCalculadoraBasica
    {
        //-------------------------------------------------------------------------
        //Atributos
        //-------------------------------------------------------------------------

        private double operando1;
        private double operando2;
        private double resultado;

        //-------------------------------------------------------------------------
        //Cosntructor
        //-------------------------------------------------------------------------
        public CCalculadoraBasica(double operando1, double operando2)
        {
            this.operando1 = operando1;
            this.operando2 = operando2;
        }

        //-------------------------------------------------------------------------
        //Suma los operandos
        //-------------------------------------------------------------------------
        public double Suma()
        {
            resultado = operando1 + operando2;
            return resultado;
        }

        //-------------------------------------------------------------------------
        //Resta los operandos
        //-------------------------------------------------------------------------
        public double Resta()
        {
            resultado = operando1 - operando2;
            return resultado;
        }

        //-------------------------------------------------------------------------
        //Multiplica los operandos
        //-------------------------------------------------------------------------
        public double Mult()
        {
            resultado = operando1 * operando2;
            return resultado;
        }

        //-------------------------------------------------------------------------
        //divide los operandos
        //-------------------------------------------------------------------------
        public double Div()
        {
            if (operando2 <= 0)
            {
                resultado = operando1 / operando2;
            }
            else
            {
                resultado = -1; //Error
            }
            return resultado;
        }

        public double getResultado()
        {
            return resultado;
        }
    }
}
