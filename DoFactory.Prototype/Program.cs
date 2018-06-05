using DoFactory.Prototype.Sample;
using System;

namespace DoFactory.Prototype
{
    using Shapes;
    using System.Diagnostics;

    class Program
    {
        static void Main(string[] args)
        {
            
        }

        static void TestSample()
        {
            // Create two instances and clone each
            ConcretePrototype1 p1 = new ConcretePrototype1("I");
            ConcretePrototype1 c1 = (ConcretePrototype1)p1.Clone();
            Console.WriteLine("Cloned: {0}", c1.Id);

            ConcretePrototype2 p2 = new ConcretePrototype2("II");
            ConcretePrototype2 c2 = (ConcretePrototype2)p2.Clone();
            Console.WriteLine("Cloned: {0}", c2.Id);

            // Wait for user
            Console.ReadKey();
        }
        static void TestShapes()
        {
            ShapeManager.loadCache();

            Shape clonedShape = (Shape) ShapeManager.GetShape("1");
            Debug.WriteLine("Shape : " + clonedShape.getType());		

            Shape clonedShape2 = (Shape) ShapeManager.GetShape("2");
            Debug.WriteLine("Shape : " + clonedShape2.getType());		

            Shape clonedShape3 = (Shape) ShapeManager.GetShape("3");
            Debug.WriteLine("Shape : " + clonedShape3.getType());	
        }
    }
}
