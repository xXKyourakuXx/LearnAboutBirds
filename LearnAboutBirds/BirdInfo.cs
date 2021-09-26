namespace LearnAboutBirds
{
    using System.Drawing;
    using System.Media;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class BirdInfo : UserControl
    {
        private string soundLocation;
        private bool currentlyPlayingSound;
        private SoundPlayer sp;
        private Bird bird;
        private Bird correctAnswer;
        private bool isInGame;

        public Bird Bird { get { return this.bird; } }

        public BirdInfo(Bird bird, bool isInGame = false, Bird correctAnswer = null)
        {
            InitializeComponent();

            this.bird = bird;
            this.isInGame = isInGame;
            this.correctAnswer = correctAnswer;

            this.SuspendLayout();
            this.Width = 250;
            this.Height = 300;
            this.labelName.Text = bird.Name;
            this.pictureBoxImage.Image = Bitmap.FromFile(bird.ImageLocation);
            this.soundLocation = bird.SoundLocation;
            this.currentlyPlayingSound = false;
            this.ResumeLayout();

            this.sp = new SoundPlayer(this.soundLocation);
        }

        private void BirdInfo_Load(object sender, System.EventArgs e)
            => this.Dock = DockStyle.Fill;

        private void pictureBoxImage_Click(object sender, System.EventArgs e)
        {
            if(!this.isInGame)
            {
                if (this.currentlyPlayingSound)
                {
                    this.currentlyPlayingSound = !this.currentlyPlayingSound;
                    sp.Stop();
                }
                else
                {
                    this.currentlyPlayingSound = !this.currentlyPlayingSound;
                    sp.PlayLooping();
                }
            }
            else
            {
                if (this.correctAnswer == this.bird)
                {
                    this.pictureBoxImage.Image = Properties.Resources.correct;

                    Utils.StopSound();
                }
                else
                    this.pictureBoxImage.Image = Properties.Resources.error;

                this.pictureBoxImage.Refresh();
                
                var cursor = Program.main.Cursor;
                Program.main.Cursor = Cursors.WaitCursor;
                Thread.Sleep(700);
                Program.main.Cursor = cursor;
                
                this.pictureBoxImage.Image = Image.FromFile(this.bird.ImageLocation);
            }
        }

        private void BirdInfo_Leave(object sender, System.EventArgs e)
            => sp.Stop();
    }
}
