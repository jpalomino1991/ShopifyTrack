using System.ComponentModel.DataAnnotations;

namespace ShopifyTrack.Models
{
    public class Web
    {
        [Key]
        public int Id { get; set; }
        public string WebURL { get; set; }
        public string WebAPI { get; set; }
        public string WebPassword { get; set; }
        public string LocationId { get; set; }
        public string SMTPUser { get; set; }
        public string SMTPPassword { get; set; }
        public string SMTPURL { get; set; }
    }
}
