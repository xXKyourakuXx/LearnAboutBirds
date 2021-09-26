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
            BirdSet data = new BirdSet(Path.Combine(Environment.CurrentDirectory, "sources", "birds_sample.csv"));

            if (!data.LoadBirdsFromCSV())
                throw new Exception($"Hiba a madarak betöltése közben a CSV fájlban. {data.CSVPath}");

            this.view.DataPanel.Controls.Clear();
            
            this.view.DataPanel.ColumnStyles.Clear();
            this.view.DataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.AutoSize));

            this.view.DataPanel.RowStyles.Clear();
            this.view.DataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));

            this.randomList = data.GetRandomBirds(count);
            
            // generate a soundindex of the random list
            int randomSoundIndex = new Random().Next(0, count);
            Bird b = this.randomList[randomSoundIndex];

            foreach (Bird item in this.randomList )
            {
                this.view.DataPanel.Controls.Add
                    (
                        new BirdInfo(item, true, b),
                        this.view.DataPanel.ColumnStyles.Count - 1,
                        this.view.DataPanel.RowStyles.Count - 1
                    );

                if (this.view.DataPanel.Width > this.view.Width * 0.6)
                {
                    this.view.DataPanel.RowCount++;
                    this.view.DataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
                }
            }

            // start playing sound until the user clicks on a bird's image, then the Utils.StopSound() is called
            Utils.PlaySound(this.randomList[randomSoundIndex].SoundLocation, true);
        }

        public void LoadInfoScreen()
        {
            this.view.Controls.Clear();
            this.view.Controls.Add(new InfoScreen());
        }
    }
}
