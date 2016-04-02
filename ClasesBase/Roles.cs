using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Roles
    {
        private int rol_Id;

        public int Rol_Id
        {
            get { return rol_Id; }
            set { rol_Id = value; }
        }

        private String rol_Descrip;

        public String Rol_Descrip
        {
            get { return rol_Descrip; }
            set { rol_Descrip = value; }
        }

        public Roles(int id, String descrip)
        {
            Rol_Id = id;
            Rol_Descrip = descrip;
        }
        
    }
}
