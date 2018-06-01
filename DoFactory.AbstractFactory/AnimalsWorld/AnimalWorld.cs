namespace DoFactory.AbstractFactory.AnimalsWorld
{
    class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalWorld(ContinentFactory continentFactory)
        {
            this._carnivore = continentFactory.CreateCarnivore();
            this._herbivore = continentFactory.CreateHerbivore();
        }

        public void RunFoodChain()
        {
            this._carnivore.Eat(this._herbivore);
        }
    }
}
