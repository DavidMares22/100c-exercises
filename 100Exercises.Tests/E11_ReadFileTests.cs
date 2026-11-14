using System.Collections.Generic;
using System.IO;
using Xunit;

namespace _100Exercises.Tests;

public class ReadFileTests
{
    [Fact]
    public void ShouldLogWarningAndThrow_WhenFileDoesNotExist()
    {
        var logger = new ListLogger();
        var exercise = new ReadFile(new InMemoryFileSystem(new Dictionary<string, string>()), logger);

        Assert.Throws<FileNotFoundException>(() => exercise.TryReadFile("missing.txt"));
        Assert.Contains("Warning: File not found: missing.txt", logger.Messages);
        Assert.Contains("Attempted to read file: missing.txt", logger.Messages);
    }

    [Fact]
    public void ShouldReturnFileContent_WhenFileExists()
    {
        var files = new Dictionary<string, string> { { "readme.txt", "Hello" } };
        var logger = new ListLogger();
        var exercise = new ReadFile(new InMemoryFileSystem(files), logger);

        var content = exercise.TryReadFile("readme.txt");

        Assert.Equal("Hello", content);
        Assert.Contains("Attempted to read file: readme.txt", logger.Messages);
    }

    private class ListLogger : ILogger
    {
        public List<string> Messages { get; } = new();

        public void Log(string message) => Messages.Add(message);
    }
}
