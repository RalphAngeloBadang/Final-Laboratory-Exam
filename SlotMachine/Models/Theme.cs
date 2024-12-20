using System.Drawing;
using System.Collections.Generic;

namespace SlotMachine.Models
{
    public abstract class Theme
    {
        public abstract Dictionary<Image, string> Symbols { get; }
        public abstract Font SymbolFont { get; }
        public abstract Color BackgroundColor { get; }
    }

    public class CardsTheme : Theme
    {
        public override Dictionary<Image, string> Symbols => new Dictionary<Image, string>
        {
            { Properties.Resources.club, "club" },
            { Properties.Resources.diamond, "diamond" },
            { Properties.Resources.heart, "heart" },
            { Properties.Resources.spade, "spade" }
        };

        public override Font SymbolFont => new Font("Segoe UI", 24, FontStyle.Bold);
        public override Color BackgroundColor => Color.LightGreen;
    }

    public class SweetBonanzaTheme : Theme
    {
        public override Dictionary<Image, string> Symbols => new Dictionary<Image, string>
        {
            { Properties.Resources.sbcandy, "candy" },
            { Properties.Resources.sbgreen, "green" },
            { Properties.Resources.sbheart, "heart" },
            { Properties.Resources.sbpurple, "purple" }
        };

        public override Font SymbolFont => new Font("Segoe UI", 24, FontStyle.Bold);
        public override Color BackgroundColor => Color.LightYellow;
    }
}
