// See https://aka.ms/new-console-template for more information
using CovarianceContravarianceDemo;

IProducer<Animal> producer = new CatProducer();
var animal = producer.Produce("Mittens");
Console.WriteLine($"Produced {animal.Name}");
Console.ReadLine();
