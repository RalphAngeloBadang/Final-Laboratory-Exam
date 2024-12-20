using System;
using System.Drawing;
using System.Windows.Forms;
using SlotMachine.Models;

namespace SlotMachine
{
    public partial class Form1 : Form
    {
        private Slot slotMachine;
        private Theme currentTheme;
        private int spinCounter;
        private const int maxSpins = 20;
        private string placeholderText = "Enter your stake here";

        public Form1()
        {
            InitializeComponent();
            LoadTheme(new CardsTheme());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtStake.Text = placeholderText;
            txtStake.ForeColor = Color.Gray;
        }

        private void LoadTheme(Theme theme)
        {
            currentTheme = theme;

            PictureBox[] pictureBoxes = { pictureBox1, pictureBox2, pictureBox3 };

            foreach (var pictureBox in pictureBoxes)
            {
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            Reel[] reels = new Reel[pictureBoxes.Length];
            for (int i = 0; i < pictureBoxes.Length; i++)
            {
                reels[i] = new Reel(pictureBoxes[i], theme);
            }

            slotMachine = new Slot(1000, reels);

            this.BackColor = theme.BackgroundColor;
        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtStake.Text, out int stake) && stake > 0 && stake <= slotMachine.Balance)
            {
                slotMachine.Stake = stake;
                slotMachine.UpdateBalance(-stake);
                lblBalance.Text = "Balance: P" + slotMachine.Balance;

                btnSpin.Enabled = false;
                lblResult.Text = "";

                spinCounter = 0;
                timerSpin.Start();
            }
            else
            {
                MessageBox.Show("Please enter a valid stake amount (between 1 and your balance).");
            }
        }

        private void timerSpin_Tick(object sender, EventArgs e)
        {
            slotMachine.Spin();

            spinCounter++;

            if (spinCounter >= maxSpins) 
            {
                timerSpin.Stop();
                btnSpin.Enabled = true;

                int winnings = slotMachine.CheckResult();

                slotMachine.UpdateBalance(winnings);

                if (winnings > 0)
                {
                    lblResult.Text = $"🎉 WIN! You earned P{winnings} 🎉";
                    lblResult.ForeColor = Color.Green;
                }
                else
                {
                    lblResult.Text = "No luck this time!";
                    lblResult.ForeColor = Color.Red;
                }

                lblBalance.Text = "Balance: P" + slotMachine.Balance;
            }
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            LoadTheme(currentTheme is CardsTheme ? new SweetBonanzaTheme() : new CardsTheme());
        }

        private void txtStake_Enter(object sender, EventArgs e)
        {
            if (txtStake.Text == placeholderText)  
            {
                txtStake.Text = ""; 
                txtStake.ForeColor = Color.Black;
            }
        }

        private void txtStake_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStake.Text)) 
            {
                txtStake.Text = placeholderText; 
                txtStake.ForeColor = Color.Gray; 
            }
        }
    }
}
