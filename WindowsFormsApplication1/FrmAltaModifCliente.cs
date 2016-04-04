using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmAltaModifCliente : Form
    {
        public FrmAltaModifCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea guardar los cambios", "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    Cliente unCliente = new Cliente(1, txtNombre.Text, txtDomicilio.Text,
                                                    txtDepartamento.Text, txtCodPostal.Text,
                                                    txtTelefono.Text, txtEmail.Text,
                                                    DateTime.Parse(txtFechaNac.Text));

                    MessageBox.Show("Nuevo Cliente: \n" +
                                    "ID: " + unCliente.Cli_Id + "\n" +
                                    "Domicilio: " + unCliente.Cli_Domicilio + "\n" +
                                    "Departamento: " + unCliente.Cli_Departamento + "\n" +
                                    "Cod Postal: " + unCliente.Cli_Codigo_Postal + "\n" +
                                    "Telefono: " + unCliente.Cli_Telefono + "\n" +
                                    "Email: " + unCliente.Cli_Email + "\n" +
                                    "Fecha nac: " + unCliente.Cli_Fecha_Nac + "\n"
                                    );
                }
                catch (System.FormatException)
                {

                    MessageBox.Show("formato fecha imvalida");
                }
            }
        }
    }
}
