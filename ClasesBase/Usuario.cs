using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario   
    {
        private int usr_Id;

        public int Usr_Id
        {
            get { return usr_Id; }
            set { usr_Id = value; }
        }

        private String usr_Nombre;

        public String Usr_Nombre
        {
            get { return usr_Nombre; }
            set { usr_Nombre = value; }
        }

        private String usr_Apellido;

        public String Usr_Apellido
        {
            get { return usr_Apellido; }
            set { usr_Apellido = value; }
        }

        private String usr_UserName;

        public String Usr_UserName
        {
            get { return usr_UserName; }
            set { usr_UserName = value; }
        }

        private String usr_Password;

        public String Usr_Password
        {
            get { return usr_Password; }
            set { usr_Password = value; }
        }

        private int rol_Id;

        public int Rol_Id
        {
            get { return rol_Id; }
            set { rol_Id = value; }
        }

        private String usr_email;

        public String Usr_email
        {
            get { return usr_email; }
            set { usr_email = value; }
        }


        public Usuario(int usr_Id, String nombre, String apellido, String userName, String password, int rol_Id, String email)
        {
            this.Usr_Id = usr_Id;
            this.Usr_Nombre = nombre;
            this.Usr_Apellido = apellido;
            this.Usr_UserName = userName;
            this.Usr_Password = password;
            this.Rol_Id = rol_Id;
            this.Usr_email = email;
        }
    }
}
