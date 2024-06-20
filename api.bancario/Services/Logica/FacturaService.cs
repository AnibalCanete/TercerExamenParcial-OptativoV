using Repository.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Logica
{
    public class FacturaService
    {
        FacturaRepository facturaRepository;

        public FacturaService(string connectionString) 
        {
            facturaRepository = new FacturaRepository(connectionString);
        }

        public bool Add(FacturaModel modelo)
        {
            if (ValidacionFactura(modelo))
            {
                return facturaRepository.add(modelo);
            }
            else
            {
                return false;
            }
        }

        public FacturaModel Get(int id)
        {
            return facturaRepository.get(id);
        }

        public bool Update(FacturaModel modelo)
        {
            if (ValidacionFactura(modelo))
            {
                return facturaRepository.update(modelo);
            }
            else
            {
                return false;
            }
        }

        public bool Delete(FacturaModel modelo)
        {
            if (modelo != null)
            {
                return facturaRepository.remove(modelo);
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<FacturaModel> list()
        {
            try
            {
                return facturaRepository.list();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private bool ValidacionFactura(FacturaModel factura)
        {
            if (factura == null || string.IsNullOrEmpty(factura.nro_factura))
            {
                return false;
            }
            return true;
        }

    }


}


