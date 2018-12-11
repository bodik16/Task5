namespace Task3.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using Task5.DataTypes;

    internal sealed class Configuration : DbMigrationsConfiguration<Task5.DataTypes.DriverContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            //ContextKey = "Task5.DataTypes.DriverContext";
        }

        protected override void Seed(Task5.DataTypes.DriverContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
            //context.Database.CreateIfNotExists();

            var taxiClients = new List<TaxiClient>()
            {
                new TaxiClient("Andrii", "+380639786514"),
                new TaxiClient("Mykola", "+380739706543"),
                new TaxiClient("Danylo", "+380966785432"),
                new TaxiClient("Vasyl", "+380967689854"),
                new TaxiClient("Natalia", "+380960807654")
            };

            foreach (var taxiClient in taxiClients)
            {
                context.Clients.AddOrUpdate(c => c.ClientId, taxiClient);
            }

            var taxiDrivers = new List<TaxiDriver>()
            {
                new TaxiDriver("Shomko", "Bogdan", 19, "BC1567AC", 5, 50, 29),
                new TaxiDriver("Berkela", "Volodymyr", 19, "BC7898BM", 3, 75, 0),
                new TaxiDriver("Kiral", "Lukyana", 20, "BC8765", 3, 23, 0),
                new TaxiDriver("Mykytyn", "Anatolii", 12, "BC3456AM1", 3, 23, 50),
            };

            foreach (var taxiDriver in taxiDrivers)
            {
                context.Drivers.AddOrUpdate(d => d.DriverId, taxiDriver);
            }

            var maria = (from elem in context.Clients where elem.ClientId == 1 select elem).First();
            var olya = (from elem in context.Clients where elem.ClientId == 2 select elem).First();
            var natalia = (from elem in context.Clients where elem.ClientId == 5 select elem).First();

            var olyaDriver = (from elem in context.Drivers where elem.DriverId == 1 select elem).First();
            var andrianaDriver = (from elem in context.Drivers where elem.DriverId == 2 select elem).First();

            var orders = new List<TaxiOrder>()
            {
                new TaxiOrder(olya, olyaDriver, Convert.ToDateTime("2017-12-07 18:00"), "Університетська,1", "Федьковича,60", 19, 15, true),
                new TaxiOrder(maria, olyaDriver, Convert.ToDateTime("2017-12-07 19:00"), "Наукова,7А", "Стрийська,89", 0, 0, false),
                new TaxiOrder(natalia, olyaDriver, Convert.ToDateTime("2017-12-07 15:00"), "Пасічна,70", "Сихівська,34", 0, 0, false),
                new TaxiOrder(maria, andrianaDriver, Convert.ToDateTime("2017-12-07 14:00"), "Пасічна,23", "Галицька,30", 0, 0, false),
                new TaxiOrder(natalia, andrianaDriver, Convert.ToDateTime("2017-12-07 18:00"), "Університетська,1", "Вашингтона,12", 0, 0, false)
            };
            
            foreach(var order in orders)
            {
                context.Orders.AddOrUpdate(o => o.OrderId, order);
            }
        }
    }
}
