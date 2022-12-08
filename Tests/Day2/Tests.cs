using Day2;
using NSubstitute;
using Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022.Tests.Day2;

public class Tests
{
    private readonly IInputHelper _inputHelper;

    public Tests()
    {
        _inputHelper = Substitute.For<IInputHelper>();

        _inputHelper.GetInput().Returns((new TestInputHelper("Day2")).GetInput());
    }

    [Fact]
    public void SolvePart1_ShouldReturnCorrectSolution_WhenInputIsFromExample()
    {
        const int expectedResult = 15;

        var solution = App.SolvePart1(_inputHelper.GetInput());

        Assert.Equal(expectedResult, solution);
    }

    [Fact]
    public void SolvePart2_ShouldReturnCorrectSolution_WhenInputIsFromExample()
    {
        const int expectedResult = 12;

        var solution = App.SolvePart2(_inputHelper.GetInput());

        Assert.Equal(expectedResult, solution);
    }
}