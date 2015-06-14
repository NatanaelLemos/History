using System;

namespace History.Models
{
    public class Periodo 
    {
        public Int32 codPeriodo { get; set; }
        public Int32 dtInicialPeriodo { get; set; }
        public Int32 dtFinalPeriodo { get; set; }

        public String periodo
        {
            get
            {
                if (codPeriodo == -1) return String.Empty;
                return dtInicialPeriodo.ToString() + " - " + dtFinalPeriodo.ToString();
            }
        }
    }
}
