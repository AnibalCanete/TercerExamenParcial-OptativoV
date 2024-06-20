using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data
{
    public class FacturaRepository : IFactura
    {
        private IDbConnection conexionDB;

        public FacturaRepository(string _connectionString)
        {
            conexionDB = new DbConection(_connectionString).dbConnection();
        }

        public bool add(FacturaModel factura)
        {
            try
            {
                if (conexionDB.Execute("INSERT INTO Cliente(nro_factura, fecha_hora, total, total_iva5, total_iva10, total_iva, total_letras, sucursal) VALUES (@nro_factura, @fecha_hora, @total, @total_iva5, @total_iva10, @total_iva, @total_letras, @sucursal)", factura) > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool remove(FacturaModel factura)
        {
            try
            {
                var query = "DELETE FROM Factura WHERE Id = @Id";
                return conexionDB.Execute(query, factura) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool update(FacturaModel factura)
        {
            try
            {
                var query = @"UPDATE Factura SET 
                              id_cliente = @Id_cliente, 
                              nro_factura = @Nro_factura, 
                              fecha_hora = @Fecha_hora, 
                              total = @Total, 
                              total_iva5 = @Total_iva5, 
                              total_iva10 = @Total_iva10, 
                              total_iva = @Total_iva, 
                              total_letras = @Total_letras, 
                              sucursal = @Sucursal 
                              WHERE Id = @Id";
                return conexionDB.Execute(query, factura) > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public FacturaModel get(int id)
        {
            try
            {
                var query = "SELECT * FROM Factura WHERE Id = @Id";
                return conexionDB.QueryFirstOrDefault<FacturaModel>(query, new { Id = id });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<FacturaModel> list()
        {
            try
            {
                var query = "SELECT * FROM Factura";
                return conexionDB.Query<FacturaModel>(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
