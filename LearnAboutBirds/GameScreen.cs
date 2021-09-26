namespace LearnAboutBirds
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class GameScreen : UserControl
    {
        private readonly GameScreenController controller;

        public TableLayoutPanel DataPanel { get { return this.datagrid; } }

        public GameScreen()
        {
            InitializeComponent();

            this.controller = new GameScreenController(this);

            try
            {
                this.buttonRestart_Click(this, EventArgs.Empty);
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
                int width = Convert.ToInt32(this.Width * 0.6);
                int height = Convert.ToInt32(this.Height * 0.6);
                this.datagrid.Size = new Size(width, height);
                this.BackgroundImage = null;
                this.controller.LoadRandomImages(3);
                this.datagrid.Location = Utils.ResizeDataGrid(this, datagrid);
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
