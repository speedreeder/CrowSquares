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
            public static List<(int Row, int Column)> LetterT => new() { (0, -1), (0, 0), (0, 1), (1, 0), (2, 0)};
            public static List<(int Row, int Column)> LetterTRight => new() {  (0, 0), (-1, 0), (1, 0), (0, -1), (0, -2) };
            public static List<(int Row, int Column)> LetterTLeft => new() { (0, 0), (-1, 0), (1, 0), (0, 1), (0, 2) };
            public static List<(int Row, int Column)> FourSquare => new() { (0, 0), (0, 1), (1, 0), (1, 1) };
            public static List<(int Row, int Column)> TwoPointsDiagonalRight => new() { (0, 0), (-1, 1) };
            public static List<(int Row, int Column)> ThreePointsDiagonalRight => new() { (0, 0), (-1, 1), (-2, 2) };
            public static List<(int Row, int Column)> FourPointsDiagonalRight => new() { (0, 0), (-1, 1), (-2, 2), (-3, 3) };
            public static List<(int Row, int Column)> TwoPointsDiagonalLeft => new() { (0, 0), (-1, -1) };
            public static List<(int Row, int Column)> ThreePointsDiagonalLeft => new() { (0, 0), (-1, -1), (-2, -2) };
            public static List<(int Row, int Column)> FourPointsDiagonalLeft => new() { (0, 0), (-1, -1), (-2, -2), (-3, -3) };

            public static List<(int Row, int Column)> Cross => new() { (0, 0), (0, 1), (1, 0), (-1, 0), (0, -1) };
            public static List<(int Row, int Column)> CornerBottomLeft => new() { (0, 0) };
            public static List<(int Row, int Column)> CornerTopLeft => new() { (0, 0) };
            public static List<(int Row, int Column)> CornerBottomRight => new() { (0, 0) };
            public static List<(int Row, int Column)> CornerTopRight => new() { (0, 0) };

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
            ShapeChoices.LetterT,
            ShapeChoices.LetterTLeft,
            ShapeChoices.LetterTRight,
            ShapeChoices.FourSquare,
            ShapeChoices.TwoPointsDiagonalLeft,
            ShapeChoices.TwoPointsDiagonalRight,
            ShapeChoices.ThreePointsDiagonalLeft,
            ShapeChoices.ThreePointsDiagonalRight,
            ShapeChoices.FourPointsDiagonalLeft,
            ShapeChoices.FourPointsDiagonalRight
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
