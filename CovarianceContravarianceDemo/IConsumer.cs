namespace CovarianceContravarianceDemo
{
    internal interface IConsumer<in T>
    {
        void Consume(T animal);
    }
}
