using CrowSquares.Extensions;
using CrowSquares.Utilities;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace CrowSquares.Pages
{
    public class GameBase :  ComponentBase
    {
        public string RowStyle = "";
        public MudDropContainer<DropItem> DropContainer { get; set; }

        protected List<DropItem> Items = new();

        public class DropItem
        {
            public string Icon { get; init; }
            public Color Color { get; init; }
            public string Zone { get; set; }
            public List<(int Row, int Column)> Points { get; set; }
        }

        protected override void OnInitialized()
        {
            GenerateShapes();
        }

        protected void ItemUpdated(MudItemDropInfo<DropItem> dropItem)
        {
            Items.Remove(dropItem.Item);
            foreach (var points in dropItem.Item.Points)
            {
                Items.Add(new DropItem
                {
                    Zone = dropItem.DropzoneIdentifier.ToPointsTuple(points.Row, points.Column).ToPointsString(),
                    Icon = Icons.Custom.Uncategorized.ChessRook,
                    Color = Color.Primary
                });

            }
        }

        protected bool CanDrop(DropItem item, string identifierOfDropZone)
        {
            if (identifierOfDropZone == "gutter") return false;
            // nothing is in that space being dropped on already
            var cursorSpaceNotOccupied = Items.All(x => identifierOfDropZone != x.Zone);

            // get all the points of all the items
            // none of their zones can be equal to any of the points of the current dropItem
            // none of their points can be outside the bounds of the grid
            var otherPointsNotOccupiedOrOutside =
                Items.Select(i => i.Zone).All(z =>
                    item.Points.All(p =>
                    {
                        var transformedTuple = identifierOfDropZone.ToPointsTuple(p.Row, p.Column);
                        return transformedTuple.ToPointsString() != z &&
                               transformedTuple.Column < 9 &&
                               transformedTuple.Row < 9;
                    }));
            
            return cursorSpaceNotOccupied && otherPointsNotOccupiedOrOutside;
        }

        public void GenerateShapes()
        {
            Items.AddRange(ShapeLibrary.RandomShapes(3).Select(s => new DropItem
            {
                Color = Color.Primary,
                Icon = Icons.Custom.Uncategorized.ChessRook,
                Points = s,
                Zone = "gutter"
            }));
            StateHasChanged();

            if(DropContainer != null)
                DropContainer.Refresh();
        }
    }
}
