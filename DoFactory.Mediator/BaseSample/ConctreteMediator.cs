using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoFactory.Mediator.BaseSample
{
    class ConctreteMediator : Mediator
    {

        private ConcreteColleague1 _colleague1;
        private ConcreteColleague2 _colleague2;

        public void SetColleague1(ConcreteColleague1 colleague1) => this._colleague1 = colleague1;
        public void SetColleague2(ConcreteColleague2 colleague2) => this._colleague2 = colleague2;

        public override void Send(string message, Colleage colleage)
        {
            if(colleage == _colleague1)
            {
                _colleague2.Notify(message);
                return;
            }

            if(colleage == _colleague2)
            {
                _colleague1.Notify(message);
                return;
            }

            throw new ArgumentException("Invalid colleague type");
        }


    }
}
