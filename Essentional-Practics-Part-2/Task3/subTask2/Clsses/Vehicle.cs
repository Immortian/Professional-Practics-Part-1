using System;
using System.Collections.Generic;
using System.Text;

namespace subTask2.Clsses
{
    public class Cords
    {
        public double position_x { get; set; }
        public double position_y { get; set; }
        public Cords (double X, double Y)
        {
            position_x = X;
            position_y = Y;
        }
    }
    public class Vehicle
    {
        public Cords coordinates { get; set; }
        public double price { get; set; }
        public double speed { get; set; }
        public int year { get; set; }

        public Vehicle(Cords Coordinates, double Price, double Speed, int Year)
        {
            coordinates = Coordinates;
            price = Price;
            speed = Speed;
            year = Year;
        }
    }
    class Plane : Vehicle
    {
        public double alt { get; set; }
        public int count_passengers { get; set; }
        public Plane(Cords Coordinates, double Price, double Speed, int Year, double Alt, int Passangers) : base(Coordinates, Price, Speed, Year)
        {
            coordinates = Coordinates;
            price = Price;
            speed = Speed;
            year = Year;
            alt = Alt;
            count_passengers = Passangers;
        }

        public double GetAlt()
        {
            return alt;
        }
        public int GetPassangers()
        {
            return count_passengers;
        }
    }
    class Car: Vehicle
    {
        public Car(Cords Coordinates, double Price, double Speed, int Year) : base(Coordinates, Price, Speed, Year)
        {
            coordinates = Coordinates;
            price = Price;
            speed = Speed;
            year = Year;
        }
    }
    class Ship : Vehicle
    {
        public int count_passengers { get; set; }
        public string port { get; set; }
        public Ship(Cords Coordinates, double Price, double Speed, int Year, string Port, int Passangers) : base(Coordinates, Price, Speed, Year)
        {
            coordinates = Coordinates;
            price = Price;
            speed = Speed;
            year = Year;
            port = Port;
            count_passengers = Passangers;
        }
    }
}
