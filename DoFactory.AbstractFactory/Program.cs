using System;

namespace DoFactory.PaintAbstractFactory
{
    using AbstractFactory.Paint;
    using DoFactory.AbstractFactory.AnimalsWorld;
    using DoFactory.AbstractFactory.Paint.Colors;
    using DoFactory.AbstractFactory.Paint.Shapes;
    using DoFactory.AbstractFactory.Paint;

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
            //get shape factory
            PaintAbstractFactory shapeFactory = PaintFactoryProducer.GetPaintFactory("SHAPE");

            //get an object of Shape Circle
            Shape shape1 = shapeFactory.CreateShape("CIRCLE");

            //call Draw method of Shape Circle
            shape1.Draw();

            //get an object of Shape Rectangle
            Shape shape2 = shapeFactory.CreateShape("RECTANGLE");

            //call Draw method of Shape Rectangle
            shape2.Draw();

            //get an object of Shape Square 
            Shape shape3 = shapeFactory.CreateShape("SQUARE");

            //call Draw method of Shape Square
            shape3.Draw();

            //get color factory
            PaintAbstractFactory colorFactory = PaintFactoryProducer.GetPaintFactory("COLOR");

            //get an object of Color Red
            Color color1 = colorFactory.CreateColor("RED");

            //call fill method of Red
            color1.Fill();

            //get an object of Color Green
            Color color2 = colorFactory.CreateColor("Green");

            //call fill method of Green
            color2.Fill();

            //get an object of Color Blue
            Color color3 = colorFactory.CreateColor("BLUE");

            //call fill method of Color Blue
            color3.Fill();
        }
    }
}
