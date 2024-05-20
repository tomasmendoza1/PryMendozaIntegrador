namespace PryMendozaIntegrador
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void seleccioneToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void localQuenakenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocalQuenaken frmLocalQuenaken = new FrmLocalQuenaken();
            frmLocalQuenaken.ShowDialog();
        }

        private void localOnasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocalOnas frmLocalOnas = new FrmLocalOnas();
            frmLocalOnas.ShowDialog();
        }
        private void localTobasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocalTobas frmLocalTobas = new FrmLocalTobas();
            frmLocalTobas.ShowDialog();
        }
    }
}
