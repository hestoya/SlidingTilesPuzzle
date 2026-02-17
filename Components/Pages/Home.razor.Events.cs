using Microsoft.JSInterop;

namespace SlidingTilesPuzzle.Components.Pages
{
    public partial class Home
    {
        async Task ToggleSound()
        {
            if (isSoundPlaying)
            {
                await JsRuntime.InvokeVoidAsync("stopHomeLoopSound");
            }
            else
            {
                await JsRuntime.InvokeVoidAsync("playHomeLoopSound");
            }

            isSoundPlaying = !isSoundPlaying;
        }

        async Task Start()
        {
            await JsRuntime.InvokeVoidAsync("stopHomeLoopSound");
            await JsRuntime.InvokeVoidAsync("playStartButtonSound");
            Nav.NavigateTo("/puzzle");
        }
    }
}
