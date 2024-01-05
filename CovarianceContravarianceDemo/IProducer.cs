namespace CovarianceContravarianceDemo
{
    internal interface IProducer<out T>
    {
        T Produce(string name);
    }
}
