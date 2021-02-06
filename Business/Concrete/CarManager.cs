using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal car)
        {
            _carDal = car;
        }

        public void Add(Car car)
        {
            if (car.DailyPrice>0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("Günlük fiyat için sıfırdan büyük değer giriniz.");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            return _carDal.GetAll(p => p.BrandId == brandId);
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            return _carDal.GetAll(p => p.ColorId == colorId);
        }

        public Car GetId(int id)
        {
            return _carDal.Get(p => p.Id == id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }

    }
}
