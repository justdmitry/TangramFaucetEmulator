namespace SquaresRemover
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;

    public class SquaresCleaner
    {
        private readonly Bitmap source;

        private byte[,] processed;

        public SquaresCleaner(Bitmap source)
        {
            this.source = source;
        }

        public enum CleanMode : byte
        {
            NotBlack,
            Hue,
        }

        public Bitmap Clean(CleanMode cleanMode)
        {
            var newBitmap = new Bitmap(source.Width, source.Height);
            processed = new byte[source.Width, source.Height];

            for (var x = 0; x < source.Width; x++)
            {
                for (var y = 0; y < source.Height; y++)
                {
                    if (processed[x, y] == 1)
                    {
                        continue;
                    }

                    var p = source.GetPixel(x, y);

                    if (IsBlack(p))
                    {
                        newBitmap.SetPixel(x, y, Color.Black);
                        processed[x, y] = 1;
                        continue;
                    }

                    ExploreArea(source, newBitmap, x, y, cleanMode);
                }
            }

            return newBitmap;
        }

        public bool IsBlack(Color pixel)
        {
            return pixel.GetBrightness() < 0.2;
        }

        public void ExploreArea(Bitmap source, Bitmap newBitmap, int x, int y, CleanMode cleanMode)
        {
            var area = new List<(int, int, Color)>();

            area.Add((x, y, source.GetPixel(x, y)));
            processed[x, y] = 1;
            ExploreAround(source, area, x, y, cleanMode);

            area = area.OrderBy(z => z.Item1).ThenBy(z => z.Item2).ToList();

            var minX = area.Min(z => z.Item1);
            var maxX = area.Max(z => z.Item1);
            var minY = area.Min(z => z.Item2);
            var maxY = area.Max(z => z.Item2);

            var areaPixels = (maxX - minX + 1) * (maxY - minY + 1);
            var colorPixels = area.Count;

            var isSquare = (colorPixels * 100 / areaPixels) > 80
                && (maxX - minX) > 5
                && (maxY - minY) > 5;

            foreach (var item in area)
            {
                newBitmap.SetPixel(item.Item1, item.Item2, isSquare ? Color.Black : item.Item3);
            }
        }

        public void ExploreAround(Bitmap source, List<(int, int, Color)> data, int x, int y, CleanMode cleanMode)
        {
            var around = new[] { (-1, 0), (1, 0), (0, -1), (0, 1) };
            foreach (var pair in around)
            {
                var newX = x + pair.Item1;
                var newY = y + pair.Item2;

                if (newX < 0 || newY < 0 || newX >= source.Width || newY >= source.Height)
                {
                    continue;
                }

                if (processed[newX, newY] == 1)
                {
                    continue;
                }

                var p = source.GetPixel(newX, newY);

                if (IsBlack(p))
                {
                    continue;
                }

                switch (cleanMode)
                {
                    case CleanMode.NotBlack:
                        data.Add((newX, newY, p));
                        processed[newX, newY] = 1;
                        ExploreAround(source, data, newX, newY, cleanMode);

                        break;
                    case CleanMode.Hue:
                        var oldP = source.GetPixel(x, y);
                        var delta = Math.Abs(p.GetHue() - oldP.GetHue());
                        if (delta < 15)
                        {
                            data.Add((newX, newY, p));
                            processed[newX, newY] = 1;
                            ExploreAround(source, data, newX, newY, cleanMode);
                        }

                        break;
                }
            }
        }
    }
}
