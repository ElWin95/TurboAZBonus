using ConsoleAppTurboAzBonus.DataModels;
using ConsoleAppTurboAzBonus.Infrastructore;
using System.Collections;

namespace ConsoleAppTurboAzBonus.Managers
{
    public class BrandManager : IManager<Brand>, IEnumerable<Brand>
    {
        Brand[] data = new Brand[0];

        public void Add(Brand item)
        {
            int len = data.Length;

            Array.Resize(ref data, len + 1);

            data[len] = item;
        }

        public void Edit(Brand item)
        {
            var index = Array.IndexOf(data, item);

            if (index == -1)
                return;

            var found = data[index];

            found.Name = item.Name;
        }

        public void Remove(Brand item)
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

        public Brand this[int index] 
        { 
            get 
            { 
                return data[index]; 
            } 
        }

        public IEnumerator<Brand> GetEnumerator()
        {
            foreach (Brand item in data)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

    }
}
