using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Contexto;
using Repository.Entidades;

namespace Repository.Repositorio
{
    public class ClienteRepository
    {
        private readonly ContextoAplicacionDB _contexto;

        public ClienteRepository(ContextoAplicacionDB contexto)
        {
            _contexto = contexto;
        }

        public int Agregar(int id, int id_banco, string nombre, string apellido, int documento, string direccion, string mail, int celular, string estado)
        {
            Cliente cliente = new Cliente()
            {
                id = id,
                id_banco = id_banco,
                nombre = nombre,
                apellido = apellido,
                documento = documento,
                direccion = direccion,
                mail = mail,
                celular = celular,
                estado = estado
            };

            _contexto.Cliente.Add(cliente);

            int resultado = _contexto.SaveChanges();
            return resultado;

        }
    }
}
