namespace DoFactory.Builder.Sample
{
    class ConcreteBuilderA : Builder
    {
        private Product _product = new Product();

        public override void BuildPartX()   => _product.AddPart("PartX");
        public override void BuildPartY()   => _product.AddPart("PartY");
        public override Product GetResult() => _product;
    }
}
