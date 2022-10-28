using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ships.Classses;
using Ships.DL;
namespace Ships.UI
{
    internal class ShipsUI
    {
        public static void changeShipPosition()
        {
            Console.WriteLine("Enter Ship Serial Number : ");
            string serialNumber = Console.ReadLine();
            bool check = false;
            foreach (Ship ship in ShipsDL.ships)
            {
                if (ship.getSerialNumber() == serialNumber)
                {
                    Console.WriteLine("Enter Ship Latitude: ");
                    Console.WriteLine("Enter Latitude's Degree :");
                    int latitudeDegrees = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Latitude's Minutes :");
                    float latitudeMinutes = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Latitude's Direction :");
                    char latitudDirection = char.ToUpper(Console.ReadLine()[0]);
                    Angle latitude = new Angle(latitudeDegrees,latitudeMinutes,latitudDirection);

                    Console.WriteLine("Enter Ship Longitude: ");
                    Console.WriteLine("Enter Longitude's Degree :");
                    int longitudeDegrees = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Longitude's Minutes :");
                    float longitudeMinutes = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Longitude's Direction :");
                    char longitudeDirection = char.ToUpper(Console.ReadLine()[0]);
                    Angle longitude=new Angle(longitudeDirection,longitudeMinutes,longitudeDirection);

                    ship.setLongitutde(longitude);
                    ship.setLatitude(latitude);
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                Console.WriteLine("No Ship Found With This Serial Number.");
            }
        }
        public static void viewShipSerialNumber()
        {
            

            Console.WriteLine("Enter Ship Latitude: ");
            Console.WriteLine("Enter Latitude's Degree :");
            int latitudeDegrees = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude's Minutes :");
            float latitudeMinutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude's Direction :");
            char latitudeDirection = char.ToUpper(Console.ReadLine()[0]);

            Console.WriteLine("Enter Ship Longitude: ");
            Console.WriteLine("Enter Longitude's Degree :");
            int longitudeDegrees = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude's Minutes :");
            float longitudeMinutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude's Direction :");
            char longitudeDirection = char.ToUpper(Console.ReadLine()[0]);
            bool check = false;
            foreach (Ship ship in ShipsDL.ships)
            {
                /*if (ship.latitude == ship2.latitude && ship.longitude == ship2.longitude)
                {
                    Console.WriteLine("Ship Serial Number is: "+ship2.serialNumber);
                    check = true;
                    break;
                }*/
                if (ship.getLatitude().getDegrees() == latitudeDegrees && ship.getLongitude().getDegrees() == longitudeDegrees)
                {
                    if (ship.getLatitude().getMinutes() == latitudeMinutes && ship.getLongitude().getMinutes() == longitudeMinutes)
                    {
                        if (ship.getLatitude().getDirection() == latitudeDirection && ship.getLongitude().getDirection() == longitudeDirection)
                        {
                            Console.WriteLine("Ship Serial Number is: " + ship.getSerialNumber());
                            check = true;
                            break;

                        }
                    }
                }
            }
            if (!check)
            {
                Console.WriteLine("No Ship Found.");
            }
        }
        public static void viewShipPosition()
        {
            Console.WriteLine("Enter Ship Serial No. : ");
            string sr = Console.ReadLine();
            bool check = false;
            foreach (Ship ship in ShipsDL.ships)
            {
                if (ship.getSerialNumber() == sr)
                {
                    Console.WriteLine("This Ship is At " + ship.getLongitude().getDegrees() + "°" + ship.getLongitude().getMinutes() + "’" + ship.getLongitude().getDirection() + " And " + ship.getLatitude().getDegrees() + "°" + ship.getLatitude().getMinutes() + "’" + ship.getLatitude().getDirection());
                    check = true;
                    break;
                }
            }
            if (!check)
            {
                Console.WriteLine("No Ship Found.");
            }
        }
        public static Ship addShip()
        {
            Console.WriteLine("Enter Ship Serial Number : ");
            string serialNumber = Console.ReadLine();
            Console.WriteLine("Enter Ship Latitude: ");
            Console.WriteLine("Enter Latitude's Degree :");
            int latitudeDegrees = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude's Minutes :");
            float latitudeMinutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude's Direction :");
            char latitudDirection = char.ToUpper(Console.ReadLine()[0]);
            Angle latitude = new Angle(latitudeDegrees, latitudeMinutes, latitudDirection);

            Console.WriteLine("Enter Ship Longitude: ");
            Console.WriteLine("Enter Longitude's Degree :");
            int longitudeDegrees = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude's Minutes :");
            float longitudeMinutes = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude's Direction :");
            char longitudeDirection = char.ToUpper(Console.ReadLine()[0]);
            Angle longitude = new Angle(longitudeDirection, longitudeMinutes, longitudeDirection);
            Ship ship = new Ship(serialNumber,longitude,latitude);
            return ship;
        }
       
    }
}
