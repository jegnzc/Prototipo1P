using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodegasAgricolas.Modelo.DTO
{
    class dtoProducto
    {
        public string codigo_producto { get; set; }
        public string nombre_producto { get; set; }
        public string codigo_linea { get; set; }
        public string codigo_marca { get; set; }
        public float existencia_producto { get; set; }
        public string estatus_producto { get; set; }

        public dtoProducto()
        {
        }

        public dtoProducto(string codigo_producto, string nombre_producto, string codigo_linea, string codigo_marca, float existencia_producto, string estatus_producto)
        {
            this.codigo_producto = codigo_producto;
            this.nombre_producto = nombre_producto;
            this.codigo_linea = codigo_linea;
            this.codigo_marca = codigo_marca;
            this.existencia_producto = existencia_producto;
            this.estatus_producto = estatus_producto;
        }
    }
}