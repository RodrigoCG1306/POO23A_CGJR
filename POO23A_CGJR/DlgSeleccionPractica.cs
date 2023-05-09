using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO23A_CGJR
{
    public partial class DlgSeleccionPractica : Form
    {
        Image Fondo;
        int Aux = 0;
        public DlgSeleccionPractica()
        {
            InitializeComponent();
        }

        //Botón para cambiar el diseño de a cuerdo a la práctica 1
        private void BtnPractica1_Click(object sender, EventArgs e)
        {
            VisibleButton();

            Fondo = Properties.Resources.Astra;

            PBSelecciónPractica.Image = Fondo;

            Aux = 1;
        }

        private void BtnPractica2_Click(object sender, EventArgs e)
        {
            VisibleButton();

            Fondo = Properties.Resources.Neon;

            PBSelecciónPractica.Image = Fondo;

            Aux = 2;
        }

        private void BtnPractica1Exe_Click(object sender, EventArgs e)
        {
            switch(Aux)
            {
                case 1:
                    DlgPractica1 Practica1 = new DlgPractica1();

                    Practica1.Show();
                    break;

                case 2:
                    DlgPractica2 Practica2 = new DlgPractica2();

                    Practica2.Show();
                    break;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void VisibleButton()
        {
            BtnEjecutar.Enabled = true;
        }

    }
}
