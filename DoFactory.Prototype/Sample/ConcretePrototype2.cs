namespace DoFactory.Prototype.Sample
{
    /// <summary>
    /// A 'ConcretePrototype' class 
    /// </summary>
    class ConcretePrototype2 : Prototype
    {
        // Constructor
        public ConcretePrototype2(string id) : base(id) { }

        // Returns a shallow copy
        public override Prototype Clone() => (Prototype)this.MemberwiseClone();
    }
}
