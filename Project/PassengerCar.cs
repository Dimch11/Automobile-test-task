using System;

public class PassengerCar : Automobile
{
    public int MaxNumOfPassengers { get; protected set; }
    public int CurrentNumOfPassengers { get; protected set; }

    protected const double fuelRangeDecreaseForOnePassenger = 0.06;

    public PassengerCar(double averageFuelConsumption, double fuelTankCapacity, double currentFuel, double speed,
        int maxNumOfPassengers, int currentNumOfPassengers) 
        : base(VehicleTypes.B, averageFuelConsumption, fuelTankCapacity, currentFuel, speed)
    {
        MaxNumOfPassengers = maxNumOfPassengers;
        CurrentNumOfPassengers = currentNumOfPassengers;

        if (CurrentNumOfPassengers > maxNumOfPassengers)
        {
            throw new ArgumentException($"Число пассажиров не может быть больше {maxNumOfPassengers}");
        }
    }

    protected override double CalcFuelRange(double fuel)
    {
        return base.CalcFuelRange(fuel) * (1 - fuelRangeDecreaseForOnePassenger * CurrentNumOfPassengers);
    }
}
