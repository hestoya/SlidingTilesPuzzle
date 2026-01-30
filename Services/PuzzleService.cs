using SlidingTilesPuzzle.Models;

namespace SlidingTilesPuzzle.Services
{
    public class PuzzleService
    {
        public const int Size = 3;

        public List<Tile> CreateTiles()
        {
            return Enumerable.Range(0, 9)
                .Select(i => new Tile
                {
                    Index = i,
                    CurrentIndex = i,
                    IsEmpty = i == 8
                })
                .ToList();
        }

        public void ShuffleSolvable(List<Tile> tiles)
        {
            var rnd = new Random();
            int[] positions;

            do
            {
                positions = Enumerable.Range(0, 8)
                    .OrderBy(_ => rnd.Next())
                    .ToArray();
            }
            while (!IsSolvable(positions));

            for (int i = 0; i < 8; i++)
                tiles[i].CurrentIndex = positions[i];

            tiles.First(t => t.IsEmpty).CurrentIndex = 8;
        }

        public bool CanMove(Tile tile, Tile empty)
        {
            int ax = tile.CurrentIndex % 3, ay = tile.CurrentIndex / 3;
            int bx = empty.CurrentIndex % 3, by = empty.CurrentIndex / 3;
            return Math.Abs(ax - bx) + Math.Abs(ay - by) == 1;
        }

        public bool IsSolved(List<Tile> tiles) =>
            tiles.All(t => t.Index == t.CurrentIndex);

        bool IsSolvable(int[] p)
        {
            int inversions = 0;

            for (int i = 0; i < p.Length; i++)
                for (int j = i + 1; j < p.Length; j++)
                    if (p[i] != 8 && p[j] != 8 && p[i] > p[j])
                        inversions++;

            return inversions % 2 == 0;
        }
    }
}
