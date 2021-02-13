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



            //Console.WriteLine("*************RENK SEÇENEKLERİ*************");
            //foreach (var color in colorManager.GetAll().Data)
            //{
            //    Console.WriteLine(color.ColorName);
            //}

            Console.WriteLine("***********ARABA İSİMLERİ************");
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.CarName);
            }

           

        }
        
        
    }
}
