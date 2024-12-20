using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SlotMachine.Models
{
    public class Reel
    {
        private readonly PictureBox pictureBox;
        private readonly Dictionary<Image, string> symbols;
        private readonly Random random = new Random();
        public string Symbol { get; private set; }

        public Reel(PictureBox pictureBox, Theme theme)
        {
            this.pictureBox = pictureBox;
            this.symbols = theme.Symbols;

            var randomIndex = random.Next(symbols.Count);
            var imageEntry = symbols.ElementAt(randomIndex);

            this.pictureBox.Image = imageEntry.Key; 
            this.Symbol = imageEntry.Value;
        }

        public void Spin()
        {
            var randomIndex = random.Next(symbols.Count);
            var imageEntry = symbols.ElementAt(randomIndex);

            pictureBox.Image = imageEntry.Key; 
            Symbol = imageEntry.Value; 
        }
    }
}
