namespace aspnetcore_jwt.Data
{
    public class OrderDetails
    {
        public Guid ProductId { get; set; }
        public Guid OrderId { get; set; }
        public int Quantity { get; set; }
        public double UnitPrice { get; set; }
        public byte Discount { get; set; }

        //relationship
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
