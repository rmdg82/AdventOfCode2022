using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3;

public static class App
{
    public static int SolvePart1(string[] input)
    {
        var result = 0;
        foreach (var line in input)
        {
            var (part1, part2) = SplitLine(line);
            char[] sharedChars = GetAllDuplicates(part1, part2);
            foreach (var sharedChar in sharedChars)
            {
                result += GetPriority(sharedChar);
            }
        }

        return result;
    }

    public static int SolvePart2(string[] input)
    {
        var splittedLines = GetThreeLines(input);

        var result = 0;
        foreach (var (firstLine, secondLine, thirdLine) in splittedLines)
        {
            var duplicates = GetAllDuplicates(firstLine, secondLine, thirdLine);
            foreach (var duplicate in duplicates)
            {
                result += GetPriority(duplicate);
            }
        }

        return result;
    }

    #region Part1

    private static (string part1, string part2) SplitLine(string line)
    {
        int lineLength = line.Length;
        if (lineLength % 2 != 0)
        {
            throw new ArgumentException("Line length must be even");
        }

        return (line.Substring(0, lineLength / 2), line.Substring(lineLength / 2));
    }

    private static int GetPriority(char c)
    {
        const int lowercaseHandicap = 96;
        const int uppercaseHandicap = 38;

        if (char.IsLower(c))
        {
            return (int)c - lowercaseHandicap;
        }

        return (int)c - uppercaseHandicap;
    }

    private static char[] GetAllDuplicates(string first, string second)
    {
        var result = new HashSet<char>();
        foreach (char c in first)
        {
            if (second.Contains(c))
            {
                result.Add(c);
            }
        }

        return result.ToArray();
    }

    #endregion Part1

    #region Part2

    private static List<(string firstLine, string secondLine, string thirdLine)> GetThreeLines(string[] input)
    {
        if (input.Length % 3 != 0)
        {
            throw new ArgumentException($"Input is not divisible by 3");
        }

        var result = new List<(string, string, string)>();
        int index = 0;
        while (index != input.Length)
        {
            result.Add((input[index], input[index + 1], input[index + 2]));
            index += 3;
        }

        return result;
    }

    private static char[] GetAllDuplicates(string first, string second, string third)
    {
        var firstSecondDuplicates = GetAllDuplicates(first, second);

        var thirdDuplicates = GetAllDuplicates(new string(firstSecondDuplicates), third);

        return thirdDuplicates;
    }

    #endregion Part2
}