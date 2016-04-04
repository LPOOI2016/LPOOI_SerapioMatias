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
    public partial class FrmListaProveedores : Form
    {
        public FrmListaProveedores()
        {
            InitializeComponent();
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            FrmAltaModifProveedores frmAltaModifProveedores = new FrmAltaModifProveedores();
            frmAltaModifProveedores.Show();
        }
    }
}
