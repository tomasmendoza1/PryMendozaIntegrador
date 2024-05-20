using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryMendozaIntegrador
{
    public partial class FrmLocalQuenaken : Form
    {
        public FrmLocalQuenaken()
        {
            InitializeComponent();
        }

        private void BtnGuardarReserva_Click(object sender, EventArgs e)
        {
            ClsDatosRegistrados clsDatosRegistrados = new ClsDatosRegistrados();
            clsDatosRegistrados.grabar(txtApellido.Text, txtApellido.Text, txtEmail.Text, txtEmail.Text, txtEmail.Text);
            MessageBox.Show("Datos guardados correctamente");
            //Limpiar campos
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtEmail.Text = "";
            txtNumero.Text = "";
        }
    }
}
