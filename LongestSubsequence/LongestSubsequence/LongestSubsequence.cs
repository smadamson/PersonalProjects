using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System;

class Solution
{
    /**
     * Take a rectangular grid of numbers and find the length
     * of the longest sub-sequence.
     * Return the length as an integer.
     */
    static int LongestSubsequence(int[][] grid)
    {
        //I think the best way to do this is to check the length of each subsequence and compare them to eachother. 
        int longestSoFar = 0;

        for (int y = 0; y < grid.Length; y++)
        {
            for (int x = 0; x < grid[y].Length; x++)
            {
                int[][] copyOfGrid = grid;

                int subLength = SubsequenceLength(copyOfGrid, x, y);
                if (subLength > longestSoFar)
                {
                    longestSoFar = subLength;
                }
            }
        }
        return longestSoFar;
    }

    /// <summary>
    /// Returns the length of the longest Subsequence starting at the x-,y-coordinates. 
    /// </summary>
    private static int SubsequenceLength(int[][] grid, int x, int y)
    {
        List<int> valuesUsed = new List<int>();
        List<int> lengths = SubsequenceLengthRecursive(grid, x, y, new List<int>(), 1, ref valuesUsed);
        //return the longest value in lengths. 
        int greatestSoFar = 0;
        foreach (int value in lengths)
        {
            if (value > greatestSoFar)
            {
                greatestSoFar = value;
            }
        }
        return greatestSoFar;
    }

    /// <summary>
    ///  Returns the length of the subsequence of 
    ///  x,y is the starting value. 
    /// </summary>
    /// <returns> a list of all the subsequence lengths starting at (x,y) </returns>
    private static List<int> SubsequenceLengthRecursive(int[][] grid, int x, int y, List<int> lengths, int length, ref List<int> valuesUsed)
    {
        //x and y are the starting element, check each element around that element. 
        int startingValue = grid[y][x];
        //add the value to the list of used values. 
        valuesUsed.Add(startingValue);

        //Look at this element and then look at each element adjacent to it. 
        //See which elements have a difference of 3. 

        // check the element to the right
        if (CheckElement(x + 1, y, grid, startingValue, valuesUsed))
        {
            //if this is true change the value of x so that we are now starting on x++ and y. 
            // x++;
            length += 1;
            lengths = SubsequenceLengthRecursive(grid, x + 1, y, lengths, length, ref valuesUsed);
            length = lengths.Last() - 1;
            
        }
        //element to the left
        if (CheckElement(x - 1, y, grid, startingValue, valuesUsed))
        {
            //x--;
            length += 1;
            lengths = SubsequenceLengthRecursive(grid, x - 1, y, lengths, length, ref valuesUsed);
            length = lengths.Last() - 1;

        }
        //element above
        if (CheckElement(x, y - 1, grid, startingValue, valuesUsed))
        {
            // y--;
            length += 1;
            lengths = SubsequenceLengthRecursive(grid, x, y - 1, lengths, length, ref valuesUsed);
            length = lengths.Last() -1;

        }
        //element below
        if (CheckElement(x, y + 1, grid, startingValue, valuesUsed))
        {
            // y++;
            //Add one to the length before or after? TODO:
            length += 1;
            lengths = SubsequenceLengthRecursive(grid, x, y + 1, lengths, length, ref valuesUsed);
            length = lengths.Last() - 1;

        }
        // lower right corner
        if (CheckElement(x + 1, y + 1, grid, startingValue, valuesUsed))
        {
            //y++; x++;
            length += 1;
            lengths = SubsequenceLengthRecursive(grid, x + 1, y + 1, lengths, length, ref valuesUsed);
            length = lengths.Last() - 1;


        }
        // lower left corner
        if (CheckElement(x - 1, y + 1, grid, startingValue, valuesUsed))
        {
            // x++; y--;
            length += 1;
            lengths = SubsequenceLengthRecursive(grid, x - 1, y + 1, lengths, length, ref valuesUsed);
            length = lengths.Last()- 1;

        }
        // upper right corner
        if (CheckElement(x + 1, y - 1, grid, startingValue, valuesUsed))
        {
            //x--; y++;
            length += 1;
            lengths = SubsequenceLengthRecursive(grid, x + 1, y - 1, lengths, length, ref valuesUsed);
            length = lengths.Last()- 1;

        }
        // upper left corner
        if (CheckElement(x - 1, y - 1, grid, startingValue, valuesUsed))
        {
            // x--; y--;
            length += 1;
            lengths = SubsequenceLengthRecursive(grid, x - 1, y - 1, lengths, length, ref valuesUsed);
            length = lengths.Last()- 1;

        }

        //None of the adjacent values have a difference of 3 or they are -1
        // this happens after all the surrounding values have been changed. 
        // This is the base case. 
        // Each of the subsequences lengths will be stored in this list. Everytime the base case is reached, 
        // add the length to the list.
        lengths.Add(length);

        //remove the value from the list of used values. 
        valuesUsed.Remove(startingValue);
        return lengths;
    }

