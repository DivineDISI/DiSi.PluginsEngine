using System.Reflection;

namespace DiSi.PluginsEngine;

public class PluginLoader
{
    public static Plugin LoadNew(string path)
    {
        if (!File.Exists(path)) throw new Exception("File not found!");

        var assembly = Assembly.LoadFrom(path);
        return new Plugin(assembly);
    }
}