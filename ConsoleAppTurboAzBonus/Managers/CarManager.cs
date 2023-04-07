using ConsoleAppTurboAzBonus.DataModels;
using ConsoleAppTurboAzBonus.Infrastructore;
using System.Collections;

namespace ConsoleAppTurboAzBonus.Managers
{
    public class CarManager : IManager<Car>, IEnumerable<Car>
    {
        Car[] data = new Car[0];
        public void Add(Car item)
        {
            int len = data.Length;

            Array.Resize(ref data, len + 1);

            data[len] = item;
        }

        public void Edit(Car item)
        {
            var index = Array.IndexOf(data, item);

            if (index == -1)
                return;

            var found = data[index];

            found.Year = item.Year;
            found.ModelId = item.ModelId;
            found.Transmission = item.Transmission;
            found.Price = item.Price;
            found.IsNew = item.IsNew;
        }

        public void Remove(Car item)
        {
            int index = Array.IndexOf(data, item);

            if (index == -1)
                return;

            int len = data.Length - 1;
            for (int i = index; i < len; i++)
            {
                data[i] = data[i + 1];
            }
            Array.Resize(ref data, len);
        }

        public IEnumerator<Car> GetEnumerator()
        {
            foreach (Car item in data)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public Car GetById(int id)
        {
            return Array.Find(data, item => item.Id == id);
        }

      

        public Car this[int index] 
        { 
            get 
            {
                return data[index];
            } 
        }
    }
}
