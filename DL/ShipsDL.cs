using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ships.Classses;

namespace Ships.DL
{
    internal class ShipsDL
    {
        public static List<Ship> ships = new List<Ship>();
        public static void addShipToList(Ship ship)
        {
            if (ship != null)
            {
                ships.Add(ship);
            }
        }
        public static void loadShips()
        {
            string path = "Ships.txt";
            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] record = line.Split(',');
                string srno = record[0];
                int lonDeg = int.Parse(record[1]);
                float lonMin = float.Parse(record[2]);
                char lonDir = char.Parse(record[3]);
                int latDeg = int.Parse(record[4]);
                float latMin = float.Parse(record[5]);
                char latDir = char.Parse(record[6]);
                Angle longitude = new Angle(lonDeg, lonMin, lonDir);
                Angle latitude = new Angle(latDeg, latMin, latDir);
                Ship ship = new Ship(srno, longitude, latitude);

                addShipToList(ship);
            }
            sr.Close();
        }

        public static void storeShips()
        {
            string path = "Ships.txt";
            StreamWriter sw = new StreamWriter(path, false);
            foreach (Ship ship in ships)
            {
                sw.WriteLine(ship.getSerialNumber() + "," + ship.getLongitude().getDegrees() + "," + ship.getLongitude().getMinutes() + "," + ship.getLongitude().getDirection() + "," + ship.getLatitude().getDegrees() + "," + ship.getLatitude().getMinutes() + "," + ship.getLatitude().getDirection());
            }
            sw.Flush();
            sw.Close();
        }
    }
}
