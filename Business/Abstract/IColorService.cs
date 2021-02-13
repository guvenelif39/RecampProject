using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IResult Add(Color color);
        IDataResult<List<Color>> GetAll();
        IResult Delete(Color color);
        IResult Update(Color color);
        IDataResult<Color> GetId(int id);
    }
}
