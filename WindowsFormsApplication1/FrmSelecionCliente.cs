﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmSelecionCliente : Form
    {
        public FrmSelecionCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAltaModifCliente frmAltaModifCliente = new FrmAltaModifCliente();
            frmAltaModifCliente.Show();
        }
    }
}
