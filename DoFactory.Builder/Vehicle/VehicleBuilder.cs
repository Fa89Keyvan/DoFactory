namespace DoFactory.Builder.Vehicle
{
    abstract class VehicleBuilder
    {
        protected Vehicle _vehicle;

        public VehicleBuilder(string vehicleType)
        {
            _vehicle = new Vehicle(vehicleType);
        }

        public Vehicle GetVehicle => _vehicle;

        // Abstract build methods
        public abstract void BuildFrame();
        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildDoors();
    }
}
