using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopifyTrack.Models
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public DateTime CreateDate { get; set; }
        public string OrderId { get; set; }
        [NotMapped]
        public string Date { get; set; }
        [NotMapped]
        public string Time { get; set; }
        [NotMapped]
        public string Active { get; set; }
    }
}
