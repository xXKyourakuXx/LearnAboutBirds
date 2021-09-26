namespace LearnAboutBirds
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class InfoScreen : UserControl
    {
        private readonly InfoScreenController controller;

        public FlowLayoutPanel DataPanel { get { return this.datagrid; } }

        public InfoScreen()
        {
            InitializeComponent();
            
            this.controller = new InfoScreenController(this);

            this.datagrid.Size = new Size(
                    Convert.ToInt32(Program.main.Width * 0.55),
                    Convert.ToInt32(Program.main.Height * 0.9)
                );

            


            try
            {
                this.SuspendLayout();
                this.BackgroundImage = null;
                this.controller.LoadImages();
                this.datagrid.Location = Utils.PositionDataGrid(this);
                this.BackgroundImage = Utils.AlterTransparency(Properties.Resources.background, 110);
                this.ResumeLayout(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        private void InfoScreen_Load(object sender, EventArgs e)
            => this.Dock = DockStyle.Fill;

        private void buttonToGame_Click(object sender, EventArgs e)
            => this.controller.LoadGame();
    }
}
