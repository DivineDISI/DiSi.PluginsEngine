using System;

namespace DiSi.PluginsEngine.Core.Interfaces;

public interface IEntryPoint
{
    public void Start();
    public void Restart();
    public void OnExit();
}
