using System;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Task5.DataTypes;

namespace Task5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TaxiDriver currentDriver;
        public MainWindow()
        {
            InitializeComponent();
            Closing += endOfWork_Close;
            //заповнення таблиць початковими значеннями
            //AddClientsInfo();
            //AddDriversInfo();
            //AddOrdersInfo();        
        }
        private void AddClientsInfo()
        {
            using (var cont = new DriverContext())
            {
                var andrii = new TaxiClient("Andrii", "+380639786514");
                var mykola = new TaxiClient("Mykola", "+380739706543");
                var danylo = new TaxiClient("Danylo", "+380966785432");
                var vasyl = new TaxiClient("Vasyl", "+380967689854");
                var natalia = new TaxiClient("Natalia", "+380960807654");

                cont.Clients.Add(andrii);
                cont.Clients.Add(mykola);
                cont.Clients.Add(danylo);
                cont.Clients.Add(vasyl);
                cont.Clients.Add(natalia);
                cont.SaveChanges();
            }
        }

        private void AddDriversInfo()
        {
            using (var cont = new DriverContext())
            {
                var anatolii = new TaxiDriver("Mykytyn", "Anatolii", 27, "BC1567AC", 5, 50, 29);
                var volodymyr = new TaxiDriver("Berkela", "Volodymyr", 19, "BC7898BM", 3, 75, 0);
                var lukyana = new TaxiDriver("Kiral", "Lukyana", 20, "BC8765", 3, 23, 0);
                var bogdan = new TaxiDriver("Shomko", "Bogdan", 12, "BC3456AM1", 3, 23, 50);

                cont.Drivers.Add(anatolii);
                cont.Drivers.Add(volodymyr);
                cont.Drivers.Add(lukyana);
                cont.Drivers.Add(bogdan);

                cont.SaveChanges();
            }
        }

        private void AddOrdersInfo()
        {
            using (var cont = new DriverContext())
            {
                var andrii = (from elem in cont.Clients where elem.ClientId == 1 select elem).First();
                var mykola = (from elem in cont.Clients where elem.ClientId == 2 select elem).First();
                var natalia = (from elem in cont.Clients where elem.ClientId == 5 select elem).First();

                var anatoliiDriver = (from elem in cont.Drivers where elem.DriverId == 1 select elem).First();
                var volodymyrDriver = (from elem in cont.Drivers where elem.DriverId == 2 select elem).First();

                cont.Orders.Add(new TaxiOrder(mykola, anatoliiDriver, Convert.ToDateTime("2017-12-07 18:00"), "Університетська,1", "Федьковича,60", 19, 15, true));
                cont.Orders.Add(new TaxiOrder(andrii, anatoliiDriver, Convert.ToDateTime("2017-12-07 19:00"), "Наукова,7А", "Стрийська,89", 0, 0, false));
                cont.Orders.Add(new TaxiOrder(natalia, anatoliiDriver, Convert.ToDateTime("2017-12-07 15:00"), "Пасічна,70", "Сихівська,34", 0, 0, false));
                cont.Orders.Add(new TaxiOrder(andrii, volodymyrDriver, Convert.ToDateTime("2017-12-07 14:00"), "Пасічна,23", "Галицька,30", 0, 0, false));
                cont.Orders.Add(new TaxiOrder(natalia, volodymyrDriver, Convert.ToDateTime("2017-12-07 18:00"), "Університетська,1", "Вашингтона,12", 0, 0, false));
                cont.SaveChanges();
            }
        }

        public void updateOrders(TaxiOrder orderToUpdate)
        {
            using (UnitOfWork.UnitOfWork content = new UnitOfWork.UnitOfWork())
            {
                //UpdateOrderInfoINDB
                content.Orders.Update(orderToUpdate);
                content.Save();
                currentDriver.PayCheck += orderToUpdate.Cost;
                driverInfoCostDetails.Content = currentDriver.PayCheck + " грн";

                //ShowOrdersInListView //Eager Loading
                var currentOrders = content.Orders.Get(s => s.Driver.DriverId == currentDriver.DriverId, includeProperties: "Client");
                orders.Items.Clear();
                foreach (var order in currentOrders)
                {
                    orders.Items.Add(order);
                }
            }
        }

        private void orders_Click(object sender, RoutedEventArgs e)
        {
            var item = (sender as ListView).SelectedItem;
            if (item != null)
            {
                OrderWindow wind = new OrderWindow(item as TaxiOrder);
                wind.Show();
            }
        }

        private void startWork_Click(object sender, RoutedEventArgs e)
        {
            using (UnitOfWork.UnitOfWork content = new UnitOfWork.UnitOfWork())
            {
                currentDriver = content.Drivers.Get(s => s.Name == driverUserName.Text).FirstOrDefault();
                if (currentDriver != null)
                {
                    driverInfoSurnameNameDetails.Content = currentDriver.Surname + " " + currentDriver.Name;
                    driverInfoAgeDetails.Content = currentDriver.Age;
                    driverInfoCarDetails.Content = currentDriver.CarNumber;
                    driverInfoExpDetails.Content = currentDriver.Experience;
                    driverInfoCostDetails.Content = currentDriver.PayCheck + " грн";
                    driverInfoCostPerMinDetails.Content = currentDriver.CostPerMinute;

                    var currentOrders = content.Orders.Get(s => s.Driver.DriverId == currentDriver.DriverId, includeProperties: "Client");

                    orders.Items.Clear();
                    foreach (var order in currentOrders)
                    {
                        orders.Items.Add(order);
                    }
                }
                else
                {
                    MessageBox.Show(String.Format("Водія {0} не знайдено!!!", driverUserName.Text));
                }
            }
        }

        private void updateDriverInfo()
        {
            using (UnitOfWork.UnitOfWork content = new UnitOfWork.UnitOfWork())
            {
                if (currentDriver != null)
                {
                    content.Drivers.Update(currentDriver);
                    content.Save();
                }
            }
        }

        private void endOfWork_Click(object sender, RoutedEventArgs e)
        {
            updateDriverInfo();
            Close();
        }

        private void endOfWork_Close(object sender, CancelEventArgs e)
        {
            updateDriverInfo();
            MessageBox.Show(String.Format("Дякуюємо за роботу {0}!", currentDriver.Name), "Допобачення");
        }
    }
}
