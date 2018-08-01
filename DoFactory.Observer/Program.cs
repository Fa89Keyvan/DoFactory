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
            var car = new Car(20000000.0m) { ProductName = "Car" };
            var home = new Home(22000000.0m) { ProductName = "Home" };

            var agent = new Agent();
            agent.AddProduct(car);
            agent.AddProduct(home);

            car.Price += 5000000.0m;
            home.Price += 3000000.0m;
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
