namespace SO59114688.Models
{
    public class Order
    {
        public int Id { get; set; }

        //public OrderStatusType CurrentOrderStatus { get; set; }
        public string PublicOrderId { get; set; }

        //public Address PickupAddress { get; set; }
        //public Address DropAddress { get; set; }

        public User Sender { get; set; }
        public User Receiver { get; set; }
        public User Creator { get; set; }

        public double ExpectedDistance { get; set; }
        public int ExpectedDuration { get; set; }
    }
}