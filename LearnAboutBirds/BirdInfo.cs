namespace LearnAboutBirds
{
    using System.Drawing;
    using System.Media;
    using System.Windows.Forms;

    public partial class BirdInfo : UserControl
    {
        private string soundLocation;
        private bool currentlyPlayingSound;
        private SoundPlayer sp;

        public BirdInfo(Bird bird)
        {
            InitializeComponent();
            
            this.SuspendLayout();
            this.Width = 250;
            this.Height = 300;
            this.labelName.Text = bird.Name;
            this.pictureBoxImage.Image = Bitmap.FromFile(bird.ImageLocation);
            this.soundLocation = bird.SoundLocation;
            this.currentlyPlayingSound = false;
            this.sp = new SoundPlayer(this.soundLocation);
            this.ResumeLayout();
        }

        private void BirdInfo_Load(object sender, System.EventArgs e)
            => this.Dock = DockStyle.Fill;

        private void pictureBoxImage_Click(object sender, System.EventArgs e)
        {
            if(this.currentlyPlayingSound)
            {
                this.currentlyPlayingSound = ! this.currentlyPlayingSound;
                sp.Stop();
            }
            else
            {
                this.currentlyPlayingSound = !this.currentlyPlayingSound;
                sp.PlayLooping();
            }
        }
    }
}
