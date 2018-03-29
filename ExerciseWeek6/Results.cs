using System;

namespace ExerciseWeek6
{
    internal class Results
    {
        private int[,] _corners;
        
        //Primary results method called in Main()
        public void GetResults(TableValues tableValues)
        {
            if (tableValues.TableNumber == 0 || tableValues.TableNumber == 37)
            {
                Console.WriteLine($"The winning number is: {tableValues.Name}\n" +
                                  $"The winning color is: {tableValues.color}\n" +
                                  $"Zero and Double Zero do not have any other results.");              
            }
            else
            {
                Console.WriteLine($"The winning number is: {tableValues.TableNumber}\n" +
                                  $"The winning parity is: {tableValues.parity}\n" +
                                  $"The winning color is: {tableValues.color}");
                GetHighLowResult(tableValues);
                GetThirdsResult(tableValues);
                Console.WriteLine($"The winning Single Column bet is: Column {tableValues.Colummn}");
                Console.WriteLine($"The winning Single Row bet is: Row {tableValues.Row}");
                GetDoubleRowResult(tableValues);
                GetCornerResults(tableValues);
            }
        }
        
        //**All following methods allow to adjust returned results**
        
        
        private static void GetDoubleRowResult(TableValues tableValues)
        {
            //Rows 1 and 12 will only have one winning double row bet
            int row = tableValues.Row;
            if (row == 1 || row == 12)
            {
                switch (row)
                {
                        case 1:
                        Console.WriteLine($"The winning Double Row bet is: Rows " +
                                          $"{tableValues.Row} and {tableValues.Row + 1}");
                            break;
                        case 12:
                            Console.WriteLine($"The winning Double Row bet is: Rows " +
                                              $"{tableValues.Row + 1} and {tableValues.Row}");
                            break;
                        default:
                            Console.WriteLine("No winning rows =( ");
                            break;
                }
            }
            //All others will have two possible winning double row bets
            else
            {
                Console.WriteLine($"The winning Double Row bet is: Rows " +
                                  $"{tableValues.Row - 1} and {tableValues.Row}" +
                                  $" and rows {tableValues.Row} and {tableValues.Row + 1}");
            }
        }

        private void GetCornerResults(TableValues tableValues)
        {
            int bin = tableValues.TableNumber;
            int col = tableValues.Colummn;
            int row = tableValues.Row;
            Console.WriteLine("Winning corner bets are");
            //  These table values will return 4 winning corner bets
            if (col == 2 && row != 1 && row != 12)
            {
                _corners = new[,]
                {
                    {bin - 4, bin - 3, bin - 1, bin},
                    {bin - 3, bin - 2, bin, bin + 1},
                    {bin - 1, bin, bin + 2, bin + 3},
                    {bin, bin + 1, bin + 3, bin + 4}

                };
                for (int i = 0; i < 4; i++)
                {
                    Console.Write($"Corner {i+1}: ");
                    for (int j = 0; j < 4; j++)
                    {
                        Console.Write(_corners[i,j]+", ");
                    }
                    Console.WriteLine();
                }
            }
            //Corner table values will only have one winning corner bet
            else if (bin == 1 || bin == 3 || bin == 34 || bin == 36)
            {
                switch (bin)
                {
                        case 1:
                            Console.WriteLine($"Corner 1: {bin}, {bin + 1}, {bin + 3}, {bin + 4}");
                            break;
                        case 3:
                            Console.WriteLine($"Corner 1: {bin - 1}, {bin}, {bin + 2}, {bin + 3}");
                            break;
                        case 34:
                            Console.WriteLine($"Corner 1: {bin - 3}, {bin - 2}, {bin}, {bin + 1}");
                            break;
                        case 36:
                            Console.WriteLine($"Corner 1: {bin - 4}, {bin - 3}, {bin - 1}, {bin}");
                            break;
                        default:
                            Console.WriteLine("No corner wins =( ");
                            break;
                }
            }
            //All others will have two possible winning corner bets
            else
            {
                switch (bin)
                {
                        case 2:
                            Console.WriteLine($"Corner 1: {bin - 1}, {bin}, {bin + 2}, {bin + 3}");
                            Console.WriteLine($"Corner 2: {bin}, {bin + 1}, {bin + 3}, {bin + 4}");
                            break;
                        case 35:
                            Console.WriteLine($"Corner 1: {bin - 4}, {bin - 3}, {bin - 1}, {bin}");
                            Console.WriteLine($"Corner 2: {bin - 3}, {bin - 2}, {bin}, {bin + 1}");
                            break;
                        default:
                            if (col == 1)
                            {
                                Console.WriteLine($"Corner 1: {bin - 3}, {bin - 2}, {bin}, {bin + 1}");
                                Console.WriteLine($"Corner 2: {bin}, {bin + 1}, {bin + 3}, {bin + 4}");
                            }
                            else
                            {
                                Console.WriteLine($"Corner 1: {bin - 4}, {bin - 3}, {bin - 1}, {bin}");
                                Console.WriteLine($"Corner 2: {bin - 1}, {bin}, {bin + 2}, {bin + 3}");
                            }
                            break;
                }
            }

        }

        private static void GetThirdsResult(TableValues tableValues)
        {
            //Finds which third the table value is in
            int bin = tableValues.TableNumber;
            if (bin < 13)
            {
                Console.WriteLine("The Winning Thirds bet is: First 12");
            }
            else if (bin > 12 && bin < 25)
            {
                Console.WriteLine("The Winning Thirds bet is: Second 12");
            }
            else
            {
                Console.WriteLine("The Winning Thirds bet is: Third 12");
            }
        }

        private static void GetHighLowResult(TableValues tableValues)
        {
            //Gets high or low 18 result
            int bin = tableValues.TableNumber;
            Console.WriteLine(bin <= 18 ? "The winning high/low bet is: Low" : "The winning high/low bet is: High");
        }
    }
}