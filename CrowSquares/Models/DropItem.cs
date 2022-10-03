using MudBlazor;

namespace CrowSquares.Models
{
    public class DropItem
    {
        public string Icon { get; init; }
        public Color Color { get; init; }
        public string Zone { get; set; }
        public List<(int Row, int Column)> Points { get; set; }

        //public bool FitsInGrid(Dictionary<string, MudDropZone<DropItem>> grid)
        //{

        //}
    }
}
