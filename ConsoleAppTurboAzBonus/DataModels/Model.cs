namespace ConsoleAppTurboAzBonus.DataModels
{
    public class Model : IEquatable<Model>
    {
        static int counter = 0;
        public Model()
        {
            counter++;
            this.Id = counter;
        }
        public int Id { get; private set; }
        public string Name { get; set; }
        public int BrandId { get; set; }

        public bool Equals(Model? other)
        {
            return other?.Id == this.Id;
        }

        public override string ToString()
        {
            return $"{Id} | {Name}";
        }
    }
}

