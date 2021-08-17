using BodegasAgricolas.Vista;
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
    public partial class VistaMenu : Form
    {
        private Form formActivo = null;
        private string formPrincipalAnterior = "";

        public VistaMenu()
        {
            InitializeComponent();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new VistaNuevoCliente(), "CLIENTE");
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new VistaVenta(), "VENTA");
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new VistaClientes(), "VERCLIENTES");
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            gestorDeFormActivo(new VistaProductos(), "VERPRODUCTOS");
        }

        private void gestorDeFormActivo(Form formHijo, string formHijoActual)
        {
            if (formPrincipalAnterior == formHijoActual)
            {
                cerrarFormActivo();
                formPrincipalAnterior = "";
            }
            else
            {
                formPrincipalAnterior = formHijoActual;
                cerrarFormActivo();
                abrirFormHijo(formHijo, panelPrincipal);
            }
        }

        private void abrirFormHijo(Form formHijo, Panel panel)
        {
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panel.Controls.Add(formHijo);
            panel.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void cerrarFormActivo()
        {
            if (formActivo != null)
            {
                formActivo.Close();
                formActivo = null;
            }
        }
    }
}