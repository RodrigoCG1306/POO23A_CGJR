using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO23A_CGJR
{
    public partial class DlgPractica2 : Form
    {
        //Atributos
        private Thread ProcesoColision;

        public DlgPractica2()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_COMPOSITED = 0x02000000;

                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_COMPOSITED;
                return cp;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CZombie zombie;

            zombie = new CZombie(this);

            zombie.Nacer();
            zombie.Desplazar();

            Click += new EventHandler(Identificar);
        }

        //Crea un zombie romero
        private void BtnZR_Click(object sender, EventArgs e)
        {
            CZombiRomero zombie;

            zombie = new CZombiRomero(this);

            zombie.Nacer();
            zombie.Desplazar();

            Click += new EventHandler(Identificar);
        }

        private void BtnColision_Click(object sender, EventArgs e)
        {
            ProcesoColision = new Thread(() =>
            {
                int[] Localizacion, Localizacion2;

                Localizacion = new int[4];
                Localizacion2 = new int[4];

                //Etapa 1: Obtiene coordenadas y procesa colores
                while (true)
                {
                    foreach (var Control in this.Controls)
                    {
                        if (Control.GetType() == typeof(CZombie) ||
                            Control.GetType() == typeof(CZombiRomero))
                        {
                            CZombie Zombie;

                            Zombie = (CZombie)Control;
                            Localizacion = Zombie.GetAreaLocalizacion();

                            Thread.Sleep(500);
                            Zombie.BackColor = Color.Fuchsia;
                            Zombie.Text = Localizacion[0].ToString() + ", " + Localizacion[1].ToString();
                            Thread.Sleep(500);
                            Zombie.BackColor = Color.Aqua;
                            Zombie.Text = Localizacion[0].ToString() + ", " + Localizacion[1].ToString();
                        }
                    }

                    //Etapa 2: Compara coordenadas
                    for (int i = 0; i < this.Controls.Count; i++)
                    {
                        Control Control, Control2;

                        Control = this.Controls[i];

                        if(i >= this.Controls.Count - 1)
                        {
                            continue;
                        }

                        Control2 = this.Controls[i+1];

                        if (Control.GetType() == typeof(CZombie) ||
                           Control.GetType() == typeof(CZombiRomero) &&
                           Control2.GetType() == typeof(CZombie) ||
                           Control2.GetType() == typeof(CZombiRomero))
                        {
                            CZombie Zombie;
                            CZombie Zombie2;
                            int Z1X1, Z1Y1, Z1X2, Z1Y2;
                            int Z2X1, Z2Y1, Z2X2, Z2Y2;

                            Zombie = (CZombie)Control;
                            Localizacion = Zombie.GetAreaLocalizacion();

                            Zombie2 = (CZombie)Control2;
                            Localizacion2 = Zombie2.GetAreaLocalizacion();

                            Z1X1 = Localizacion[0];
                            Z1Y1 = Localizacion[1];
                            Z1X2 = Localizacion[2];
                            Z1Y2 = Localizacion[3];

                            Z2X1 = Localizacion2[0];
                            Z2Y1 = Localizacion2[1];
                            Z2X2 = Localizacion2[2];
                            Z2Y2 = Localizacion2[3];

                            if ((Z2X2 >= Z1X1 && Z2X2 <= Z1X1 + 100) ||
                                (Z2X2 <= Z1X1 && Z2X2 >= Z1X1 - 100))
                            {
                                MessageBox.Show("!Colision¡");

                            }
                        }
                    }                    
                }
            });
            ProcesoColision.Start();
        }

        public void Identificar(Object sender, EventArgs e)
        {
            // MessageBox.Show(Name + " (" + XNacimiento + " , " + YNacimiento + ") Nacido = "+ Nacido);
        }

        private void InitializeComponent()
        {
            this.PnlLeft = new System.Windows.Forms.Panel();
            this.BtnColision = new System.Windows.Forms.Button();
            this.BtnZR = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PnlTop = new System.Windows.Forms.Panel();
            this.PnlZombi = new System.Windows.Forms.Panel();
            this.PnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlLeft
            // 
            this.PnlLeft.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.PnlLeft.Controls.Add(this.BtnColision);
            this.PnlLeft.Controls.Add(this.BtnZR);
            this.PnlLeft.Controls.Add(this.button1);
            this.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlLeft.Location = new System.Drawing.Point(0, 0);
            this.PnlLeft.Name = "PnlLeft";
            this.PnlLeft.Size = new System.Drawing.Size(154, 398);
            this.PnlLeft.TabIndex = 1;
            // 
            // BtnColision
            // 
            this.BtnColision.Location = new System.Drawing.Point(12, 94);
            this.BtnColision.Name = "BtnColision";
            this.BtnColision.Size = new System.Drawing.Size(119, 47);
            this.BtnColision.TabIndex = 3;
            this.BtnColision.Text = "Colisión";
            this.BtnColision.UseVisualStyleBackColor = true;
            this.BtnColision.Click += new System.EventHandler(this.BtnColision_Click);
            // 
            // BtnZR
            // 
            this.BtnZR.Location = new System.Drawing.Point(12, 41);
            this.BtnZR.Name = "BtnZR";
            this.BtnZR.Size = new System.Drawing.Size(119, 47);
            this.BtnZR.TabIndex = 2;
            this.BtnZR.Text = "Crear Zombie Romero";
            this.BtnZR.UseVisualStyleBackColor = true;
            this.BtnZR.Click += new System.EventHandler(this.BtnZR_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Crear Zombie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PnlTop
            // 
            this.PnlTop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTop.Location = new System.Drawing.Point(154, 0);
            this.PnlTop.Name = "PnlTop";
            this.PnlTop.Size = new System.Drawing.Size(674, 52);
            this.PnlTop.TabIndex = 2;
            // 
            // PnlZombi
            // 
            this.PnlZombi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlZombi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlZombi.Location = new System.Drawing.Point(154, 52);
            this.PnlZombi.Name = "PnlZombi";
            this.PnlZombi.Size = new System.Drawing.Size(674, 346);
            this.PnlZombi.TabIndex = 3;
            // 
            // DlgPractica2
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(828, 398);
            this.Controls.Add(this.PnlZombi);
            this.Controls.Add(this.PnlTop);
            this.Controls.Add(this.PnlLeft);
            this.Name = "DlgPractica2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PnlLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private Panel PnlLeft;
        private Button button1;
        private Panel PnlTop;
        private Button BtnZR;
        private Button BtnColision;
        private Panel PnlZombi;


    }
}
