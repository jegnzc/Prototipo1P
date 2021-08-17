using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodegasAgricolas.Modelo.DTO
{
    class dtoVentasEncabezado
    {
        public string documento_ventaenca { get; set; }
        public string codigo_cliente { get; set; }
        public string fecha_ventaenca { get; set; }
        public float total_ventaenca { get; set; }
        public string estatus_ventaenca { get; set; }

        public dtoVentasEncabezado()
        {
        }

        public dtoVentasEncabezado(string Documento_ventaenca, string Codigo_cliente, string Fecha_ventaenca,
            float Total_ventaenca, string Estatus_ventaenca)
        {
            documento_ventaenca = Documento_ventaenca;
            codigo_cliente = Codigo_cliente;
            fecha_ventaenca = Fecha_ventaenca;
            total_ventaenca = Total_ventaenca;
            estatus_ventaenca = Estatus_ventaenca;
        }
    }
}