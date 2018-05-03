using System;

namespace DoFactory.PaintAbstractFactory
{
    using AbstractFactory.Paint;
    using DoFactory.AbstractFactory.AnimalsWorld;
    using DoFactory.AbstractFactory.Paint.Colors;
    using DoFactory.AbstractFactory.Paint.Shapes;

    class Program
    {
        static void Main(string[] args)
        {

            TestPaint();

        }

        static void TestAnimalsWorld()
        {
            AnimalWorld animalWorldAfrica = new AnimalWorld(new AfricaFactory());

            animalWorldAfrica.RunFoodChain();

            AnimalWorld animalWorldAmerica = new AnimalWorld(new AmericaFactory());

            animalWorldAmerica.RunFoodChain();
        }

        static void TestPaint()
        {
            //get IShape factory
            PaintAbstractFactory shapeFactory = PaintFactoryProducer.GetPaintFactory("Shape");

            //get an object of IShape Circle
            IShape shape1 = shapeFactory.CreateShape("CIRCLE");

            //call Draw method of IShape Circle
            shape1.Draw();

            //get an object of IShape Rectangle
            IShape shape2 = shapeFactory.CreateShape("RECTANGLE");

            //call Draw method of IShape Rectangle
            shape2.Draw();

            //get an object of IShape Square 
            IShape shape3 = shapeFactory.CreateShape("SQUARE");

            //call Draw method of IShape Square
            shape3.Draw();

            //get color factory
            PaintAbstractFactory colorFactory = PaintFactoryProducer.GetPaintFactory("COLOR");

            //get an object of Color Red
            IColor color1 = colorFactory.CreateColor("RED");

            //call fill method of Red
            color1.Fill();

            //get an object of Color Green
            IColor color2 = colorFactory.CreateColor("Green");

            //call fill method of Green
            color2.Fill();

            //get an object of Color Blue
            IColor color3 = colorFactory.CreateColor("BLUE");

            //call fill method of Color Blue
            color3.Fill();
        }
    }
}
