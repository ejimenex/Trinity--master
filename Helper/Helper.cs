using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;

namespace spirit.Funciones
{
    static class Helper
    {
        //Metodo para convertir el formato de la fecha a PostgreSQL
        public static string convertirFechaPSQL(string sFecha)
        {
           sFecha = sFecha.Substring(6, 4) + sFecha.Substring(3, 2) + sFecha.Substring(0, 2);
           return sFecha;
        }

        //public static string convertirHoraFormatoPSLQ(string sHora)
        //{
        //    sHora = sHora.Substring(11, 2) + sHora.Substring(14, 2) + sHora.Substring(17, 2);
        //    return sHora;
        //}

        //Metodo para convertir el formato de la hora a PostgreSQL
        public static string convertirHoraFormatoPSLQ(string sHora)
        {
            if(sHora.Length == 7){
                sHora = sHora.Substring(0, 1) + sHora.Substring(2, 2) + sHora.Substring(5,2);
                return sHora;
            }
            else
            {
                sHora = sHora.Substring(0, 2) + sHora.Substring(3, 2) + sHora.Substring(6, 2);
                return sHora;
            }
            
        }

        //Metodo para convertir el formato de la fecha a la aplicacion.
        public static string convertirFechaFormatoApp(string sFecha)
        {
            //sFecha = sFecha.Substring(6, 4) + "/" + sFecha.Substring(3, 2) + "/" + sFecha.Substring(0, 2);
            //return sFecha;
            sFecha = sFecha.Substring(6, 2) + "/" + sFecha.Substring(4, 2) + "/" + sFecha.Substring(0,4);
            return sFecha;
        }

        //Metodo para convertir el formato de la hora a la aplicacion.
        public static string convertirHoraFormatoApp(string sHora)
        {
            sHora = sHora.Substring(0, 2) + ":" + sHora.Substring(2, 2) + ":" + sHora.Substring(4, 2);
            return sHora;
        }
    }
}
