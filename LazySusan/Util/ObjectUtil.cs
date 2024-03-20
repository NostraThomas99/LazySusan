using Dalamud.Game.ClientState.Objects.Types;
using ECommons.GameHelpers;
using FFXIVClientStructs.FFXIV.Common.Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazySusan.Util
{
    public static class ObjectUtil
    {
        public static float DistanceToPlayer(this GameObject obj)
        {
            if (obj == null) return float.MaxValue;
            var player = Player.Object;
            if (player == null) return float.MaxValue;

            var distance = Vector3.Distance(player.Position, obj.Position) - player.HitboxRadius;
            distance -= obj.HitboxRadius;
            return distance;
        }
    }
}
