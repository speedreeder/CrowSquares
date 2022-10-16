using CrowSquares.Extensions;
using CrowSquares.Models;

namespace CrowSquares.Levels
{
    public abstract class Level
    {
        public abstract LevelType Type { get; }
        public List<DropItem> InitialLevelCells { get; set; } = new();
        public LevelState State { get; set; }
        public List<LevelGoal> Goals { get; set; }
        public List<DropItem> Grid { get; set; }
        public string Name { get; set; }

        public virtual void CheckLevel()
        {
            var gutterItems = Grid.Where(i => i.Zone.Contains("gutter")).ToList();
            Grid.ItemsFitInList(gutterItems);

            if (gutterItems.All(g => !g.FitsInGrid))
            {
                State = LevelState.Failed;
            }

            if (Goals.All(g => g.Current == g.Goal))
            {
                State = LevelState.Complete;
            }
        }
    }
}
