namespace LearnAboutBirds
{
    using System;
    using System.Windows.Forms;

    public partial class MainFrame : Form
    {
        private readonly MainFrameController controller;

        public MainFrame()
        {
            InitializeComponent();
            this.Icon = LearnAboutBirds.Properties.Resources.icon;
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = SystemInformation.VirtualScreen.Size;

            this.controller = new MainFrameController(this);
        }

        private void MainFrame_Load(object sender, EventArgs e)
            => this.controller.LoadInfoScreen();
    }
}
