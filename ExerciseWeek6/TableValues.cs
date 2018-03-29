using System;
using System.Runtime.InteropServices.ComTypes;

namespace ExerciseWeek6
{
    //Fields for all table value objects
    internal class TableValues
    {
        internal readonly int Row;
        internal readonly int Colummn;
        internal readonly int TableNumber;
        internal readonly string Name;
        internal readonly Color color;
        internal readonly Parity parity;
        
        //Constructor for all numbers not zero or double zero
        public TableValues(int row, int colummn, int tableNumber, string name, Color color, Parity parity)
        {
            this.Row = row;
            this.Colummn = colummn;
            this.TableNumber = tableNumber;
            this.Name = name;
            this.color = color;
            this.parity = parity;
        }
        
        //Constructor for zero and double zero
        public TableValues(int tableNumber, string name, Color color)
        {
            this.TableNumber = tableNumber;
            this.Name = name;
            this.color = color;
        }
        
        //Made to allow single parameter bet methods that differ by type
        public enum Color
        {
            Green,
            Red,
            Black
        };
        
        //Made to allow single parameter bet methods that differ by type
        public enum Parity
        {
            Even,
            Odd
        };

    }
}