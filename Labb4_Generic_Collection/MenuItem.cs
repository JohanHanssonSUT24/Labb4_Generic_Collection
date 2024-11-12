namespace Labb4_Generic_Collection
{
    internal class MenuItem
    {
        //Auto-implemented properties
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public MenuItem(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
        //Override to display dish and its price
        public override string ToString()
        {
            return $"{Name} - {Price:C}";
        }
    }
}
