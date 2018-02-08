using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APP_MML_V1.Models
{
    public class RecaudacionPuesto
    {
        public string CONCEPTO { get; set; }
        public string CONTRATO { get; set; }
        public string PERIODO { get; set; }
        public Nullable<decimal> EMISION { get; set; }
        public Nullable<decimal> SERVICIO { get; set; }
        public Nullable<decimal> MORA { get; set; }
        public Nullable<System.DateTime> FEC_CANCELACION { get; set; }
        public string COD_LETRA { get; set; }
        public string NUM_CONTRATO { get; set; }
        public string COD_NOMBRE { get; set; }
        public string COD_TIPOPRO { get; set; }
        public string INSOLUTO { get; set; }
        public Nullable<decimal> MONTO { get; set; }
    }
}