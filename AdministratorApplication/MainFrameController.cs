namespace AdministratorApplication
{
    using LearnAboutBirds;
    using System;
    using System.IO;

    public class MainFrameController
    {
        private MainFrame view;

        public MainFrameController(MainFrame view)
        {
            this.view = view;
        }

        public void LoadBirds()
        {
            BirdSet data = new BirdSet(Path.Combine(Environment.CurrentDirectory, "sources", "birds_sample.csv"));

            if (!data.LoadBirdsFromCSV())
                throw new Exception($"Hiba a madarak betöltése közben a CSV fájlban. {data.CSVPath}");

            int i = 0;
            foreach (Bird item in data.Birds)
            {
                AdminBirdInfo tmp = new AdminBirdInfo (item, 150, this.view);
                tmp.Parent = this.view.DataPanel;
                
                this.view.DataPanel.Controls.Add(tmp);
                this.view.DataPanel.Controls.SetChildIndex(tmp, i++);
            }
        }
    }
}
