namespace LearnAboutBirds
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class GameScreen : UserControl
    {
        private readonly GameScreenController controller;

        public FlowLayoutPanel DataPanel { get { return this.datagrid; } }

        public GameScreen()
        {
            InitializeComponent();

            this.controller = new GameScreenController(this);

            this.datagrid.Size = new Size(
                    Convert.ToInt32(Program.main.Width * 0.55),
                    Convert.ToInt32(Program.main.Height * 0.9)
                );

            try
            {
                this.buttonRestart_Click(this, EventArgs.Empty);
                this.datagrid.Location = Utils.PositionDataGrid(this);
                this.buttonRestart.BringToFront();
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
                this.buttonRestart.Enabled = false;
                this.BackgroundImage = null;
                this.controller.LoadRandomImages(Properties.Settings.Default.NumberOfBirds);
                this.BackgroundImage = Utils.AlterTransparency(Properties.Resources.gameBackground, 140);
                this.buttonRestart.Enabled = true;
                this.ResumeLayout(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
