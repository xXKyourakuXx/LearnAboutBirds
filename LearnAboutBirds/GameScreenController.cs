namespace LearnAboutBirds
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class GameScreenController
    {
        private GameScreen view;
        private IList<Bird> randomList;

        public GameScreenController(GameScreen view)
        {
            this.view = view;
        }

        public void LoadRandomImages(int count)
        {
            int fontSize = Convert.ToInt32(Program.main.Width * 0.0116);

            BirdSet data = new BirdSet(Path.Combine(Environment.CurrentDirectory, "sources", "birds_sample.csv"));

            if (!data.LoadBirdsFromCSV())
                throw new Exception($"Hiba a madarak betöltése közben a CSV fájlban. {data.CSVPath}");

            this.randomList = data.GetRandomBirds(count);
            
            // generate a soundindex of the random list
            int randomSoundIndex = new Random().Next(0, count);
            Bird b = this.randomList[randomSoundIndex];

            int width = 0;
            width = Utils.CalculateBirdSize(count);

            this.view.DataPanel.Controls.Clear();
            foreach (Bird item in this.randomList)
                this.view.DataPanel.Controls.Add(new BirdInfo(item, width, true, b, fontSize));

            // start playing sound until the user clicks on a bird's image, then the Utils.StopSound() is called
            Utils.PlaySound(this.randomList[randomSoundIndex].SoundLocation, true);
        }

        public void LoadInfoScreen()
        {
            Utils.StopSound();
            this.view.Controls.Clear();
            this.view.Controls.Add(new InfoScreen());
        }
    }
}
