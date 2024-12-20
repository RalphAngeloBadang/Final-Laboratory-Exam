using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine.Models
{
    public abstract class Theme
    {
        public abstract string[] Symbols { get; }
        public abstract Font Font { get; }
        public abstract Brush Brush { get; }
    }

    public class FruitsTheme : Theme
    {
        public override string[] Symbols => new[] { "🍎", "🍌", "🍇", "🍒", "🍍", "🥭" };
        public override Font Font => new Font("Segoe UI Emoji", 30, FontStyle.Bold);
        public override Brush Brush => Brushes.DarkGreen;
    }

    public class AnimalsTheme : Theme
    {
        public override string[] Symbols => new[] { "🐶", "🐱", "🦊", "🐼", "🐸", "🐔" };
        public override Font Font => new Font("Segoe UI Emoji", 30, FontStyle.Italic);
        public override Brush Brush => Brushes.DarkBlue;
    }

}