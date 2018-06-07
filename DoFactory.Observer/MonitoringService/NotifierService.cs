namespace DoFactory.Observer.MonitoringService
{
    interface NotifierService
    {
        void SendMessage(string newEvent);
    }
}
