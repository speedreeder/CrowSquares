using System.Text.RegularExpressions;

namespace CrowSquares.Extensions
{
    public static class StringExtensions
    {
        public static (int Row, int Column) ToPointsTuple(this string pointsString, int rowToAdd = 0, int columnToAdd = 0)
        {
            return (int.Parse(pointsString[0].ToString()) + rowToAdd, int.Parse(pointsString[1].ToString()) + columnToAdd);
        }
    }
}
