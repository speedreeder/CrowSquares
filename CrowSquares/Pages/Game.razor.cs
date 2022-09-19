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

        public DropItem CurrentlyDraggingItem { get; set; }

        protected List<DropItem> Items = new();

        protected Dictionary<string, MudDropZone<DropItem>> Grid { get; set; } = new();

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

            if (!Items.Any(i => i.Zone.Contains("gutter", StringComparison.Ordinal)))
            {
                GenerateShapes();
            }

            foreach (var gridSquare in Grid)
            {
                gridSquare.Value.Class =
                    "d-flex justify-center align-center border-2 border-solid docs-gray-bg mud-border-lines-default";
            }
        }

        protected void OnDragEnter(string coordinates)
        {
            var foundGridSquares = new List<MudDropZone<DropItem>>();

            foreach (var point in CurrentlyDraggingItem.Points)
            {
                var foundSquare =
                    Grid.GetValueOrDefault(coordinates.ToPointsTuple(point.Row, point.Column).ToPointsString());

                if (foundSquare != null) foundGridSquares.Add(foundSquare);
            }

            foreach (var gridSquare in Grid)
            {
                gridSquare.Value.Class =
                    "d-flex justify-center align-center border-2 border-solid docs-gray-bg mud-border-lines-default";
            }

            foreach (var foundGridSquare in foundGridSquares)
            {
                if (DropContainer.CanDrop(CurrentlyDraggingItem, coordinates))
                    foundGridSquare.Class += " mud-border-info";
            }
            DropContainer.Refresh();
        }

        protected void OnDragEnd()
        {
            foreach (var gridSquare in Grid)
            {
                gridSquare.Value.Class =
                    "d-flex justify-center align-center border-2 border-solid docs-gray-bg mud-border-lines-default";
            }
            DropContainer.Refresh();
        }

        protected bool CanDrop(DropItem item, string identifierOfDropZone)
        {
            if (identifierOfDropZone.Contains("gutter", StringComparison.Ordinal)) return false;
            CurrentlyDraggingItem = item;

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
                               transformedTuple.Column is < 9 and >= 0 &&
                               transformedTuple.Row is < 9 and >= 0;
                    }));
            
            return cursorSpaceNotOccupied && otherPointsNotOccupiedOrOutside;
        }

        public void GenerateShapes()
        {
            for (var i = 0; i < 3; i++)
            {
                Items.Add(new DropItem
                {
                    Color = Color.Primary,
                    Icon = Icons.Custom.Uncategorized.ChessRook,
                    Points = ShapeLibrary.RandomShape,
                    Zone = $"gutter{i}"
                });
            }

            StateHasChanged();

            if(DropContainer != null)
                DropContainer.Refresh();
        }

        public void ClearGrid()
        {
            Items.RemoveAll(i => !i.Zone.Contains("gutter"));

            if (DropContainer != null)
                DropContainer.Refresh();
        }
    }
}
