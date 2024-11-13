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
        public int OrderId()
        {
            return _orderId;
        }

        public override string ToString()
        {
            decimal cost = 0;
            foreach (var costs in _orderItems)
            {
                cost += costs.Price;
            }           
            //String.join to create a clear overview with all parameters of each order
            string totalItems = string.Join(" - ", _orderItems);
            return $"\tORDERNUMBER: {_orderId}\n\tOrder: {totalItems}\n\tTablenumber: {_tableNumber}\n\tTotal bill: {cost.ToString("C")}\n";            
        }
    }
}   

