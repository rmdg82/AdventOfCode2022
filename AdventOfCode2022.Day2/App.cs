using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2;

public static class App
{
    private enum Result
    {
        Win = 6,
        Draw = 3,
        Lose = 0
    }

    //private static readonly Dictionary<char, int> _firstColumnValues = new()
    //{
    //    ['A'] = 1,
    //    ['B'] = 2,
    //    ['C'] = 3
    //};

    private static readonly Dictionary<char, int> _secondColumnValues = new()
    {
        ['X'] = 1,
        ['Y'] = 2,
        ['Z'] = 3
    };

    public static int SolvePart1(string[] input)
    {
        var total = 0;
        foreach (var line in input)
        {
            total += CalculateLineOutcomePart1(line);
        }

        return total;
    }

    public static int SolvePart2(string[] input)
    {
        var total = 0;
        foreach (var line in input)
        {
            total += CalculateLineOutcomePart2(line);
        }

        return total;
    }

    private static int CalculateLineOutcomePart2(string line)
    {
        var roundElements = GetRoundValues(line);

        var elementToPlay = CalculateMoveToMatchDesiredResult(roundElements[0], roundElements[1]);

        var roundOutcome = (int)CalculateRoundOutcome(roundElements[0], elementToPlay);
        var valueShapeYouSelect = _secondColumnValues[elementToPlay];

        return roundOutcome + valueShapeYouSelect;
    }

    private static char[] GetRoundValues(string line)
    {
        var roundElements = line.Split(" ").Select(x => x.ToCharArray().First()).ToArray();
        if (roundElements.Length != 2)
        {
            throw new ArgumentOutOfRangeException($"Invalid line : {line}");
        }

        return roundElements;
    }

    private static int CalculateLineOutcomePart1(string line)
    {
        var roundElements = GetRoundValues(line);

        var roundOutcome = (int)CalculateRoundOutcome(roundElements[0], roundElements[1]);
        var valueShapeYouSelected = _secondColumnValues[roundElements[1]];

        return roundOutcome + valueShapeYouSelected;
    }

    private static char CalculateMoveToMatchDesiredResult(char first, char desiredResult)
    {
        return (first, desiredResult) switch
        {
            ('A', 'X') => 'Z',
            ('A', 'Y') => 'X',
            ('A', 'Z') => 'Y',
            ('B', 'X') => 'X',
            ('B', 'Y') => 'Y',
            ('B', 'Z') => 'Z',
            ('C', 'X') => 'Y',
            ('C', 'Y') => 'Z',
            ('C', 'Z') => 'X',
            _ => throw new ArgumentException($"Invalid input: {first}, {desiredResult}"),
        };
    }

    private static Result CalculateRoundOutcome(char first, char second)
    {
        return (first, second) switch
        {
            ('A', 'X') => Result.Draw,
            ('A', 'Y') => Result.Win,
            ('A', 'Z') => Result.Lose,
            ('B', 'X') => Result.Lose,
            ('B', 'Y') => Result.Draw,
            ('B', 'Z') => Result.Win,
            ('C', 'X') => Result.Win,
            ('C', 'Y') => Result.Lose,
            ('C', 'Z') => Result.Draw,
            _ => throw new ArgumentException($"Invalid input: {first}, {second}"),
        };
    }
}