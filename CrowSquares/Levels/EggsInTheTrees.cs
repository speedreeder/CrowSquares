using CrowSquares.Extensions;
using CrowSquares.Models;
using MudBlazor;

namespace CrowSquares.Levels
{
    public class EggsInTheTrees : Level
    {
        public override LevelType Type => LevelType.EggsInTheTrees;

        public EggsInTheTrees(List<DropItem> grid)
        {
            Grid = grid;
            Name = "Eggs In The Trees";
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
            Goals = new List<LevelGoal>
            {
                new ()
                {
                    Current = 0,
                    Goal = 5,
                    GoalText = "Eggs",
                    Icon = Icons.Material.Filled.Forest,
                    IconColor = Color.Success
                }
            };
        }
    }
}
