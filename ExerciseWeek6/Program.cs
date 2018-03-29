using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace ExerciseWeek6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates list and adds all table values.
            List<TableValues> TableList = new List<TableValues>();
            TableList.Add(new TableValues(0, "Zero", TableValues.Color.Black));
            TableList.Add(new TableValues(1, 1, 1, "One", TableValues.Color.Red, TableValues.Parity.Odd));
            TableList.Add(new TableValues(1, 2, 2, "Two", TableValues.Color.Black, TableValues.Parity.Even));
            TableList.Add(new TableValues(1, 3, 3, "Three", TableValues.Color.Red, TableValues.Parity.Odd));
            TableList.Add(new TableValues(2, 1, 4, "Four", TableValues.Color.Black, TableValues.Parity.Even));
            TableList.Add(new TableValues(2, 2, 5, "Five", TableValues.Color.Red, TableValues.Parity.Odd));
            TableList.Add(new TableValues(2, 3, 6, "Six", TableValues.Color.Black, TableValues.Parity.Even));
            TableList.Add(new TableValues(3, 1, 7, "Seven", TableValues.Color.Red, TableValues.Parity.Odd));
            TableList.Add(new TableValues(3, 2, 8, "Eight", TableValues.Color.Black, TableValues.Parity.Even));
            TableList.Add(new TableValues(3, 3, 9, "Nine", TableValues.Color.Red, TableValues.Parity.Odd));
            TableList.Add(new TableValues(4, 1, 10, "Ten", TableValues.Color.Black, TableValues.Parity.Even));
            TableList.Add(new TableValues(4, 2, 11, "Eleven", TableValues.Color.Black, TableValues.Parity.Odd));
            TableList.Add(new TableValues(4, 3, 12, "Twelve", TableValues.Color.Red, TableValues.Parity.Even));
            TableList.Add(new TableValues(5, 1, 13, "Thirteen", TableValues.Color.Black, TableValues.Parity.Odd));
            TableList.Add(new TableValues(5, 2, 14, "Fourteen", TableValues.Color.Red, TableValues.Parity.Even));
            TableList.Add(new TableValues(5, 3, 15, "Fifteen", TableValues.Color.Black, TableValues.Parity.Odd));
            TableList.Add(new TableValues(6, 1, 16, "Sixteen", TableValues.Color.Red, TableValues.Parity.Even));
            TableList.Add(new TableValues(6, 2, 17, "Seventeen", TableValues.Color.Black, TableValues.Parity.Odd));
            TableList.Add(new TableValues(6, 3, 18, "Eighteen", TableValues.Color.Red, TableValues.Parity.Even));
            TableList.Add(new TableValues(7, 1, 19, "Nineteen", TableValues.Color.Red, TableValues.Parity.Odd));
            TableList.Add(new TableValues(7, 2, 20, "Twenty", TableValues.Color.Black, TableValues.Parity.Even));
            TableList.Add(new TableValues(7, 3, 21, "Twenty One", TableValues.Color.Red, TableValues.Parity.Odd));
            TableList.Add(new TableValues(8, 1, 22, "Twenty Two", TableValues.Color.Black, TableValues.Parity.Even));
            TableList.Add(new TableValues(8, 2, 23, "Twenty Three", TableValues.Color.Red, TableValues.Parity.Odd));
            TableList.Add(new TableValues(8, 3, 24, "Twenty Four", TableValues.Color.Black, TableValues.Parity.Even));
            TableList.Add(new TableValues(9, 1, 25, "Twenty Five", TableValues.Color.Red, TableValues.Parity.Odd));
            TableList.Add(new TableValues(9, 2, 26, "Twenty Six", TableValues.Color.Black, TableValues.Parity.Even));
            TableList.Add(new TableValues(9, 3, 27, "Twenty Seven", TableValues.Color.Red, TableValues.Parity.Odd));
            TableList.Add(new TableValues(10, 1, 28, "Twenty Eight", TableValues.Color.Black, TableValues.Parity.Even));
            TableList.Add(new TableValues(10, 2, 29, "Twenty Nine", TableValues.Color.Black, TableValues.Parity.Odd));
            TableList.Add(new TableValues(10, 3, 30, "Thirty", TableValues.Color.Red, TableValues.Parity.Even));
            TableList.Add(new TableValues(11, 1, 31, "Thirty One", TableValues.Color.Black, TableValues.Parity.Odd));
            TableList.Add(new TableValues(11, 2, 32, "Thirty Two", TableValues.Color.Red, TableValues.Parity.Even));
            TableList.Add(new TableValues(11, 3, 33, "Thirty Three", TableValues.Color.Black, TableValues.Parity.Odd));
            TableList.Add(new TableValues(12, 1, 34, "Thirty Four", TableValues.Color.Red, TableValues.Parity.Even));
            TableList.Add(new TableValues(12, 2, 35, "Thirty Five", TableValues.Color.Black, TableValues.Parity.Odd));
            TableList.Add(new TableValues(12, 3, 36, "Thirty Six", TableValues.Color.Red, TableValues.Parity.Even));
            TableList.Add(new TableValues(37, "Double Zero", TableValues.Color.Green));
            
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
