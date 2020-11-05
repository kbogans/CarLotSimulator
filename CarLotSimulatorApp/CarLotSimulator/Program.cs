using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var lot = new CarLot();
     
            var myCar = new Car();
            myCar.Year = 2017;
            myCar.Make = "Pathfinder";
            myCar.Model = "Nissan";
            myCar.EngineNoise = "Vroom";
            myCar.HonkNoise = "Beep";
            myCar.IsDriveable = true;

            lot.Cars.Add(myCar);

            var mySecondCar = new Car()
            {
                Year = 2013,
                Make = "Hyundai",
                Model = "Genesis",
                EngineNoise = "Hummmmm",
                HonkNoise = "Hoonnkk",
                IsDriveable = true

            };
            lot.Cars.Add(mySecondCar);

            var myThirdCar = new Car(2018, "Nissan", "Sentra", "VroomVroom", "BeepBeep", true);

            myCar.MakeEngineNoise(myCar.EngineNoise);
            mySecondCar.MakeEngineNoise(mySecondCar.EngineNoise);
            myThirdCar.MakeEngineNoise(myThirdCar.EngineNoise);

            lot.Cars.Add(myThirdCar);
            foreach(var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }
            //Create a seperate class file called Car
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}
