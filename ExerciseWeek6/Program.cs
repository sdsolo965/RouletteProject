using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace ExerciseWeek6
{
    class Program
    {
        static void Main(string[] args)
        {
            /* My Roulette game consists of five classes, all have seperate responsibilites following SRP.
             * 1. The TablesValue class hold the attributes for all the values on a roulette table 0,00,1,2,3 etc.
             * 2. The Player class will hold all the attributes ofthe player to allow for multiple players and allowing
             * them to all have their own pot of money to gamble with.  This is currently still a TODO.
             * 3. The Wheel class is responsible for the wheel and the spinning of the wheel.
             * 4. The Results class will be incharge of getting all bet results, this is polymorphic because we can
             * simply add a new method to the class for a new bet and then add that new bet to GetResults()
             * without having to change the main program.
             * 5. The last class I currently have is the Bet class, this will include all possible bets the players can
             * make and allow money to be associated with them.  Once this class is implemented the logic inside the
             * Results class will need to change.
             * 6. In time I will be creating a Bank class as well to interact with the players, ie take their money.  I
             * may also use this to check whether the player has enough money to make the bet.
             */
            //Creates list and adds all table values.
            List<TableValues> TableList = new List<TableValues>();
            TableList.Add(new TableValues(0, "Zero", TableValues.Colors.Black));
            TableList.Add(new TableValues(1, 1, 1, "One", TableValues.Colors.Red, TableValues.Parities.Odd));
            TableList.Add(new TableValues(1, 2, 2, "Two", TableValues.Colors.Black, TableValues.Parities.Even));
            TableList.Add(new TableValues(1, 3, 3, "Three", TableValues.Colors.Red, TableValues.Parities.Odd));
            TableList.Add(new TableValues(2, 1, 4, "Four", TableValues.Colors.Black, TableValues.Parities.Even));
            TableList.Add(new TableValues(2, 2, 5, "Five", TableValues.Colors.Red, TableValues.Parities.Odd));
            TableList.Add(new TableValues(2, 3, 6, "Six", TableValues.Colors.Black, TableValues.Parities.Even));
            TableList.Add(new TableValues(3, 1, 7, "Seven", TableValues.Colors.Red, TableValues.Parities.Odd));
            TableList.Add(new TableValues(3, 2, 8, "Eight", TableValues.Colors.Black, TableValues.Parities.Even));
            TableList.Add(new TableValues(3, 3, 9, "Nine", TableValues.Colors.Red, TableValues.Parities.Odd));
            TableList.Add(new TableValues(4, 1, 10, "Ten", TableValues.Colors.Black, TableValues.Parities.Even));
            TableList.Add(new TableValues(4, 2, 11, "Eleven", TableValues.Colors.Black, TableValues.Parities.Odd));
            TableList.Add(new TableValues(4, 3, 12, "Twelve", TableValues.Colors.Red, TableValues.Parities.Even));
            TableList.Add(new TableValues(5, 1, 13, "Thirteen", TableValues.Colors.Black, TableValues.Parities.Odd));
            TableList.Add(new TableValues(5, 2, 14, "Fourteen", TableValues.Colors.Red, TableValues.Parities.Even));
            TableList.Add(new TableValues(5, 3, 15, "Fifteen", TableValues.Colors.Black, TableValues.Parities.Odd));
            TableList.Add(new TableValues(6, 1, 16, "Sixteen", TableValues.Colors.Red, TableValues.Parities.Even));
            TableList.Add(new TableValues(6, 2, 17, "Seventeen", TableValues.Colors.Black, TableValues.Parities.Odd));
            TableList.Add(new TableValues(6, 3, 18, "Eighteen", TableValues.Colors.Red, TableValues.Parities.Even));
            TableList.Add(new TableValues(7, 1, 19, "Nineteen", TableValues.Colors.Red, TableValues.Parities.Odd));
            TableList.Add(new TableValues(7, 2, 20, "Twenty", TableValues.Colors.Black, TableValues.Parities.Even));
            TableList.Add(new TableValues(7, 3, 21, "Twenty One", TableValues.Colors.Red, TableValues.Parities.Odd));
            TableList.Add(new TableValues(8, 1, 22, "Twenty Two", TableValues.Colors.Black, TableValues.Parities.Even));
            TableList.Add(new TableValues(8, 2, 23, "Twenty Three", TableValues.Colors.Red, TableValues.Parities.Odd));
            TableList.Add(new TableValues(8, 3, 24, "Twenty Four", TableValues.Colors.Black, TableValues.Parities.Even));
            TableList.Add(new TableValues(9, 1, 25, "Twenty Five", TableValues.Colors.Red, TableValues.Parities.Odd));
            TableList.Add(new TableValues(9, 2, 26, "Twenty Six", TableValues.Colors.Black, TableValues.Parities.Even));
            TableList.Add(new TableValues(9, 3, 27, "Twenty Seven", TableValues.Colors.Red, TableValues.Parities.Odd));
            TableList.Add(new TableValues(10, 1, 28, "Twenty Eight", TableValues.Colors.Black, TableValues.Parities.Even));
            TableList.Add(new TableValues(10, 2, 29, "Twenty Nine", TableValues.Colors.Black, TableValues.Parities.Odd));
            TableList.Add(new TableValues(10, 3, 30, "Thirty", TableValues.Colors.Red, TableValues.Parities.Even));
            TableList.Add(new TableValues(11, 1, 31, "Thirty One", TableValues.Colors.Black, TableValues.Parities.Odd));
            TableList.Add(new TableValues(11, 2, 32, "Thirty Two", TableValues.Colors.Red, TableValues.Parities.Even));
            TableList.Add(new TableValues(11, 3, 33, "Thirty Three", TableValues.Colors.Black, TableValues.Parities.Odd));
            TableList.Add(new TableValues(12, 1, 34, "Thirty Four", TableValues.Colors.Red, TableValues.Parities.Even));
            TableList.Add(new TableValues(12, 2, 35, "Thirty Five", TableValues.Colors.Black, TableValues.Parities.Odd));
            TableList.Add(new TableValues(12, 3, 36, "Thirty Six", TableValues.Colors.Red, TableValues.Parities.Even));
            TableList.Add(new TableValues(37, "Double Zero", TableValues.Colors.Green));
            
            //Keep player playing until they're done.
            bool KeepPlaying = true;
            while (KeepPlaying)
            {
                var firstWheel = new Wheel();
                var winningBin = firstWheel.SpinWheel(TableList);
                
                var betResults = new Results();
                betResults.GetResults(winningBin);
                
                //Validate user input TODO: exception handling
                Console.WriteLine("Do you want to keep playing?");
                var userInput = Console.ReadLine();
                while (string.IsNullOrWhiteSpace(userInput) || String.IsNullOrEmpty(userInput))
                {
                    Console.WriteLine("Invalis input, please try again.");
                    userInput = Console.ReadLine();
                }

                KeepPlaying = userInput.ToLower() == "yes";
            }

        }

    }
}
