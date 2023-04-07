using ConsoleAppTurboAzBonus.DataModels;
using ConsoleAppTurboAzBonus.Managers;

namespace ConsoleAppTurboAzBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BrandManager brandManager = new BrandManager();
            ModelManager modelManager = new ModelManager();

            Brand brand = new Brand();
            brand.Name = "Kia";
            brandManager.Add(brand);

            Brand brand2 = new Brand();
            brand2.Name = "Mercedes";
            brandManager.Add(brand2);

            Brand brand3 = new Brand();
            brand3.Name = "BMW";
            brandManager.Add(brand3);

            var forRemove = new Brand(3);
            brandManager.Remove(forRemove);

            foreach (var item in brandManager)
            {
                Console.WriteLine(item);
            }

            var reNew = new Brand(1)
            {
                Name = "Kia-x1"
            };
            brandManager.Edit(reNew);
            Console.WriteLine("=======================================================");
            foreach (var item in brandManager)
            {
                Console.WriteLine(item);
            }
        }
    }
}