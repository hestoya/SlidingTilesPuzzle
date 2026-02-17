using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace SlidingTilesPuzzle.Components.Puzzle
{
    public partial class WinOverlay
    {
        [Parameter] public bool Visible { get; set; }
        [Parameter] public int Moves { get; set; }
        [Parameter] public EventCallback OnRetry { get; set; }
        [Parameter] public EventCallback OnNew { get; set; }

        private string Performance => Moves switch
        {
            <= 22 => "You are an absolute legend. Way to go, champ!",
            <= 30 => "Insane moves! That was clean!",
            <= 40 => "Solid play! You got skills!",
            <= 55 => "Nicely done! You stayed in control.",
            <= 75 => "Hey, a win is a win!",
            _ => "You fought bravely… and you won."
        };
    }
}
