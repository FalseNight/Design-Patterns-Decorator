namespace DecoratorPattern.App
{
    public class Macchiato : Beverage
    {
        private readonly Size _size;

        public string Description => $"{_size.Description} Macchiato";
        public decimal Price => 2.55m + _size.Ounces * .10m;
        public int Calories => _size.Ounces * 17;

        public Macchiato(Size size)
        {
            _size = size;
        }
    }
}