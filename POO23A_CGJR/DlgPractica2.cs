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
        private Button button1;

        public DlgPractica2()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            CZombie zombie;

            zombie = new CZombie(this);

            zombie.Nacer();
            zombie.Desplazar(1);

            Click += new EventHandler(Identificar);
        }

        public void Identificar(Object sender, EventArgs e)
        {
           // MessageBox.Show(Name + " (" + XNacimiento + " , " + YNacimiento + ") Nacido = "+ Nacido);
        }

        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Crear Zombie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DlgPractica2
            // 
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(828, 398);
            this.Controls.Add(this.button1);
            this.Name = "DlgPractica2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

    }
}
