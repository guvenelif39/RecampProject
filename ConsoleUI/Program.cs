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
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            CustomerManager customer = new CustomerManager(new EfCustomerDal());

            rentalManager.Add(new Rental { CarId = 2 , CustomerId=1, RentDate=DateTime.Now, ReturnDate=null});
            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rental.CarId);
            }





        }


    }
}