    /// <summary>
    /// checks the elemnt with the given x-,y- coordinates. 
    /// The value must be in bounds of the grid, must not have been previously used (-1), 
    /// and the absoulute difference must be at least 3.
    /// </summary>
    /// <param name="x"> x-value to check</param>
    /// <param name="y">y-value to check</param>
    /// <returns> returns true if the cordinates are in bounds, if the grid at those coordinates is not -1, 
    /// and if the absoulute difference between the starting value and grid value
    /// is greater than or equal to 3 </returns>
    private static bool CheckElement(int x, int y, int[][] grid, int startingValue, List<int> valuesUsed)
    {
        return IsInBounds(x, y, grid) && Math.Abs(startingValue - grid[y][x]) > 3 && !valuesUsed.Contains(grid[y][x]);
    }

    /// <summary>
    /// Returns true if the given x-, y-coordinates are in the bounds of the grid. 
    /// </summary>
    private static bool IsInBounds(int x, int y, int[][] grid)
    {
        return x >= 0 && y >= 0 && y < grid.Length && x < grid[0].Length;
    }

    static void Main(String[] args)
    {
        int res, res1, res2, res3, res4, res5, res6, res7;
        /*
        int numRows = 0;
        int numCols = 0;
        String[] firstLine = Regex.Split(Console.ReadLine(), @"\s+");
        numRows = Convert.ToInt32(firstLine[0]);
        numCols = Convert.ToInt32(firstLine[1]);

        int[][] grid = new int[numRows][];
        for (int row = 0; row < numRows; row++)
        {
            String[] inputRow = Regex.Split(Console.ReadLine(), @"\s+");
            int[] gridRow = new int[numCols];

            for (int col = 0; col < numCols; col++)
            {
                gridRow[col] = Convert.ToInt32(inputRow[col]);
            }
            grid[row] = gridRow;
        }
        */
        // 1 6 2
        // 8 3 7
        // 4 9 5
        // Answer is 9
        int[][] grid1 = new int[3][];

        int[] gridRow0 = new int[] { 1, 6, 2 };
        int[] gridRow1 = new int[] { 8, 3, 7 };
        int[] gridRow2 = new int[] { 4, 9, 5 };

        grid1[0] = gridRow0;
        grid1[1] = gridRow1;
        grid1[2] = gridRow2;

        // 4 2 4
        // 0 3 1
        // 3 7 9
        // Answer is 6
        int[][] grid4 = new int[3][]; 

        int[] grid4Row0 = new int[] { 4, 2, 4 };
        int[] grid4Row1 = new int[] { 0, 3, 1 };
        int[] grid4Row2 = new int[] { 3, 7, 9 };

        grid4[0] = grid4Row0;
        grid4[1] = grid4Row1;
        grid4[2] = grid4Row2;

        // 1 6
        // 8 3
        //Answer is 4
        int[][] grid2 = new int[2][];

        int[] grid2Row0 = new int[] { 1, 6 };
        int[] grid2Row1 = new int[] { 8, 3 };

        grid2[0] = grid2Row0;
        grid2[1] = grid2Row1;

        // 5 6
        // 8 7
        //Answer is 1
        int[][] grid3 = new int[2][];

        int[] grid3Row0 = new int[] { 5, 6 };
        int[] grid3Row1 = new int[] { 8, 7 };

        grid3[0] = grid3Row0;
        grid3[1] = grid3Row1;

        // 8 2 4
        // 0 6 1 
        // 3 7 9
        // Answer is 8
        int[][] grid5 = new int[3][];

        int[] grid5Row0 = new int[] { 8, 2, 4 };
        int[] grid5Row1 = new int[] { 0, 6, 1 };
        int[] grid5Row2 = new int[] { 3, 7, 9 };

        grid5[0] = grid5Row0;
        grid5[1] = grid5Row1;
        grid5[2] = grid5Row2;

        // 4 2 4 
        // 0 3 1
        // Answer is 2
        int[][] grid6 = new int[2][];

        int[] grid6Row0 = new int[] { 4, 2, 4 };
        int[] grid6Row1 = new int[] { 0, 3, 1 };
        //int[] grid6Row2 = new int[] { 3, 7, 9 };

        grid6[0] = grid6Row0;
        grid6[1] = grid6Row1;
        //grid6[2] = grid6Row2;

        // -1 -9 2
        // -4 4 12
        // 16 0 9
        // Answer is 9
        int[][] grid7 = new int[3][];

        int[] grid7Row0 = new int[] { -1, -9, 2 };
        int[] grid7Row1 = new int[] { -4, 4, 12 };
        int[] grid7Row2 = new int[] { 16, 0, 9 };

        grid7[0] = grid7Row0;
        grid7[1] = grid7Row1;
        grid7[2] = grid7Row2;


       // res = LongestSubsequence(grid);
        res4 = LongestSubsequence(grid4); 
        res3 = LongestSubsequence(grid3);
        res2 = LongestSubsequence(grid2);
        res1 = LongestSubsequence(grid1);
        res5 = LongestSubsequence(grid5);
        res6 = LongestSubsequence(grid6);
        res7 = LongestSubsequence(grid7);

        Console.WriteLine(res1 + " Answer: 9");
        Console.WriteLine(res2 + " Answer: 4");
        Console.WriteLine(res3 + " Answer: 1");
        Console.WriteLine(res4 + " Answer: 6");
        Console.WriteLine(res5 + " Answer: 8");
        Console.WriteLine(res6 + " Answer: 2");
        Console.WriteLine(res7 + " Answer: 9");
        //Console.WriteLine(res);
        Console.Read();
    }
}