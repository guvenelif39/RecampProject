using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        void Add(Brand brand);
        List<Brand> GetAll();
        void Delete(Brand brand);
        void Update(Brand brand);
        Brand GetId(int id);
    }
}
