namespace Labb4_Generic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a menu
            Restaurant Menu = new Restaurant();
            //Create menu-objects
            MenuItem Pizza = new MenuItem(1, "Pizza", 150.55M);
            MenuItem Hamburger = new MenuItem(2, "Hamburger", 180.01M);
            MenuItem Kebab = new MenuItem(3, "Kebab", 199.99M);
            MenuItem Falafel = new MenuItem(4, "Falafel", 200.50M);
            MenuItem Hotdog = new MenuItem(5, "Hotdog", 99.99M);
            //Add menu-objects 
            Menu.AddtoMenu(Pizza);
            Menu.AddtoMenu(Hamburger);
            Menu.AddtoMenu(Kebab);
            Menu.AddtoMenu(Falafel);
            Menu.AddtoMenu(Hotdog);
            Menu.ShowMenu();

            
            //Create orders with menu-items
            Order order1 = new Order(new List<MenuItem>(), 7);
            order1.AddMenuItem(Pizza);
            order1.AddMenuItem(Falafel);
            Menu.CreateOrder(order1);
            

            Order order2 = new Order(new List<MenuItem>(), 4);
            order2.AddMenuItem(Hotdog);
            order2.AddMenuItem(Kebab);
            order2.AddMenuItem(Pizza);
            order2.AddMenuItem(Hamburger);
            Menu.CreateOrder(order2);

            Order order3 = new Order(new List<MenuItem>(), 8);
            order3.AddMenuItem(Hamburger);
            order3.AddMenuItem(Pizza);
            order3.AddMenuItem(Falafel);
            Menu.CreateOrder(order3);
            Console.WriteLine("-----------------");
            Console.WriteLine("ORDERS IN QUEUE:");
            Console.WriteLine("-----------------");
            Menu.ShowOrders();
            Menu.ShowNextOrder();
            Menu.HandleOrder();
            Console.WriteLine("-----------------");
            Console.WriteLine("PREPARING ORDERS:");
            Menu.ShowOrders();
            Order order4 = new Order(new List<MenuItem>(), 5);
            order4.AddMenuItem(Falafel);
            order4.AddMenuItem(Hotdog);
            Menu.CreateOrder(order4);

            Console.WriteLine("PREPARING ORDERS:");
            Menu.ShowOrders();

            Console.WriteLine("------------------");
            Console.WriteLine("------------------");

            Menu.HandleOrder();
            Menu.ShowOrderCount();
            Menu.ShowOrders();

            Menu.ShowNextOrder();
            Menu.ShowOrders();
            Menu.ShowOrderCount();



        }
    }
}
