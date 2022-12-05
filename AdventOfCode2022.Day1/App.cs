using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Day1;

public static class App
{
    private static string _separator = string.Empty;

    public static int SolvePart1(string[] input)
    {
        Dictionary<int, int> elvesCalories = GetElvesCaloriesDict(input);

        var maxCalories = elvesCalories.Max(x => x.Value);

        return maxCalories;
    }

    public static int SolvePart2(string[] input)
    {
        Dictionary<int, int> elvesCalories = GetElvesCaloriesDict(input);

        var orderedElvesCalories = elvesCalories.OrderByDescending(kpv => kpv.Value);

        var solution = orderedElvesCalories.Take(3).Sum(x => x.Value);

        return solution;
    }

    private static Dictionary<int, int> GetElvesCaloriesDict(string[] input)
    {
        int elfNumber = 1;

        var elvesCalories = new Dictionary<int, int>() { [elfNumber] = 0 };

        foreach (var line in input)
        {
            if (line != _separator)
            {
                if (!elvesCalories.TryGetValue(elfNumber, out _))
                {
                    elvesCalories[elfNumber] = 0;
                }

                elvesCalories[elfNumber] += Convert.ToInt32(line);
            }
            else
            {
                elfNumber++;
            }
        }

        return elvesCalories;
    }
}