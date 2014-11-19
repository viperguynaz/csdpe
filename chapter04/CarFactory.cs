﻿/*
 *  C# Design Pattern Essentials
 *  Copyright 2012, Ability First Limited
 *
 *  This source code is provided to accompany the book and is provided AS-IS without warranty of any kind.
 *  It is intended for educational and illustrative purposes only, and may not be re-published
 *  without the express written permission of the publisher.
 */
using System;
using Chapter01;

namespace Chapter04
{
    public class CarFactory : VehicleFactory
    {
        protected internal override IVehicle SelectVehicle
												(DrivingStyle style)
        {
            IVehicle selectedVehicle;

            if (style == DrivingStyle.Economical)
            {
                selectedVehicle = new Saloon(new StandardEngine(1300));

            }
            else if (style == DrivingStyle.Midrange)
            {
                selectedVehicle = new Coupe(new StandardEngine(1600));

            }
            else
            {
                selectedVehicle = new Sport(new TurboEngine(2000));
            }

            return selectedVehicle;
        }

    }
}
