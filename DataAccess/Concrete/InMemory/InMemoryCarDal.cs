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
            _cars = new List<Car>
            {
                new Car{ Id=1, BrandId=1, ColorId= 2, ModelYear=2020 ,DailyPrice=470000, Description="volkswagen jetta 2020 Benzin Otomatil" },
                new Car{ Id=2, BrandId=2, ColorId= 1, ModelYear=2020 ,DailyPrice=345000, Description="Renault 3008  2020 Dizel Otomatil" },
                new Car{ Id=3, BrandId=3, ColorId= 3, ModelYear=2016 ,DailyPrice=378000, Description="Bmw 2014 Benzin Otomatil" },
                new Car{ Id=4, BrandId=4, ColorId= 1, ModelYear=2016 ,DailyPrice=250000, Description="Audi A4 2016 Benzin Otomatil" },
                new Car{ Id=5, BrandId=5, ColorId= 2, ModelYear=2014 ,DailyPrice=116000, Description="Honda Civic VTEC 2014 Benzin Manuel" },



            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
