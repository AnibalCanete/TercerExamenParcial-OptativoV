using Npgsql.Replication.PgOutput.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data
{
    public interface IFactura
    {
        public bool add(FacturaModel factura);
        public bool remove(FacturaModel factura);
        public bool update(FacturaModel factura);
        FacturaModel get(int id);
        IEnumerable<FacturaModel> List();
    }
}
