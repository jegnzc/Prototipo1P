using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BodegasAgricolas.Modelo.DAO;

namespace BodegasAgricolas.Vista
{
    public partial class VistaClientes : Form
    {
        public VistaClientes()
        {
            InitializeComponent();
        }

        private void VistaClientes_Load(object sender, EventArgs e)
        {
            daoCliente db = new daoCliente();
            tablaClientes.DataSource = db.mostrarClientes();
        }
    }
}