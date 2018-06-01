namespace DoFactory.AbstractFactory.AnimalsWorld
{
    /// <summary>
    /// Abstract factory class
    /// قاره
    /// </summary>
    abstract class ContinentFactory
    {
        /// <summary>
        /// گیاهخواران
        /// </summary>
        /// <returns></returns>
        public abstract Herbivore CreateHerbivore();
        /// <summary>
        /// گوشتخواران
        /// </summary>
        /// <returns></returns>
        public abstract Carnivore CreateCarnivore();
    }
}
