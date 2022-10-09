using CrowSquares.Models;

namespace CrowSquares.Extensions
{
    public static class DropItemListExtensions
    {
        public static void ItemsFitInList(this List<DropItem> grid, IEnumerable<DropItem> items)
        {
            foreach (var dropItem in items)
            {
                dropItem.FitsInGrid = dropItem.CheckFitsInGrid(grid.Where(e => !e.Zone.Contains("gutter")).ToList());
            }
        }
    }
}
