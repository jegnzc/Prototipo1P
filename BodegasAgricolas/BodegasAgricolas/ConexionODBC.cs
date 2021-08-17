using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodegasAgricolas
{
    class ConexionODBC
    {
        private string dsn = "Dsn=agricola";

        public OdbcConnection abrirConexion()
        {
            OdbcConnection conexion = new OdbcConnection(dsn);
            try
            {
                conexion.Open();
                return conexion;
            }
            catch (OdbcException e)
            {
                Console.WriteLine("Error de conexión");
                return null;
            }
        }

        public void cerrarConexion(OdbcConnection conexion)
        {
            try
            {
                conexion.Close();
            }
            catch (OdbcException e)
            {
                Console.WriteLine("Error de conexión");
            }
        }
    }
}