using Day1;
using Shared.Helpers;
using AdventOfCode2022.Tests;

namespace Tests.Day1;

public class Tests
{
    private readonly TestInputHelper _inputHelper;

    public Tests()
    {
        _inputHelper = new TestInputHelper("Day4");
    }

    [Fact]
    public void SolvePart1_ShouldReturnCorrectSolution_WhenInputIsFromExample()
    {
        const int expectedCalories = 24000;

        var solution = App.SolvePart1(_inputHelper.GetInput());

        Assert.Equal(expectedCalories, solution);
    }

    [Fact]
    public void SolvePart2_ShouldReturnCorrectSolution_WhenInputIsFromExample()
    {
        const int expectedCalories = 45000;

        var solution = App.SolvePart2(_inputHelper.GetInput());

        Assert.Equal(expectedCalories, solution);
    }
}