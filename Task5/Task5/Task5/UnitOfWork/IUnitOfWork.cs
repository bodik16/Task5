using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5.DataTypes;
using Task5.Repository;

namespace Task3.UnitOfWork
{
    public interface IUnitOfWork
    {
        GenericRepository<TaxiClient> Clients { get; }
        GenericRepository<TaxiDriver> Drivers { get; }
        GenericRepository<TaxiOrder> Orders { get; }
    }
}
