using Dalamud.Game.Command;
using Dalamud.IoC;
using Dalamud.Plugin;
using System.IO;
using Dalamud.Interface.Windowing;
using Dalamud.Plugin.Services;
using LazySusan.Windows;
using ECommons;
using ECommons.DalamudServices;
using ECommons.Configuration;
using System;
using ECommons.Commands;
using LazySusan.Controllers;

namespace LazySusan
{
    public sealed class LazySusan : IDalamudPlugin
    {
        public string Name => "LazySusan";
        private const string CommandName = "/psusan";

        #region Static Singleton
        public static WindowSystem WindowSystem;
        public static ConfigWindow ConfigWindow;
        public static DebugWindow DebugWindow;
        public static Configuration Configuration;

        public static EnemyController EnemyController;

        #endregion

        public LazySusan([RequiredVersion("1.0")] DalamudPluginInterface pluginInterface)
        {
            ECommonsMain.Init(pluginInterface, this);

            Configuration = EzConfig.Init<Configuration>();

            ConfigWindow = new ConfigWindow();
            DebugWindow = new DebugWindow();

            WindowSystem = new WindowSystem("LazySusan");
            WindowSystem.AddWindow(ConfigWindow);
            WindowSystem.AddWindow(DebugWindow);

            EnemyController = new EnemyController();

            Svc.PluginInterface.UiBuilder.OpenConfigUi += ConfigUiRequested;
            Svc.PluginInterface.UiBuilder.Draw += WindowSystem.Draw;
        }

        private void ConfigUiRequested()
        {
            OpenConfigMenu("psusan", "");
        }

        [Cmd("/psusan", "Opens config menu", true, true)]
        internal void OpenConfigMenu(string cmd, string args)
        {
            ConfigWindow.IsOpen = true;
        }

        [Cmd("/susandebug", "Opens debug menu", false, false)]
        internal void OpenDebugWindow(string cmd, string args)
        {
            DebugWindow.IsOpen = true;
        }

        public void Dispose()
        {
            ECommonsMain.Dispose();
        }
    }
}
