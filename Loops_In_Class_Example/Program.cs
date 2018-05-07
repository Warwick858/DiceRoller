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
    class Program
    {
        //Constants
        const string NO = "n";
        const string YES = "y";

        static void Main(string[] args)
        {
            //Local vars:
            Dice dice = new Dice();
            string response = string.Empty;
            string roll = string.Empty;

            //Print intro
            Console.WriteLine("Dice Game");
            Console.WriteLine("*****************************************************\n");

            //Prompt user for input
            Console.Write("Roll dice? ('y' or 'n') ");
            response = Console.ReadLine();

            //While input is invalid
            while (response.ToLower() != YES && response.ToLower() != NO)
            {
                Console.Write("\nInvalid response.  Please enter 'y' or 'n': ");
                response = Console.ReadLine();
            }

            //While user wants to roll the dice
            while (response.ToLower() == YES)
            {
                //Roll dice and print result to console
                roll = dice.RollDice();
                Console.WriteLine($"{roll}");

                //Prompt user again
                Console.Write("\nRoll again? ('y', 'n') ");
                response = Console.ReadLine();

                //While input is invalid
                while (response.ToLower() != YES && response.ToLower() != NO)
                {
                    Console.Write("\nInvalid response.  Please enter 'y' or 'n': ");
                    response = Console.ReadLine();
                }
            } // end while

            //Hold console
            Console.Write("\npress any key to exit...");
            Console.ReadKey();
        } // end method Main()
    } // end class Program
} // end namespace DiceRoller
