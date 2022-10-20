using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2CapasApiFluent.Datos.Models
{
    public class Factura
    {
        public int IdFactura { get; set; }
        // FK de cliente id
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public decimal IVA { get; set; }

        #region prop de navegacion
        public List<Detalle> Detalles { get; set; }
        #endregion


    }
}
