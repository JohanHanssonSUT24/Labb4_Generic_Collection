namespace Labb4_Generic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant Menu = new Restaurant();

            MenuItem Pizza = new MenuItem(1, "Pizza", 150M);
            MenuItem Hamburger = new MenuItem(2, "Hamburger", 180M);
            MenuItem Kebab = new MenuItem(3, "Kebab", 199M);
            MenuItem Falafel = new MenuItem(4, "Falafel", 200M);

            Menu.AddtoMenu(Pizza);
            Menu.AddtoMenu(Hamburger);
            Menu.AddtoMenu(Kebab);
            Menu.AddtoMenu(Falafel);

            Menu.ShowMenu();

            Order order = new Order(new List<MenuItem>(), 1);
            order.AddMenuItem(Pizza);
            order.AddMenuItem(Falafel);
            Order order2 = new Order(new List<MenuItem>(), 2);
            order2.AddMenuItem(Kebab);
            order2.AddMenuItem(Hamburger);
            Order order3 = new Order(new List<MenuItem>(), 3);
            order3.AddMenuItem(Hotdog);
            order3.AddMenuItem(Hamburger);

            Menu.CreateOrder(order);
            Menu.CreateOrder(order2);
            Menu.CreateOrder(order3);
            Menu.ShowOrders();
        }
    }
}
