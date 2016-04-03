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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnStock_MouseHover(object sender, EventArgs e)
        {
            btnStock.Text = "Stock";
        }

        private void btnStock_MouseLeave(object sender, EventArgs e)
        {
            btnStock.Text = "";
        }

        private void btnCompras_MouseHover(object sender, EventArgs e)
        {
            btnCompras.Text = "Compras";
        }

        private void btnCompras_MouseLeave(object sender, EventArgs e)
        {
            btnCompras.Text = "";
        }

        private void btnProduccion_MouseHover(object sender, EventArgs e)
        {
            btnProduccion.Text = "Produccion";
        }

        private void btnProduccion_MouseLeave(object sender, EventArgs e)
        {
            btnProduccion.Text = "";
        }

        private void btnVentas_MouseHover(object sender, EventArgs e)
        {
            btnVentas.Text = "Ventas";
        }

        private void btnVentas_MouseLeave(object sender, EventArgs e)
        {
            btnVentas.Text = "";
        }

        private void btnUsuarios_MouseHover(object sender, EventArgs e)
        {
            btnUsuarios.Text = "Usuarios";
        }

        private void btnUsuarios_MouseLeave(object sender, EventArgs e)
        {
            btnUsuarios.Text = "";
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            btnSalir.Text = "Salir";
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.Text = "";
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            FrmMenuCompra frmMenuCompra = new FrmMenuCompra();

            frmMenuCompra.Show();

        }

        
        

    }
}
