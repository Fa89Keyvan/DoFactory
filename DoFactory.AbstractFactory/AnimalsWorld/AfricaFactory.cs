namespace DoFactory.AbstractFactory.AnimalsWorld
{
    using AnimalsWorld.Animals;

    /// <summary>
    /// Concrete factory Africa
    /// </summary>
    class AfricaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }

        public override Herbivore CreateHerbivore()
        {
            return new WildBeest();
        }
    }
}
