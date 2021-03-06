using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopifyTrack.Models
{
    public class KellyChild
    {
        public string CodigoPadre { get; set; }
        public string CodigoSistema { get; set; }
        public string Talla { get; set; }
        public int Peso { get; set; }
        public decimal PrecioTV { get; set; }
        public string PermitePromocion { get; set; }
        public decimal Promocion { get; set; }
        public string InicioPromocion { get; set; }
        public string FinPromocion { get; set; }
        public int StockTotal { get; set; }
        public string Id { get; set; }
        public string CompareAtPrice { get; set; }
        public decimal Price { get; set; }
        public string Size { get; set; }
        public string SKU { get; set; }
        public int Stock { get; set; }
        public string Taco { get; set; }
    }
}
