using Microsoft.JSInterop;

namespace SlidingTilesPuzzle.Components.Puzzle
{
    public partial class WinOverlay
    {
        protected override async Task OnParametersSetAsync()
        {
            if (Visible && JsRuntime != null)
            {
                await JsRuntime.InvokeVoidAsync("launchConfetti");
                await JsRuntime.InvokeVoidAsync("playWinSound");
            }
        }
    }
}
