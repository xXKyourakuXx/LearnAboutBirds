namespace LearnAboutBirds
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    public partial class InfoScreen : UserControl
    {
        private readonly InfoScreenController controller;

        public TableLayoutPanel DataPanel { get { return this.datagrid; } }

        public InfoScreen()
        {
            InitializeComponent();
            this.controller = new InfoScreenController(this);

            int width = Convert.ToInt32(this.Width * 0.6);
            int height = Convert.ToInt32(this.Height * 0.6);
            this.datagrid.Size = new Size(width, height);

            try
            {
                this.SuspendLayout();
                this.BackgroundImage = null;
                this.controller.LoadImages();
                this.datagrid.Location = Utils.ResizeDataGrid(this, datagrid);
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
