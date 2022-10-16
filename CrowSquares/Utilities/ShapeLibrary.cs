namespace CrowSquares.Utilities
{
    public class Shape
    {
        public List<(int Row, int Column)> Points { get; set; }
        public string Icon { get; set; }
    }

    public class ShapeLibrary
    {
        public struct ShapeChoices
        {
            public static Shape SinglePoint => new()
            {
                Points = new List<(int Row, int Column)>{(0, 0)}, 
                Icon = "<g id=\"Layer_1\">\r\n  <title>Layer 1</title>\r\n  <rect x=\"20\" y=\"15\" fill=\"#fff\" stroke=\"#000\" width=\"10\" height=\"10\" id=\"svg_1\"/>\r\n </g>"
            };

            public static Shape TwoInARow => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (0, 1) },
                Icon = "<g id=\"Layer_1\">\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_2\">\r\n   <rect x=\"14.96875\" y=\"15\" id=\"svg_1\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect y=\"15\" id=\"svg_7\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"25.03125\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape ThreeInARow => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (0, 1), (0, 2) },
                Icon = "<g id=\"Layer_1\">\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_2\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" width=\"10\" height=\"10\" id=\"svg_1\" y=\"15\" x=\"9.96875\"/>\r\n   <rect x=\"20.03125\" fill=\"#fff\" stroke=\"#000\" width=\"10\" height=\"10\" id=\"svg_7\" y=\"15\"/>\r\n   <rect x=\"30.03125\" fill=\"#fff\" stroke=\"#000\" width=\"10\" height=\"10\" id=\"svg_3\" y=\"15\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape FourInARow => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (0, 1), (0, 2), (0, 3) },
                Icon = "<g id=\"Layer_1\">\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_5\">\r\n   <rect x=\"5\" y=\"15\" id=\"svg_1\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect y=\"15\" id=\"svg_7\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"15\"/>\r\n   <rect y=\"15\" id=\"svg_3\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"25\"/>\r\n   <rect y=\"15\" id=\"svg_4\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"35\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape FiveInARow => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (0, 1), (0, 2), (0, 3), (0, 4) },
                Icon = "<g id=\"svg_2\">\r\n   <rect y=\"15\" id=\"svg_1\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect y=\"15\" id=\"svg_7\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"10\"/>\r\n   <rect y=\"15\" id=\"svg_3\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"20\"/>\r\n   <rect y=\"15\" id=\"svg_4\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"30\"/>\r\n   <rect y=\"15\" id=\"svg_5\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"40\"/>\r\n  </g>"
            };

            public static Shape TwoInARowVertical => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (1, 0) },
                Icon = "<g id=\"Layer_1\">\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_8\">\r\n   <rect transform=\"rotate(90, 25, 20)\" x=\"20\" y=\"15\" id=\"svg_1\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(90, 25, 30)\" y=\"25\" id=\"svg_7\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"20\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape ThreeInARowVertical => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (1, 0), (2, 0) },
                Icon = "<g id=\"Layer_1\">\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_6\">\r\n   <rect transform=\"rotate(90, 25, 15)\" x=\"20\" y=\"10\" id=\"svg_1\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(90, 25, 25)\" y=\"20\" id=\"svg_7\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"20\"/>\r\n   <rect transform=\"rotate(90, 25, 35)\" y=\"30\" id=\"svg_3\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"20\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape FourInARowVertical => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (1, 0), (2, 0), (3, 0) },
                Icon = "<g id=\"Layer_1\">\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 20)\" id=\"svg_5\">\r\n   <rect x=\"5\" y=\"15\" id=\"svg_1\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect y=\"15\" id=\"svg_7\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"15\"/>\r\n   <rect y=\"15\" id=\"svg_3\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"25\"/>\r\n   <rect y=\"15\" id=\"svg_4\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"35\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape FiveInARowVertical => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (1, 0), (2, 0), (3, 0), (4, 0) },
                Icon = "<g id=\"Layer_1\">\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_9\">\r\n   <rect x=\"0\" y=\"20\" id=\"svg_1\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect y=\"20\" id=\"svg_7\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"10\"/>\r\n   <rect y=\"20\" id=\"svg_3\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"20\"/>\r\n   <rect y=\"20\" id=\"svg_4\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"30\"/>\r\n   <rect y=\"20\" id=\"svg_5\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"40\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape Cross => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (0, 1), (1, 0), (-1, 0), (0, -1) },
                Icon = "<g id=\"Layer_1\">\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_5\">\r\n   <rect y=\"10\" id=\"svg_3\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"20\"/>\r\n   <rect y=\"20\" id=\"svg_3\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"20\"/>\r\n   <rect y=\"20\" id=\"svg_1\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"30\"/>\r\n   <rect y=\"30\" id=\"svg_2\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"20\"/>\r\n   <rect y=\"20\" id=\"svg_4\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"10\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape FourSquare => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (0, 1), (1, 0), (1, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_5\">\r\n   <rect id=\"svg_1\" height=\"10\" width=\"10\" y=\"15\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_4\" height=\"10\" width=\"10\" y=\"25\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape TwoPointsDiagonalRight => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n  <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n </g>"
            };

            public static Shape ThreePointsDiagonalRight => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 1), (-2, 2) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_1\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"20\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_2\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"30\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape FourPointsDiagonalRight => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 1), (-2, 2), (-3, 3) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_1\">\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"14.875\" stroke=\"#000\" fill=\"#fff\" transform=\"rotate(90, 19.875, 20)\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"5\" x=\"4.875\" stroke=\"#000\" fill=\"#fff\" transform=\"rotate(90, 9.875, 10)\"/>\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"25\" x=\"24.875\" stroke=\"#000\" fill=\"#fff\" transform=\"rotate(90, 29.875, 30)\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"35\" x=\"34.875\" stroke=\"#000\" fill=\"#fff\" transform=\"rotate(90, 40, 40.125)\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape TwoPointsDiagonalLeft => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (-1, -1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_2\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"14.875\" x=\"25\" stroke=\"#000\" fill=\"#fff\" transform=\"rotate(180, 30, 19.875)\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"25.125\" x=\"14.5\" stroke=\"#000\" fill=\"#fff\" transform=\"rotate(180, 19.75, 30.125)\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape ThreePointsDiagonalLeft => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (-1, -1), (-2, -2) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_1\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"20\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_2\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"30\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape FourPointsDiagonalLeft => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (-1, -1), (-2, -2), (-3, -3) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_1\">\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"14.875\" stroke=\"#000\" fill=\"#fff\" transform=\"rotate(90, 19.875, 20)\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"5\" x=\"4.875\" stroke=\"#000\" fill=\"#fff\" transform=\"rotate(90, 9.875, 10)\"/>\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"25\" x=\"24.875\" stroke=\"#000\" fill=\"#fff\" transform=\"rotate(90, 29.875, 30)\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"35\" x=\"34.875\" stroke=\"#000\" fill=\"#fff\" transform=\"rotate(90, 40, 40.125)\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape CornerBottomLeft => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (0, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(-90, 25, 25)\" id=\"svg_1\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape CornerTopLeft => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (0, 1), (1, 0) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_1\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape CornerBottomRight => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (0, -1), (-1, 0) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(180, 25, 25)\" id=\"svg_1\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape CornerTopRight => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (0, -1), (0, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_1\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape BigCornerBottomLeft => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (0, 1), (-2, 0), (0, 2) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_7\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_5\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"20\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_2\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"30\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_4\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape BigCornerTopLeft => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (0, 1), (1, 0), (0, 2), (2, 0) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_7\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_5\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"20\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_2\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"30\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_4\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape BigCornerBottomRight => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (0, -1), (-1, 0), (0, -2), (-2, 0) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(-90, 25, 25)\" id=\"svg_7\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_5\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"20\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_2\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"30\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_4\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape BigCornerTopRight => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (0, -1), (0, 1), (0, -2), (0, 2) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(180, 25, 25)\" id=\"svg_7\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_5\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"20\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_2\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"30\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_4\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape RichardUp => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (-2, 0), (0, -1), (0, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_1\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"30\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"30\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"20\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"30\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_4\" height=\"10\" width=\"10\" y=\"10\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape RichardDown => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (1, 0), (2, 0), (0, -1), (0, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(180, 25, 25)\" id=\"svg_1\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"30\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"30\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"20\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"30\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_4\" height=\"10\" width=\"10\" y=\"10\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape RichardLeft => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (1, 0), (0, 1), (0, 2) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(-90, 25, 25)\" id=\"svg_1\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"30\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"30\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"20\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"30\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_4\" height=\"10\" width=\"10\" y=\"10\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape RichardRight => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (1, 0), (0, -1), (0, -2) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_1\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"30\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"30\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"20\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"30\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_4\" height=\"10\" width=\"10\" y=\"10\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape LilRichardUp => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (0, -1), (0, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(180, 25, 25)\" id=\"svg_4\">\r\n   <rect transform=\"rotate(180, 25, 20)\" id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 15, 20)\" id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 25, 30)\" id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 35, 20)\" id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape LilRichardDown => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (1, 0), (0, -1), (0, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_4\">\r\n   <rect transform=\"rotate(180, 25, 20)\" id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 15, 20)\" id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 25, 30)\" id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 35, 20)\" id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape LilRichardLeft => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (1, 0), (0, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_4\">\r\n   <rect transform=\"rotate(180, 25, 20)\" id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 15, 20)\" id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 25, 30)\" id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 35, 20)\" id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape LilRichardRight => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (1, 0), (0, -1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(-90, 25, 25)\" id=\"svg_4\">\r\n   <rect transform=\"rotate(180, 25, 20)\" id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 15, 20)\" id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 25, 30)\" id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 35, 20)\" id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape LeftWormVertical => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (-1, -1), (-2, -1) },
                Icon = "<g id=\"Layer_1\">\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25.0625, 20)\" id=\"svg_5\">\r\n   <rect x=\"10.0625\" y=\"10\" fill=\"#fff\" stroke=\"#000\" width=\"10\" height=\"10\" id=\"svg_1\"/>\r\n   <rect y=\"10\" fill=\"#fff\" stroke=\"#000\" x=\"20.0625\" width=\"10\" height=\"10\" id=\"svg_2\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"20.0625\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"30.0625\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_4\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape LeftWormHorizontal => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (0, -1), (-1, 0), (-1, 1) },
                Icon = "<g id=\"Layer_1\">\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_5\">\r\n   <rect x=\"10\" y=\"10\" fill=\"#fff\" stroke=\"#000\" width=\"10\" height=\"10\" id=\"svg_1\"/>\r\n   <rect y=\"10\" fill=\"#fff\" stroke=\"#000\" x=\"20\" width=\"10\" height=\"10\" id=\"svg_2\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"20\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"30\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_4\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape RightWormVertical => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (-1, 1), (-2, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_7\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_5\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"25\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"25\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_2\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape RightWormHorizontal => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (0, 1), (-1, 0), (-1, -1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_7\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_5\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"25\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"25\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_2\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape HelmetTop => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (0, -1), (0, 1), (1, -1), (1, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_4\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_1\" height=\"10\" width=\"10\" y=\"25\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape HelmetBottom => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (0, -1), (0, 1), (1, -1), (1, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(180, 25, 25)\" id=\"svg_4\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_1\" height=\"10\" width=\"10\" y=\"25\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape HelmetLeft => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (1, 0), (-1, 1), (1, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(-90, 25, 25)\" id=\"svg_4\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_1\" height=\"10\" width=\"10\" y=\"25\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape HelmetRight => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (1, 0), (-1, -1), (1, -1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_4\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_1\" height=\"10\" width=\"10\" y=\"25\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape LuigiTop => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (0, -1), (1, 0), (2, -1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(180, 25, 25)\" id=\"svg_2\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_5\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"25\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_1\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape LuigiBottom => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (0, 1), (-1, 0), (-2, 0) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_2\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_5\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"25\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_1\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape LuigiLeft => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (1, 0), (0, 1), (0, 2) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_2\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_5\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"25\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_1\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape LuigiRight => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (-1, 0), (-2, 0) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(-90, 25, 25)\" id=\"svg_2\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_5\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"25\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_1\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape WaluigiTop => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (0, 1), (1, 0), (2, 0) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(180, 25, 25)\" id=\"svg_4\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"30\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"10\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"20\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_1\" height=\"10\" width=\"10\" y=\"30\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape WaluigiBottom => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (0, -1), (-1, 0), (-2, 0) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_4\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"30\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"10\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"20\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_1\" height=\"10\" width=\"10\" y=\"30\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape WaluigiLeft => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (0, 1), (0, 2) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_4\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"30\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"10\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"20\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_1\" height=\"10\" width=\"10\" y=\"30\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape WaluigiRight => new()
            {
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (0, -1), (0, -2) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(-90, 25, 25)\" id=\"svg_4\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"30\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"10\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"20\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_1\" height=\"10\" width=\"10\" y=\"30\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };
        }

        public static List<Shape> Shapes = new()
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

        public static Shape RandomShape
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
                shapes.Add(RandomShape.Points);
            }

            return shapes;
        }
    }
}
