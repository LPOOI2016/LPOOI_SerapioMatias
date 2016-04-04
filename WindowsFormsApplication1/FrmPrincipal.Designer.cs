namespace Vistas
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnProduccion = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnVentas);
            this.panel1.Controls.Add(this.btnProduccion);
            this.panel1.Controls.Add(this.btnCompras);
            this.panel1.Controls.Add(this.btnStock);
            this.panel1.Location = new System.Drawing.Point(31, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 308);
            this.panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Location = new System.Drawing.Point(285, 157);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(135, 136);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            this.btnSalir.MouseLeave += new System.EventHandler(this.btnSalir_MouseLeave);
            this.btnSalir.MouseHover += new System.EventHandler(this.btnSalir_MouseHover);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.BackgroundImage")));
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuarios.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.Location = new System.Drawing.Point(150, 157);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(135, 136);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.MouseLeave += new System.EventHandler(this.btnUsuarios_MouseLeave);
            this.btnUsuarios.MouseHover += new System.EventHandler(this.btnUsuarios_MouseHover);
            // 
            // btnVentas
            // 
            this.btnVentas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnVentas.BackgroundImage")));
            this.btnVentas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVentas.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.btnVentas.Location = new System.Drawing.Point(15, 157);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(135, 136);
            this.btnVentas.TabIndex = 3;
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.MouseLeave += new System.EventHandler(this.btnVentas_MouseLeave);
            this.btnVentas.MouseHover += new System.EventHandler(this.btnVentas_MouseHover);
            // 
            // btnProduccion
            // 
            this.btnProduccion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnProduccion.BackgroundImage")));
            this.btnProduccion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProduccion.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.btnProduccion.Location = new System.Drawing.Point(285, 15);
            this.btnProduccion.Name = "btnProduccion";
            this.btnProduccion.Size = new System.Drawing.Size(135, 136);
            this.btnProduccion.TabIndex = 2;
            this.btnProduccion.UseVisualStyleBackColor = true;
            this.btnProduccion.MouseLeave += new System.EventHandler(this.btnProduccion_MouseLeave);
            this.btnProduccion.MouseHover += new System.EventHandler(this.btnProduccion_MouseHover);
            // 
            // btnCompras
            // 
            this.btnCompras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCompras.BackgroundImage")));
            this.btnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCompras.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.btnCompras.Location = new System.Drawing.Point(150, 15);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(135, 136);
            this.btnCompras.TabIndex = 1;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            this.btnCompras.MouseLeave += new System.EventHandler(this.btnCompras_MouseLeave);
            this.btnCompras.MouseHover += new System.EventHandler(this.btnCompras_MouseHover);
            // 
            // btnStock
            // 
            this.btnStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStock.BackgroundImage")));
            this.btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStock.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Bold);
            this.btnStock.Location = new System.Drawing.Point(15, 15);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(135, 136);
            this.btnStock.TabIndex = 0;
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            this.btnStock.MouseLeave += new System.EventHandler(this.btnStock_MouseLeave);
            this.btnStock.MouseHover += new System.EventHandler(this.btnStock_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu de Gestion";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 372);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "FrmPrincipal";
            this.Text = "FormPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnProduccion;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Label label1;
    }
}