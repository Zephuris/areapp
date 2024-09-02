using System;
using System.Collections.Generic;

/// Let's assume the number of point equals 10.
/// Input validation is removed because of previous assumption. <summary>
/// We use shoelace formula 


class Program
{
    static int AreaCalculator(List<(int x, int y)> pointsList)
    {
        int area = 0; ///defining variable for area
        int n = pointsList.Count;
        for (int i = 0; i < n-1; i++)
        {
            /// in this part we define two vertices 
            int x1 = pointsList[i].Item1, y1 = pointsList[i].Item2;
            int x2 = pointsList[(i + 1)].Item1, y2 = pointsList[i + 1].Item2;
            
            area += x1 * y2 - x2 * y1;
        }

        area = area / 2;

        /// area is negavite and returning absolute value
        return Math.Abs(area);
    }
    static void Main()
    {   /// example list to calculate 
        var points = new List<(int, int)> { 
            (2, 3), (5, 11),
            (12, 8), (9, 5),
            (5, 6), (1, 7), 
            (3, 10), (6, 12),
            (8, 7), (4, 4) 
        };
        /// caling method and printing result
        Console.WriteLine(AreaCalculator(points));
    }
}
