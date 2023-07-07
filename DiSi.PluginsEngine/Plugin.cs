using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DiSi.PluginsEngine.Core.Attributes;

namespace DiSi.PluginsEngine;
public class Plugin
{
    public Plugin(Assembly assembly)
    {
        Assembly = assembly;
    }

    internal Assembly Assembly { get; set; }

    public void Execute()
    {
        var type = Assembly.GetTypes()
            .FirstOrDefault(x=>x.GetCustomAttribute<TestAttribute>() != null) ?? throw new NullReferenceException();

        var inst = Activator.CreateInstance(type);
        
        var result = type.GetMethods().FirstOrDefault(x=>x.GetCustomAttribute<MethodAttribute>()!=null)!.Invoke(inst, null);
    }
}
