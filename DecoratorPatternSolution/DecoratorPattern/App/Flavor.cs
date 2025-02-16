﻿namespace DecoratorPattern.App
{
    public class Flavor: BeverageIngredient
    {
        public decimal Price { get; }
        public string Description { get; }
        public int Calories { get; }

        private Flavor(string description, int calories, decimal price)
        {
            Price = price;
            Description = description;
            Calories = calories;
        }

        public static Flavor Caramel = new Flavor("Caramel", 5, .50m);
        public static Flavor Hazelnut = new Flavor("Hazelnut", 5, .50m);
        public static Flavor Raspberry = new Flavor("Raspberry", 5, .50m);
    }
}