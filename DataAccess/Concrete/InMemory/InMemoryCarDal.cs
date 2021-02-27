using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                    new Car{ Id=1,  BrandId=1, ColorId=1, DailyPrice=1200, ModelYear=2019, Description="Red Audi"},
                    new Car{ Id=2,  BrandId=1, ColorId=2, DailyPrice=2000, ModelYear=2020, Description="White Mercedes"},
                    new Car{ Id=3,  BrandId=2, ColorId=1, DailyPrice=1300, ModelYear=2017, Description="Yellow VW"},
                    new Car{ Id=4,  BrandId=3, ColorId=3, DailyPrice=2500, ModelYear=2021, Description="Dark Blue BMW"},
                    new Car{ Id=5,  BrandId=3, ColorId=2, DailyPrice=1750, ModelYear=2018, Description="Black Fiat"},

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);

        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(p => p.Id == id).ToList();

        }

        public Car GetById(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }


        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }
    }
}
