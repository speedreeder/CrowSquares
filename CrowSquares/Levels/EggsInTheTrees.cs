using CrowSquares.Extensions;
using CrowSquares.Models;
using MudBlazor;

namespace CrowSquares.Levels
{
    public class EggsInTheTrees : Level
    {
        public override LevelType Type => LevelType.EggsInTheTrees;

        public EggsInTheTrees()
        {
            State = LevelState.Ongoing;
            InitialLevelCells = new List<DropItem>
            {
                new()
                {
                    Icon = Icons.Material.Filled.Forest,
                    Color = Color.Success,
                    IsLocked = true,
                    Zone = "11"
                },
                new()
                {
                    Icon = Icons.Material.Filled.Forest,
                    Color = Color.Success,
                    IsLocked = true,
                    Zone = "17"
                },
                new()
                {
                    Icon = Icons.Material.Filled.Forest,
                    Color = Color.Success,
                    IsLocked = true,
                    Zone = "71"
                },
                new()
                {
                    Icon = Icons.Material.Filled.Forest,
                    Color = Color.Success,
                    IsLocked = true,
                    Zone = "77"
                }
            };
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
