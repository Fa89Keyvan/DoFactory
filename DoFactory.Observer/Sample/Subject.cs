using System.Collections.Generic;

namespace DoFactory.Observer.Sample
{
    abstract class Subject
    {
        private List<Observer> _observers = new List<Observer>();

        public void Attach(Observer observer) => this._observers.Add(observer);
        public void Remove(Observer observer) => this._observers.Remove(observer);
        public void Notify() => _observers.ForEach((observer) => { observer.Update(); });

    }
}
