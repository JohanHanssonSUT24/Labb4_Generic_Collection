namespace Labb4_Generic_Collection
{
    internal class Order
    {
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
        public override string ToString()
        {
            decimal cost = 0;
            foreach (var costs in _orderItems)
            {
                cost += costs.Price;
            }
            var totalItems = string.Join(" - ", _orderItems);
            return $"OrderId: {_orderId}\nTablenumber: {_tableNumber}\nOrder: {totalItems}\nTotal bill: {cost.ToString("C")}\n";
        }

    }

}   

