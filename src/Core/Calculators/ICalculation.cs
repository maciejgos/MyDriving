namespace MyDriving.Core.Calculators
{
    public interface ICalculation<T, K> where T : class
    {
        K Calculate(T entity);
    }
}