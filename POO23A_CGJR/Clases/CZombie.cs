using POO23A_CGJR.Properties;
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
        protected int Velocidad;

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
            BackColor = Color.White;
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
            Velocidad = 50;

            ProcesoVida = null;

            //Método manejador del click
            Click += new EventHandler(Identificar);

        }

        public void Identificar(Object sender, EventArgs e)
        {
            int[] Localizacion = GetAreaLocalizacion();

            MessageBox.Show("Localización = " + Localizacion[0] + ", " + Localizacion[1] + ", " 
                + Localizacion[2] + ", " + Localizacion[3]);
        }

        //--------------------------------
        // Desplaza a un zombie
        //--------------------------------
        public void Desplazar()
        {
            int x, y;
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
            Color ColorNacimiento;

            ColorNacimiento = this.ColorNacimiento();

            ProcesoEjecucion = new Thread(() =>
            {
                Thread.Sleep(150);
                BackColor = ColorNacimiento;
                Image = Resources.Chris_Walker;
                Nacido = true;
            });

            ProcesoEjecucion.Start();
        }

        //--------------
        // Colorea el zombi al momento de nacer
        //--------------

        protected virtual Color ColorNacimiento()
        {
            /* Aleatorio = new Random();

            R = Aleatorio.Next(1, 255);
            G = Aleatorio.Next(1, 255);
            B = Aleatorio.Next(1, 255); */

            return Color.FromArgb(0, 0, 0);
        }

        //----------------------
        //Detiene el hilo de ejecución
        //----------------------
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            Muerto = true;
        }

        //Obtiene el area de localización de un zombie
        public int[] GetAreaLocalizacion()
        {
            //Variable de array
            int[] Localización;
            
            //Instancia del array con 4 puntos
            Localización = new int[4];

            //Configuración de los 4 puntos de manera individual
            Localización[0] = Location.X;
            Localización[1] = Location.Y;
            Localización[2] = Location.X + 41;
            Localización[3] = Location.Y + 41;

            return Localización;
        }
    }
}
