using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceGameApp
{
    public partial class GameScreen : Form
    {
        Zeep[] zeeps = new Zeep[4];
        Punter[] players = new Punter[3];
        Zeep winnerZeep;
        Timer[] timers = new Timer[4];

        public GameScreen()
        {
            InitializeComponent();
            InitializeGameSettings();
        }

        private void InitializeGameSettings()
        {
            // Zeep Details
            zeeps[0] = new Zeep() { ZeepName = "Zeep 1", FinishPoint = 40, MyPictureBox = picZeep1 };
            zeeps[1] = new Zeep() { ZeepName = "Zeep 2", FinishPoint = 40, MyPictureBox = picZeep2 };
            zeeps[2] = new Zeep() { ZeepName = "Zeep 3", FinishPoint = 40, MyPictureBox = picZeep3 };
            zeeps[3] = new Zeep() { ZeepName = "Zeep 4", FinishPoint = 40, MyPictureBox = picZeep4 };

            // Player Details
            players[0] = PunterFactory.GetPunter(1);
            players[1] = PunterFactory.GetPunter(2);
            players[2] = PunterFactory.GetPunter(3);

            players[0].MyRadioButton = radioPunter1;
            players[0].MyText = textPunter1;
            players[0].MyRadioButton.Text = players[0].Name;


            players[1].MyRadioButton = radioPunter2;
            players[1].MyText = textPunter2;
            players[1].MyRadioButton.Text = players[1].Name;


            players[2].MyRadioButton = radioPunter3;
            players[2].MyText = textPunter3;
            players[2].MyRadioButton.Text = players[2].Name;

            
        }


        private void btnAction_Click(object sender, EventArgs e)
        {
            if (btnAction.Text.Contains("Place"))
            {
                int count = 0;
                int total_active = 0;
                foreach (Punter player in players)
                {
                    if (!player.Busted)
                    {
                        total_active++;
                        if (player.MyRadioButton.Checked)
                        {
                            if (player.MyBet == null)
                            {
                                int number = (int)numericDogNumber.Value;
                                int amount = (int)numericBetAmount.Value;
                                bool alreadyPlaced = false;
                                foreach (Punter pla in players)
                                {
                                    if (pla.MyBet != null && pla.MyBet.Zeep == zeeps[number - 1])
                                    {
                                        alreadyPlaced = true;
                                        break;
                                    }
                                }
                                if (alreadyPlaced)
                                {
                                    MessageBox.Show("This Zeep is Already Taken...");
                                }
                                else
                                {
                                    player.MyBet = new Bet() { Amount = amount, Zeep = zeeps[number - 1] };
                                }

                            }
                            else
                            {
                                MessageBox.Show("You Already Place Bet for " + player.Name);
                            }
                        }
                        if (player.MyBet != null)
                        {
                            count++;
                        }
                    }
                }
                SetDetails();
                if (count == total_active)
                {
                    btnAction.Text = "Begin The Race";
                    panelControls.Enabled = false;
                }
            }
            else if (btnAction.Text.Contains("Begin"))
            {
                for (int index = 0; index < timers.Length; index++)
                {
                    timers[index] = new Timer();
                    timers[index].Interval = 15;
                    timers[index].Tick += Timer_Tick;
                }
                for (int index = 0; index < timers.Length; index++)
                {
                    timers[index].Start();
                }
            }
            else if (btnAction.Text.Contains("End"))
            {
                MessageBox.Show("Game Over!!!");
                Application.Exit();
            }
        }

        private void Timer_Tick(object sender, EventArgs args)
        {
            if (sender is Timer)
            {
                int index = -1;
                Timer timer = sender as Timer;
                for( int i = 0; i < timers.Length; i++)
                {
                    if( timer == timers[i])
                    {
                        index = i;
                        break;
                    }
                }
                if (index != -1)
                {
                    PictureBox picture = zeeps[index].MyPictureBox;
                    if (picture.Location.X < zeeps[index].FinishPoint)
                    {
                        if (winnerZeep == null)
                        {
                            winnerZeep = zeeps[index];
                        }
                        for(int i = 0; i < timers.Length; i++)
                        {
                            timers[i].Stop();
                        }
                    }
                    else
                    {
                        int jump = new Random().Next(1, 15);
                        picture.Location = new Point(picture.Location.X - jump, picture.Location.Y);
                    }
                }
            }
            if (winnerZeep != null)
            {
                MessageBox.Show(winnerZeep.ZeepName + " is Won The Race!!!");
                SetDetails();
                foreach (Punter player in players)
                {
                    if (player.MyBet != null)
                    {
                        if (player.MyBet.Zeep == winnerZeep)
                        {
                            player.Cash += player.MyBet.Amount;
                            player.MyText.Text = player.Name + " Won and now has $" + player.Cash;                            
                        }
                        else
                        {
                            player.Cash -= player.MyBet.Amount;
                            if (player.Cash == 0)
                            {
                                player.MyText.Text = "BUSTED";
                                player.Busted = true;
                                player.MyRadioButton.Enabled = false;
                                player.MyRadioButton.Checked = false;
                                CheckBustedStatus();
                            }
                            else
                            {
                                player.MyText.Text = player.Name + " Lost and now has $" + player.Cash;
                            }
                        }
                    }
                }
                winnerZeep = null;
                for(int i =0; i < timers.Length; i++)
                {
                    timers[i] = null;
                }
                int count = 0;
                foreach (Punter player in players)
                {
                    if (player.Busted)
                    {
                        count++;
                    }
                    if (player.MyRadioButton.Enabled && player.MyRadioButton.Checked)
                    {
                        labelMaxBet.Text = player.Name + " Max Bet is $" + player.Cash;
                        numericBetAmount.Maximum = player.Cash;
                        numericBetAmount.Minimum = 1;
                    }
                    player.MyBet = null;                    
                }
                if (count == players.Length)
                {
                    btnAction.Text = "End Game";
                }
                else
                {
                    panelControls.Enabled = true;
                }
                foreach (Zeep zeep in zeeps)
                {
                    zeep.MyPictureBox.Location = new Point(810, zeep.MyPictureBox.Location.Y);
                }
                CheckBustedStatus();
            }
        }

        private void CheckBustedStatus()
        {
            int count = 0;
            foreach (Punter player in players)
            {
                if (player.Busted)
                {
                    count++;
                }
            }
            if (count == players.Length)
            {
                btnAction.Text = "End Game";
            }
            else
            {
                foreach (Punter player in players)
                {
                    if (!player.Busted)
                    {
                        player.MyRadioButton.Checked = true;
                        break;
                    }
                }
                panelControls.Enabled = true;
            }
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            SetDetails();
        }

        private void SetDetails()
        {
            foreach (Punter player in players)
            {
                if (player.Busted)
                {
                    player.MyText.Text = "BUSTED";
                }
                else
                {
                    if (player.MyBet == null)
                    {
                        player.MyText.Text = player.Name + " hasn't placed a bet";
                    }
                    else
                    {
                        player.MyText.Text = player.Name + " bets $" + player.MyBet.Amount + " on " + player.MyBet.Zeep.ZeepName;
                    }
                    if (player.MyRadioButton.Checked)
                    {
                        labelMaxBet.Text = player.Name + " Max Bet Amount is $" + player.Cash.ToString();
                        btnAction.Text = "Place Bet for " + player.Name;
                        labelBet.Text = player.Name + " Bet Amount is $";
                        labelBetDog.Text = player.Name + " Bet on Zeep No";
                        numericBetAmount.Maximum = player.Cash;
                        numericBetAmount.Value = 1;
                    }
                }
            }
        }

        private void GameScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
