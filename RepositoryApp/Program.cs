// See https://aka.ms/new-console-template for more information
using Newtonsoft.Json;
using Repository.Concrete;


CarRepository carRepository = new CarRepository();

Console.WriteLine(JsonConvert.SerializeObject(carRepository.GetAll()));