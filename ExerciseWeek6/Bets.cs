using System;
using System.Linq;

namespace ExerciseWeek6
{
    internal class Bets
    {
        private int tableNumber;
        private TableValues.Color color;
        private int column;
        private int row;
        private TableValues.Parity parity;

        public Bets(int tableNumber)
        {
            //TODO
        }

        public Bets(TableValues.Color color)
        {
            //TODO
            this.color = color;
        }

        public Bets(TableValues.Parity parity)
        {
            //TODO
            this.parity = parity;
        }
        

    }
}