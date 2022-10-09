using CrowSquares.Models;

namespace CrowSquares.Levels
{
    public abstract class Level
    {
        public abstract LevelType Type { get; }
        public List<DropItem> InitialLevelCells { get; set; } = new();
        public LevelState State { get; set; }
        public abstract void CheckLevel(List<DropItem> grid);
    }
}
