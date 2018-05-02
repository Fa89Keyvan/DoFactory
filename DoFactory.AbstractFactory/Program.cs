using System;

namespace DoFactory.AbstractFactory
{
    using Animals;
    class Program
    {
        static void Main(string[] args)
        {
            
            AnimalWorld animalWorldAfrica = new AnimalWorld(new AfricaFactory());

            animalWorldAfrica.RunFoodChain();

            AnimalWorld animalWorldAmerica = new AnimalWorld(new AmericaFactory());

            animalWorldAmerica.RunFoodChain();

        }
    }
}
