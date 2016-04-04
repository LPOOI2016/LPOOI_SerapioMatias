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
    public partial class FrmListaFamilias : Form
    {
        public FrmListaFamilias()
        {
            InitializeComponent();
        }

        private void btnNuevFamilia_Click(object sender, EventArgs e)
        {
            FrmAltaModifFamilia frmAltaModifFamilia = new FrmAltaModifFamilia();
            frmAltaModifFamilia.Show();
        }
    }
}
