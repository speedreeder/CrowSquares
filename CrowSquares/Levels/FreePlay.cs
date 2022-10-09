using CrowSquares.Extensions;
using CrowSquares.Models;

namespace CrowSquares.Levels
{
    public class FreePlay : Level
    {
        public override LevelType Type => LevelType.FreePlay;

        public FreePlay()
        {
            State = LevelState.Ongoing;
        }

        public override void CheckLevel(List<DropItem> grid)
        {
            var gridItems = grid.Where(i => i.Zone.Contains("gutter")).ToList();
            grid.ItemsFitInList(gridItems);

            if (gridItems.All(g => !g.FitsInGrid))
            {
                State = LevelState.Failed;
            }
        }
    }
}
