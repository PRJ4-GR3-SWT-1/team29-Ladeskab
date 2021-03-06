﻿using System;
using Charger_Functionality_Library.Help_Interfaces;
using Charger_Functionality_Library.Interfaces;

namespace Charger_Functionality_Library.Classes
{
    
    public class Display : IDisplay
    {
        private IConsoleWriter Writer;
        public Display(IConsoleWriter writer)
        {
            Writer = writer;
        }
        //public void PhoneConnected()
        //{
        //    Writer.write("Phone is connected to USBcharger");
        //}

        public void RFIDRead()
        {
            Writer.write("Please place your RFID tag in front of the reader");
        }

        public void ConnectionError()
        {
            Writer.write("A phone is not connected");
        }

        public void CabinetOccupied()
        {
            Writer.write("The cabinet is currently in use");
        }

        public void RFIDError()
        {
            Writer.write("Error with reading RFID");
        }

        public void RemovePhone()
        {
            Writer.write("Please remove the phone from the cabinet");
        }

        public void PhoneIsCharged()
        {
            Writer.write("The phone is fully charged");
        }

        public void PhoneIsCharging()
        {
            Writer.write("The phone is currently charging");
        }

        public void PhoneChargingError()
        {
            Writer.write("Error while charging phone, Charging is stopped");
        }

        public void ConnectPhone()
        {
            Writer.write("Please Connect Your Phone and close the door");
        }
    }
}