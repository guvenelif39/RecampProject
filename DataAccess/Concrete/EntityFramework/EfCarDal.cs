using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, RecampDatabaseContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (RecampDatabaseContext context= new RecampDatabaseContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cc in context.Colors
                             on c.ColorId equals cc.ColorId
                             select new CarDetailDto
                             {
                                 CarName= c.CarName,
                                 BrandName = b.BrandName,
                                 ColorName = cc.ColorName,
                                 DailyPrice = c.DailyPrice
                             };
                return result.ToList();
            }
                        

                         
        }

        
    }
}
