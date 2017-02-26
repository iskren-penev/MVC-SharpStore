namespace SharpStore.Models
{
    using SharpStore.Enums;

    public class Purchase
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public DeliveryType DeliveryType { get; set; }
    }
}
