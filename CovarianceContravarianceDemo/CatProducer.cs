namespace CovarianceContravarianceDemo
{
    internal class CatProducer : IProducer<Cat>
    {
        public Cat Produce(string name)
        {
            return new Cat(name);
        }
    }
}
