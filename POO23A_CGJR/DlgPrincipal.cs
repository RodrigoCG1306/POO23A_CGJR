namespace POO23A_CGJR
{
    //-------------------------------------------------------------------------
    //Dialogo principal del proyecto de pr�ctias de POO 23A.
    //CGJR. 24/enero/2023
    //-------------------------------------------------------------------------
    public partial class DlgPrincipal : Form
    {
        //-------------------------------------------------------------------------
        //Atributos
        //-------------------------------------------------------------------------
        private int Altura;
        private int Ancho;

        //-------------------------------------------------------------------------
        //Cosntructor
        //-------------------------------------------------------------------------
        public DlgPrincipal()
        {
            InitializeComponent();
            Altura = 1920;
            Ancho = 1080;
            Text = "Jos� Rodrigo C�zares Godoy";
        }

        //-------------------------------------------------------------------------
        //Maximiza el dialogo seg�n los atributos
        //-------------------------------------------------------------------------
        public void maximizar()
        {
            Height = Altura;
            Width = Ancho;
            Text = "Maximizado";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maximizar();
        }

        private void LblIniciar_Click(object sender, EventArgs e)
        {
            DlgSeleccionPractica DlgSeleccionPractica;

            DlgSeleccionPractica = new DlgSeleccionPractica();

            DlgSeleccionPractica.Show();
        }

    }
}