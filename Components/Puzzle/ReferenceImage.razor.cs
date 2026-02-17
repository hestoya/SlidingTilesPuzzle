using Microsoft.AspNetCore.Components;

namespace SlidingTilesPuzzle.Components.Puzzle
{
    public partial class ReferenceImage
    {
        [Parameter] public string ImageUrl { get; set; } = "https://picsum.photos/1000/1000";
    }
}
