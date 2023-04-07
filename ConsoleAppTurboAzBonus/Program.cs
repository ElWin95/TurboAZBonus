using ConsoleAppTurboAzBonus.DataModels;
using ConsoleAppTurboAzBonus.Enums;
using ConsoleAppTurboAzBonus.Helpers;
using ConsoleAppTurboAzBonus.Managers;

namespace ConsoleAppTurboAzBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BrandManager brandManager = new BrandManager();
            ModelManager modelManager = new ModelManager();
            CarManager carManager = new CarManager();


            MenuTypes selectedMenu;

            Brand brand;
            int id;

            l1:
            Console.WriteLine("### Edeceyiniz emeliyyati siyahidan secin");
            selectedMenu = Helper.ReadEnum<MenuTypes>("menu: ");
            switch (selectedMenu)
            {
                case MenuTypes.BrandAdd:
                    brand = new Brand();
                    brand.Name = Helper.ReadString("Markanin adi: ");
                    brandManager.Add(brand);

                    Console.Clear();
                    goto l1;

                case MenuTypes.BrandEdit:
                    Console.WriteLine("Redakte etmek istediyiniz markani secin");
                    foreach (var item in brandManager)
                    {
                        Console.WriteLine(item);
                    }
                    id = Helper.ReadInt("Marka id");

                    if (id == 0) 
                        goto l1;

                    brand = brandManager.GetById(id);

                    if (brand == null) 
                    {
                        Console.Clear();
                        goto case MenuTypes.BrandEdit;
                    }

                    brand.Name = Helper.ReadString("Markanin adi: ");
                    Console.Clear();
                    goto case MenuTypes.BrandGetAll;

                case MenuTypes.BrandRemove:
                    Console.WriteLine("Silmek etmek istediyiniz markani secin");
                    foreach (var item in brandManager)
                    {
                        Console.WriteLine(item);
                    }
                    id = Helper.ReadInt("Marka id");
                    brand = brandManager.GetById(id);
                    if (brand == null)
                    {
                        Console.Clear();
                        goto case MenuTypes.BrandRemove;
                    }
                    brandManager.Remove(brand);
                    Console.Clear();
                    goto case MenuTypes.BrandGetAll;

                case MenuTypes.BrandGetAll:
                    Console.Clear();
                    foreach (var item in brandManager)
                    {
                        Console.WriteLine(item);
                    }
                    goto l1;
                case MenuTypes.BrandGetById:
                    id = Helper.ReadInt("Marka id");

                    if (id == 0)
                    {
                        Console.Clear();
                        goto l1;
                    }

                    brand = brandManager.GetById(id);
                    if (brand == null)
                    {
                        Console.Clear();
                        Console.WriteLine("Tapilmadi...");
                        goto case MenuTypes.BrandGetById;
                    }

                    Console.WriteLine(brand);
                    goto l1;

                case MenuTypes.BrandFindByName:
                    string name = Helper.ReadString("Axtarish ucun adin en az 3 herfini qeyd edin: ");
                    var data = brandManager.FindByName(name);

                    if (data.Length == 0)
                    {
                        Console.WriteLine("Tapilmadi...");
                    }
                    foreach (var item in data)
                    {
                        Console.WriteLine(item);
                    }

                    goto l1;
                case MenuTypes.ModelAdd:
                    break;
                case MenuTypes.ModelEdit:
                    break;
                case MenuTypes.ModelRemove:
                    break;
                case MenuTypes.ModelGetAll:
                    break;
                case MenuTypes.ModelGetById:
                    break;
                case MenuTypes.ModelFindByName:
                    break;
                case MenuTypes.CarAdd:
                    break;
                case MenuTypes.CarEdit:
                    break;
                case MenuTypes.CarRemove:
                    break;
                case MenuTypes.CarGetAll:
                    break;
                case MenuTypes.CarGetById:
                    break;
                case MenuTypes.CarFindByName:
                    break;
            }
        }
    }
}