using BodegasAgricolas.Modelo.DTO;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodegasAgricolas.Modelo.DAO
{
    class daoProducto
    {
        private ConexionODBC ODBC = new ConexionODBC();

        public List<dtoProducto> mostrarProductos()
        {
            List<dtoProducto> sqlresultado = new List<dtoProducto>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM productos;";
                sqlresultado = conexionODBC.Query<dtoProducto>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
                return sqlresultado;
            }
            return null;
        }
    }
}