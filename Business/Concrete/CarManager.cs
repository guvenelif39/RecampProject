using Business.Abstract;
using Business.Constant;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTO;
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

        public IResult Add(Car car)
        {
            if (car.DailyPrice>0 && car.CarName.Length>=2)
            {
                _carDal.Add(car);
                return new SuccessResult(Messages.SuccessAdded);
            }
               
             return new ErrorResult(Messages.FailMessage);
            
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.SuccessDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.SuccessMessage);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.BrandId == brandId), Messages.SuccessMessage);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(p => p.ColorId == colorId), Messages.SuccessMessage);
        }

        public IDataResult<Car> GetId(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.CarId == id), Messages.SuccessMessage);
        }

        public IDataResult<List<CarDetailDto>> projectDetailDtos(Car car)
        {
           return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(),Messages.SuccessMessage);
        }

        public IResult Update(Car car)
        {
            if (car.CarName.Length>=2)
            {
                _carDal.Update(car);
               return new SuccessResult(Messages.SuccessUpdated);
            }
            else
            {
                return new ErrorResult(Messages.FailMessage);
            }
        }

    }
}
