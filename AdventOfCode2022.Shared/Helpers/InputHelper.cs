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
    public string InputFilePath { get; init; }

    public InputHelper()
    {
        var executingAssemblyFolder = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new Exception("Could not find executing assembly folder");

        var currentProjectDirectory = Directory.GetParent(executingAssemblyFolder)!.Parent!.Parent;

        InputFilePath = Path.Combine(currentProjectDirectory!.FullName, _folderName, _fileName) ?? throw new Exception("Could not find input file");

        if (!File.Exists(InputFilePath))
        {
            throw new FileNotFoundException($"File not found: {InputFilePath}");
        }
    }

    public string[] GetInput()
    {
        var input = File.ReadAllLines(InputFilePath);
        return input ?? throw new Exception("Could not read input file");
    }
}