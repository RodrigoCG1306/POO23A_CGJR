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

        public DlgPractica2()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            CZombie zombie;

            zombie = new CZombie(this.PnlZombi);

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
            ComponentResourceManager resources = new ComponentResourceManager(typeof(DlgPractica2));
            PnlLeft = new Panel();
            button1 = new Button();
            PnlTop = new Panel();
            PnlZombi = new Panel();
            PnlLeft.SuspendLayout();
            SuspendLayout();
            // 
            // PnlLeft
            // 
            PnlLeft.BackColor = Color.DarkOliveGreen;
            PnlLeft.Controls.Add(button1);
            PnlLeft.Dock = DockStyle.Left;
            PnlLeft.Location = new Point(0, 0);
            PnlLeft.Name = "PnlLeft";
            PnlLeft.Size = new Size(154, 398);
            PnlLeft.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(119, 23);
            button1.TabIndex = 1;
            button1.Text = "Crear Zombie";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PnlTop
            // 
            PnlTop.BackColor = SystemColors.ControlDark;
            PnlTop.Dock = DockStyle.Top;
            PnlTop.Location = new Point(154, 0);
            PnlTop.Name = "PnlTop";
            PnlTop.Size = new Size(674, 52);
            PnlTop.TabIndex = 2;
            // 
            // PnlZombi
            // 
            PnlZombi.BackgroundImage = (Image)resources.GetObject("PnlZombi.BackgroundImage");
            PnlZombi.BackgroundImageLayout = ImageLayout.Stretch;
            PnlZombi.Dock = DockStyle.Fill;
            PnlZombi.Location = new Point(154, 52);
            PnlZombi.Name = "PnlZombi";
            PnlZombi.Size = new Size(674, 346);
            PnlZombi.TabIndex = 3;
            // 
            // DlgPractica2
            // 
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(828, 398);
            Controls.Add(PnlZombi);
            Controls.Add(PnlTop);
            Controls.Add(PnlLeft);
            Name = "DlgPractica2";
            WindowState = FormWindowState.Maximized;
            PnlLeft.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel PnlLeft;
        private Button button1;
        private Panel PnlTop;
        private Panel PnlZombi;
    }
}
