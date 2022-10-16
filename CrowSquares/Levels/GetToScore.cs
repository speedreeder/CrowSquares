using CrowSquares.Extensions;
using CrowSquares.Models;
using MudBlazor;

namespace CrowSquares.Levels
{
    public class GetToScore : Level
    {
        public override LevelType Type => LevelType.FreePlay;
        private int _streakCounter;

        public GetToScore(List<DropItem> grid)
        {
            Grid = grid;
            Name = "Get To Score";
            State = LevelState.Ongoing;
            Goals = new List<LevelGoal>
            {
                new()
                {
                    Current = 0,
                    Goal = 200,
                    GoalText = "Points",
                    Icon = Icons.Material.Filled.SportsScore
                }
            };
        }

        public void CheckCompletionsAndGetScore(MudItemDropInfo<DropItem> dropItem)
        {
            var completions = 0;
            var itemsToRemove = new List<DropItem>();

            var rows = new List<List<DropItem>>();
            for (var j = 0; j < 9; j++)
            {
                rows.Add(Grid.Where(i => i.Zone[..1] == j.ToString()).ToList());
            }

            foreach (var row in rows.Where(row => row.Count == 9))
            {
                completions++;
                itemsToRemove.AddRange(row.Where(r => !r.IsLocked));
            }

            var columns = new List<List<DropItem>>();
            for (var j = 0; j < 9; j++)
            {
                columns.Add(Grid.Where(i => i.Zone[1..2] == j.ToString()).ToList());
            }

            foreach (var column in columns.Where(column => column.Count == 9))
            {
                completions++;
                itemsToRemove.AddRange(column.Where(r => !r.IsLocked));
            }

            var squares = new List<List<DropItem>>
            {
                Grid.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row <= 2 && i.Column <= 2)
                    .Select(i => i.Item)
                    .ToList(),
                Grid.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row <= 2 && i.Column is >= 3 and <= 5)
                    .Select(i => i.Item)
                    .ToList(),
                Grid.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row <= 2 && i.Column >= 6)
                    .Select(i => i.Item)
                    .ToList(),
                Grid.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row is >= 3 and <= 5 && i.Column <= 2)
                    .Select(i => i.Item)
                    .ToList(),
                Grid.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row is >= 3 and <= 5 && i.Column is >= 3 and <= 5)
                    .Select(i => i.Item)
                    .ToList(),
                Grid.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row is >= 3 and <= 5 && i.Column >= 6)
                    .Select(i => i.Item)
                    .ToList(),
                Grid.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row >= 6 && i.Column <= 2)
                    .Select(i => i.Item)
                    .ToList(),
                Grid.Where(i => !i.Zone.Contains("gutter"))
                    .Select(i => new { Row = int.Parse(i.Zone[..1]), Column = int.Parse(i.Zone[1..2]), Item = i })
                    .Where(i => i.Row >= 6 && i.Column is >= 3 and <= 5)
                    .Select(i => i.Item)
                    .ToList(),
                Grid.Where(i => !i.Zone.Contains("gutter"))
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

            Grid.RemoveAll(i => itemsToRemove.Contains(i));

            var points = dropItem.Item.Points.Count +
                         completions * 18 +
                         (completions == 0 ? completions : completions - 1) * 10 +
                         _streakCounter * 10;

            if (itemsToRemove.Any())
            {
                _streakCounter++;
            }
            else
            {
                _streakCounter = 0;
            }

            Goals[0].Current += points;
        }

    }
}
