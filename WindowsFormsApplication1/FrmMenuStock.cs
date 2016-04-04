using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMenuStock : Form
    {
        public FrmMenuStock()
        {
            InitializeComponent();
        }

        private void FrmStock_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAltaModifArticulo altaArticulo = new FrmAltaModifArticulo();

            altaArticulo.Show();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            FrmListaProveedores frmListaProveedores = new FrmListaProveedores();

            frmListaProveedores.Show();
        }

        private void btnFamilias_Click(object sender, EventArgs e)
        {
            FrmListaFamilias frmListaFamilias = new FrmListaFamilias();
            frmListaFamilias.Show();
        }
    }
}
