namespace LearnAboutBirds
{
    using System.Drawing;

    static public class Utils
    {
        static public Bitmap AlterTransparency(Image image, byte alpha)
        {
            Bitmap original = new Bitmap(image);
            Bitmap transparent = new Bitmap(image.Width, image.Height);

            Color c = Color.Black;
            Color v = Color.Black;

            for (int i = 0; i < image.Width; i++)
            {
                for (int j = 0; j < image.Height; j++)
                {
                    c = original.GetPixel(i, j);
                    v = Color.FromArgb(alpha, c.R, c.G, c.B);
                    transparent.SetPixel(i, j, v);
                }
            }

            return transparent;
        }
    }
}
