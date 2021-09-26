namespace LearnAboutBirds
{
    public class MainFrameController
    {
        private MainFrame view;

        public MainFrameController(MainFrame view)
        {
            this.view = view;
        }

        public void LoadInfoScreen()
        {
            this.view.Controls.Clear();
            this.view.Controls.Add(new InfoScreen());
        }
    }
}
