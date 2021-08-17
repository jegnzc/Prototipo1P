using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BodegasAgricolas.Modelo.DTO;
using Dapper;

namespace BodegasAgricolas.Modelo.DAO
{
    class daoVentaDetalle
    {
        private ConexionODBC ODBC = new ConexionODBC();

        public dtoVentaDetalle agregarVentaDetalles(dtoVentaDetalle modelo)
        {
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                var sqlinsertar =
                "INSERT INTO ventas_detalle (documento_ventaenca, codigo_producto, cantidad_ventadet" +
                ", costo_ventadet, precio_ventadet, codigo_bodega) VALUES(?documento_ventaenca?" +
                ", ?codigo_producto?, ?cantidad_ventadet?, ?costo_ventadet?, ?precio_ventadet?" +
                ", ?codigo_bodega?);";
                var ValorDeVariables = new
                {
                    documento_ventaenca = modelo.documento_ventaenca,
                    codigo_producto = modelo.codigo_producto,
                    cantidad_ventadet = modelo.cantidad_ventadet,
                    costo_ventadet = modelo.costo_ventadet,
                    precio_ventadet = modelo.precio_ventadet,
                    codigo_bodega = modelo.codigo_bodega
                };
                conexionODBC.Execute(sqlinsertar, ValorDeVariables);
                ODBC.cerrarConexion(conexionODBC);
            }
            return modelo;
        }

        public List<dtoVentaDetalle> mostrarVentasDetalles()
        {
            List<dtoVentaDetalle> sqlresultado = new List<dtoVentaDetalle>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM ventas_detalle;";
                sqlresultado = conexionODBC.Query<dtoVentaDetalle>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
                return sqlresultado;
            }
            return null;
        }
    }
}