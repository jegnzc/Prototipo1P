using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BodegasAgricolas.Modelo.DTO;
using BodegasAgricolas.Modelo.DAO;

namespace BodegasAgricolas.Vista
{
    public partial class VistaVerVentasEnca : Form
    {
        public VistaVerVentasEnca()
        {
            InitializeComponent();
        }

        private void VistaVerVentasEnca_Load(object sender, EventArgs e)
        {
            daoVentasEncabezado db = new daoVentasEncabezado();
            tablaVentasEnca.DataSource = db.mostrarVentasEncabezado();
        }
    }
}