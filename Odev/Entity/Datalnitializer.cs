using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Odev.Entity
{
    public class Datalnitializer:DropCreateDatabaseIfModelChanges<DataContext>
    {
        protected override void Seed(DataContext context)
        {
            var kategoriler = new List<Category>()
            {//kategorilerimizi oluşturduk
                new Category(){Name="KAMERA",Description="KAMERA ÜRÜNLERİ"},
                new Category(){Name="TELEFON",Description="TELEFON ÜRÜNLERİ"},
                new Category(){Name="BİLGİSAYAR",Description="BİLGİSAYAR ÜRÜNLERİ"},
                new Category(){Name="ERKEK GİYİM",Description="ERKEK GİYİM ÜRÜNLERİ ÜRÜNLERİ"}
            };
            foreach (var kategori in kategoriler)
            {//kategorilerimizi veri tabanına eklemiş oluyoruz
                context.Categoris.Add(kategori);
            }
            context.SaveChanges();
            var urunler = new List<Product>()
            {
                new Product() {Name="Canon",Description="kamera ürünleri",Price=2500,Stock=125,IsHome=true,IsApproved=true,IsFeatured=false,Slider=true,CategoryId=1,Image="1.jpg"},
                new Product() {Name="Asus",Description="bilgisayar ürünleri",Price=7000,Stock=100,IsHome=true,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=3,Image="2.jpg"},
                new Product() {Name="Lenova",Description="bilgisayar ürünleri",Price=3500,Stock=50,IsHome=false,IsApproved=true,IsFeatured=true,Slider=false,CategoryId=3,Image="3.jpg"},
                new Product() {Name="Samsung 6S",Description="telefon ürünleri",Price=3000,Stock=150,IsHome=true,IsApproved=true,IsFeatured=true,Slider=true,CategoryId=2,Image="4.jpg"},
                new Product() {Name="İphone 6",Description="telefon ürünleri",Price=5000,Stock=150,IsHome=true,IsApproved=true,IsFeatured=true,Slider=false,CategoryId=2,Image="iphone6s.jpg"},
            };
            foreach (var urun in urunler)
            { //ürünlerimizi veri tabanına ekledik
                context.Products.Add(urun);
            }
            context.SaveChanges();
            base.Seed(context);
        }
    }
}