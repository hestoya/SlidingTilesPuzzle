namespace SlidingTilesPuzzle.Components.Pages
{
    public partial class Puzzle
    {
        protected override void OnInitialized()
        {
            StartPuzzle();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender && isInitialized && isSoundPlaying)
            {
                await PlayGameLoopSound();
            }
        }
    }
}
