using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            CarManager carManager = new CarManager(new EfCarDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }

            Console.WriteLine("\n");

            Console.WriteLine("Color Id'si 2 olan araçların markası, rengi ve günlük kira ücretleri: ");
            foreach (var car in carManager.GetCarsByColorId(2))
            {
                Console.WriteLine("Marka: " + brandManager.GetId(car.Id).Name + " Renk: " + colorManager.GetId(car.Id).Name + " Günlük fiyat: " + car.DailyPrice + " TL");

            }

            Console.WriteLine("\n");

            Console.WriteLine("Brand Id'si 1 olan araçların markaları, açıklamaları ve günlük kira ücretleri: ");
            foreach (var car in carManager.GetCarsByBrandId(1))
            {
                Console.WriteLine("Marka: " + brandManager.GetId(car.Id).Name + " Açıklama: " +car.Descriptions + " Günlük fiyat: " + car.DailyPrice + " TL");

            }

            Console.WriteLine("\n");
            Console.WriteLine("--------Ekleme Metodu Uygulanmış Hali-------");

            carManager.Add(new Car { Id = 2, BrandId = 2, ColorId = 3, DailyPrice = 0, ModelYear = "2015", Descriptions = "Otomatik Vites" });
            brandManager.Update(new Brand { Id = 5, Name = "a" });



        }
    }
}
