using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        void Add(Color color);
        List<Color> GetAll();
        void Delete(Color color);
        void Update(Color color);
        Color GetId(int id);
    }
}
