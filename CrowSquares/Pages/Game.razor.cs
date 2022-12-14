using CrowSquares.Extensions;
using CrowSquares.Models;
using CrowSquares.Utilities;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using MudBlazor;

namespace CrowSquares.Pages
{
    public class GameBase :  ComponentBase
    {
        public string RowStyle = "";
        public MudDropContainer<DropItem> DropContainer { get; set; }

        public DropItem CurrentlyDraggingItem { get; set; }
        public MudDropZone<DropItem> Gutter0 { get; set; }
        public MudDropZone<DropItem> Gutter1 { get; set; }
        public MudDropZone<DropItem> Gutter2 { get; set; }

        public int CompletedRows { get; set; }
        public int CompletedColumns { get; set; }

        public int CompletedSquares { get; set; }


        protected List<DropItem> Items = new();

        protected Dictionary<string, MudDropZone<DropItem>> Grid { get; set; } = new();
        protected bool OnDragEnterFired = false;

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

            CheckCompletions();
            ReevaluateFitsInGrid(Items.Where(i => i.Zone.Contains("gutter")));

            if (!Items.Any(i => i.Zone.Contains("gutter", StringComparison.Ordinal)))
            {
                GenerateShapes();
            }

            foreach (var gridSquare in Grid)
            {
                gridSquare.Value.Class =
                    "d-flex justify-center align-center border-2 border-solid docs-gray-bg mud-border-lines-default";
            }

            Gutter0.Class = "";
            Gutter1.Class = "";
            Gutter2.Class = "";
        }

        protected void OnDragStartGutter(MudDropZone<DropItem> gutter)
        {
            if (gutter != null)
                gutter.Class = "invisible";
        }

        protected void OnDragEndGutter(MudDropZone<DropItem> gutter)
        {
            if (gutter != null)
                gutter.Class = "";
        }

        protected void OnDragEnter(string coordinates)
        {
            OnDragEnterFired = true;
            var foundGridSquares = new List<MudDropZone<DropItem>>();

            foreach (var point in CurrentlyDraggingItem.Points)
            {
                var foundSquare =
                    Grid.GetValueOrDefault(coordinates.ToPointsTuple(point.Row, point.Column).ToPointsString());

                if (foundSquare != null) foundGridSquares.Add(foundSquare);
            }

            foreach (var gridSquare in Grid)
            {
                //gridSquare.Value.CanDrop = _ => false;
                gridSquare.Value.Class =
                    "d-flex justify-center align-center border-2 border-solid docs-gray-bg mud-border-lines-default";
            }
            DropContainer.Refresh();

            foreach (var foundGridSquare in foundGridSquares)
            {
                if (DropContainer.CanDrop(CurrentlyDraggingItem, coordinates))
                {
                    //foundGridSquare.CanDrop = _ => true;
                    //foundGridSquare.CanDropClass = "mud-border-info";
                    foundGridSquare.Class += " mud-border-info";
                }
            }
            DropContainer.Refresh();
        }

        protected void OnDragLeaveGrid(string coordinates)
        {
            if (!OnDragEnterFired)
            {
                foreach (var gridSquare in Grid)
                {
                    gridSquare.Value.Class =
                        "d-flex justify-center align-center border-2 border-solid docs-gray-bg mud-border-lines-default";
                }
                DropContainer.Refresh();
            }

            OnDragEnterFired = false;
        }

        protected void OnDragEnd(DragEventArgs args)
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
            Items.RemoveAll(i => i.Zone.StartsWith("gutter"));

            for (var i = 0; i < 3; i++)
            {
                var item = new DropItem
                {
                    Color = Color.Primary,
                    Icon = Icons.Custom.Uncategorized.ChessRook,
                    Points = ShapeLibrary.RandomShape,
                    Zone = $"gutter{i}"
                };

                item.FitsInGrid = item.CheckFitsInGrid(Items.Where(e => !e.Zone.Contains("gutter")).ToList());

                Items.Add(item);
            }

            StateHasChanged();

            if(DropContainer != null)
                DropContainer.Refresh();
        }

        private void ReevaluateFitsInGrid(IEnumerable<DropItem> items)
        {
            foreach (var dropItem in items)
            {
                dropItem.FitsInGrid = dropItem.CheckFitsInGrid(Items.Where(e => !e.Zone.Contains("gutter")).ToList());
            }
        }

        public void ClearGrid()
        {
            Items.RemoveAll(i => !i.Zone.Contains("gutter"));

            if (DropContainer != null)
                DropContainer.Refresh();
        }

        private void CheckCompletions()
        {
            var itemsToRemove = new List<DropItem>();

            var rows = new List<List<DropItem>>();
            for (var j = 0; j < 9; j++)
            {
                rows.Add(Items.Where(i => i.Zone[..1] == j.ToString()).ToList());
            }

            foreach (var row in rows.Where(row => row.Count == 9))
            {
                CompletedRows++;
                itemsToRemove.AddRange(row);
                //Items.RemoveAll(i => row.Contains(i));
            }

            var columns = new List<List<DropItem>>();
            for (var j = 0; j < 9; j++)
            {
                columns.Add(Items.Where(i => i.Zone[1..2] == j.ToString()).ToList());
            }

            foreach (var column in columns.Where(column => column.Count == 9))
            {
                CompletedColumns++;
                itemsToRemove.AddRange(column);
                //Items.RemoveAll(i => column.Contains(i));
            }

            var squares = new List<List<DropItem>>
            {
                Items.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row <= 2 && i.Column <= 2)
                    .Select(i => i.Item)
                    .ToList(),
                Items.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row <= 2 && i.Column >= 3 && i.Column <= 5)
                    .Select(i => i.Item)
                    .ToList(),
                Items.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row <= 2 && i.Column >= 6)
                    .Select(i => i.Item)
                    .ToList(),
                Items.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row >= 3 && i.Row <= 5 && i.Column <= 2)
                    .Select(i => i.Item)
                    .ToList(),
                Items.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row >= 3 && i.Row <= 5 && i.Column >= 3 && i.Column <= 5)
                    .Select(i => i.Item)
                    .ToList(),
                Items.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row >= 3 && i.Row <= 5 && i.Column >= 6)
                    .Select(i => i.Item)
                    .ToList(),
                Items.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row >= 6 && i.Column <= 2)
                    .Select(i => i.Item)
                    .ToList(),
                Items.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row >= 6 && i.Column >= 3 && i.Column <= 5)
                    .Select(i => i.Item)
                    .ToList(),
                Items.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row >= 6 && i.Column >= 6)
                    .Select(i => i.Item)
                    .ToList()
            };

            foreach (var square in squares.Where(s => s.Count == 9))
            {
                CompletedSquares++;
                itemsToRemove.AddRange(square);
            }

            Items.RemoveAll(i => itemsToRemove.Contains(i));

        }
    }
}
