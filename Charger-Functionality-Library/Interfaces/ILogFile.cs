﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Charger_Functionality_Library.Interfaces
{
    public interface ILogFile
    {
        void DoorLocked(string RFid_num);

        abstract void DoorUnlocked(string RFid_num);

    }
}
