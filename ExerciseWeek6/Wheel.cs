using System;
using System.Collections.Generic;

namespace ExerciseWeek6
{
    internal class Wheel
    {
        
        //Wheel class is incharge of spinning wheel
        public TableValues SpinWheel(List<TableValues> tableList)
        {
            Random NextRandom = new Random();
            int wheelSpin = NextRandom.Next(tableList.Count);
            TableValues winningBin = tableList[wheelSpin];
            return winningBin;
        }
    }
}