using System;
using System.IO;

namespace valueAndReferenceTypes
{
    class Program
    {

        static void Main(string[] args)
        {
            var carStructObject1 = new CarStruct();
            var carStructObject2 = new CarStruct();

            var carClassObject1 = new CarClass();
            var carClassObject2 = new CarClass();

            // Struct Object1 initial Make is Honda.
            // After assignment to Object2, remains same. (Value)

            carStructObject1.Make = "Honda";
            Console.WriteLine($"  carStructObject1.Make: {carStructObject1.Make}");
            carStructObject2 = carStructObject1;
            carStructObject2.Make = "Toyota";
            Console.WriteLine($"=>carStructObject1.Make: {carStructObject1.Make}");
            Console.WriteLine($"=>carStructObject1.Make: {carStructObject2.Make}");

            Console.WriteLine("----------------------------");

            // Class Object1 initial Make is Honda.
            // After assignment to Object2, Make is what Object2 Make. (Reference)

            carClassObject1.Make = "Honda";
            Console.WriteLine($"  carStructObject1.Make: {carClassObject1.Make}");
            carClassObject2 = carClassObject1;
            carClassObject2.Make = "Toyota";
            Console.WriteLine($"=>carClassObject1.Make: {carClassObject1.Make}");
            Console.WriteLine($"=>carClassObject2.Make: {carClassObject2.Make}");

            Console.ReadLine();
        }

        struct CarStruct { public string Make { get; set; } }
        class CarClass { public string Make { get; set; } }
    }
}


