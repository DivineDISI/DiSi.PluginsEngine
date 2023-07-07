using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DiSi.PluginsEngine;
public class Plugin
{
    public Plugin(Assembly assembly)
    {
        Assembly = assembly;
    }

    internal Assembly Assembly { get; set; }
}
