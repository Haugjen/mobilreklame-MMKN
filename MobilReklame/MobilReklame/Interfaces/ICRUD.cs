namespace MobilReklame
{
    public interface ICRUD<TData, TKey>
    {
        void Create(TData obj);
        void Delete(TKey key);
        void Update(TData obj);
    }
}

