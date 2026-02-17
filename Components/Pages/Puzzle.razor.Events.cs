using Microsoft.JSInterop;
using SlidingTilesPuzzle.Models;

namespace SlidingTilesPuzzle.Components.Pages
{
    public partial class Puzzle
    {
        async Task NewGame()
        {
            Navigation.NavigateTo(Navigation.Uri, forceLoad: true);
            await PlayClickButtonSound();
        }

        void StartPuzzle()
        {
            ImageUrl = Images.GenerateImageUrl();
            Tiles = Puzzles.CreateTiles();
            Puzzles.ShuffleSolvable(Tiles);
            Moves = 0;
            IsSolved = false;
            isInitialized = true;
        }

        void ResetGame()
        {
            Puzzles.ShuffleSolvable(Tiles);
            Moves = 0;
            IsSolved = false;
        }

        async Task Reshuffle()
        {
            ResetGame();
            await PlayClickButtonSound();
        }

        async Task Restart()
        {
            ResetGame();
            await PlayGameLoopSound();
        }

        async Task MoveTile(Tile tile)
        {
            var empty = Tiles.First(t => t.IsEmpty);
            if (!Puzzles.CanMove(tile, empty)) return;

            (tile.CurrentIndex, empty.CurrentIndex) =
            (empty.CurrentIndex, tile.CurrentIndex);

            Moves++;
            IsSolved = Puzzles.IsSolved(Tiles);

            await PlayTileMoveSound();

            if (IsSolved)
            {
                await StopGameLoopSound();
                return;
            }
        }

        async Task ToggleSound()
        {
            if (isSoundPlaying)
            {
                await StopGameLoopSound();
            }
            else
            {
                await PlayGameLoopSound();
            }

            isSoundPlaying = !isSoundPlaying;
        }

        private async Task PlayClickButtonSound()
        {
            if (JsRuntime != null)
            {
                await JsRuntime.InvokeVoidAsync("playClickButtonSound");
            }
        }

        private async Task PlayTileMoveSound()
        {
            if (JsRuntime != null)
            {
                await JsRuntime.InvokeVoidAsync("playTileMoveSound");
            }
        }

        private async Task PlayGameLoopSound()
        {
            if (JsRuntime != null)
            {
                await JsRuntime.InvokeVoidAsync("playGameLoopSound");
            }
        }

        private async Task StopGameLoopSound()
        {
            if (JsRuntime != null)
            {
                await JsRuntime.InvokeVoidAsync("stopGameLoopSound");
            }
        }
    }
}
