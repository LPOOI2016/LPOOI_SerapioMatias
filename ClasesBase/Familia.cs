using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Familia
    {
        private int fam_Id;

        public int Fam_Id
        {
            get { return fam_Id; }
            set { fam_Id = value; }
        }

        private String fam_Descrip;

        public String Fam_Descrip
        {
            get { return fam_Descrip; }
            set { fam_Descrip = value; }
        }

        public Familia(int id, String descripcion)
        {
            Fam_Id = id;
            Fam_Descrip = descripcion;
        }
    }
}
