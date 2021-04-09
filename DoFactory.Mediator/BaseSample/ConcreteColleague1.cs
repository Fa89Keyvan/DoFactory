using System;

namespace DoFactory.Mediator.BaseSample
{
    class ConcreteColleague1 : Colleage
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator)
        {

        }

        public void Send(string message)
        {
            this._mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"Colleague1 gets message: {message}");
        }
    }
}
