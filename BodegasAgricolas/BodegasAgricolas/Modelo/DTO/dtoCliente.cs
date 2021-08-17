using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodegasAgricolas.Modelo.DTO
{
    class dtoCliente
    {
        public string codigo_cliente { get; set; }
        public string nombre_cliente { get; set; }
        public string direccion_cliente { get; set; }
        public string nit_cliente { get; set; }
        public string telefono_cliente { get; set; }
        public string codigo_vendedor { get; set; }
        public string estatus_cliente { get; set; }

        public dtoCliente()
        {
        }

        public dtoCliente(string Codigo_cliente, string Nombre_cliente, string Direccion_cliente,
            string Nit_cliente, string Telefono_cliente, string Codigo_vendedor, string Estatus_cliente)
        {
            codigo_cliente = Codigo_cliente;
            nombre_cliente = Nombre_cliente;
            direccion_cliente = Direccion_cliente;
            nit_cliente = Nit_cliente;
            telefono_cliente = Telefono_cliente;
            codigo_vendedor = Codigo_vendedor;
            estatus_cliente = Estatus_cliente;
        }
    }
}