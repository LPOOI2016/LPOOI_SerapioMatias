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
    public partial class FrmAltaModifProveedores : Form
    {
        public FrmAltaModifProveedores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea guardar los cambios", "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Proveedor unProvedor = new Proveedor(1,txtNombre.Text, txtDomicilio.Text,
                                                    txtDepartamento.Text, txtCodPostal.Text,
                                                    txtTelefono.Text, txtEmail.Text);

                MessageBox.Show("Nuevo proveedor : \n \n" +
                                "Id: " + unProvedor.Prov_Id + "\n" +
                                "NOMBRE: " + unProvedor.Prov_Nombre + "\n" +
                                "DOMICILIO: " + unProvedor.Prov_Domicilio + "\n"+
                                "DEPARTAMENTO: " + unProvedor.Prov_Departamento + "\n"+
                                "COD POSTAL: " + unProvedor.Prov_Codigo_PostaL + "\n"+
                                "TELEFONO: " + unProvedor.Prov_Telefono + "\n"+
                                "EMAIL: " + unProvedor.Prov_Email + "\n"
                                );
            }
        }

        private void FrmAltaModifProveedores_Load(object sender, EventArgs e)
        {

        }
    }
}
