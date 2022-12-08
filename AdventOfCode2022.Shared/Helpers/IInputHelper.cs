namespace Shared.Helpers;

public interface IInputHelper
{
    string InputFileFolderPath { get; init; }

    string[] GetInput(string? filename = null);
}