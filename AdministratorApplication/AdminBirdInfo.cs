namespace AdministratorApplication
{
    using LearnAboutBirds;
    using System.Drawing;
    using System.Windows.Forms;

    public partial class AdminBirdInfo : UserControl
    {
        private Bird bird;
        private MainFrame form;

        public Bird Bird { get { return this.bird; } }

        public AdminBirdInfo(Bird bird, int size, MainFrame form)
        {
            InitializeComponent();
            
            this.bird = bird;
            this.form = form;
            
            this.SuspendLayout();
            this.Width = size;
            this.Height = size;
            this.labelName.Text = bird.Name;
            this.pictureBoxImage.Image = Bitmap.FromFile(bird.ImageLocation);
            this.ResumeLayout();
        }

        private void pictureBoxImage_Click(object sender, System.EventArgs e)
            => form.UpdateBird(this.bird);

        private void labelName_Click(object sender, System.EventArgs e)
            => pictureBoxImage_Click(sender, e);

        private void AdminBirdInfo_Click(object sender, System.EventArgs e)
            => pictureBoxImage_Click(sender, e);

        private void panelName_Click(object sender, System.EventArgs e)
            => pictureBoxImage_Click(sender, e);
    }
}
