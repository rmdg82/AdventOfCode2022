using AdventOfCode2022.Tests;
using Day4;
using Shared.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Day4;

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
        const int expectedResult = 2;

        var solution = App.SolvePart1(_inputHelper.GetInput());

        Assert.Equal(expectedResult, solution);
    }

    [Fact]
    public void SolvePart2_ShouldReturnCorrectSolution_WhenInputIsFromExample()
    {
        const int expectedResult = 70;

        var solution = App.SolvePart2(_inputHelper.GetInput());

        Assert.Equal(expectedResult, solution);
    }
}