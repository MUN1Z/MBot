using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

using Kedrah;
using Kedrah.Constants;
using Kedrah.Modules;
using Kedrah.Objects;
using Kedrah.Util;

using Tibia;
using Tibia.Util;
using Tibia.Objects;
using Tibia.Constants;

using MBot.model;
using System.Timers;

namespace MBot
{
    public partial class mBot : Form
    {


        public mBot()
        {
            InitializeComponent();
        }


        private Tibia.Objects.Console console;

        Client cliente;
        Player player;

        private void mBot_Load(object sender, EventArgs e)
        {
            cliente = ClientChooser.ShowBox();
            if (cliente == null || !cliente.LoggedIn)
            {
                MessageBox.Show("Você deve ter pelo menos um cliente aberto e conectado.");
                Application.Exit();
            }
            else
            {
                player = cliente.GetPlayer();
                this.Text = "MBot - " + player.Name + " (" + player.WorldName + ")";
                cliente.Statusbar = "MBot: Injetado com sucesso.";
                console = new Tibia.Objects.Console(cliente);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabSelect.SelectTab(tabBasics);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabSelect.SelectTab(tabHeal);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabSelect.SelectTab(tabMana);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabSelect.SelectTab(tabTrainer);
        }

        private void btnEspiarCima_Click(object sender, EventArgs e)
        {
            cliente.Map.LevelSpyOn(1);
        }

        private void btnEspiarBaixo_Click(object sender, EventArgs e)
        {
            cliente.Map.LevelSpyOn(-1);
        }

        private void btnEspiarClear_Click(object sender, EventArgs e)
        {
            cliente.Map.LevelSpyOff();
        }

        private void gbBasicf_Enter(object sender, EventArgs e)
        {

        }

        private void btnAndarCima_Click(object sender, EventArgs e)
        {
            player.Walk(Direction.Up);
        }

        private void btnVirarBaixo_Click(object sender, EventArgs e)
        {
            player.Turn(Direction.Down);
        }

        private void btnEnviarMenssagem_Click(object sender, EventArgs e)
        {
            Basico.getEnviarMenssagem(cliente, "Exura");
        }

        private void btnComerCarne_Click(object sender, EventArgs e)
        {
            Basico.getComerQueijo(cliente);
        }

        private void btnMudarOutfit_Click(object sender, EventArgs e)
        {
            Basico.getMudarOutfitWizard(player);
        }

        private void btnOutfitDeamon_Click(object sender, EventArgs e)
        {
            Basico.getMudarOutfitDemon(player);
        }

        private void chkLuzTotal_CheckedChanged(object sender, EventArgs e)
        {
            Basico.getLuzTotal(cliente, chkLuzTotal);
        }

        private void chkRaioX_CheckedChanged(object sender, EventArgs e)
        {
            Basico.getEspionarNome(cliente, chkRaioX);
        }

        private void chkEsconderArvores_CheckedChanged(object sender, EventArgs e)
        {
            Basico.getEsconderArvores(cliente, chkEsconderArvores);
        }

        private void chkAfk_CheckedChanged_1(object sender, EventArgs e)
        {
           
             if (chkAfk.Checked == true) {

                 tmrAfk.Start();

            }else{

                tmrAfk.Stop();

             }

        }

        private void OnTimedEvent(object source, ElapsedEventArgs e){
            player.Turn(Direction.Right);
            player.Turn(Direction.Down);
            player.Turn(Direction.Left);
            player.Turn(Direction.Up);
        }

        private void btnBlackSkull_Click(object sender, EventArgs e)
        {
            Basico.getBlackSkull(player);
        }

        private void tmrExura_Tick(object sender, EventArgs e)
        {
            Cura.getExura(cliente);
        }

        private void btnAutoExuraOn_Click(object sender, EventArgs e)
        {
            tmrExura.Start();
        }

        private void btnAutoExuraOff_Click(object sender, EventArgs e)
        {
            tmrExura.Stop();
        }

        private void tmrAfk_Tick(object sender, EventArgs e)
        {
            Trainer.getAfk(player);
        }

    }
}
