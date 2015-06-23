// **********************************************************************
// SOLUTION: StrategyPattern
// PROJECT: Simon8029.DesignPatterns.StrategyPattern.Units 
// FILE NAME: IUnit.cs 
// CREATED ON 2015-06-23 2:48 PM
//   
// Copyright (C) 2015 Simon8029
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license.  See the LICENSE file for details.
// **********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simon8029.DesignPatterns.StrategyPattern.Units
{
    public interface IUnit
    {
        int Type { get; set; }
        string Name { get; set; }
        int Speed { get; set; }
    }
}
