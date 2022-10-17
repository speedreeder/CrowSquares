namespace CrowSquares.Utilities
{
    public class Shape
    {
        public List<(int Row, int Column)> Points { get; set; }
        public string Icon { get; set; }
        public string Name { get; set; }
    }

    public class ShapeLibrary
    {
        public struct ShapeChoices
        {
            public static Shape SinglePoint => new()
            {
                Name = "SinglePoint",
                Points = new List<(int Row, int Column)>{(0, 0)}, 
                Icon = "<g id=\"Layer_1\">\r\n  <title>Layer 1</title>\r\n  <rect x=\"20\" y=\"15\" fill=\"#fff\" stroke=\"#000\" width=\"10\" height=\"10\" id=\"svg_1\"/>\r\n </g>"
            };

            public static Shape TwoInARow => new()
            {
                Name = "TwoInARow",
                Points = new List<(int Row, int Column)> { (0, 0), (0, 1) },
                Icon = "<g id=\"Layer_1\">\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_2\">\r\n   <rect x=\"14.96875\" y=\"15\" id=\"svg_1\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect y=\"15\" id=\"svg_7\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"25.03125\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape ThreeInARow => new()
            {
                Name = "ThreeInARow",
                Points = new List<(int Row, int Column)> { (0, 0), (0, 1), (0, 2) },
                Icon = "<g id=\"Layer_1\">\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_2\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" width=\"10\" height=\"10\" id=\"svg_1\" y=\"15\" x=\"9.96875\"/>\r\n   <rect x=\"20.03125\" fill=\"#fff\" stroke=\"#000\" width=\"10\" height=\"10\" id=\"svg_7\" y=\"15\"/>\r\n   <rect x=\"30.03125\" fill=\"#fff\" stroke=\"#000\" width=\"10\" height=\"10\" id=\"svg_3\" y=\"15\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape FourInARow => new()
            {
                Name = "FourInARow",
                Points = new List<(int Row, int Column)> { (0, 0), (0, 1), (0, 2), (0, 3) },
                Icon = "<g id=\"Layer_1\">\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_5\">\r\n   <rect x=\"5\" y=\"15\" id=\"svg_1\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect y=\"15\" id=\"svg_7\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"15\"/>\r\n   <rect y=\"15\" id=\"svg_3\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"25\"/>\r\n   <rect y=\"15\" id=\"svg_4\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"35\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape FiveInARow => new()
            {
                Name = "FiveInARow",
                Points = new List<(int Row, int Column)> { (0, 0), (0, 1), (0, 2), (0, 3), (0, 4) },
                Icon = "<g id=\"svg_2\">\r\n   <rect y=\"15\" id=\"svg_1\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect y=\"15\" id=\"svg_7\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"10\"/>\r\n   <rect y=\"15\" id=\"svg_3\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"20\"/>\r\n   <rect y=\"15\" id=\"svg_4\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"30\"/>\r\n   <rect y=\"15\" id=\"svg_5\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"40\"/>\r\n  </g>"
            };

            public static Shape TwoInARowVertical => new()
            {
                Name = "TwoInARowVertical",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0) },
                Icon = "<g id=\"Layer_1\">\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_8\">\r\n   <rect transform=\"rotate(90, 25, 20)\" x=\"20\" y=\"15\" id=\"svg_1\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(90, 25, 30)\" y=\"25\" id=\"svg_7\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"20\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape ThreeInARowVertical => new()
            {
                Name = "ThreeInARowVertical",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (-2, 0) },
                Icon = "<g id=\"Layer_1\">\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_6\">\r\n   <rect transform=\"rotate(90, 25, 15)\" x=\"20\" y=\"10\" id=\"svg_1\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(90, 25, 25)\" y=\"20\" id=\"svg_7\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"20\"/>\r\n   <rect transform=\"rotate(90, 25, 35)\" y=\"30\" id=\"svg_3\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"20\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape FourInARowVertical => new()
            {
                Name = "FourInARowVertical",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (-2, 0), (-3, 0) },
                Icon = "<g id=\"Layer_1\">\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 20)\" id=\"svg_5\">\r\n   <rect x=\"5\" y=\"15\" id=\"svg_1\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect y=\"15\" id=\"svg_7\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"15\"/>\r\n   <rect y=\"15\" id=\"svg_3\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"25\"/>\r\n   <rect y=\"15\" id=\"svg_4\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"35\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape FiveInARowVertical => new()
            {
                Name = "FiveInARowVertical",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (-2, 0), (-3, 0), (-4, 0) },
                Icon = "<g id=\"Layer_1\">\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_9\">\r\n   <rect x=\"0\" y=\"20\" id=\"svg_1\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect y=\"20\" id=\"svg_7\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"10\"/>\r\n   <rect y=\"20\" id=\"svg_3\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"20\"/>\r\n   <rect y=\"20\" id=\"svg_4\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"30\"/>\r\n   <rect y=\"20\" id=\"svg_5\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"40\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape Cross => new()
            {
                Name = "Cross",
                Points = new List<(int Row, int Column)> { (0, 0), (0, 1), (1, 0), (-1, 0), (0, -1) },
                Icon = "<g id=\"Layer_1\">\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_5\">\r\n   <rect y=\"10\" id=\"svg_3\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"20\"/>\r\n   <rect y=\"20\" id=\"svg_3\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"20\"/>\r\n   <rect y=\"20\" id=\"svg_1\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"30\"/>\r\n   <rect y=\"30\" id=\"svg_2\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"20\"/>\r\n   <rect y=\"20\" id=\"svg_4\" height=\"10\" width=\"10\" stroke=\"#000\" fill=\"#fff\" x=\"10\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape FourSquare => new()
            {
                Name = "FourSquare",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (0, 1), (-1, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_5\">\r\n   <rect id=\"svg_1\" height=\"10\" width=\"10\" y=\"15\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_4\" height=\"10\" width=\"10\" y=\"25\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape TwoPointsDiagonalRight => new()
            {
                Name = "TwoPointsDiagonalRight",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n  <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n </g>"
            };

            public static Shape ThreePointsDiagonalRight => new()
            {
                Name = "ThreePointsDiagonalRight",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 1), (-2, 2) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_1\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"20\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_2\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"30\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape FourPointsDiagonalRight => new()
            {
                Name = "FourPointsDiagonalRight",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 1), (-2, 2), (-3, 3) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_1\">\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"14.875\" stroke=\"#000\" fill=\"#fff\" transform=\"rotate(90, 19.875, 20)\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"5\" x=\"4.875\" stroke=\"#000\" fill=\"#fff\" transform=\"rotate(90, 9.875, 10)\"/>\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"25\" x=\"24.875\" stroke=\"#000\" fill=\"#fff\" transform=\"rotate(90, 29.875, 30)\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"35\" x=\"34.875\" stroke=\"#000\" fill=\"#fff\" transform=\"rotate(90, 40, 40.125)\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape TwoPointsDiagonalLeft => new()
            {
                Name = "TwoPointsDiagonalLeft",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, -1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_2\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"14.875\" x=\"25\" stroke=\"#000\" fill=\"#fff\" transform=\"rotate(180, 30, 19.875)\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"25.125\" x=\"14.5\" stroke=\"#000\" fill=\"#fff\" transform=\"rotate(180, 19.75, 30.125)\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape ThreePointsDiagonalLeft => new()
            {
                Name = "ThreePointsDiagonalLeft",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, -1), (-2, -2) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_1\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"20\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_2\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"30\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape FourPointsDiagonalLeft => new()
            {
                Name = "FourPointsDiagonalLeft",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, -1), (-2, -2), (-3, -3) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_1\">\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"14.875\" stroke=\"#000\" fill=\"#fff\" transform=\"rotate(90, 19.875, 20)\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"5\" x=\"4.875\" stroke=\"#000\" fill=\"#fff\" transform=\"rotate(90, 9.875, 10)\"/>\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"25\" x=\"24.875\" stroke=\"#000\" fill=\"#fff\" transform=\"rotate(90, 29.875, 30)\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"35\" x=\"34.875\" stroke=\"#000\" fill=\"#fff\" transform=\"rotate(90, 40, 40.125)\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape CornerBottomLeft => new()
            {
                Name = "CornerBottomLeft",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (0, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(-90, 25, 25)\" id=\"svg_1\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape CornerTopLeft => new()
            {
                Name = "CornerTopLeft",
                Points = new List<(int Row, int Column)> { (0, 0), (0, 1), (1, 0) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_1\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape CornerBottomRight => new()
            {
                Name = "CornerBottomRight",
                Points = new List<(int Row, int Column)> { (0, 0), (0, -1), (-1, 0) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(180, 25, 25)\" id=\"svg_1\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape CornerTopRight => new()
            {
                Name = "CornerTopRight",
                Points = new List<(int Row, int Column)> { (0, 0), (0, -1), (1, 0) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_1\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape BigCornerBottomLeft => new()
            {
                Name = "BigCornerBottomLeft",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (0, 1), (-2, 0), (0, 2) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_7\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_5\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"20\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_2\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"30\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_4\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape BigCornerTopLeft => new()
            {
                Name = "BigCornerTopLeft",
                Points = new List<(int Row, int Column)> { (0, 0), (0, 1), (1, 0), (0, 2), (2, 0) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_7\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_5\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"20\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_2\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"30\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_4\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape BigCornerBottomRight => new()
            {
                Name = "BigCornerBottomRight",
                Points = new List<(int Row, int Column)> { (0, 0), (0, -1), (-1, 0), (0, -2), (-2, 0) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(-90, 25, 25)\" id=\"svg_7\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_5\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"20\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_2\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"30\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_4\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape BigCornerTopRight => new()
            {
                Name = "BigCornerTopRight",
                Points = new List<(int Row, int Column)> { (0, 0), (0, -1), (0, 1), (0, -2), (0, 2) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(180, 25, 25)\" id=\"svg_7\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_5\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"20\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"10\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_2\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"30\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_4\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape RichardUp => new()
            {
                Name = "RichardUp",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (-2, 0), (0, -1), (0, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_1\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"30\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"30\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"20\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"30\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_4\" height=\"10\" width=\"10\" y=\"10\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape RichardDown => new()
            {
                Name = "RichardDown",
                Points = new List<(int Row, int Column)> { (0, 0), (1, 0), (2, 0), (0, -1), (0, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(180, 25, 25)\" id=\"svg_1\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"30\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"30\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"20\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"30\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_4\" height=\"10\" width=\"10\" y=\"10\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape RichardLeft => new()
            {
                Name = "RichardLeft",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (1, 0), (0, -1), (0, -2) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(-90, 25, 25)\" id=\"svg_1\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"30\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"30\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"20\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"30\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_4\" height=\"10\" width=\"10\" y=\"10\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape RichardRight => new()
            {
                Name = "RichardRight",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (1, 0), (0, 1), (0, 2) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_1\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"30\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"30\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"20\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"30\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_4\" height=\"10\" width=\"10\" y=\"10\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape LilRichardUp => new()
            {
                Name = "LilRichardUp",
                Points = new List<(int Row, int Column)> { (0, 0), (0, -1), (-1, 0), (0, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(180, 25, 25)\" id=\"svg_4\">\r\n   <rect transform=\"rotate(180, 25, 20)\" id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 15, 20)\" id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 25, 30)\" id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 35, 20)\" id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape LilRichardDown => new()
            {
                Name = "LilRichardDown",
                Points = new List<(int Row, int Column)> { (0, 0), (1, 0), (0, -1), (0, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_4\">\r\n   <rect transform=\"rotate(180, 25, 20)\" id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 15, 20)\" id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 25, 30)\" id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 35, 20)\" id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape LilRichardLeft => new()
            {
                Name = "LilRichardLeft",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (1, 0), (0, -1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_4\">\r\n   <rect transform=\"rotate(180, 25, 20)\" id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 15, 20)\" id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 25, 30)\" id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 35, 20)\" id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape LilRichardRight => new()
            {
                Name = "LilRichardRight",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (1, 0), (0, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(-90, 25, 25)\" id=\"svg_4\">\r\n   <rect transform=\"rotate(180, 25, 20)\" id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 15, 20)\" id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 25, 30)\" id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect transform=\"rotate(180, 35, 20)\" id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape LeftWormVertical => new()
            {
                Name = "LeftWormVertical",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (-1, -1), (-2, -1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_4\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_1\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"25\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_2\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"25\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n  </g>"
            };

            public static Shape LeftWormHorizontal => new()
            {
                Name = "LeftWormHorizontal",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (0, 1), (-1, -1) },
                Icon = "<g id=\"Layer_1\">\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_5\">\r\n   <rect x=\"10\" y=\"10\" fill=\"#fff\" stroke=\"#000\" width=\"10\" height=\"10\" id=\"svg_1\"/>\r\n   <rect y=\"10\" fill=\"#fff\" stroke=\"#000\" x=\"20\" width=\"10\" height=\"10\" id=\"svg_2\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"20\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"30\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_4\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape RightWormVertical => new()
            {
                Name = "RightWormVertical",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (-1, 1), (-2, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_7\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_5\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"25\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"25\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_2\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape RightWormHorizontal => new()
            {
                Name = "RightWormHorizontal",
                Points = new List<(int Row, int Column)> { (0, 0), (0, 1), (-1, 0), (-1, -1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_7\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_5\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"25\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"25\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_2\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape HelmetTop => new()
            {
                Name = "HelmetTop",
                Points = new List<(int Row, int Column)> { (0, 0), (0, -1), (0, 1), (1, -1), (1, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_4\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_1\" height=\"10\" width=\"10\" y=\"25\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape HelmetBottom => new()
            {
                Name = "HelmetBottom",
                Points = new List<(int Row, int Column)> { (0, 0), (0, -1), (0, 1), (-1, -1), (-1, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(180, 25, 25)\" id=\"svg_4\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_1\" height=\"10\" width=\"10\" y=\"25\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape HelmetLeft => new()
            {
                Name = "HelmetLeft",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (1, 0), (-1, 1), (1, 1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(-90, 25, 25)\" id=\"svg_4\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_1\" height=\"10\" width=\"10\" y=\"25\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape HelmetRight => new()
            {
                Name = "HelmetRight",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (1, 0), (-1, -1), (1, -1) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_4\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"15\" x=\"20\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"15\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"25\" x=\"10\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_2\" height=\"10\" width=\"10\" y=\"15\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_1\" height=\"10\" width=\"10\" y=\"25\" x=\"30\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape LuigiTop => new()
            {
                Name = "LuigiTop",
                Points = new List<(int Row, int Column)> { (0, 0), (0, -1), (1, 0), (2, 0) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(180, 25, 25)\" id=\"svg_2\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_5\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"25\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_1\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape LuigiBottom => new()
            {
                Name = "LuigiBottom",
                Points = new List<(int Row, int Column)> { (0, 0), (0, 1), (-1, 0), (-2, 0) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_2\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_5\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"25\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_1\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape LuigiLeft => new()
            {
                Name = "LuigiLeft",
                Points = new List<(int Row, int Column)> { (0, 0), (1, 0), (0, 1), (0, 2) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_2\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_5\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"25\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_1\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape LuigiRight => new()
            {
                Name = "LuigiRight",
                Points = new List<(int Row, int Column)> { (0, 0), (0, -1), (0, -2), (-1, 0) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(-90, 25, 25)\" id=\"svg_2\">\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_6\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"10\" width=\"10\" height=\"10\" id=\"svg_5\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"15\" y=\"20\" width=\"10\" height=\"10\" id=\"svg_3\"/>\r\n   <rect fill=\"#fff\" stroke=\"#000\" x=\"25\" y=\"30\" width=\"10\" height=\"10\" id=\"svg_1\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape WaluigiTop => new()
            {
                Name = "WaluigiTop",
                Points = new List<(int Row, int Column)> { (0, 0), (0, 1), (1, 0), (2, 0) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(180, 25, 25)\" id=\"svg_4\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"30\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"10\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"20\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_1\" height=\"10\" width=\"10\" y=\"30\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape WaluigiBottom => new()
            {
                Name = "WaluigiBottom",
                Points = new List<(int Row, int Column)> { (0, 0), (0, -1), (-1, 0), (-2, 0) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g id=\"svg_4\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"30\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"10\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"20\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_1\" height=\"10\" width=\"10\" y=\"30\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape WaluigiLeft => new()
            {
                Name = "WaluigiLeft",
                Points = new List<(int Row, int Column)> { (0, 0), (-1, 0), (0, 1), (0, 2) },
                Icon = "<g>\r\n  <title>Layer 1</title>\r\n  <g transform=\"rotate(90, 25, 25)\" id=\"svg_4\">\r\n   <rect id=\"svg_6\" height=\"10\" width=\"10\" y=\"30\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_5\" height=\"10\" width=\"10\" y=\"10\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_3\" height=\"10\" width=\"10\" y=\"20\" x=\"25\" stroke=\"#000\" fill=\"#fff\"/>\r\n   <rect id=\"svg_1\" height=\"10\" width=\"10\" y=\"30\" x=\"15\" stroke=\"#000\" fill=\"#fff\"/>\r\n  </g>\r\n </g>"
            };

            public static Shape WaluigiRight => new()
            {
                Name = "WaluigiRight",
                Points = new List<(int Row, int Column)> { (0, 0), (1, 0), (0, -1), (0, -2) },
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
