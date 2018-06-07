using System;

namespace DoFactory.Observer
{
    using Sample;
    using MonitoringService;

    class Program
    {
        static void Main(string[] args)
        {
            //TestSample();
            TestMonitoringService();
        }

        private static void TestMonitoringService()
        {
            ServiceMonitor serviceMonitor = new ServiceMonitor();
            serviceMonitor.AttachNotifer(new MailService());
            serviceMonitor.AttachNotifer(new SmsService());

            serviceMonitor.LastEvent = "Sql server service has been stoped unexpectly !!!";
        }

        private static void TestSample()
        {
            ConcreteSubject concreteSubject = new ConcreteSubject();

            concreteSubject.Attach(new ConcreteObserver(concreteSubject, "A"));
            concreteSubject.Attach(new ConcreteObserver(concreteSubject, "B"));
            concreteSubject.Attach(new ConcreteObserver(concreteSubject, "C"));

            concreteSubject.SubjectState = "xyz";

        }
    }
}
