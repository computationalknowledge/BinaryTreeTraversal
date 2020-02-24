using System;

namespace LinkedList1
{
    class Driver
    {
        static void Main(String [] args)
        {
            Fruit apple = new Fruit("Apple", 100, null); 
        }
    }
    class FruitBasket
    {
        Fruit fruit1;
    }

    class Fruit
    {
        public Fruit(String thisFruitName, int thisCalories, Fruit aFruit)
        {
            fruitName = thisFruitName;
            Calories = thisCalories;
            nextFruit = aFruit;
        }
        String fruitName = "";
        int Calories;
        Fruit nextFruit;
    }
}
