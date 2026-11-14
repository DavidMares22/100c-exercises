using System;
using System.IO;


namespace _100Exercises;

public class ReadFile
{
    private readonly IFileSystem _fileSystem;
    private readonly ILogger _logger;

    public ReadFile(IFileSystem fileSystem, ILogger logger)
    {
        _fileSystem = fileSystem;
        _logger = logger;
    }
    public string TryReadFile(string fileName)
    {
             try
            {
                // Try to read the file
                return _fileSystem.ReadFile(fileName);
            }
            catch (FileNotFoundException ex)
            {
                // Log a warning with the exception message
                _logger.Log($"Warning: {ex.Message}");
        
                // Rethrow the exception
                throw;
            }
            finally
            {
                // Always log this message whether it fails or succeeds
                _logger.Log($"Attempted to read file: {fileName}");
            }
    }
}
public interface IFileSystem
{
    string ReadFile(string fileName);
}

public interface ILogger
{
    void Log(string message);
}


public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

public class InMemoryFileSystem : IFileSystem
{
    private readonly Dictionary<string, string> _files = new();

    public InMemoryFileSystem(Dictionary<string, string> files)
    {
        _files = files;
    }
    public string ReadFile(string fileName)
    {
        if(!_files.TryGetValue(fileName, out var content))
        {
            throw new FileNotFoundException($"File not found: {fileName}");
        }

        return content;
    }
}