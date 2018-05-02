using System.Diagnostics;

namespace DoFactory.AbstractFactory.AnimalsWorld.Animals
{
    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            // Eat Wildebeest
            Debug.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }
}
