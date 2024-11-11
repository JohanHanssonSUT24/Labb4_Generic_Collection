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
        }
    }
}
