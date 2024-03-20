using Dalamud.Game.ClientState.Objects.Types;
using ECommons.Automation;
using ECommons.DalamudServices;
using ECommons.GameFunctions;
using LazySusan.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazySusan.Controllers
{
    public class EnemyController
    {
        public TaskManager TaskManager;
        public EnemyController() 
        {
            TaskManager = new TaskManager();
            Svc.Framework.Update += Framework_Update;
        }

        private void Framework_Update(Dalamud.Plugin.Services.IFramework framework)
        {
            AllTargets = Svc.Objects.Where(o => o.DistanceToPlayer() <= 30);
            EnemyTargets = AllTargets.Where(o => o.IsHostile());
        }

        public IEnumerable<GameObject> AllTargets { get; set; } = new List<GameObject>();
        public IEnumerable<GameObject> EnemyTargets { get; set; } = new List<GameObject>();
    }
}
