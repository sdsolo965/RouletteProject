using System;
using System.Linq;

namespace ExerciseWeek6
{
    internal class Bets
    {
        private int tableNumber;
        private TableValues.Colors color;
        private int column;
        private int row;
        private TableValues.Parities parity;

        public Bets(int tableNumber)
        {
            //TODO
        }

        public Bets(TableValues.Colors color)
        {
            //TODO
            this.color = color;
        }

        public Bets(TableValues.Parities parity)
        {
            //TODO
            this.parity = parity;
        }
        

    }
}