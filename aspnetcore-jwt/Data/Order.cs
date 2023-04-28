using System.ComponentModel.DataAnnotations.Schema;

namespace aspnetcore_jwt.Data
{
    public enum OrderStatus
    {
        New = 0, Payment = 1, Complete = 2, Cancel = -1
    }

    [Table("Order")]
    public class Order
    {
        public Guid OrderId { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public OrderStatus Status { get; set; }
        public string Receiver { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public ICollection<OrderDetails> OrderDetails { get; set; }
        public Order()
        {
            OrderDetails = new List<OrderDetails>();
        }
    }
}
