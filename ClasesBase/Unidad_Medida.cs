﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    class Unidad_Medida
    {
        private int uM_Id;

        public int UM_Id
        {
            get { return uM_Id; }
            set { uM_Id = value; }
        }

        private String uM_descrip;

        public String UM_descrip
        {
            get { return uM_descrip; }
            set { uM_descrip = value; }
        }

        private String uM_Abrev;

        public String UM_Abrev
        {
            get { return uM_Abrev; }
            set { uM_Abrev = value; }
        }
    }
}