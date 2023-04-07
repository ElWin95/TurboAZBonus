using ConsoleAppTurboAzBonus.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTurboAzBonus.DataModels
{
    public class Car : IEquatable<Car>
    {
        static int counter = 0;
        public Car()
        {
            counter++;
            this.Id = counter;
        }
        public int Id { get; private set; }
        public int Year { get; set; }
        public int ModelId { get; set; }
        public Transmission Transmission { get; set; }
        public double Price { get; set; }
        public bool IsNew { get; set; }

        public bool Equals(Car? other)
        {
            return other?.Id == this.Id;
        }
    }
}
