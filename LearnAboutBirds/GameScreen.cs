namespace LearnAboutBirds
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class GameScreen : UserControl
    {
        private readonly GameScreenController controller;

        public FlowLayoutPanel DataPanel { get { return this.datagrid; } }

        public int GameLevel { get; set; }
        public bool Paused { get; set; }

        public GameScreen()
        {
            InitializeComponent();

            this.controller = new GameScreenController(this);

            this.datagrid.Size = new Size(
                    Convert.ToInt32(Program.main.Width * 0.55),
                    Convert.ToInt32(Program.main.Height * 0.9)
                );
            
            this.GameLevel = 1;
            this.Paused = false;
            this.buttonStartStop.BackgroundImage = LearnAboutBirds.Properties.Resources.stop;

            try
            {
                this.buttonRestart_Click(this, EventArgs.Empty);
                this.datagrid.Location = Utils.PositionDataGrid(this);
                this.buttonRestart.Visible = false;
                this.buttonToInfo.BringToFront();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GameScreen_Load(object sender, EventArgs e)
            => this.Dock = DockStyle.Fill;

        private void buttonToInfo_Click(object sender, EventArgs e)
            => this.controller.LoadInfoScreen();

        // to disable flickering when loading images
        // source: https://www.codeproject.com/Tips/112132/Flicker-free-Form-Painting
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            try
            {
                this.SuspendLayout();
                
                this.BackgroundImage = null;
                this.controller.LoadRandomImages(Properties.Settings.Default.NumberOfBirds);
                this.BackgroundImage = Utils.AlterTransparency(Properties.Resources.gameBackground, 140);
                this.buttonStartStop.BackgroundImage = LearnAboutBirds.Properties.Resources.stop;
                this.buttonStartStop.Enabled = true;
                this.buttonRestart.Visible = false;
                
                this.ResumeLayout(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLevel1_Click(object sender, EventArgs e)
        {
            this.GameLevel = 1;
            this.ResetGame();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.GameLevel = 2;
            this.ResetGame();
        }

        private void ResetGame()
        {
            this.buttonRestart.Visible = false;
            this.datagrid.Enabled = true;

            if (this.GameLevel == 1)
            {
                this.buttonLevel1.BackColor = Color.Teal;
                this.buttonLevel1.ForeColor = Color.White;
                this.buttonLevel2.BackColor = Color.Red;
                this.buttonLevel1.Enabled = false;
                this.buttonLevel2.Enabled = true;
            }
            else
            {
                this.buttonLevel1.BackColor = Color.PaleTurquoise;
                this.buttonLevel1.ForeColor = Color.Black;
                this.buttonLevel2.BackColor = Color.DarkRed;
                this.buttonLevel2.Enabled = false;
                this.buttonLevel1.Enabled = true;
            }
            this.controller.ResetGameState();
            this.buttonRestart_Click(this, EventArgs.Empty);
            this.Paused = false;
            this.buttonStartStop.BackgroundImage = LearnAboutBirds.Properties.Resources.stop;
            this.controller.ResumeGame();
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            this.Paused = !this.Paused;
            if (this.Paused)
            {       
                this.buttonStartStop.BackgroundImage = LearnAboutBirds.Properties.Resources.play;
                this.controller.PauseGame();
            }
            else
            {
                this.buttonStartStop.BackgroundImage = LearnAboutBirds.Properties.Resources.stop;
                this.controller.ResumeGame();
            }
        }

        public void NextTurn()
        {
            this.Paused = false;
            this.buttonStartStop.BackgroundImage = LearnAboutBirds.Properties.Resources.stop;
            this.buttonRestart_Click(this, EventArgs.Empty);
            this.controller.ResumeGame();
        }

        public async void ShowEndGame()
        {
            this.datagrid.Enabled = false;
            this.datagrid.BringToFront();

            buttonStartStop_Click(this, EventArgs.Empty);
            this.buttonStartStop.Enabled = false;

            Utils.StopSound();

            PictureBox p = new PictureBox();
            p.Name = "Win";
            p.Width = 700;
            p.Height = 700;
            p.BackColor = Color.Transparent;
            p.SizeMode = PictureBoxSizeMode.StretchImage;
            p.Image = Properties.Resources.like;
            p.Left = Convert.ToInt32((this.Width - p.Width) / 2.0);
            p.Top = Convert.ToInt32((this.Height - p.Height) / 2.0);

            this.Controls.Add(p);
            this.Controls["Win"].BringToFront();

            await System.Threading.Tasks.Task.Delay(2000);
            this.Controls.Remove(this.Controls["Win"]);
            p.Dispose();
            
            this.buttonRestart.Visible = true;
        }
    }
}
