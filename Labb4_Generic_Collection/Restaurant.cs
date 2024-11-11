namespace Labb4_Generic_Collection
{
    internal class Restaurant
    {
        public List<MenuItem> _menu = new List<MenuItem>();
        public Queue<Order> _order = new Queue<Order>();


        public void AddtoMenu(MenuItem menuItem)
        {
            _menu.Add(menuItem);
        }
        public void ShowMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("-------------");
            foreach (var item in _menu)
            {
                Console.WriteLine(item);
            }
        }
        public void CreateOrder(Order order)
        {
            _order.Enqueue(order);
        }
        public void HandleOrder()
        {

        }
        public void ShowOrders()
        {

        }
        public void ShowNextOrder()
        {

        }
        public void ShowOrderCount()
        {

        }


    }
}
