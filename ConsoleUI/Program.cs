using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine("ID = " + car.Id+" " + "Bland ID = " + car.BrandId+" " + "Colar ID = " + car.ColorId +" "+ "Model = " + car.ModelYear +" "+"Fiyat = " + car.DailyPrice + " " + "Açıklama = " + car.Description);
            }
        }
    }
}
