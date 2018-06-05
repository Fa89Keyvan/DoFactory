namespace DoFactory.Prototype.Sample
{
    /// <summary>
    /// A 'ConcretePrototype' class 
    /// </summary>
    class ConcretePrototype1 : Prototype
    {
        // Constructor
        public ConcretePrototype1(string id) : base(id) { }

        // Returns a shallow copy
        public override Prototype Clone() => (Prototype)this.MemberwiseClone();
        
    }
}
