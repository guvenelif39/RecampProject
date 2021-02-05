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
            Console.WriteLine("Araba başarıyla eklendi.");
        }

        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        
    }
}
