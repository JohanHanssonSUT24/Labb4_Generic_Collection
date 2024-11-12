namespace Labb4_Generic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant Menu = new Restaurant();

            MenuItem Pizza = new MenuItem(1, "Pizza", 150.55M);
            MenuItem Hamburger = new MenuItem(2, "Hamburger", 180.01M);
            MenuItem Kebab = new MenuItem(3, "Kebab", 199.99M);
            MenuItem Falafel = new MenuItem(4, "Falafel", 200.50M);
            MenuItem Hotdog = new MenuItem(5, "Hotdog", 99.99M);

            Menu.AddtoMenu(Pizza);
            Menu.AddtoMenu(Hamburger);
            Menu.AddtoMenu(Kebab);
            Menu.AddtoMenu(Falafel);
            Menu.AddtoMenu(Hotdog);

            Menu.ShowMenu();

            Order order1 = new Order(new List<MenuItem>() { Pizza, Falafel }, 7);
            Menu.CreateOrder(order1);
            Order order2 = new Order(new List<MenuItem>() { Hotdog, Kebab }, 3);
            Menu.CreateOrder(order2);
            Order order3 = new Order(new List<MenuItem>() { Hamburger, Pizza }, 1);
            Menu.CreateOrder(order3);

            Menu.ShowOrders();
            Console.WriteLine("---------");
            Menu.HandleOrder(order1);
            Menu.ShowOrders();
            Menu.ShowNextOrder();
            Menu.ShowOrderCount();



        }
    }
}
