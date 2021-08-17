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
    public partial class VistaVentaDetalles : Form
    {
        public VistaVentaDetalles()
        {
            InitializeComponent();
        }

        private void btnVentaDetalles_Click(object sender, EventArgs e)
        {
            dtoVentaDetalle modelo = new dtoVentaDetalle();
            daoVentaDetalle db = new daoVentaDetalle();
            modelo.documento_ventaenca = txtNumeroDocumento.Text;
            modelo.codigo_producto = txtCodigoProducto.Text;
            modelo.codigo_bodega = txtCodigoBodega.Text;
            modelo.costo_ventadet = float.Parse(txtCostoProducto.Text);
            modelo.precio_ventadet = float.Parse(txtPrecio.Text);
            modelo.cantidad_ventadet = float.Parse(txtCantidadProducto.Text);
            db.agregarVentaDetalles(modelo);
        }
    }
}