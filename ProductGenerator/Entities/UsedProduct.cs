namespace ProductGenerator.Entities
{
    class UsedProduct : Product
    {
        public DateTime Date { get; set; }

        public UsedProduct(string name, double price, DateTime date) 
            :base(name, price)
        {
            Date = date;
        }

        public override string PriceTag()
        {
            return Price.ToString("F2") + $"(Manufacture date: {Date})";
        }
    }
}
