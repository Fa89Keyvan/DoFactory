namespace DoFactory.Builder.Sample
{
    class ConcreteBuilderB : Builder
    {
        private Product _product = new Product();

        public override void BuildPartX()   => _product.AddPart("PartXX");
        public override void BuildPartY()   => _product.AddPart("PartYY");
        public override Product GetResult() => _product;
    }
}
