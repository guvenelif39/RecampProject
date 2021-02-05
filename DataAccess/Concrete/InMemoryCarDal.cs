using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal

    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2011,DailyPrice=100000,Description="36.000 km"},
                new Car{Id=2,BrandId=1,ColorId=1,ModelYear=2017,DailyPrice=98000,Description="45.000 km"},
                new Car{Id=3,BrandId=2,ColorId=2,ModelYear=2020,DailyPrice=190000,Description="0 km"},
            };
        }

        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _car.SingleOrDefault(p => p.Id == car.Id);
            _car.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int Id)
        {
            return _car.Where(p => p.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = null;
            carToUpdate = _car.SingleOrDefault(p => p.Id == car.Id);
            car.Id = carToUpdate.Id;
            car.BrandId = carToUpdate.BrandId;
            car.ColorId = carToUpdate.ColorId;
            car.ModelYear = carToUpdate.ModelYear;
            car.DailyPrice = carToUpdate.DailyPrice;
            car.Description = carToUpdate.Description;

        }
    }
}
