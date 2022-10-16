using CrowSquares.Extensions;
using CrowSquares.Models;
using MudBlazor;

namespace CrowSquares.Levels
{
    public class FreePlay : Level
    {
        public override LevelType Type => LevelType.FreePlay;

        public FreePlay(List<DropItem> grid)
        {
            Grid = grid;
            Name = "Free Play";
            State = LevelState.Ongoing;
            Goals = new List<LevelGoal>
            {
                new()
                {
                    Current = 0,
                    GoalText = "Points",
                    Icon = Icons.Material.Filled.Scoreboard
                }
            };
        }
    }
}
