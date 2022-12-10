using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4;

public static class App
{
    public static int SolvePart1(string[] input)
    {
        int result = 0;
        foreach (var line in input)
        {
            var (first, second) = GetIntervals(line);
            if (OneFullyContainsTheOther(first, second))
            {
                result += 1;
            }
        }

        return result;
    }

    public static int SolvePart2(string[] input)
    {
        int result = 0;
        foreach (var line in input)
        {
            var (first, second) = GetIntervals(line);
            if (IsOverlaping(first, second))
            {
                result += 1;
            }
        }

        return result;
    }

    private static bool IsOverlaping(Interval first, Interval second)
    {
        return first.Overlaps(second) || first.FullyContains(second) || second.FullyContains(first);
    }

    private static bool OneFullyContainsTheOther(Interval first, Interval second)
    {
        return first.FullyContains(second) || second.FullyContains(first);
    }

    private static (Interval first, Interval second) GetIntervals(string line)
    {
        var splittedLine = line.Split(",");
        var first = splittedLine[0].Split("-");
        var second = splittedLine[1].Split("-");

        return (
            new Interval(Convert.ToInt32(first[0]), Convert.ToInt32(first[1])),
            new Interval(Convert.ToInt32(second[0]), Convert.ToInt32(second[1])));
    }
}

public class Interval
{
    public int Start { get; }
    public int End { get; }

    public Interval(int start, int end)
    {
        Start = start;
        End = end;
    }

    public bool FullyContains(Interval other)
    {
        return Start <= other.Start && End >= other.End;
    }

    public bool Overlaps(Interval other)
    {
        return Start <= other.Start && End >= other.Start ||
            other.Start <= Start && other.End >= Start;
    }
}