using System.Windows.Forms;

namespace SlotMachine.Models
{
    public class Slot
    {
        private int balance;
        private int stake;
        private readonly Reel[] reels;

        public Slot(int initialBalance, Reel[] reels)
        {
            this.balance = initialBalance;
            this.reels = reels;
        }

        public int Balance
        {
            get => balance;
            set => balance = value;
        }

        public int Stake
        {
            get => stake;
            set => stake = value;
        }

        public void Spin()
        {
            foreach (var reel in reels)
            {
                reel.Spin();
            }
        }

        public int CheckResult()
        {
            int winnings = 0;

            if (reels[0].Symbol == reels[1].Symbol && reels[1].Symbol == reels[2].Symbol)
            {
                winnings = stake * 10;
            }
            else if (reels[0].Symbol == reels[1].Symbol || reels[1].Symbol == reels[2].Symbol || reels[0].Symbol == reels[2].Symbol)
            {
                winnings = stake * 2;
            }

            return winnings;
        }


        public void UpdateBalance(int winnings)
        {
            Balance += winnings;
        }
    }
}
