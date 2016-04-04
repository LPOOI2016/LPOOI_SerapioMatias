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
    public partial class FrmAltaModifFamilia : Form
    {
        private FrmAltaModifArticulo frmAltaModifArticulo;
        public FrmAltaModifFamilia(FrmAltaModifArticulo frm)
        {
            InitializeComponent();
            frmAltaModifArticulo = frm;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea guardar los cambios", "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Familia unaFamilia = new Familia(1, txtDescripcion.Text);

                MessageBox.Show("Nueva Familia : \n \n" +
                                "Id: " + unaFamilia.Fam_Id + "\n" +
                                "DESCRIPCION: " + unaFamilia.Fam_Descrip);
            }
        }

        private void FrmAltaModifFamilia_Load(object sender, EventArgs e)
        {
        
        }
       

    }
}
