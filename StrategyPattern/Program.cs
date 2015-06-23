// **********************************************************************
// SOLUTION: StrategyPattern
// PROJECT: Simon8029.DesignPatterns.StrategyPattern.App 
// FILE NAME: Program.cs 
// CREATED ON 2015-06-23 2:48 PM
//   
// Copyright (C) 2015 Simon8029
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license.  See the LICENSE file for details.
// **********************************************************************
using System;
using Simon8029.DesignPatterns.StrategyPattern.Units;
using Simon8029.DesignPatterns.StrategyPattern.Weapons;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeapon machineGun = new MachineGun();
            IBehavior landBehavior = new LandBehavior();
            Unit ryan = new Unit("Ryan",  machineGun,landBehavior);
            ryan.Move(50, 50);
            ryan.Attack(100, 100);

            Unit ben = new Unit("Ben",machineGun,landBehavior);
            ben.Move(1000, 1000);
            ben.Attack(50,50);

            ben.Weapon = new Cannon();
            Console.WriteLine("Ben changes weapon.");
            ben.Attack(50,50);
        }
    }
}
