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
            UserManager userManager = new UserManager(new EfUserDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            RentalAddTest(rentalManager);
            //UserAddTest(userManager);
            //UserDeleteTest(userManager);

            //GetRentalDetailDtoTest(rentalManager);
        }

        private static void GetRentalDetailDtoTest(RentalManager rentalManager)
        {
            foreach (var detail in rentalManager.GetRentalDetailDto().Data)
            {
                Console.WriteLine("Brand Name : {0}, Car Name : {1}, Daily Price : {2} TL, Rent Date : {3} ", detail.BrandName, detail.CarName, detail.DailyPrice, detail.RentDate);
            }
        }

        private static void UserDeleteTest(UserManager userManager)
        {
            userManager.Delete(new User { Id = 3, FirstName = "Emir,", LastName = "Tekin", Email = "emir@gmail.com", Password = "123456" });
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName + " " + user.LastName);
            }
        }

        private static void UserAddTest(UserManager userManager)
        {
            userManager.Add(new User { FirstName = "Emir", LastName = "Tekin", Email = "emir@gmail.com", Password = "123456" });
            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine(user.FirstName + " " + user.LastName);
            }
        }

        private static void RentalAddTest(RentalManager rentalManager)
        {
            rentalManager.Add(new Rental { CarId = 6, CustomerId = 1, RentDate = DateTime.Now, ReturnDate = null });
            foreach (var rental in rentalManager.GetAll().Data)
            {
                Console.WriteLine(rental.CarId);
            }
        }
    }
}
