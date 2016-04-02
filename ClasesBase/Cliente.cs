using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    class Cliente
    {
        private int cli_Id;

        public int Cli_Id
        {
            get { return cli_Id; }
            set { cli_Id = value; }
        }

        private String cli_Nombre;

        public String Cli_Nombre
        {
            get { return cli_Nombre; }
            set { cli_Nombre = value; }
        }

        private String cli_Domicilio;

        public String Cli_Domicilio
        {
            get { return cli_Domicilio; }
            set { cli_Domicilio = value; }
        }

        private String cli_Departamento;

        public String Cli_Departamento
        {
            get { return cli_Departamento; }
            set { cli_Departamento = value; }
        }

        private String cli_Codigo_Postal;

        public String Cli_Codigo_Postal
        {
            get { return cli_Codigo_Postal; }
            set { cli_Codigo_Postal = value; }
        }

        private String cli_Telefono;

        public String Cli_Telefono
        {
            get { return cli_Telefono; }
            set { cli_Telefono = value; }
        }

        private String cli_Email;

        public String Cli_Email
        {
            get { return cli_Email; }
            set { cli_Email = value; }
        }

        private DateTime cli_Fecha_Nac;

        public DateTime Cli_Fecha_Nac
        {
            get { return cli_Fecha_Nac; }
            set { cli_Fecha_Nac = value; }
        }

        public Cliente(int id, String nombre, String domicilio, String departamento, String codigoPostal, String telefono, String email, DateTime fechaNac)
        {
            Cli_Id = id;
            Cli_Nombre = nombre;
            Cli_Domicilio = domicilio;
            Cli_Departamento = departamento;
            Cli_Codigo_Postal = codigoPostal;
            Cli_Telefono = telefono;
            Cli_Email = email;   
            Cli_Fecha_Nac = fechaNac;
        }
    }
}
