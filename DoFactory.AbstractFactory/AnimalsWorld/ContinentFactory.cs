namespace DoFactory.AbstractFactory.AnimalsWorld
{
    /// <summary>
    /// Abstract factory class
    /// </summary>
    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }
}
