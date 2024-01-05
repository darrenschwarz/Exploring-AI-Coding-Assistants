using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("CovarianceContravarianceDemo.Tests")]
namespace CovarianceContravarianceDemo
{
    internal class Cat : Animal
    {


        public Cat(string name) : base(name)
        {

        }
    }
}

