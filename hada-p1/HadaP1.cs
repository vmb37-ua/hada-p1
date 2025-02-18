using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hada_p1
{
    /// <summary>
    /// Clase que sirve como apoyo para cálculo de conversión entre unidades de tiempo.
    /// </summary>
    internal class HadaP1
    {
        /// <summary>
        /// Función de conversión de segundos a minutos. (Recibe parámetro real en segundos)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static double Seconds2Minutes(double s) {
            if (s == 0) return 0;
            return s / 60;
        }

        /// <summary>
        /// Función de conversión de minutos a segundos. (Recibe parámetro real en minutos)
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static double Minutes2Seconds(double m) {
            return 60 * m;
        }

        /// <summary>
        /// Función de conversión de horas a minutos. (Recibe parámetro real en horas)
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public static double Hours2Minutes(double h) {
            return 60 * h;
        }
    }
}
