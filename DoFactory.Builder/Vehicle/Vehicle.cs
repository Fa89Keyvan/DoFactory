using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace DoFactory.Builder.Vehicle
{
    class Vehicle
    {

        private string _vehicleType;
        private Dictionary<string, string> _parts = new Dictionary<string, string>();

        public Vehicle(string vehicleType)
        {
            this._vehicleType = vehicleType;
        }
        
        public string this[string partKey]
        {
            get { return _parts[partKey]; }
            set { _parts[partKey] = value; }
        }

        public void ShowParts()
        {
            Debug.WriteLine("\n---------------------------");
            Debug.WriteLine("Vehicle Type: {0}",args: _vehicleType);
            Debug.WriteLine(" Frame : {0}",args: _parts["frame"]);
            Debug.WriteLine(" Engine : {0}",args: _parts["engine"]);
            Debug.WriteLine(" #Wheels: {0}",args: _parts["wheels"]);
            Debug.WriteLine(" #Doors : {0}",args: _parts["doors"]);
        }
    }
}
