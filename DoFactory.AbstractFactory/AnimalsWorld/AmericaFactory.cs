namespace DoFactory.AbstractFactory.AnimalsWorld
{
    using Animals;

    /// <summary>
    /// Concrete factory America
    /// </summary>
    class AmericaFactory : ContinentFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}
