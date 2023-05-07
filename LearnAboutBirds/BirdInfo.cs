namespace LearnAboutBirds
{
    using System.Drawing;
    using System.Media;
    using System.Threading;
    using System.Windows.Forms;

    public partial class BirdInfo : UserControl
    {
        private readonly GameScreenController controller;
        private string soundLocation;
        private bool currentlyPlayingSound;
        private SoundPlayer sp;
        private Bird bird;
        private Bird correctAnswer;
        private bool isInGame;
        private float ratio;
        private int fontSize;

        public Bird Bird { get { return this.bird; } }
        public int FontSize 
        { 
            get { return this.fontSize; } 
            set 
            {
                this.labelName.Font = new Font(this.labelName.Font.FontFamily, value); 
                this.fontSize = value;
            } 
        }

        public BirdInfo(Bird bird, int width, GameScreenController controller = null, bool isInGame = false, Bird correctAnswer = null, int fontSize = 0)
        {
            InitializeComponent();
            this.controller = controller;
            this.bird = bird;
            this.isInGame = isInGame;
            this.correctAnswer = correctAnswer;
            ratio = isInGame ? Properties.Settings.Default.BirdInGameRatio : 1;
            this.SuspendLayout();
            this.Width = System.Convert.ToInt32(width * ratio);
            this.Height = width;
            this.labelName.Text = bird.Name;
            if (fontSize != 0)
                this.labelName.Font = new Font(this.labelName.Font.FontFamily, fontSize);
            this.pictureBoxImage.Image = Bitmap.FromFile(bird.ImageLocation);
            this.soundLocation = bird.SoundLocation;
            this.currentlyPlayingSound = false;
            this.ResumeLayout();

            this.sp = new SoundPlayer(this.soundLocation);
        }

        private void pictureBoxImage_Click(object sender, System.EventArgs e)
        {
            if (!this.isInGame)
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
                this.pictureBoxImage.Click -= pictureBoxImage_Click;
                var cursor = Program.main.Cursor;

                if (this.correctAnswer == this.bird)
                {
                    this.pictureBoxImage.Image = Properties.Resources.correct;
                    Utils.StopSound();

                    this.pictureBoxImage.Refresh();

                    Program.main.Cursor = Cursors.WaitCursor;
                    Thread.Sleep(700);
                    Program.main.Cursor = cursor;

                    this.controller.CorrectAnswer();
                }
                else
                {
                    this.pictureBoxImage.Image = Properties.Resources.error;
                    Utils.StopSound();

                    this.pictureBoxImage.Refresh();

                    Program.main.Cursor = Cursors.WaitCursor;
                    Thread.Sleep(700);
                    Program.main.Cursor = cursor;

                    this.controller.IncorrectAnswer();
                }
            }
        }

        private void BirdInfo_Leave(object sender, System.EventArgs e)
        {
            sp.Stop();
            Utils.StopSound();
        }
    }
}
