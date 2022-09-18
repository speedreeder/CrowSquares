namespace CrowSquares.Extensions
{
    public static class TupleExtensions
    {
        public static string ToPointsString(this (int Row, int Column) pointsTuple)
        {
            return $"{pointsTuple.Row}{pointsTuple.Column}";
        }

        public static (int Row, int Column) AddRowAddColumn(this (int Row, int Column) pointsTuple, int rowToAdd, int columnToAdd)
        {
            return (pointsTuple.Row + rowToAdd, pointsTuple.Column + columnToAdd);
        }
    }
}
