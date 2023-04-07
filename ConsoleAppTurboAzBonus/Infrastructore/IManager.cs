namespace ConsoleAppTurboAzBonus.Infrastructore
{
    public interface IManager<T>
    {
        void Add(T item);
        void Edit(T item);
        void Remove(T item);
    }
}
