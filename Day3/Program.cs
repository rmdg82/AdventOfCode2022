using Shared.Helpers;

namespace Day3;

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

        var solutionMessage = $"The sum of all priorities is {solution}";
        Console.WriteLine(solutionMessage);
    }

    private static void SolvePart2(string[] input)
    {
        var solution = App.SolvePart2(input);

        var solutionMessage = $"The sum of all priorities for all the three-elf group is {solution}";
        Console.WriteLine(solutionMessage);
    }
}