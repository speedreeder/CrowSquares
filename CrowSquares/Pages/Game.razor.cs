using CrowSquares.Extensions;
using CrowSquares.Levels;
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

        public int StreakCounter { get; set; }

        protected List<DropItem> Items = new();

        protected Dictionary<string, MudDropZone<DropItem>> Grid { get; set; } = new();
        protected bool OnDragEnterFired;

        public Level Level { get; set; }

        protected override void OnInitialized()
        {
            GenerateLevel();
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
                    Icon = Icons.Custom.Brands.Twitter,
                    Color = Color.Primary,
                    Shape = dropItem.Item.Shape
                });
            }

            Level.CheckLevel();
            //var completionPoints = CheckCompletionsAndGetScore();
            //Score += dropItem.Item.Points.Count + completionPoints;

            Items.ItemsFitInList(Items.Where(i => i.Zone.Contains("gutter")));

            if (!Items.Any(i => i.Zone.Contains("gutter", StringComparison.Ordinal)))
            {
                GenerateShapes();
            }

            ClearGridBorders();

            Gutter0.Class = "";
            Gutter1.Class = "";
            Gutter2.Class = "";

        }

        protected void OnLevelValueChanged(Level levelChanged)
        {
            Level = levelChanged;
            Items = levelChanged.InitialLevelCells;

            GenerateShapes();

            StateHasChanged();
            DropContainer.Refresh();
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

            ClearGridBorders();
            DropContainer.Refresh();

            foreach (var foundGridSquare in foundGridSquares)
            {
                if (DropContainer.CanDrop(CurrentlyDraggingItem, coordinates))
                {
                    foundGridSquare.Class = foundGridSquare.Class.Replace("mud-border-lines-default", "mud-border-info");
                }
            }
            DropContainer.Refresh();
        }

        protected void OnDragLeaveGrid()
        {
            if (!OnDragEnterFired)
            {
                ClearGridBorders();
                DropContainer.Refresh();
            }

            OnDragEnterFired = false;
        }

        protected void OnDragEnd(DragEventArgs args)
        {
            ClearGridBorders();
            DropContainer.Refresh();
        }

        private void ClearGridBorders()
        {
            foreach (var gridSquare in Grid)
            {
                gridSquare.Value.Class =
                    "d-flex justify-center align-center border-2 border-solid docs-gray-bg mud-border-lines-default";
            }
        }

        protected bool CanDrop(DropItem item, string identifierOfDropZone)
        {
            if (identifierOfDropZone.Contains("gutter", StringComparison.Ordinal)) return false;
            CurrentlyDraggingItem = item;

            var cursorSpaceOccupied = Items.Any(x => identifierOfDropZone == x.Zone);

            if (cursorSpaceOccupied) return false;

            var otherPointsNotOccupiedOrOutside =
                Items.Select(i => i.Zone).All(z =>
                    item.Points.All(p =>
                    {
                        var transformedTuple = identifierOfDropZone.ToPointsTuple(p.Row, p.Column);
                        return transformedTuple.ToPointsString() != z &&
                               transformedTuple.Column is < 9 and >= 0 &&
                               transformedTuple.Row is < 9 and >= 0;
                    }));
            
            return otherPointsNotOccupiedOrOutside;
        }

        public void GenerateShapes()
        {
            Items.RemoveAll(i => i.Zone.StartsWith("gutter"));

            for (var i = 0; i < 3; i++)
            {
                var shape = ShapeLibrary.RandomShape;
                var item = new DropItem
                {
                    Color = Color.Primary,
                    Icon = shape.Icon,
                    Shape = shape,
                    //Icon = Icons.Custom.Brands.Twitter,
                    Points = shape.Points,
                    Zone = $"gutter{i}"
                };

                item.FitsInGrid = item.CheckFitsInGrid(Items.Where(e => !e.Zone.Contains("gutter")).ToList());

                Items.Add(item);
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

        private int CheckCompletionsAndGetScore()
        {
            var completions = 0;
            var itemsToRemove = new List<DropItem>();

            var rows = new List<List<DropItem>>();
            for (var j = 0; j < 9; j++)
            {
                rows.Add(Items.Where(i => i.Zone[..1] == j.ToString()).ToList());
            }

            foreach (var row in rows.Where(row => row.Count == 9))
            {
                completions++;
                itemsToRemove.AddRange(row.Where(r => !r.IsLocked));
            }

            var columns = new List<List<DropItem>>();
            for (var j = 0; j < 9; j++)
            {
                columns.Add(Items.Where(i => i.Zone[1..2] == j.ToString()).ToList());
            }

            foreach (var column in columns.Where(column => column.Count == 9))
            {
                completions++;
                itemsToRemove.AddRange(column.Where(r => !r.IsLocked));
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
                    .Where(i => i.Row <= 2 && i.Column is >= 3 and <= 5)
                    .Select(i => i.Item)
                    .ToList(),
                Items.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row <= 2 && i.Column >= 6)
                    .Select(i => i.Item)
                    .ToList(),
                Items.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row is >= 3 and <= 5 && i.Column <= 2)
                    .Select(i => i.Item)
                    .ToList(),
                Items.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row is >= 3 and <= 5 && i.Column is >= 3 and <= 5)
                    .Select(i => i.Item)
                    .ToList(),
                Items.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row is >= 3 and <= 5 && i.Column >= 6)
                    .Select(i => i.Item)
                    .ToList(),
                Items.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row >= 6 && i.Column <= 2)
                    .Select(i => i.Item)
                    .ToList(),
                Items.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row >= 6 && i.Column is >= 3 and <= 5)
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
                completions++;
                itemsToRemove.AddRange(square.Where(r => !r.IsLocked));
            }

            Items.RemoveAll(i => itemsToRemove.Contains(i));

            var points = completions * 18 + (completions == 0 ? completions : completions - 1) * 10 + StreakCounter * 10;

            if (itemsToRemove.Any())
            {
                StreakCounter++;
            }
            else
            {
                StreakCounter = 0;
            }
            return points;
        }

        public void GenerateLevel()
        {
            Level = new GetToScore(Items);
            Items = Level.InitialLevelCells;
        }
    }
}
