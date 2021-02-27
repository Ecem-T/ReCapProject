using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
<<<<<<< HEAD
    public interface ICarDal:IEntityRepository<Car>
    {         
        
=======
    public interface ICarDal
    {
        
        List<Car> GetAll();
        void Add(Car car);
        void Update(Car car);
        void Delete(Car car);
        List<Car> GetAllByCategory(int categoryId);





>>>>>>> 78b08a1705d17c7da05b4302f679108c4ebe6e58
    }
}
