using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Emre.MvcWebUI.Entity
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Ürün İsmi")]
        public string Name { get; set; }
        [DisplayName("Ürün Açıklaması")]
        public string Description { get; set; }
        [DisplayName("Ürün Fiyatı")]
        public double Price { get; set; }
        [DisplayName("Ürün Stoğu")]
        public int Stock { get; set; }
        [DisplayName("Ürünün Fotoğrafı")]
        public string Image { get; set; }
        [DisplayName("Ürün Anasayfada mı?")]
        public bool IsHome { get; set; }
        [DisplayName("Ürün Onaylandı mı?")]
        public bool IsApproved { get; set; }
        [DisplayName("Ürünün Kategorisi")]
        public int CategoryId { get; set; }
        [DisplayName("Ürünün Kategorisi")]
        public Category Category { get; set; }
    }
}