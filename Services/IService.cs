namespace repro.Services;
public interface IService<T1, T2>
{
    public T1 Create();
    public void Sink(T2 value);
}
