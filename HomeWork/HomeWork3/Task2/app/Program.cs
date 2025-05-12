using app.Entities.Models;

Vehicle car = new Car();
Vehicle motorBike = new MotorBike();
Vehicle boat = new Boat();
Vehicle plane = new Airplane();

// Display Info
car.DisplayInfo();
motorBike.DisplayInfo();
boat.DisplayInfo();
plane.DisplayInfo();

// Call specific actions
((Car)car).Drive();
((MotorBike)motorBike).Wheelie();
((Boat)boat).Sail();
((Airplane)plane).Fly();