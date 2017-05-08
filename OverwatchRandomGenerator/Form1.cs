using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OverwatchRandomGenerator
{
    public partial class Form1 : Form
    {
        List<Player> players = new List<Player>();
        HeroFactory factory;
        Random random;
        int groupSize;
        List<TextBox> playerTextBoxes = new List<TextBox>();
        List<Label> playerHeroLabels = new List<Label>();

        public Form1()
        {
            InitializeComponent();

            players.Add(new Player(p1Name.Text));
            players.Add(new Player(p2Name.Text));
            players.Add(new Player(p3Name.Text));
            players.Add(new Player(p4Name.Text));
            players.Add(new Player(p5Name.Text));
            players.Add(new Player(p6Name.Text));

            playerTextBoxes.Add(p1Name);
            playerTextBoxes.Add(p2Name);
            playerTextBoxes.Add(p3Name);
            playerTextBoxes.Add(p4Name);
            playerTextBoxes.Add(p5Name);
            playerTextBoxes.Add(p6Name);

            playerHeroLabels.Add(p1Hero);
            playerHeroLabels.Add(p2Hero);
            playerHeroLabels.Add(p3Hero);
            playerHeroLabels.Add(p4Hero);
            playerHeroLabels.Add(p5Hero);
            playerHeroLabels.Add(p6Hero);

            random = new Random();
            groupSize = (int)groupSizeBox.Value;
            factory = new HeroFactory(players, groupSize, random);

            randomizeButton.Enabled = false;

            for (int i = 0; i < 6; i++)
            {
                playerTextBoxes[i].Enabled = false;
                playerHeroLabels[i].Enabled = false;
            }
        }

        private void UpdateHeroes()
        {
            for (int i = 0; i < groupSize; i++)
            {
                playerHeroLabels[i].Text = players[i].MyHero.ToString();
            }
        }

        private void sizeButton_Click(object sender, EventArgs e)
        {
            // update groupSize value for both form and factory
            this.groupSize = (int)groupSizeBox.Value;
            factory.UpdateSize(this.groupSize);

            // enable randomize button if disabled
            if (randomizeButton.Enabled == false)
                randomizeButton.Enabled = true;

            // enable amount of playerBoxes/Labels equal to groupSize, disable remaining and reset MyHero and heroLabel
            for (int i = 0; i < 6; i++)
            {
                if (i+1 > this.groupSize)
                {
                    playerTextBoxes[i].Enabled = false;
                    playerHeroLabels[i].Enabled = false;
                    playerHeroLabels[i].Text = "?";
                    players[i].SetHero(Hero.None);
                }

                else
                {
                    if (playerTextBoxes[i].Enabled == false || playerHeroLabels[i].Enabled == false)
                    {
                        playerTextBoxes[i].Enabled = true;
                        playerHeroLabels[i].Enabled = true;
                    }
                }
            }
        }

        private void randomizeButton_Click(object sender, EventArgs e)
        {
            factory.GenerateTeam();
            UpdateHeroes();
        }

        private void p1Name_TextChanged(object sender, EventArgs e)
        {
            players[0].SetName(p1Name.Text);
        }

        private void p2Name_TextChanged(object sender, EventArgs e)
        {
            players[1].SetName(p2Name.Text);
        }

        private void p3Name_TextChanged(object sender, EventArgs e)
        {
            players[2].SetName(p3Name.Text);
        }

        private void p4Name_TextChanged(object sender, EventArgs e)
        {
            players[3].SetName(p4Name.Text);
        }

        private void p5Name_TextChanged(object sender, EventArgs e)
        {
            players[4].SetName(p5Name.Text);
        }

        private void p6Name_TextChanged(object sender, EventArgs e)
        {
            players[5].SetName(p6Name.Text);
        }
    }
}
