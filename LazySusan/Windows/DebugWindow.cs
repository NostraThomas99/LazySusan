using Dalamud.Interface.Windowing;
using ImGuiNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
namespace LazySusan.Windows
{
    public class DebugWindow : Window, IDisposable
    {
        public DebugWindow() : base("LazySusan Debug",
            ImGuiWindowFlags.NoCollapse)
        {
            this.Size = new Vector2(500, 200);
            this.SizeCondition = ImGuiCond.FirstUseEver;
        }

        public void Dispose()
        {

        }

        public override void Draw()
        {
            var currentTargets = LazySusan.EnemyController.AllTargets;
            foreach (var target in currentTargets)
            {
                ImGui.Text(target.Name.ToString());
                ImGui.SameLine();
                ImGui.Text(target.ObjectId.ToString());
            }
        }
    }
}
