using Shared.Helpers;

namespace Day4;

public static class Program
{
    private static void Main(string[] args)
    {
        var input = new InputHelper().GetInput();
        SolvePart1(input);
        SolvePart2(input);
    }

    private static void SolvePart1(string[] input)
    {
        var solution = App.SolvePart1(input);

        var solutionMessage = $"The number of assignment pairs that fully contain the other are {solution}.";
        Console.WriteLine(solutionMessage);
    }

    private static void SolvePart2(string[] input)
    {
        var solution = App.SolvePart2(input);

        var solutionMessage = $"The number of assignment pairs that overlap the other are {solution}.";
        Console.WriteLine(solutionMessage);
    }
}