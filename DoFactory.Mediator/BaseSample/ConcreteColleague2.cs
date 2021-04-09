using System;

namespace DoFactory.Mediator.BaseSample
{
    class ConcreteColleague2 : Colleage
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {

        }

        public void Send(string message)
        {
            this._mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"Colleague2 gets message: {message}");
        }
    }
}
