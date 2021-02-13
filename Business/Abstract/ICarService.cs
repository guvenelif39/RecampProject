using Business.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IResult Add(Car car);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
        IResult Delete(Car car);
        IResult Update(Car car);
        IDataResult<Car> GetId(int id);
        IDataResult<List<ProjectDetailDto>> projectDetailDtos(Car car);

    }
}
