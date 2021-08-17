using BodegasAgricolas.Modelo.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodegasAgricolas.Vista
{
    public partial class VistaProductos : Form
    {
        public VistaProductos()
        {
            InitializeComponent();
        }

        private void VistaProductos_Load(object sender, EventArgs e)
        {
            daoProducto db = new daoProducto();
            tablaProductos.DataSource = db.mostrarProductos();
        }
    }
}