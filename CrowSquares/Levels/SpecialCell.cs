using MudBlazor;

namespace CrowSquares.Levels
{
    public class LevelGoal
    {
        public string Icon { get; set; }
        public Color IconColor { get; set; }
        public int? Goal { get; set; }
        public int Current { get; set; }
        public string GoalText { get; set; }
    }
}
