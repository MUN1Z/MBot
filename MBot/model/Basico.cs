using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tibia;
using Tibia.Objects;


namespace MBot.model
{
    class Basico
    {

        /// <summary>
        /// Método responsável por habilitar a espionagem de nomes dos levels inferiores do mapa.<para/>
        /// Recebe como argumento um Client e um CheckBox.
        /// </summary>
        public static void getEspionarNome(Client c, CheckBox check) {
            if (check.Checked == true)
            {
                c.Map.NameSpyOn();
            }
            else
            {
                c.Map.NameSpyOff();
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

    }
}
