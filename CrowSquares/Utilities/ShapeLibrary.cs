namespace CrowSquares.Utilities
{
    public class ShapeLibrary
    {
        public struct ShapeChoices
        {
            public static List<(int Row, int Column)> SinglePoint => new() {(0, 0)};
            public static List<(int Row, int Column)> TwoInARow => new() { (0, 0), (0, 1) };
            public static List<(int Row, int Column)> ThreeInARow => new() { (0, 0), (0, 1), (0, 2) };
            public static List<(int Row, int Column)> LetterT => new() { (0, 0), (0, 1), (0, 2), (0, 3), (0, 4), (1, 2), (2, 2), (3, 2) };
            public static List<(int Row, int Column)> TwoPointsDiagonalRight => new() { (0, 0), (1, 1) };
            public static List<(int Row, int Column)> TwoPointsDiagonalLeft => new() { (0, 1), (1, 0) };
        }

        public static List<List<(int Row, int Column)>> Shapes = new()
        {
            ShapeChoices.SinglePoint,
            ShapeChoices.TwoInARow,
            ShapeChoices.ThreeInARow,
            ShapeChoices.LetterT,
            ShapeChoices.TwoPointsDiagonalLeft,
            ShapeChoices.TwoPointsDiagonalRight
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
