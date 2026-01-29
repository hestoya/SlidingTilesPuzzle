namespace SlidingTilesPuzzle.Services
{
    public class ImageService
    {
        public string GenerateImageUrl()
        {
            return $"https://source.unsplash.com/600x600/?aesthetic&sig={Guid.NewGuid()}";
        }
    }
}
