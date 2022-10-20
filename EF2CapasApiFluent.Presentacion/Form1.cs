using EF2CapasApiFluent.Datos.Models;
using EF2CapasApiFluent.Presentacion.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF2CapasApiFluent.Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente() 
            { 
                Nombre = "Pepo", 
                Apellido = "Witi", 
                Email = "pepo@gmail.com", 
                DNI = "40309992", 
            };

            var guardado = ADMCliente.Insertar(cliente);

            if(guardado > 0)
            {
                MessageBox.Show("Ok!");
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            gridTable.DataSource = ADMCliente.Listar();
        }
    }
}
