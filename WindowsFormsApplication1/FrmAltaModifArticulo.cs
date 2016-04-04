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
    public partial class FrmAltaModifArticulo : Form
    {
        public FrmAltaModifArticulo()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtMargenBenf_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea guardar los cambios", "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                try
                {
                    Articulo unArticulo = new Articulo(1, txtDescripcion.Text, cmbFamilia.SelectedIndex,
                                                    cmbUnidadMedida.SelectedIndex, Decimal.Parse(txtCosto.Text),
                                                    Decimal.Parse(txtMargenBenf.Text), Decimal.Parse(txtPrecio.Text),
                                                    Decimal.Parse(txtStockMin.Text), Decimal.Parse(txtStockMax.Text),
                                                    Decimal.Parse(txtStockReposicion.Text), Decimal.Parse(txtStockActual.Text),
                                                    chkManejaStock.Checked);

                    MessageBox.Show("Id: " + unArticulo.Art_Id + "\n" +
                                    "descripcion :" + unArticulo.Art_Descrip + "\n" +
                                    "ID Familia :" + unArticulo.Fam_Id + "\n" +
                                    "ID Unidad medida :" + unArticulo.UM_Id + "\n" +
                                    "Costo :" + unArticulo.Art_Costo + "\n" +
                                    "Margen Benef:" + unArticulo.Art_Margen_Beneficio + "\n" +
                                    "Precio:" + unArticulo.Art_Precio + "\n" +
                                    "Stock min :" + unArticulo.Art_Stock_Min + "\n" +
                                    "Stock Max :" + unArticulo.Art_Stock_Max + "\n" +
                                    "Stock Reposicion:" + unArticulo.Art_Stock_Reposicion + "\n" +
                                    "Stock actual :" + unArticulo.Art_Stock_Actual + "\n" +
                                    "maneja Stock :" + unArticulo.Art_Maneja_Stock + "\n");

                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Hay Campos invalidos o vacios en el formulario");
                }    
            }
        }

        private void btnNuevaFamilia_Click(object sender, EventArgs e)
        {
            FrmAltaModifFamilia frmAltaModifFamilia = new FrmAltaModifFamilia(this);

            frmAltaModifFamilia.Show();
        }

        private void btnNuevaUnidMedida_Click(object sender, EventArgs e)
        {
            FrmAltaModifUnidadMedida frmAltaModificacionUnidadMedida = new FrmAltaModifUnidadMedida(this);

            frmAltaModificacionUnidadMedida.Show();
        }
    }
}
