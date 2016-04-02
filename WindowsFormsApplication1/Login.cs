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
    public partial class Login : Form
    {
        public static List<Usuario> listaUsuarios = new List<Usuario>();
        public static List<Roles> listaRoles = new List<Roles>();


        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            // Cargo la lista de roles
            listaRoles.Add(new Roles(1, "Administrador"));
            listaRoles.Add(new Roles(2, "Repositor"));
            listaRoles.Add(new Roles(3, "Pastelero"));
            listaRoles.Add(new Roles(4, "Comprador"));
            listaRoles.Add(new Roles(5, "Vendedor"));
            listaRoles.Add(new Roles(6, "Cajero"));

            //Cargo la lista de usuarios
            listaUsuarios.Add(new Usuario(1,"juan", "Vargas", "juanvargas", "1111", 1, "jua@gmail.com"));
            listaUsuarios.Add(new Usuario(2,"don", "pepito", "pepito", "1111", 2, "pepitp@gmail.com"));
            listaUsuarios.Add(new Usuario(3,"don", "jose", "jose", "1111", 3, "jose@gmail.com"));
            listaUsuarios.Add(new Usuario(4,"san", "Martin", "sanmartin", "1111", 4, "sanmartin@gmail.com"));
            listaUsuarios.Add(new Usuario(5,"manuel", "Belgrano", "manu", "1111", 5, "drbelgrano@gmail.com"));
            listaUsuarios.Add(new Usuario(6,"mariano", "moreno", "moreno", "1111", 6, "marmor@gmail.com"));



        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String userIngresado = txtNombre.Text;
            String passIngresado = txtPass.Text;
            Boolean datosCorrectos = false;
            foreach (Usuario user in listaUsuarios)
            {
                if (user.Usr_UserName == userIngresado && user.Usr_Password == passIngresado)
                {
                    datosCorrectos = true;
                }
            }
            if (datosCorrectos)
            {
                MessageBox.Show("correcto");
            }
            else
            {
                MessageBox.Show("datos incorrectos");
            }
        }
    }
}
