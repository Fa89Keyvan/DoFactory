namespace DoFactory.Builder.Sample
{
    class Director
    {
        public void Construct(Builder builder)
        {
            builder.BuildPartX();
            builder.BuildPartY();
        }
    }
}
