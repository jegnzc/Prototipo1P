using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodegasAgricolas.Modelo.DTO
{
    class dtoVentaDetalle
    {
        public string documento_ventaenca { get; set; }
        public string codigo_producto { get; set; }
        public float cantidad_ventadet { get; set; }
        public float costo_ventadet { get; set; }
        public float precio_ventadet { get; set; }
        public string codigo_bodega { get; set; }

        public dtoVentaDetalle()
        {
        }

        public dtoVentaDetalle(string documento_ventaenca, string codigo_producto, float cantidad_ventadet, float costo_ventadet, float precio_ventadet, string codigo_bodega)
        {
            this.documento_ventaenca = documento_ventaenca;
            this.codigo_producto = codigo_producto;
            this.cantidad_ventadet = cantidad_ventadet;
            this.costo_ventadet = costo_ventadet;
            this.precio_ventadet = precio_ventadet;
            this.codigo_bodega = codigo_bodega;
        }
    }
}