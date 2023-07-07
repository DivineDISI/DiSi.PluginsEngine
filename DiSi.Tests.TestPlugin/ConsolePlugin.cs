using DiSi.PluginsEngine.Core.Attributes;

namespace DiSi.Tests.TestPlugin;

[Test]
public class ConsolePlugin
{
    [Method]
    public void Print()
    {
        Console.WriteLine("Console plugin.");
    }
}