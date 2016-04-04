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
    public partial class FrmAltaModifUnidadMedida : Form
    {
        private FrmAltaModifArticulo frmAltaModificacionArticulo;

        public FrmAltaModifUnidadMedida(FrmAltaModifArticulo frm)
        {
            InitializeComponent();
            frmAltaModificacionArticulo = frm;
        }

        private void FrmAltaModifUnidadMedida_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea guardar los cambios", "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Unidad_Medida unaUnidadMedida = new Unidad_Medida(1, txtDescripcion.Text, txtAbrev.Text);
                MessageBox.Show("Nueva Uidad de Medida : \n \n" +
                                "Id: " + unaUnidadMedida.UM_Id + "\n" +
                                "DESCRIPCION: " + unaUnidadMedida.UM_descrip + "\n" +
                                "ABREV: " + unaUnidadMedida.UM_Abrev + "\n");
            }
        }
    }
}
