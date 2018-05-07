// ******************************************************************************************************************
//  Dice Roller - a simple program that rolls dice using a random number generator.
//  Copyright(C) 2018  James LoForti
//  Contact Info: jamesloforti@gmail.com
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.If not, see<https://www.gnu.org/licenses/>.
//									     ____.           .____             _____  _______   
//									    |    |           |    |    ____   /  |  | \   _  \  
//									    |    |   ______  |    |   /  _ \ /   |  |_/  /_\  \ 
//									/\__|    |  /_____/  |    |__(  <_> )    ^   /\  \_/   \
//									\________|           |_______ \____/\____   |  \_____  /
//									                             \/          |__|        \/ 
//
// ******************************************************************************************************************
//
using System;

namespace DiceRoller
{
    /// <summary>
    /// Dice Class - represents a pair of dice
    /// </summary>
    class Dice
    {
        //Constants
        const int MAX = 6;

        //Data Members:
        private Random random;

        public Dice()
        {
            random = new Random();
        }

        public string RollDice()
        {
            int die1 = random.Next(1, MAX + 1);
            int die2 = random.Next(1, MAX + 1);

            //SNAKE-EYES (two 1s)
            if (die1 == 1 && die2 == 1)
            {
                return "You rolled snake-eyes";
            }
            //BOXCAR (two 6s)
            else if (die1 == MAX && die2 == MAX)
            {
                return "You rolled boxcars";
            }
            //Every other type of roll
            else
            {
                return $"You rolled {die1} and {die2}";
            }
        } // end method RollDice()
    } // end class Die
} // end namespace DiceRoller
