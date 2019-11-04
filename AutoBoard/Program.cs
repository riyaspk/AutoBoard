using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoBoard.Domain;
using AutoBoard.Service;

namespace AutoBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Get all vehicle list from database to perform the operation 
            //MotorVehicleService service = new MotorVehicleService();
            //IEnumerable<Vehicle> vehicleList = service.GetAllMotorVehicles();

            // Init 4 Car 
            MotorVehicle car1 = new MotorVehicle()
            {
                Name = "BMW 3-Series (E21)",
                RegistrationID = RegistrationService.NewRigstrationNumber(),
                Make = new Make()
                {
                    MakeId = 1,
                    Name = "BMW"
                },
                MaxPassengers = 5,
                NoOfWheeels = 4,
                Milage = 10,
                MotorVehicleModel = new MotorVehicleModel()
                {
                    ModelId = 1,
                    Name = "3-Series (E21) 1975-1983",
                    Year = 2019,
                    BodyType = "Saloon",
                    Transmission = "Auto",
                    Color = "Black",
                    Doors = 5,
                    FuelType = "Diesel"
                },
                EngineSize = 3
            };
            RegistrationService.RigsterNewVehicle(car1);

            MotorVehicle car2 = new MotorVehicle()
            {
                Name = "Civic (1st gen)",
                RegistrationID = RegistrationService.NewRigstrationNumber(),
                Make = new Make()
                {
                    MakeId = 2,
                    Name = "Honda"
                },
                MaxPassengers = 5,
                NoOfWheeels = 4,
                Milage = 12,
                MotorVehicleModel = new MotorVehicleModel()
                {
                    ModelId = 2,
                    Name = "Civic (1st gen) 1972-1979",
                    Year = 2019,
                    BodyType = "Hatchback",
                    Transmission = "Manual",
                    Color = "Black",
                    Doors = 5,
                    FuelType = "Petrol"
                },
                EngineSize = 2
            };
            RegistrationService.RigsterNewVehicle(car2);

            MotorVehicle car3 = new MotorVehicle()
            {
                Name = "Golf VII",
                RegistrationID = RegistrationService.NewRigstrationNumber(),
                Make = new Make()
                {
                    MakeId = 3,
                    Name = "Volkswagen"
                },
                MaxPassengers = 5,
                NoOfWheeels = 4,
                Milage = 13,
                MotorVehicleModel = new MotorVehicleModel()
                {
                    ModelId = 3,
                    Name = "Golf VII (A7 Typ 5G) 2012-present",
                    Year = 2012,
                    BodyType = "Hatchback",
                    Transmission = "Manual",
                    Color = "Black",
                    Doors = 5,
                    FuelType = "Petrol"
                },
                EngineSize = 2
            };
            RegistrationService.RigsterNewVehicle(car3);

            MotorVehicle car4 = new MotorVehicle()
            {
                Name = "Toyota Deluxe - Sedan",
                RegistrationID = RegistrationService.NewRigstrationNumber(),
                Make = new Make()
                {
                    MakeId = 4,
                    Name = "Toyota"
                },
                MaxPassengers = 5,
                NoOfWheeels = 4,
                Milage = 13,
                MotorVehicleModel = new MotorVehicleModel()
                {
                    ModelId = 4,
                    Name = "(2.0L 4-cyl. 5-speed Manual)",
                    Year = 2012,
                    BodyType = "Sedan",
                    Transmission = "Manual",
                    Color = "Black",
                    Doors = 5,
                    FuelType = "Petrol"
                },
                EngineSize = 2
            };
            RegistrationService.RigsterNewVehicle(car4);

            // Init a Bicycle
            Bicycle cycle1 = new Bicycle()
            {
                // To track the entities, temporary Registering Bicycle
                RegistrationID = RegistrationService.NewRigstrationNumber(),
                Make = new Make()
                {
                    MakeId = 5,
                    Name = "Eurobike"
                },
                MaxPassengers = 1,
                NoOfWheeels = 2,
                Category = "Road Bike",
                MaterialType = "Disc",
                BicycleModel = new BicycleModel()
                {
                    ModelId = 6,
                    Name= "Road Bike",
                    BicycleType = BicycleType.Regular,
                    Age = "Adult",
                    Weight = 18.6f,
                    BasketColor = "Red",
                    Shift = 5,
                    WheelMaterial = "700C Clincher"
                },
            };
            RegistrationService.RigsterNewVehicle(cycle1);

            // Init Bus
            MotorVehicle bus = new MotorVehicle()
            {
                Name = "BMW 520d Touring",
                RegistrationID = RegistrationService.NewRigstrationNumber(),
                Make = new Make()
                {
                    MakeId = 1,
                    Name = "BMW"
                },
                MaxPassengers = 50,
                NoOfWheeels = 10,
                Milage = 8,
                MotorVehicleModel = new MotorVehicleModel()
                {
                    ModelId = 7,
                    Name = "BMW 5 Series Touring.520d",
                    Year = 2012,
                    Transmission = "Manual",
                    Color = "White",
                    Doors = 4,
                    FuelType = "Diesel"
                },
                EngineSize = 3
            };
            RegistrationService.RigsterNewVehicle(bus);
            
            // Init Ship
            Ship ship = new Ship()
            {
                Name = "Prime Time Cruise",
                RegistrationID = RegistrationService.NewRigstrationNumber(),
                Make = new Make()
                {
                    MakeId = 7,
                    Name = "PrimeTime"
                },
                MaxPassengers = 350,
                Milage = 5,
                Length = 45,
                Width = 9
            };
            RegistrationService.RigsterNewVehicle(ship);

            // Print all vehicle with Efficiancy 
            foreach (KeyValuePair<int, Vehicle> item in RegistrationService.register)
            {
                Console.WriteLine(item.Value.Print());
            }

            Console.ReadLine();
        }
    }
}
