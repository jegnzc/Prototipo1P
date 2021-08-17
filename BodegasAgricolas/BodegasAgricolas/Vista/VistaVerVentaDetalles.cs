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
using BodegasAgricolas.Modelo.DTO;

namespace BodegasAgricolas.Vista
{
    public partial class VistaVerVentaDetalles : Form
    {
        public VistaVerVentaDetalles()
        {
            InitializeComponent();
        }

        private void VistaVerVentaDetalles_Load(object sender, EventArgs e)
        {
            daoVentaDetalle db = new daoVentaDetalle();
            tablaVerDetalles.DataSource = db.mostrarVentasDetalles();
        }
    }
}