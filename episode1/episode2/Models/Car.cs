using System;
using System.Collections.Generic;
using System.Text;

namespace Episode2.Models
{
    public abstract class Car
    {
        public double Speed { get; protected set; } = 100;
        public double Acceleration { get; protected set; } = 10;

        public void Start()
        {
            Console.WriteLine("Turning on the engine");
            Console.WriteLine($"Running at:{Speed} km/h");
        }
        public void Stop()
        {
            Console.WriteLine("Stopping the car");
        }
        public virtual void Accelerate()
        {
            Console.WriteLine("Accelerating");
            Speed += Acceleration;
            Console.WriteLine($"Running at:{Speed} km/h");
        }
        public abstract void Boost();
        
     }
    public class Truck : Car
    {
        public override void Accelerate()
        {
            Console.WriteLine("Accelerating a track");
            base.Accelerate();

        }

        public override void Boost()
        {
            Console.WriteLine("Boosting a truck");
            Speed += 50;
            Console.WriteLine($"Running at:{Speed} km/h");
        }
    }
    public class SportCar : Car
    {
        public override void Accelerate()
        {
            Console.WriteLine("Accelerating a sportCar");
            base.Accelerate();


        }

        public override void Boost()
        {
            Console.WriteLine("Boosting a sportCar");
            Speed += 100;
            Console.WriteLine($"Running at:{Speed} km/h");
        }
        public void DisplayInfo()
        {
            Console.WriteLine("sport car");

        }
    }
    public class Race
    {
/*        public void Begin()
        {
            SportCar sportCar = new SportCar();
            Truck truck = new Truck();

            List<Car> cars = new List<Car>
            {
                sportCar,truck
            };

            foreach (Car car in cars)
            {
                car.Start();
                car.Accelerate();
            }
        }*/
        public void Begin()
        {
            Car sportCar = new SportCar();
            Car truck = new Truck();

            List<Car> cars = new List<Car>
            {
                sportCar,truck
            };

            foreach (Car car in cars)
            {
                car.Start();
                car.Accelerate();
            }
        }
        public void Casting()
        {
            Car sportCar = new SportCar();
            Car truck = new Truck();

            /*            SportCar realSportCar = (SportCar)sportCar; *//*rzutowanie w dół*//*
                        realSportCar.DisplayInfo();
                        Car realSportCar2 = (Car)sportCar; *//*rzutowanie w górę*//*
                        realSportCar2.Boost();
            */
            bool isSportCar = sportCar is SportCar;/*rzutowanie ze sprawdzeniem, czy można rzutować sposób 1*/
            if(isSportCar)
            {
                ((SportCar)sportCar).DisplayInfo();
            }

            SportCar castedSportCar = sportCar as SportCar;/*rzutowanie ze sprawdzeniem, czy można rzutować sposób 2*/
            if (castedSportCar!=null)
            {
                
                castedSportCar.DisplayInfo();
             /*   ((SportCar)castedSportCar).DisplayInfo();*/
            }



        }
    }
      

}
