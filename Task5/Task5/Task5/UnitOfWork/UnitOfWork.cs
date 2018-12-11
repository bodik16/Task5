using System;
using Task3.UnitOfWork;
using Task5.DataTypes;
using Task5.Repository;

namespace Task5.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private DriverContext context = new DriverContext();
        GenericRepository<TaxiClient> clients;
        GenericRepository<TaxiDriver> drivers;
        GenericRepository<TaxiOrder> orders;
        public GenericRepository<TaxiClient> Clients
        {
            get
            {
                if (clients == null)
                {
                    clients = new GenericRepository<TaxiClient>(context);
                }
                return clients;
            }
        }
        public GenericRepository<TaxiDriver> Drivers
        {
            get
            {
                if (drivers == null)
                {
                    drivers = new GenericRepository<TaxiDriver>(context);
                }
                return drivers;
            }
        }
        public GenericRepository<TaxiOrder> Orders
        {
            get
            {
                if (orders == null)
                {
                    orders = new GenericRepository<TaxiOrder>(context);
                }
                return orders;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
