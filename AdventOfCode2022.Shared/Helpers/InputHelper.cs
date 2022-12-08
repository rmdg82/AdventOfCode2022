using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Helpers;

public class InputHelper : IInputHelper
{
    private const string _fileName = "input.txt";
    private const string _folderName = "Input";
    public string InputFileFolderPath { get; init; }

    public InputHelper()
    {
        var executingAssemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new Exception("Could not find executing assembly folder");

        var currentProjectDirectory = Directory.GetParent(executingAssemblyFolder)!.Parent!.Parent;

        InputFileFolderPath = Path.Combine(currentProjectDirectory!.FullName, _folderName) ?? throw new Exception("Could not build input file");

        if (!Directory.Exists(InputFileFolderPath))
        {
            throw new FileNotFoundException($"Folder not found: {InputFileFolderPath}");
        }
    }

    public string[] GetInput(string? filename = null)
    {
        var filePath = Path.Combine(InputFileFolderPath, filename ?? _fileName);

        if (!File.Exists(filePath))
        {
            throw new FileNotFoundException($"File not found: {filePath}");
        }

        var input = File.ReadAllLines(filePath);
        return input ?? throw new Exception("Could not read input file");
    }
}