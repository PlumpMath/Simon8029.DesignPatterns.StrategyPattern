// **********************************************************************
// SOLUTION: StrategyPattern
// PROJECT: Simon8029.DesignPatterns.StrategyPattern.Units 
// FILE NAME: Unit.cs 
// CREATED ON 2015-06-23 2:48 PM
//   
// Copyright (C) 2015 Simon8029
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license.  See the LICENSE file for details.
// **********************************************************************
using System;
using Simon8029.DesignPatterns.StrategyPattern.Weapons;

namespace Simon8029.DesignPatterns.StrategyPattern.Units
{
    public class Unit : IUnit,IWeapon,IBehavior
    {
        public int Type { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }
        public IWeapon Weapon { get; set; }
        public IBehavior Behavior { get; set; }


        public Unit(string name, IWeapon weapon, IBehavior behavior)
        {
            Name = name;
            Weapon = weapon;
            Behavior = behavior;
        }

        public void Attack(int x, int y)
        {
            Console.Write("{0} is using ",Name);
            Weapon.Attack(x, y);
        }

        public void Move(int x, int y)
        {
            Console.Write("{0} ",Name);
            Behavior.Move(x,y);
        }
    }
}