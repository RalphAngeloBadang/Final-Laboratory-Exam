using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SlotMachine.Models
{
    public class Reel
    {
        private string symbol;
        private readonly PictureBox pictureBox;
        private readonly Theme theme;
        private readonly Random random = new Random();

        public Reel(PictureBox pictureBox, Theme theme)
        {
            this.pictureBox = pictureBox;
            this.theme = theme;
            this.pictureBox.Paint += Reel_Paint;
            this.Symbol = theme.Symbols[random.Next(theme.Symbols.Length)];
        }

        public string Symbol
        {
            get => symbol;
            set
            {
                symbol = value;
                pictureBox.Invalidate(); // Trigger repaint
            }
        }

        private void Reel_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawString(symbol, theme.Font, theme.Brush, new PointF(10, 10));
        }

        public void Spin()
        {
            Symbol = theme.Symbols[random.Next(theme.Symbols.Length)];
        }
    }
}
