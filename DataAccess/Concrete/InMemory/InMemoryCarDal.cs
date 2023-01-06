using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{ Id = 1,BrandId=1,ColorId=1,DailyPrice=150000,Description="Spor Araba",ModelYear=2022},
                new Car{ Id = 2,BrandId=1,ColorId=2,DailyPrice=120000,Description="Suv Araba",ModelYear=2020},
                new Car{ Id = 3,BrandId=2,ColorId=1,DailyPrice=100000,Description="Pickup Araba",ModelYear=2019},
                new Car{ Id = 4,BrandId=2,ColorId=2,DailyPrice=80000,Description="Hatchback Araba",ModelYear=2017},              
            };
        }

        public List<Car> GetAll()
        {
            return _car;
        }
        public List<Car> GetAllByCategory(int Id)
        {
            return _car.Where(c => c.Id== Id).ToList();
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }
        public void Delete(Car car)
        {
            Car carToDelete= _car.SingleOrDefault(c => c.Id==car.Id);
            _car.Remove(carToDelete);
        }
        public void Update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id==car.Id);
            carToUpdate.Id=car.Id;
            carToUpdate.BrandId=car.BrandId;
            carToUpdate.ColorId=car.ColorId;
            carToUpdate.ModelYear=car.ModelYear;
            carToUpdate.DailyPrice=car.DailyPrice;
            carToUpdate.Description=car.Description;
        }
    }
}
