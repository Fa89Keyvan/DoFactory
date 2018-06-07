using System.Diagnostics;

namespace DoFactory.Observer.MonitoringService
{
    class SmsService : NotifierService
    {
        private string _lastEvent;

        public void SendMessage(string newEvent)
        {
            this._lastEvent = newEvent;
            Debug.WriteLine($"==========================");
            Debug.WriteLine($"Sms sent");
            Debug.WriteLine($"Body: {_lastEvent}");
            Debug.WriteLine($"==========================");
        }

        public override string ToString() => this.GetType().Name;
    }
}
