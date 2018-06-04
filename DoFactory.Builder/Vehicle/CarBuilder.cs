namespace DoFactory.Builder.Vehicle
{
    class CarBuilder : VehicleBuilder
    {

        public CarBuilder() : base("Car") { }
        public override void BuildFrame()
        {
            _vehicle["frame"] = "Car Frame";
        }

        public override void BuildEngine()
        {
            _vehicle["engine"] = "2500 cc";
        }

        public override void BuildWheels()
        {
            _vehicle["wheels"] = "4";
        }

        public override void BuildDoors()
        {
            _vehicle["doors"] = "4";
        }
    }
}
