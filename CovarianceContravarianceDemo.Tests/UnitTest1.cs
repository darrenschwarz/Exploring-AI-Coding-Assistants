using Xunit;
using CovarianceContravarianceDemo;

public class CovarianceContravarianceTests
{
    [Fact]
    public void CovarianceTest()
    {
        IProducer<Animal> producer = new CatProducer();
        var animal = producer.Produce("Mittens");
        Assert.IsType<Cat>(animal);
    }

    [Fact]
    public void ContravarianceTest()
    {
        IConsumer<Cat> consumer = new AnimalConsumer();
        var cat = new Cat ("Mittens");
        consumer.Consume(cat); // Should not throw an exception
        Assert.True(true); // Just to indicate the test passed
    }
}
