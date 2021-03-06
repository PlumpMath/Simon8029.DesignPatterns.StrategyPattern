﻿// **********************************************************************
// SOLUTION: StrategyPattern
// PROJECT: Simon8029.DesignPatterns.StrategyPattern.Weapons 
// FILE NAME: MachineGun.cs 
// CREATED ON 2015-06-23 2:48 PM
//   
// Copyright (C) 2015 Simon8029
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license.  See the LICENSE file for details.
// **********************************************************************
using System;

namespace Simon8029.DesignPatterns.StrategyPattern.Weapons
{
    public class MachineGun : IWeapon
    {
        public string Name
        {
            get { return "MachineGun"; }
        }

        public void Attack(int x, int y)
        {
            Console.WriteLine(" {0} attack ({1}, {2})", Name, x, y);
        }
    }
}