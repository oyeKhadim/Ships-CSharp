using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships.Classses
{
    internal class Ship
    {
        private string serialNumber;
        private Angle longitude=new Angle();
        private Angle latitude = new Angle();
        public string getSerialNumber() { return serialNumber; }
        public Angle getLongitude() { return longitude; }
        public Angle getLatitude() { return latitude; }
        public void setSerialNumber(string serialNumber) { this.serialNumber = serialNumber; }
        public void setLongitutde(Angle longitude) { this.longitude = longitude; }
        public void setLatitude(Angle latitude) { this.latitude = latitude; }
        public Ship() { }

        public Ship(string serialNumber,Angle longitude,Angle latitude)
        {
            this.serialNumber = serialNumber;
            this.longitude = longitude;
            this.latitude = latitude;
        }
    }
}
