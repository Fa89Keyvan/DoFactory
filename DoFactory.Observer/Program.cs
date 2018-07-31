using System;

namespace DoFactory.Observer
{
    using Sample;
    using MonitoringService;
    using MarketFuctuations;

    class Program
    {
        static void Main(string[] args)
        {
            //TestSample();
            //TestMonitoringService();
            TestMarketFuctuations();
        }
        
        private static void TestMarketFuctuations()
        {
            var product = new Product(100.0m);
            var agent   = new Agent();
            agent.AddProduct(product);
            product.Price = 110.0m;
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
