using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Historial_login
    {
        private int hLog_Id;

        public int HLog_Id
        {
            get { return hLog_Id; }
            set { hLog_Id = value; }
        }

        private int usr_Id;

        public int Usr_Id
        {
            get { return usr_Id; }
            set { usr_Id = value; }
        }

        private DateTime hLog_Fecha_Hora;

        public DateTime HLog_Fecha_Hora
        {
            get { return hLog_Fecha_Hora; }
            set { hLog_Fecha_Hora = value; }
        }

        public Historial_login(int hLog_Id, int usr_Id, DateTime fechaHora)
        {
            this.HLog_Id = hLog_Id;
            this.Usr_Id = usr_Id;
            hLog_Fecha_Hora = fechaHora;
        }
    }
}
