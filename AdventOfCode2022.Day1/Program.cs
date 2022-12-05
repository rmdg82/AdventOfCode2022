using AdventOfCode2022.Shared.Helpers;

namespace AdventOfCode2022.Day1
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var input = (new InputHelper()).GetInput();
            SolvePart1(input);
            SolvePart2(input);
        }

        private static void SolvePart1(string[] input)
        {
            var solution = App.SolvePart1(input);

            var solutionMessage = $"The elf carrying most calories has {solution} calories.";
            Console.WriteLine(solutionMessage);
        }

        private static void SolvePart2(string[] input)
        {
            var solution = App.SolvePart2(input);

            var solutionMessage = $"The top three Elves total calories are {solution}";
            Console.WriteLine(solutionMessage);
        }
    }
}