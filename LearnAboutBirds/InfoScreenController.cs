namespace LearnAboutBirds
{
    using System;
    using System.IO;

    public class InfoScreenController
    {
        private InfoScreen view;

        public InfoScreenController(InfoScreen view)
        {
            this.view = view;
        }

        public void LoadImages()
        {
            BirdSet data = new BirdSet(Path.Combine(Environment.CurrentDirectory,"sources","birds_sample.csv"));

            if (!data.LoadBirdsFromCSV())
                throw new Exception($"Hiba a madarak betöltése közben a CSV fájlban. {data.CSVPath}");

            int width = 0;
            width = Utils.CalculateBirdSize(data.Birds.Count);

            int i = 0;
            foreach (Bird item in data.Birds)
            {
                BirdInfo tmp = new BirdInfo(item, width);
                tmp.Parent = this.view.DataPanel;
                this.view.DataPanel.Controls.Add(tmp);
                this.view.DataPanel.Controls.SetChildIndex(tmp, i++);
            }
        }

        public void LoadGame()
        {
            this.view.Controls.Clear();
            this.view.Controls.Add(new GameScreen());
        }
    }
}
