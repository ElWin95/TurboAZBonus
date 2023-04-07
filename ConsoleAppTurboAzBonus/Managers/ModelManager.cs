using ConsoleAppTurboAzBonus.DataModels;
using ConsoleAppTurboAzBonus.Infrastructore;
using System.Collections;

namespace ConsoleAppTurboAzBonus.Managers
{
    public class ModelManager : IManager<Model>, IEnumerable<Model>
    {
        Model[] data = new Model[0];
        public void Add(Model item)
        {
            int len = data.Length;

            Array.Resize(ref data, len + 1);

            data[len] = item;
        }

        public void Edit(Model item)
        {
            var index = Array.IndexOf(data, item);

            if (index == -1)
                return;

            var found = data[index];

            found.Name = item.Name;
            found.BrandId = item.BrandId;
        }

        public void Remove(Model item)
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

        public Model this[int index]
        {
            get
            {
                return data[index];
            }
        }

        public IEnumerator<Model> GetEnumerator()
        {
            foreach (Model item in data)
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
