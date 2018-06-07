using System;
using System.Diagnostics;

namespace DoFactory.Observer.Sample
{
    class ConcreteObserver : Observer
    {
        private string _name;
        private string _observerState;
        private ConcreteSubject _subject;
        

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this._subject = subject;
            this._name    = name;
        }

        public override void Update()
        {
            this._observerState = _subject.SubjectState;
            Debug.WriteLine($"Observer {_name}'s new state is {_observerState}");
        }
    }
}
