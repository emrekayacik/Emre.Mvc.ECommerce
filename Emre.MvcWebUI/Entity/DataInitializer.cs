using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Emre.MvcWebUI.Entity
{
    public class DataInitializer : DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            List<Category> kategoriler = new List<Category>()
            {
                new Category(){Name="Kamera",Description= "Kamera ürünleri"},
                new Category(){Name="Bilgisayar",Description= "Bilgisayar ürünleri"},
                new Category(){Name="Telefon",Description= "Telefon ürünleri"},
                new Category(){Name="Tablet",Description= "TabletTabletTabletTabletTablet"}
            };
            foreach (var category in kategoriler)
            {
                context.Categories.Add(category);
            }

            context.SaveChanges();

            List<Product> urunler = new List<Product>()
            {
                new Product(){Name = "Canon eos 1556",Description = "Canon eos 1556Canon eos 1556Canon eos 1556",Price = 456456,Stock = 4898448,IsApproved = true,CategoryId =1,IsHome = true,Image = "1.png"},
                new Product(){Name = "Canon asdas fdsfs",Description = "Canon asdas fdsfsCanon asdas fdsfs",Price = 645654,Stock = 4564,IsApproved = true,CategoryId = 1,IsHome = true,Image = "2.png"},
                new Product(){Name = "Nikon 700d",Description = "Nikon 700dNikon 700dNikon 700dNikon 700d",Price = 456456,Stock =456 ,IsApproved = true,CategoryId = 1,IsHome = true,Image = "4.png"},
                new Product(){Name = "Nikon 850d",Description = "Nikon 850dNikon 850dNikon 850dNikon 850dNikon 850dNikon 850d",Price =456456 ,Stock =123 ,IsApproved =false ,CategoryId = 1,IsHome = true,Image = "1.png"},

                new Product(){Name = "Casper notebook",Description = "Casper notebookCasper notebookCasper notebookCasper notebookCasper notebook",Price =456456 ,Stock = 897,IsApproved =true ,CategoryId = 2,Image = "1.png"},
                new Product(){Name = "Asus UX310",Description = "Asus UX310Asus UX310Asus UX310Asus UX310Asus UX310Asus UX310",Price =456456 ,Stock =1234 ,IsApproved =true,IsHome = false,CategoryId =2,Image = "4.png"},
                new Product(){Name = "Asus rog strix notebook",Description = "rog strix notebook",Price =456456 ,Stock = 123,IsApproved = true,CategoryId =2 ,IsHome = true,Image = "4.png"},
                new Product(){Name = "Lenovo plus",Description = "lenovo plussssssssssssssssssssssssssssssss",Price = 46554,Stock = 123,IsApproved = false,CategoryId =2 ,IsHome = true,Image = "2.png"},
                new Product(){Name = "Casper nirvana",Description = "Casper nirvana",Price =45645 ,Stock = 123,IsApproved =true ,CategoryId = 2,IsHome = true,Image = "1.png"},
                
                new Product(){Name = "xiaomi",Description = "Canon eos 1556Canon eos 1556Canon eos 1556",Price = 123,Stock = 456456,IsApproved = true,CategoryId =3 ,Image = "2.png"},
                new Product(){Name = "huawei",Description = "Canon asdas fdsfsCanon asdas fdsfs",Price = 121,Stock = 1234,IsApproved = true,CategoryId = 3,IsHome = true,Image = "2.png"},
                new Product(){Name = "sony",Description = "Nikon 700dNikon 700dNikon 700dNikon 700d",Price = 1235,Stock =456 ,IsApproved = true,CategoryId = 3,Image = "3.png"},
                new Product(){Name = "samsung",Description = "Nikon 850dNikon 850dNikon 850dNikon 850dNikon 850dNikon 850d",Price =123487 ,Stock =123 ,IsApproved =true ,CategoryId =3,Image = "4.png" },
                new Product(){Name = "iphone",Description = "Dell inspironDell inspironDell inspironDell inspironDell inspironDell inspironDell inspironDell inspironDell inspironDell inspironDell inspironDell inspironDell inspironDell inspironDell inspironDell inspironDell inspironDell inspironDell inspiron",Price =456456 ,Stock =123547 ,IsApproved = true,CategoryId = 3,IsHome = true,Image = "1.png"}

            };
            foreach (var product in urunler)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}