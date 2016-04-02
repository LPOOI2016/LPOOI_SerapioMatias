using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    class Proveedor
    {
        private int prov_Id;

        public int Prov_Id
        {
            get { return prov_Id; }
            set { prov_Id = value; }
        }

        private String prov_Nombre;

        public String Prov_Nombre
        {
            get { return prov_Nombre; }
            set { prov_Nombre = value; }
        }

        private String prov_Domicilio;

        public String Prov_Domicilio
        {
            get { return prov_Domicilio; }
            set { prov_Domicilio = value; }
        }

        private String prov_Departamento;

        public String Prov_Departamento
        {
            get { return prov_Departamento; }
            set { prov_Departamento = value; }
        }

        private String prov_Codigo_Postal;

        public String Prov_Codigo_PostaL
        {
            get { return prov_Codigo_Postal; }
            set { prov_Codigo_Postal = value; }
        }

        private String prov_Telefono;

        public String Prov_Telefono
        {
            get { return prov_Telefono; }
            set { prov_Telefono = value; }
        }

        private String prov_Email;

        public String Prov_Email
        {
            get { return prov_Email; }
            set { prov_Email = value; }
        }

        public Proveedor(int Id, String nombre, String domicilio, String departamento, String codigoPostal, String telefono , String email)
        {
            Prov_Id = Id;
            Prov_Nombre = nombre;
            Prov_Domicilio = domicilio;
            Prov_Departamento = departamento;
            Prov_Codigo_PostaL = codigoPostal;
            Prov_Telefono = telefono;
            Prov_Email = email;
        }
    }
}
