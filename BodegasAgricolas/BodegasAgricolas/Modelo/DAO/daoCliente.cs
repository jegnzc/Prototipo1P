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
    class daoCliente
    {
        private ConexionODBC ODBC = new ConexionODBC();

        public List<dtoCliente> mostrarClientes()
        {
            List<dtoCliente> sqlresultado = new List<dtoCliente>();
            OdbcConnection conexionODBC = ODBC.abrirConexion();
            if (conexionODBC != null)
            {
                string sqlconsulta = "SELECT * FROM clientes;";
                sqlresultado = conexionODBC.Query<dtoCliente>(sqlconsulta).ToList();
                ODBC.cerrarConexion(conexionODBC);
                return sqlresultado;
            }
            return null;
        }
    }
}