using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2CapasApiFluent.Datos.Models
{
    public class Detalle
    {
        public int IdDetalle { get; set; }
        // FK con factura id
        public int IdFactura{ get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }

        #region prop de navegacion
        public Factura Factura { get; set; }
        #endregion
    }
}
