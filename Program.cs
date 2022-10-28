using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ships.Classses;
using Ships.DL;
using Ships.UI;
namespace Ships
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShipsDL.loadShips();
            while (true)
            {
                int option = MenuUI.menu();
                if (option == 1)
                {
                    ShipsDL.ships.Add(ShipsUI.addShip());
                    ShipsDL.storeShips();
                }
                else if (option == 2)
                {
                    ShipsUI.viewShipPosition();
                }
                else if (option == 3)
                {
                    ShipsUI.viewShipSerialNumber();
                }
                else if (option == 4)
                {
                    ShipsUI.changeShipPosition();
                    ShipsDL.storeShips();

                }
                else if (option == 5)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Option.");
                }
                MenuUI.clear();
            }
        }
      
    }
}
