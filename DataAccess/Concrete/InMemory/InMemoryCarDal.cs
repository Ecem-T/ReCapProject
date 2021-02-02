using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                    new Car{ CarId=1,  CategoryId=1, BrandId="Audi", ColorId="Red", DailyPrice=1200, ModelYear=2019, Description="Navigasyonlu" },
                    new Car{ CarId=2,  CategoryId=2, BrandId="Mercedes", ColorId="White", DailyPrice=2000, ModelYear=2020, Description="Navigasyonlu, Sunrooflu" },
                    new Car{ CarId=3,  CategoryId=1, BrandId="VW", ColorId="Yellow", DailyPrice=1300, ModelYear=2017, Description="Celik jant" },
                    new Car{ CarId=4,  CategoryId=2, BrandId="BMW", ColorId="Dark Blue", DailyPrice=2500, ModelYear=2021, Description="Yol tutus" },
                    new Car{ CarId=5,  CategoryId=3, BrandId="Fiat", ColorId="Black", DailyPrice=1750, ModelYear=2018, Description="Otomatik bagaj sistemi" },

            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete= _cars.SingleOrDefault(c=>c.CarId== car.CarId);
            _cars.Remove(carToDelete);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByCategoryId(int categoryId)
        {
           return _cars.Where(c => c.CategoryId == categoryId).ToList();

        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.CategoryId = car.CategoryId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }
    }
}
