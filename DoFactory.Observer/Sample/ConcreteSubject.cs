namespace DoFactory.Observer.Sample
{
    class ConcreteSubject : Subject
    {
        private string _subjectState;
        public string SubjectState
        {
            get => _subjectState;
            set
            {
                _subjectState = value;
                this.Notify();
            }
        }
    }
}
