using Microsoft.AspNetCore.Components;
using SlidingTilesPuzzle.Models;

namespace SlidingTilesPuzzle.Components.Puzzle
{
    public partial class PuzzleBoard
    {
        [Parameter] public List<Tile> Tiles { get; set; } = new();
        [Parameter] public string ImageUrl { get; set; } = "https://picsum.photos/1000/1000";
        [Parameter] public EventCallback<Tile> OnTileClick { get; set; }

        const int TileSize = 200;
        const int BoardSize = 600;

        string TileStyle(Tile tile)
        {
            if (string.IsNullOrWhiteSpace(ImageUrl))
                return "";

            return $"background-image: url('https://picsum.photos/1000/1000'); " +
                   $"background-size: {BoardSize}px {BoardSize}px; " +
                   $"background-position: {-(tile.Index % 3) * TileSize}px {-(tile.Index / 3) * TileSize}px; " +
                   $"width: {TileSize}px; height: {TileSize}px; " +
                   $"position: absolute; " +
                   $"transform: translate({(tile.CurrentIndex % 3) * TileSize}px, {(tile.CurrentIndex / 3) * TileSize}px);";
        }
    }
}
