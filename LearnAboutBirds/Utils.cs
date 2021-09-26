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

        static public Point ResizeDataGrid(System.Windows.Forms.UserControl form, System.Windows.Forms.TableLayoutPanel datagrid)
        {
            return new Point
                (
                    Convert.ToInt32((form.Width - datagrid.Width) / 2.0),
                    Convert.ToInt32((form.Height - datagrid.Height) / 2.0)
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
    }
}
