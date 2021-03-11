using System.Collections.Generic;

namespace ShopifyTrack.Models
{
    public class OrderDetail
    {
        public Orders Order { get; set; }
        public List<Item> Items { get; set; }
        public BillAddress Bill { get; set; }
        public ShipAddress Ship { get; set; }
        public Customer Customer { get; set; }
        public List<OrderStatus> Status { get; set; }
        public List<string> Combo { get; set; }
    }
}
