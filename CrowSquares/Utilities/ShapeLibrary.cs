namespace CrowSquares.Utilities
{
    public class ShapeLibrary
    {
        public struct ShapeChoices
        {
            public static List<(int Row, int Column)> SinglePoint => new() {(0, 0)};

            public static List<(int Row, int Column)> TwoInARow => new() { (0, 0), (0, 1) };
            public static List<(int Row, int Column)> ThreeInARow => new() { (0, 0), (0, 1), (0, 2) };
            public static List<(int Row, int Column)> FourInARow => new() { (0, 0), (0, 1), (0, 2), (0, 3) };
            public static List<(int Row, int Column)> FiveInARow => new() { (0, 0), (0, 1), (0, 2), (0, 3), (0, 4) };
            public static List<(int Row, int Column)> TwoInARowVertical => new() { (0, 0), (1, 0) };
            public static List<(int Row, int Column)> ThreeInARowVertical => new() { (0, 0), (1, 0), (2, 0) };
            public static List<(int Row, int Column)> FourInARowVertical => new() { (0, 0), (1, 0), (2, 0), (3, 0) };
            public static List<(int Row, int Column)> FiveInARowVertical => new() { (0, 0), (1, 0), (2, 0), (3, 0), (4, 0) };

            public static List<(int Row, int Column)> Cross => new() { (0, 0), (0, 1), (1, 0), (-1, 0), (0, -1) };
            public static List<(int Row, int Column)> FourSquare => new() { (0, 0), (0, 1), (1, 0), (1, 1) };

            public static List<(int Row, int Column)> TwoPointsDiagonalRight => new() { (0, 0), (-1, 1) };
            public static List<(int Row, int Column)> ThreePointsDiagonalRight => new() { (0, 0), (-1, 1), (-2, 2) };
            public static List<(int Row, int Column)> FourPointsDiagonalRight => new() { (0, 0), (-1, 1), (-2, 2), (-3, 3) };
            public static List<(int Row, int Column)> TwoPointsDiagonalLeft => new() { (0, 0), (-1, -1) };
            public static List<(int Row, int Column)> ThreePointsDiagonalLeft => new() { (0, 0), (-1, -1), (-2, -2) };
            public static List<(int Row, int Column)> FourPointsDiagonalLeft => new() { (0, 0), (-1, -1), (-2, -2), (-3, -3) };

            public static List<(int Row, int Column)> CornerBottomLeft => new() { (0, 0), (-1, 0), (0, 1) };
            public static List<(int Row, int Column)> CornerTopLeft => new() { (0, 0), (0, 1), (1, 0) };
            public static List<(int Row, int Column)> CornerBottomRight => new() { (0, 0), (0, -1), (-1, 0) };
            public static List<(int Row, int Column)> CornerTopRight => new() { (0, 0), (0, -1), (0, 1) };

            public static List<(int Row, int Column)> BigCornerBottomLeft => new() { (0, 0), (-1, 0), (0, 1), (-2, 0), (0, 3) };
            public static List<(int Row, int Column)> BigCornerTopLeft => new() { (0, 0), (0, 1), (1, 0), (0, 2), (2, 0) };
            public static List<(int Row, int Column)> BigCornerBottomRight => new() { (0, 0), (0, -1), (-1, 0), (0, -2), (-2, 0) };
            public static List<(int Row, int Column)> BigCornerTopRight => new() { (0, 0), (0, -1), (0, 1), (0, -2), (0, 2) };

            public static List<(int Row, int Column)> RichardUp => new() { (0, 0), (-1, 0), (-2, 0), (0, -1), (0, 1) };
            public static List<(int Row, int Column)> RichardDown => new() { (0, 0), (1, 0), (2, 0), (0, -1), (0, 1) };
            public static List<(int Row, int Column)> RichardLeft => new() { (0, 0), (-1, 0), (1, 0), (0, 1), (0, 2) };
            public static List<(int Row, int Column)> RichardRight => new() { (0, 0), (-1, 0), (1, 0), (0, -1), (0, -2) };

            public static List<(int Row, int Column)> LilRichardUp => new() { (0, 0), (-1, 0), (0, -1), (0, 1) };
            public static List<(int Row, int Column)> LilRichardDown => new() { (0, 0), (1, 0), (0, -1), (0, 1) };
            public static List<(int Row, int Column)> LilRichardLeft => new() { (0, 0), (-1, 0), (1, 0), (0, 1) };
            public static List<(int Row, int Column)> LilRichardRight => new() { (0, 0), (-1, 0), (1, 0), (0, -1) };


            public static List<(int Row, int Column)> LeftWormVertical => new() { (0, 0), (-1, 0), (-1, -1), (-2, -1) };
            public static List<(int Row, int Column)> LeftWormHorizontal => new() { (0, 0), (0, -1), (-1, 0), (-1, 1) };

            public static List<(int Row, int Column)> RightWormVertical => new() { (0, 0), (-1, 0), (-1, 1), (-2, 1) };
            public static List<(int Row, int Column)> RightWormHorizontal => new() { (0, 0), (0, 1), (-1, 0), (-1, -1) };

            public static List<(int Row, int Column)> HelmetTop => new() { (0, 0), (0, -1), (0, 1), (1, -1), (1, 1) };
            public static List<(int Row, int Column)> HelmetBottom => new() { (0, 0), (0, -1), (0, 1), (1, -1), (1, 1) };
            public static List<(int Row, int Column)> HelmetLeft => new() { (0, 0), (-1, 0), (1, 0), (-1, 1), (1, 1) };
            public static List<(int Row, int Column)> HelmetRight => new() { (0, 0), (-1, 0), (1, 0), (-1, -1), (1, -1) };

            public static List<(int Row, int Column)> LuigiTop => new() { (0, 0), (0, -1), (1, 0), (2, -1) };
            public static List<(int Row, int Column)> LuigiBottom => new() { (0, 0), (0, 1), (-1, 0), (-2, 0) };
            public static List<(int Row, int Column)> LuigiLeft => new() { (0, 0), (1, 0), (0, 1), (0, 2) };
            public static List<(int Row, int Column)> LuigiRight => new() { (0, 0), (-1, 0), (-1, 0), (-2, 0)};

            public static List<(int Row, int Column)> WaluigiTop => new() { (0, 0), (0, 1), (1, 0), (2, 0)};
            public static List<(int Row, int Column)> WaluigiBottom => new() { (0, 0), (0, -1), (-1, 0), (-2, 0)};
            public static List<(int Row, int Column)> WaluigiLeft => new() { (0, 0), (-1, 0), (0, 1), (0, 2) };
            public static List<(int Row, int Column)> WaluigiRight => new() { (0, 0), (-1, 0), (0, -1), (0, -2) };
        }

        public static List<List<(int Row, int Column)>> Shapes = new()
        {
            ShapeChoices.SinglePoint,
            ShapeChoices.TwoInARow,
            ShapeChoices.ThreeInARow,
            ShapeChoices.FourInARow,
            ShapeChoices.FiveInARow,
            ShapeChoices.TwoInARowVertical,
            ShapeChoices.ThreeInARowVertical,
            ShapeChoices.FourInARowVertical,
            ShapeChoices.FiveInARowVertical,
            ShapeChoices.Cross,
            ShapeChoices.FourSquare,
            ShapeChoices.TwoPointsDiagonalLeft,
            ShapeChoices.TwoPointsDiagonalRight,
            ShapeChoices.ThreePointsDiagonalLeft,
            ShapeChoices.ThreePointsDiagonalRight,
            ShapeChoices.FourPointsDiagonalLeft,
            ShapeChoices.FourPointsDiagonalRight,
            ShapeChoices.CornerBottomLeft,
            ShapeChoices.CornerBottomRight,
            ShapeChoices.CornerTopLeft,
            ShapeChoices.CornerTopRight,
            ShapeChoices.BigCornerBottomLeft,
            ShapeChoices.BigCornerBottomRight,
            ShapeChoices.BigCornerTopLeft,
            ShapeChoices.BigCornerTopRight,
            ShapeChoices.RichardDown,
            ShapeChoices.RichardLeft,
            ShapeChoices.RichardRight,
            ShapeChoices.RichardUp,
            ShapeChoices.LilRichardDown,
            ShapeChoices.LilRichardLeft,
            ShapeChoices.LilRichardRight,
            ShapeChoices.LilRichardUp,
            ShapeChoices.LeftWormHorizontal,
            ShapeChoices.LeftWormVertical,
            ShapeChoices.RightWormHorizontal,
            ShapeChoices.RightWormVertical,
            ShapeChoices.HelmetTop,
            ShapeChoices.HelmetBottom,
            ShapeChoices.HelmetLeft,
            ShapeChoices.HelmetRight,
            ShapeChoices.LuigiTop,
            ShapeChoices.LuigiBottom,
            ShapeChoices.LuigiLeft,
            ShapeChoices.LuigiRight,
            ShapeChoices.WaluigiTop,
            ShapeChoices.WaluigiBottom,
            ShapeChoices.WaluigiLeft,
            ShapeChoices.WaluigiRight
        };

        public static List<(int Row, int Column)> RandomShape
        {
            get
            {
                var r = new Random();
                return Shapes[r.Next(0, Shapes.Count)];
            }
        }

        public static  List<List<(int Row, int Column)>> RandomShapes(int numberOfRandomShapes)
        {
            var shapes = new List<List<(int Row, int Column)>>();
            for (var i = 0; i < numberOfRandomShapes; i++)
            {
                shapes.Add(RandomShape);
            }

            return shapes;
        }
    }
}
