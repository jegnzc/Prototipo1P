using BodegasAgricolas.Modelo.DAO;
using BodegasAgricolas.Modelo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodegasAgricolas
{
    public partial class VistaVenta : Form
    {
        public VistaVenta()
        {
            InitializeComponent();
        }

        private void VistaVenta_Load(object sender, EventArgs e)
        {
            daoCliente daoCliente = new daoCliente();
            cboCliente.DataSource = daoCliente.mostrarClientes();
            cboCliente.DisplayMember = "nombre_cliente";
            cboCliente.ValueMember = "codigo_cliente";
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            daoVentasEncabezado db = new daoVentasEncabezado();
            dtoVentasEncabezado modelo = new dtoVentasEncabezado();
            modelo.codigo_cliente = cboCliente.SelectedValue.ToString();
            modelo.documento_ventaenca = txtNumeroDocumento.Text;
            modelo.estatus_ventaenca = txtEstatusVenta.Text;
            modelo.total_ventaenca = float.Parse(txtTotalVenta.Text);
            string fecha = dateFecha.Value.ToString("yyyy-MM-dd");
            modelo.fecha_ventaenca = fecha;
            db.agregarVentaEncabezado(modelo);
        }
    }
}