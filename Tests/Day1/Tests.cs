using NSubstitute;
using Day1;
using Shared.Helpers;

namespace AdventOfCode2022.Tests.Day1;

public class Tests
{
    private readonly IInputHelper _inputHelper;

    public Tests()
    {
        _inputHelper = Substitute.For<IInputHelper>();

        _inputHelper.GetInput().Returns((new TestInputHelper("Day1")).GetInput());
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