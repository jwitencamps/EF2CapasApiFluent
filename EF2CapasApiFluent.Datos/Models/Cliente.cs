using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2CapasApiFluent.Datos.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string DNI { get; set; }

        #region prop de navegacion
        public List<Factura> Facturas { get; set; }
        #endregion
    }   
}
