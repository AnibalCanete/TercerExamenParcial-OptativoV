using Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class ClienteService
    {
        ClienteRepository clienteRepository;
        
        public ClienteService(string connectionString)
        {
            clienteRepository = new ClienteRepository(connectionString);
        }

       
public bool add(ClienteModel modelo)
        {
            if (validacionCliente(modelo))
            return clienteRepository.add(modelo);
            else 
                return false;
        }
        public ClienteModel Get(int id)
        {
            return clienteRepository.get(id);
        }

        public bool Update(ClienteModel modelo)
        {
            if (ValidacionCliente(modelo))
            {
                return clienteRepository.update(modelo);
            }
            else
            {
                return false;
            }
        }

        public bool Delete(ClienteModel modelo)
        {
            if (modelo != null)
            {
                return clienteRepository.remove(modelo);
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<ClienteModel> list()
        {
            try
            {
                return clienteRepository.list();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool validacionCliente(ClienteModel cliente)
        {
            if (cliente == null)
                return false;
            if (string.IsNullOrEmpty(cliente.nombre))
                return false;
            return true;
        }
 
    }
}
