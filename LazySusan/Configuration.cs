using Dalamud.Configuration;
using Dalamud.Plugin;
using ECommons.Configuration;
using System;

namespace LazySusan
{
    [Serializable]
    public class Configuration : IEzConfig
    {

        public void Save()
        {
            this.SaveConfiguration(EzConfig.DefaultConfigurationFileName);
        }

        public bool SomePropertyToBeSavedAndWithADefault { get; set; } = true;
    }
}
