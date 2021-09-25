using System;
using System.Drawing;
using System.Windows.Forms;

namespace LearnAboutBirds
{
    public partial class MainFrame : Form
    {
        private readonly MainFrameController controller;
        public TableLayoutPanel DataPanel { get { return this.datagrid; } }

        public MainFrame()
        {
            InitializeComponent();
            this.Icon = LearnAboutBirds.Properties.Resources.icon;
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = SystemInformation.VirtualScreen.Size;

            this.controller = new MainFrameController(this);

            int width = Convert.ToInt32(this.Width * 0.6);
            int height = Convert.ToInt32(this.Height * 0.6);
            this.datagrid.Size = new Size(width, height);

            try
            {
                this.controller.LoadImages();
                this.ResizeDataGrid();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.BackgroundImage = Utils.AlterTransparency(this.BackgroundImage, 110);
        }

        private void ResizeDataGrid()
        {
            this.datagrid.Location = new Point
                (
                    Convert.ToInt32((this.Width - this.datagrid.Width) / 2.0),
                    Convert.ToInt32((this.Height - this.datagrid.Height) / 2.0)
                );
        }
    }
}
