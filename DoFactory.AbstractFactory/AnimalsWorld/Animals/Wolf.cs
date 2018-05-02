using System.Diagnostics;

namespace DoFactory.AbstractFactory.AnimalsWorld.Animals
{
    class Wolf : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Debug.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }
}
