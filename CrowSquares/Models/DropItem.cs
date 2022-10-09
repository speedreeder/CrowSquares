using CrowSquares.Extensions;
using MudBlazor;

namespace CrowSquares.Models
{
    public class DropItem
    {
        public string Icon { get; init; }
        public Color Color { get; init; }
        public string Zone { get; set; }
        public List<(int Row, int Column)> Points { get; set; }
        public bool FitsInGrid { get; set; }
        public bool IsLocked { get; set; }

        public bool CheckFitsInGrid(List<DropItem> gridItems)
        {
            for (var row = 0; row < 9; row++)
            {
                for (var column = 0; column < 9; column++)
                {
                    var selectedZone = $"{row}{column}";

                    var pointsNotOccupiedOrOutside = Points
                        .Select(p => selectedZone.ToPointsTuple(p.Row, p.Column))
                        .All(transformedTuple =>
                        {
                            var pointNotOccupied =
                                gridItems.FirstOrDefault(g => g.Zone == transformedTuple.ToPointsString()) == null;

                            return transformedTuple.Column is < 8 and >= 0 &&
                                   transformedTuple.Row is < 8 and >= 0 &&
                                   pointNotOccupied;
                        });

                    if (pointsNotOccupiedOrOutside) return true;
                }
            }

            return false;
        }
    }
}
