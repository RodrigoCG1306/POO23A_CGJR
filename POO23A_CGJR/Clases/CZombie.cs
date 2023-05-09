using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO23A_CGJR
{
    //Clase que representa a un zombie 
    //CAGR 02/05/2023
    public class CZombie : Button
    {
        //ATRIBUTOS

        //Atributos de naciminto 

        private int XNacimiento;
        private int YNacimiento;

        //Atributo de dezplazamiento 

        protected Control AreaDezplazamiento;
        private bool Norte;
        private bool Sur;
        private bool Este;
        private bool Oeste;
        private int Velocidad;

        //Atributos de control
        private bool Nacido;
        private bool Muerto;
        private bool RegresarACasa;

        //Atributos de ejecución
        Thread ProcesoVida;

        public CZombie(Control AreaDezplazamiento) : base()
        {
            Random Aleatorio;

            Aleatorio = new Random();
            XNacimiento = Aleatorio.Next(0, AreaDezplazamiento.Width - 41);
            YNacimiento = Aleatorio.Next(0, AreaDezplazamiento.Height - 41);

            //Inicia Atributos

            this.AreaDezplazamiento = AreaDezplazamiento;
            this.AreaDezplazamiento.Controls.Add(this);

            //Contruye Zombie

            Location = new Point(XNacimiento, YNacimiento);
            BackColor = Color.DarkOliveGreen;
            Name = "Zombie";
            Size = new Size(41, 41);
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            this.AreaDezplazamiento.Controls.Add(this);
            BringToFront();

            //Inicializa Atributos

            Nacido = false;
            Muerto = false;
            RegresarACasa = false;

            Norte = false;
            Sur = true;
            Este = true;
            Oeste = false;
            Velocidad = 0;

            ProcesoVida = null;

            //Método manejador del click
            Click += new EventHandler(Identificar);

        }

        public void Identificar(Object sender, EventArgs e)
        {
            MessageBox.Show(Name + " (" + XNacimiento + " , " + YNacimiento + ") Nacido = " + Nacido);
        }

        //--------------------------------
        // Desplaza a un zombie a una velocidad determinada
        //--------------------------------
        public void Desplazar(int velocidad)
        {
            int x, y;

            this.Velocidad = velocidad;
            //Desplaza el zombie por un tiempo indefinido.
            //NOTA: Se ejecuta un hilo de ejecución el cual deberá ser
            //finalizado al término del programa

            ProcesoVida = new Thread(() =>
            {
                while(!Muerto)
                {
                    if(Nacido)
                    {
                        //Posición inicial

                        x = Location.X;
                        y = Location.Y;

                        //Calcula Desplazamiento

                        if(Norte)
                        {
                            y = y - 1;
                        }
                        if (Sur)
                        {
                            y = y + 1;
                        }
                        if (Este)
                        {
                            x = x + 1;
                        }
                        if (Oeste)
                        {
                            x = x - 1;
                        }

                        //Procesa el rebote.

                        if(x <= 0)
                        {
                            Oeste = false;
                            Este = true;
                        }

                        if(x >= AreaDezplazamiento.Width - 82)
                        {
                            Este = false;
                            Oeste = true;
                        }

                        if(y <= 0)
                        {
                            Norte = false;
                            Sur = true;
                        }

                        if(y >= AreaDezplazamiento.Height - 82)
                        {
                            Sur = false;
                            Norte = true;
                        }

                        //Posición final
                        Location = new Point(x, y);
                        Thread.Sleep(this.Velocidad);
                    }
                }
            });

            ProcesoVida.Start();
        }

        //--------------------------------
        // Da vida al zombie después de un momento.
        //--------------------------------
        public void Nacer()
        {
            Thread ProcesoEjecucion;
            Random Aleatorio;
            Color ColorAleatorio;
            int R, G, B;

            Aleatorio = new Random();

            R = Aleatorio.Next(1, 255);
            G = Aleatorio.Next(1, 255);
            B = Aleatorio.Next(1, 255);

            ColorAleatorio = Color.FromArgb(R, G, B);

            ProcesoEjecucion = new Thread(() =>
            {
                Thread.Sleep(1500);
                BackColor = ColorAleatorio;
                Nacido = true;
            });

            ProcesoEjecucion.Start();
        }
    }
}
