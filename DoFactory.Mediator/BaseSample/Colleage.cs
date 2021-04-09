namespace DoFactory.Mediator.BaseSample
{
    abstract class Colleage
    {
        protected readonly Mediator _mediator;

        public Colleage(Mediator mediator)
        {
            this._mediator = mediator;
        }
    }
}