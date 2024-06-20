using Repository.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Entidades;

namespace Repository.Repositorio
{
    public class FacturaRepository
    {
        private readonly ContextoAplicacionDB _contexto;

        public FacturaRepository(ContextoAplicacionDB contexto)
        {
            _contexto = contexto;
        }

        public int Agregar(int id, int id_cliente, int nro_factura, int fecha_hora, int total, int total_iva5, int total_iva10, int total_iva, string total_letras, string sucursal)
        {
            Factura factura = new Factura()
            {
                id = id,
                id_cliente = id_cliente,
                nro_factura = nro_factura,
                fecha_hora = fecha_hora,
                total = total,
                total_iva5 = total_iva5,
                total_iva10 = total_iva10,
                total_iva = total_iva10,
                total_letras = total_letras,
                sucursal = sucursal
            };

            _contexto.Factura.Add(factura);

            int resultado = _contexto.SaveChanges();
            return resultado;

        }
    }
}
