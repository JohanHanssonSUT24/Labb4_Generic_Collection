namespace Labb4_Generic_Collection
{
    internal class Order
    {
        //Private fields
        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;


        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }
        public void AddMenuItem(MenuItem menuItem)
        {
            _orderItems.Add(menuItem);
        }
        
        //Override to display orderID, tableNo, items ordered and total cost of order.
        public override string ToString()
        {
            decimal cost = 0;
            foreach (var costs in _orderItems)
            {
                cost += costs.Price;
            }
            
            //String.join to create a clear overview with all parameters of each order
            string totalItems = string.Join(" - 1, ", _orderItems);
            return $"Ordernumber: {_orderId}\n------------\nTablenumber: {_tableNumber}\nOrder: 1, {totalItems}\nTotal bill: {cost.ToString("C")}\n";            
        }

    }

}   

