using System;
using System.Runtime.InteropServices.ComTypes;

namespace ExerciseWeek6
{
    //Fields for all table value objects
    internal class TableValues
    {
        public int Row { get;}
        public int Column { get;}
        public int TableNumber { get;}
        public string Name { get;}
        public Colors Color { get;}
        public Parities Parity { get;}
        
        //Made to allow single parameter bet methods that differ by type
        public enum Colors
        {
            Green,
            Red,
            Black
        };
        //Made to allow single parameter bet methods that differ by type
        public enum Parities
        {
            Even,
            Odd
        };

        //Constructor for all numbers not zero or double zero
        public TableValues(int row, int colummn, int tableNumber, string name, Colors color, Parities parity)
        {
            Row = row;
            Column = colummn;
            TableNumber = tableNumber;
            Name = name;
            Color = color;
            Parity = parity;
        }
        
        //Constructor for zero and double zero
        public TableValues(int tableNumber, string name, Colors color)
        {
            TableNumber = tableNumber;
            Name = name;
            Color = color;
        }
    }
}