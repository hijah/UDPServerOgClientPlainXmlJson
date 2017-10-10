using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public class Car
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string RegistrationNumber { get; set; }

        public Car()
        {
            
        }
        public Car(string model, string color, string registrationNumber)
        {
            Model = model;
            Color = color;
            RegistrationNumber = registrationNumber;
        }


        public override string ToString()
        {
            return $"Model: {Model}, Color: {Color}, RegistrationNumber: {RegistrationNumber}";
        }
    }
}
