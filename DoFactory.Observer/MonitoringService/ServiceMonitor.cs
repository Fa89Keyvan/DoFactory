using System;
using System.Collections.Generic;
using System.Text;

namespace DoFactory.Observer.MonitoringService
{
    class ServiceMonitor
    {
        private List<NotifierService> _notifierServices = new List<NotifierService>();
        private string _lastEvent = string.Empty;

        public ServiceMonitor()
        {

        }

        public string LastEvent
        {
            get => _lastEvent;
            set
            {
                _lastEvent = value;
                NotifyByAllServices();
            }
        }

        public void AttachNotifer(NotifierService notifierService)
        {
            if(notifierService == null)
                throw new ArgumentNullException("notifierService");
            if(_notifierServices.Contains(notifierService))
                return;
            _notifierServices.Add(notifierService);
        }
        public void DetachNotifier(NotifierService notifierService)
        {
            if(notifierService == null)
                throw new ArgumentNullException("notifierService");
            _notifierServices.Remove(notifierService);
        }
        private void NotifyByAllServices() 
            => _notifierServices.ForEach((notiferService) => { notiferService.SendMessage(_lastEvent); });
    }
}
