using DiSi.PluginsEngine;

var plugin = PluginLoader.LoadNew(@"C:\C#\Github\DiSi.PluginsEngine\DiSi.Tests.TestPlugin\bin\Debug\net7.0\DiSi.Tests.TestPlugin.dll");
plugin.Execute();