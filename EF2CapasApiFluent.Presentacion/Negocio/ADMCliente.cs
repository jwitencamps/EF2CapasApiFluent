using EF2CapasApiFluent.Datos.Data;
using EF2CapasApiFluent.Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF2CapasApiFluent.Presentacion.Negocio
{
    public class ADMCliente
    {
        private static DBFacturacionContext context = new DBFacturacionContext();

        //Listar()
        public static List<Cliente> Listar()
        {
            return context.Clientes.ToList();
        }

        // TraerUno()
        public static Cliente TraerUno(int id)
        {
            return context.Clientes.Find(id);
        }

        //Insertar()
        public static int Insertar(Cliente cli)
        {
            context.Clientes.Add(cli);
            return context.SaveChanges();
        }

        //Modificar()
        public static int Modificar(Cliente cli)
        {
            int contadorGuardado = 0;

            var clienteO = context.Clientes.Find(cli.IdCliente);

            if (clienteO != null)
            {
                clienteO.Nombre = cli.Nombre;
                clienteO.Apellido = cli.Apellido;
                clienteO.Email = cli.Email;
                clienteO.DNI = cli.DNI;

                contadorGuardado = context.SaveChanges();
            }

            return contadorGuardado;
        }

        //Eliminar()
        public static int Eliminar(Cliente cli)
        {
            int contadorGuardado = 0;

            var clienteO = context.Clientes.Find(cli.IdCliente);

            if (clienteO != null)
            {
                context.Clientes.Remove(cli);

                contadorGuardado = context.SaveChanges();
            }

            return contadorGuardado;
        }


    }
}

