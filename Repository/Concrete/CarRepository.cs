using Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Concrete
{
    public class CarRepository : IRepository<Car>
    {
        private List<Car> cars = new List<Car>();
        public CarRepository()
        {
            cars.Add(new Car(Guid.NewGuid(),"BMW"));
            cars.Add(new Car(Guid.NewGuid(),"Mercedes"));
            cars.Add(new Car(Guid.NewGuid(),"Audi"));
        }
        public Car Get()
        {
            return cars.First();
        }

        public List<Car> GetAll()
        {
            return cars;
        }
    }
}
