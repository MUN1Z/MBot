using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Kedrah;
using Kedrah.Constants;
using Kedrah.Modules;
using Kedrah.Objects;
using Kedrah.Util;

using Tibia;
using Tibia.Util;
using Tibia.Objects;
using Tibia.Constants;
using System.Timers;


namespace MBot.model
{
    class Basico
    {
        /// <summary>
        /// Método responsável por fazer o player falar uma menssagem no cliente.<para/>
        /// Recebe como argumento um Client e uma String.
        /// </summary>
        public static void getEnviarMenssagem(Client cliente, String menssagem)
        {
            cliente.Console.Say(menssagem);
        }

        /// <summary>
        /// Método responsável por mudar fazer o player comer um cheese do inventário.<para/>
        /// Recebe como argumento um Client.
        /// </summary>
        public static void getComerQueijo(Client cliente)
        {
            cliente.Inventory.UseItem(Items.Food.Cheese.Id);
        }

        /// <summary>
        /// Método responsável por mudar a outfit do player para um Demon.<para/>
        /// Recebe como argumento um Player.
        /// </summary>
        public static void getMudarOutfitDemon(Player player)
        {
            player.OutfitType = OutfitType.Demon;
        }

        /// <summary>
        /// Método responsável por mudar a outfit do player para um Wizard.<para/>
        /// Recebe como argumento um Player.
        /// </summary>
        public static void getMudarOutfitWizard(Player player)
        {
            player.OutfitType = OutfitType.WizardMale;
        }

        /// <summary>
        /// Método responsável por habilitar a espionagem de nomes dos levels inferiores do mapa.<para/>
        /// Recebe como argumento um Client e um CheckBox.
        /// </summary>
        public static void getEspionarNome(Client cliente, CheckBox check)
        {
            if (check.Checked == true)
            {
                cliente.Map.NameSpyOn();
            }
            else
            {
                cliente.Map.NameSpyOff();
            }
        }

        /// <summary>
        /// Método responsável por habilitar e desabilitar a luz total do cliente.<para/>
        /// Recebe como argumento um Client e um CheckBox.
        /// </summary>
        public static void getLuzTotal(Client cliente, CheckBox check){
            if (check.Checked == true)
            {
                cliente.Map.FullLightOn();
            }
            else
            {
                cliente.Map.FullLightOff();
            }
        }

        /// <summary>
        /// Método responsável por esconder as arvores do mapa.<para/>
        /// Recebe como argumento um Client e um CheckBox.
        /// </summary>
        public static void getEsconderArvores(Client cliente, CheckBox check)
        {
            if (check.Checked == true)
            {
                cliente.Map.ReplaceTrees();
            }
        }

        /// <summary>
        /// Método responsável por não deixar que o player seja deslogado quando ficar AFK.<para/>
        /// Recebe como argumento um Player e um CheckBox.
        /// </summary>
        public static void getAfk(Player player, CheckBox check)
        {

        }
 
    }
}
