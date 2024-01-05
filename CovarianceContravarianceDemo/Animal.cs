namespace CovarianceContravarianceDemo
{
    public abstract class Animal
    {
        private string _name;

        public string Name { get => _name; }

        internal Animal(string name)
        {
            _name = name;
        }
    }
}
