namespace ConsoleAppTurboAzBonus.DataModels
{
    public class Brand : IEquatable<Brand>
    {
        static int counter = 0;
        public Brand()
        {
            counter++;
            this.Id = counter;
        }
        public Brand(int id)
        {
            this.Id = id; 
        }
        public int Id { get; private set; }
        public string Name { get; set; }

        public bool Equals(Brand? other)
        {
            return other?.Id == this.Id;
        }

        public override string ToString()
        {
            return $"{Id} | {Name}";
        }
    }
}
