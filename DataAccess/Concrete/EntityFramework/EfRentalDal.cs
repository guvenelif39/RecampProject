using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RecampDatabaseContext>, IRentalDal
    {

        public List<RentalDetailDto> GetRentalDetailDto()
        {
            using (RecampDatabaseContext context = new RecampDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join r in context.Rentals
                             on c.CarId equals r.CarId
                             select new RentalDetailDto()
                             {
                                 CarName = c.CarName,
                                 BrandName = b.BrandName,
                                 DailyPrice = c.DailyPrice,
                                 RentDate= r.RentDate,

                             };
                return result.ToList();

            }

        }
    }
}
