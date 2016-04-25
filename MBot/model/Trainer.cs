using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kedrah;
using Kedrah.Constants;
using Kedrah.Modules;
using Kedrah.Objects;
using Kedrah.Util;

using Tibia;
using Tibia.Util;
using Tibia.Objects;
using Tibia.Constants;

namespace MBot.model
{
    class Trainer
    {
        /// <summary>
        /// Método responsável por permitir que o player fike AFK.<para/>
        /// Recebe como argumento um Player.
        /// </summary>
        public static void getAfk(Player player)
        {
            player.Turn(Direction.Up);
            player.Turn(Direction.Right);
            player.Turn(Direction.Down);
            player.Turn(Direction.Left);
        }
    }
}
