﻿namespace AdventOfCode2022.Shared.Helpers;

public interface IInputHelper
{
    string InputFilePath { get; init; }

    string[] GetInput();
}