namespace DoFactory.Builder.Sample
{
    abstract class Builder
    {
        public abstract void BuildPartX();
        public abstract void BuildPartY();

        public abstract Product GetResult();
    }
}
