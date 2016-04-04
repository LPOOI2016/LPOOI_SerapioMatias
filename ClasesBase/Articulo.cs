using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Articulo
    {
        private int art_Id;

        public int Art_Id
        {
            get { return art_Id; }
            set { art_Id = value; }
        }

        private String art_Descrip;

        public String Art_Descrip
        {
            get { return art_Descrip; }
            set { art_Descrip = value; }
        }

        private int fam_Id;

        public int Fam_Id
        {
            get { return fam_Id; }
            set { fam_Id = value; }
        }

        private int uM_Id;

        public int UM_Id
        {
            get { return uM_Id; }
            set { uM_Id = value; }
        }

        private Decimal art_Costo;

        public Decimal Art_Costo
        {
            get { return art_Costo; }
            set { art_Costo = value; }
        }

        private Decimal art_Margen_Beneficio;

        public Decimal Art_Margen_Beneficio
        {
            get { return art_Margen_Beneficio; }
            set { art_Margen_Beneficio = value; }
        }

        private Decimal art_Precio;

        public Decimal Art_Precio
        {
            get { return art_Precio; }
            set { art_Precio = value; }
        }

        private Decimal art_Stock_Min;

        public Decimal Art_Stock_Min
        {
            get { return art_Stock_Min; }
            set { art_Stock_Min = value; }
        }

        private Decimal art_Stock_Max;

        public Decimal Art_Stock_Max
        {
            get { return art_Stock_Max; }
            set { art_Stock_Max = value; }
        }

        private Decimal art_Stock_Reposicion;

        public Decimal Art_Stock_Reposicion
        {
            get { return art_Stock_Reposicion; }
            set { art_Stock_Reposicion = value; }
        }

        private Decimal art_Stock_Actual;

        public Decimal Art_Stock_Actual
        {
            get { return art_Stock_Actual; }
            set { art_Stock_Actual = value; }
        }

        private Boolean art_Maneja_Stock;

        public Boolean Art_Maneja_Stock
        {
            get { return art_Maneja_Stock; }
            set { art_Maneja_Stock = value; }
        }

        public Articulo(int art_Id, String descrip, int fam_Id, int uM_id, Decimal costo,
                        Decimal margen_Beneficio, Decimal precio, Decimal stock_Min, Decimal stock_Max,
                        Decimal stock_Reposicion, Decimal stock_Actual, Boolean maneja_Stock)
        {
            this.Art_Id = art_Id;
            this.Art_Descrip = descrip;
            this.Fam_Id = fam_Id;
            this.uM_Id = uM_id;
            this.Art_Costo = costo;
            this.Art_Margen_Beneficio = margen_Beneficio;
            this.Art_Precio = precio;
            this.Art_Stock_Min = stock_Min;
            this.Art_Stock_Max = stock_Max;
            this.Art_Stock_Reposicion = stock_Reposicion;
            this.Art_Stock_Actual = stock_Actual;
            this.Art_Maneja_Stock = maneja_Stock;
        }

    }
}
