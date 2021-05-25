using System;
using subTask2.Clsses;
using System.Globalization;
using System.Text;

namespace subTask2
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            RegionInfo rf = (RegionInfo.CurrentRegion);
            Vehicle someCar = new Car(new Cords(0, 0), 1500000, 219, 2021);
            Console.WriteLine($"Car in X: {someCar.coordinates.position_x}, Y: {someCar.coordinates.position_y},\n" +
                $"created in {someCar.year},\n" +
                $"priced of {someCar.price}{rf.CurrencySymbol}\n" +
                $"drive on speed: {someCar.speed}km/p.\n");
            Vehicle somePlane = new Plane(new Cords(12.6, 216.9), 17000000, 1200, 2021, 2000, 15);
            Console.WriteLine($"Plane in X: {somePlane.coordinates.position_x}, Y: {somePlane.coordinates.position_y},\n" +
                $"created in {somePlane.year},\n" +
                $"priced of {somePlane.price}{rf.CurrencySymbol},\n" +
                $"fly on speed: {somePlane.speed}km/p on altitude: {((Plane)somePlane).alt}m.\n" +
                $"can get {((Plane)somePlane).count_passengers} passangers on bord.\n");

            Vehicle someShip = new Ship(new Cords(511, 116), 3500000000, 250, 2019, "Yamaika", 300);
            Console.WriteLine($"Ship in X: {someShip.coordinates.position_x}, Y: {someShip.coordinates.position_y},\n" +
                $"created in {someShip.year},\n" +
                $"priced of {someShip.price}{rf.CurrencySymbol},\n" +
                $"moving on speed: {someShip.speed}km/p to {((Ship)someShip).port} port.\n" +
                $"can get {((Ship)someShip).count_passengers} passangers on bord.\n");
        }
    }
}
