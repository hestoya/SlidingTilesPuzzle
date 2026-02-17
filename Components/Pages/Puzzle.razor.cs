using Microsoft.JSInterop;
using SlidingTilesPuzzle.Models;

namespace SlidingTilesPuzzle.Components.Pages
{
    public partial class Puzzle
    {
        List<Tile> Tiles = [];
        string ImageUrl = "";
        int Moves;
        bool IsSolved; 
        bool isInitialized = false;
        private bool isSoundPlaying = true;
        private string soundIcon => isSoundPlaying ? "bi-volume-up cursor-pointer" : "bi-volume-mute cursor-pointer";
    }
}
