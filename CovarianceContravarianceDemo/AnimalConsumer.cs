namespace CovarianceContravarianceDemo
{
    internal class AnimalConsumer : IConsumer<Animal>
    {
        public void Consume(Animal animal)
        {
            Console.WriteLine($"Consuming {animal.Name}");
        }
    }
}
