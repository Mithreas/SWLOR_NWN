﻿using NWN;
using SWLOR.Game.Server.GameObject;

namespace SWLOR.Game.Server.DoorRule.Contracts
{
    public interface IDoorRule
    {
        NWPlaceable Run(NWArea area, Location location);
    }
}
