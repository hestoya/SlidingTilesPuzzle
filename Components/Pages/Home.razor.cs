using Microsoft.JSInterop;

namespace SlidingTilesPuzzle.Components.Pages
{
    public partial class Home
    {
        private bool isSoundPlaying = false;
        private string soundIcon => isSoundPlaying ? "bi-volume-up cursor-pointer" : "bi-volume-mute cursor-pointer";
    }
}
