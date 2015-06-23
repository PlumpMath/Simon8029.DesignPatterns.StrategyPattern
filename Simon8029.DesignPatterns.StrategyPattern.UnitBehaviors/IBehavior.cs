// **********************************************************************
// SOLUTION: StrategyPattern
// PROJECT: Simon8029.DesignPatterns.StrategyPattern.UnitBehaviors 
// FILE NAME: IBehavior.cs 
// CREATED ON 2015-06-23 2:48 PM
//   
// Copyright (C) 2015 Simon8029
// All rights reserved.
// 
// This software may be modified and distributed under the terms
// of the BSD license.  See the LICENSE file for details.
// **********************************************************************
namespace Simon8029.DesignPatterns.StrategyPattern.Units
{
    public interface IBehavior
    {
        void Move( int x, int y);
    }
}