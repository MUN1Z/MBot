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
    

    class Cura
    {

        /// <summary>
        /// Método responsável por ficar falando exura.<para/>
        /// Recebe como argumento um cliente.
        /// </summary>
        public static void getExura(Client cliente)
        {
            cliente.Console.Say("Exura");
        }
       

    }

}
