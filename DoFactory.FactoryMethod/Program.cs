using System;
using System.Diagnostics;

namespace DoFactory.FactoryMethod
{
    using DoFactory.FactoryMethod.CMS;
    using Sample;

    class Program
    {
        static void Main(string[] args)
        {
            //TestSample();
            TestCMS();
        }

        static void TestSample()
        {
            var creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            foreach (var creator in creators)
            {
                Product product = creator.FactoryMethod();
                Debug.WriteLine(creator.GetType().Name + " has created: " + product.GetType().Name);
            }
            Console.ReadKey();
        }

        static void TestCMS()
        {
            var documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            foreach (var doc in documents)
            {
                Debug.WriteLine(doc.GetType().Name);
                Debug.WriteLine("====================");

                var i = 1;
                foreach (var page in doc.Pages)
                {
                    Debug.WriteLine($"{i}-{page.GetType().Name}");
                    i++;
                }
            }
            
        }
    }
}
