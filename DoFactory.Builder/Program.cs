namespace DoFactory.Builder
{
    using Sample;
    using Vehicle;
    using Foods;
    using Foods.Items;
    using Foods.Packings;
    using System.Collections.Generic;
    using System.Collections;
    using System.Diagnostics;

    class Program
    {
        static void Main(string[] args)
        {
            //TestSample2();
            //VehicleTest();
            TestFoods();

        }

        static void TestSample1()
        {
            var director = new Director();
            var builders = new List<Builder> { new ConcreteBuilderA(), new ConcreteBuilderB() };
            var products = new List<Product>();

            builders.ForEach((builder) => 
            {
                director.Construct(builder);
                products.Add(builder.GetResult());
            });

            products.ForEach((product)=> { product.ShowParts(); });

        }
        static void TestSample2()
        {
            // Create director and builders

            Director director = new Director();
 
            Builder b1 = new ConcreteBuilderA();
            Builder b2 = new ConcreteBuilderB();
 
            // Construct two products

            director.Construct(b1);
            Product p1 = b1.GetResult();
            p1.ShowParts();
 
            director.Construct(b2);
            Product p2 = b2.GetResult();
            p2.ShowParts();
 
            // Wait for user

            System.Console.ReadKey();
        }

        static void VehicleTest()
        {
            Shop shop = new Shop();
            var vehicles = new List<Vehicle.Vehicle>();
            var vehicleBuilders = new List<VehicleBuilder>()
            {
                new MotorCycleBuilder(),
                new CarBuilder(),
                new ScooterBuilder()
            };

            vehicleBuilders.ForEach((vehicleBuilder) =>
            {
                shop.Construct(vehicleBuilder);
                vehicles.Add(vehicleBuilder.GetVehicle);
            });

            vehicles.ForEach((vehicle) => { vehicle.ShowParts(); });

        }

        static void TestFoods()
        {
            MealBuilder mealBuilder = new MealBuilder();
            Meal vegMeal = mealBuilder.PrepareVegMeal();
            vegMeal.ShowItems();
            
            Debug.WriteLine($"total price: {vegMeal.CalculateCost()}");

            Meal nonVegMeal = mealBuilder.PrepareNonVegMeal();
            nonVegMeal.ShowItems();
            Debug.WriteLine($"total price: {nonVegMeal.CalculateCost()}");
        }
    }
}
