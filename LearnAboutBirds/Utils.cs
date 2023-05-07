namespace LearnAboutBirds
{
    using System;
    using System.Drawing;
    using System.Media;
    using System.Threading.Tasks;

    static public class Utils
    {
        static public SoundPlayer sp;

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

        static public Point PositionDataGrid(System.Windows.Forms.UserControl form)
        {
            return new Point
                (
                    Convert.ToInt32(form.Width * 0.55),
                    50
                );
        }

        static public void PlaySound(string path, bool looping = false)
        {
            sp = new SoundPlayer(path);
            Task.Run( () => 
            {
                if (looping)
                    sp.PlayLooping();
                else
                    sp.Play();
            });
        }

        static public void StopSound()
        {
            if (! (sp is null) )
                sp.Stop();
        }

        static public int CalculateBirdSize(int count)
        {
            float usableArea = (Program.main.Width * Program.main.Height) *0.35f;
            float areaOfOneBird = usableArea / (float)count;

            int w = Convert.ToInt32(Math.Sqrt(areaOfOneBird));

            return (w);
        }
    }
}
