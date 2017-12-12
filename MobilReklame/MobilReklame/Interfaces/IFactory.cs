namespace MobilReklame
{
    public interface IFactory<T, TData>
    {
        T Convert(TData obj);
    }
}