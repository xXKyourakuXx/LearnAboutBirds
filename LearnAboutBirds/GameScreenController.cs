namespace LearnAboutBirds
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class GameScreenController
    {
        private GameScreen view;
        private IList<Bird> randomList;
        private int randomSoundIndex;
        private int correctAnswers;
        private int incorrectAnswers;
        private int round;

        public int Round { get; }
        public GameScreenController(GameScreen view)
        {
            this.view = view;
            this.randomSoundIndex = 0;
            this.round = 0;
            this.correctAnswers = this.incorrectAnswers = 0;
        }

        public void LoadRandomImages(int count)
        {
            this.round++;

            int fontSize = Convert.ToInt32(Program.main.Width * 0.0116);

            BirdSet data = new BirdSet(Path.Combine(Environment.CurrentDirectory, "sources", "birds_sample.csv"));

            if (!data.LoadBirdsFromCSV())
                throw new Exception($"Hiba a madarak betöltése közben a CSV fájlban. {data.CSVPath}");

            this.randomList = data.GetRandomBirds(count, this.view.GameLevel);
            
            // generate a soundindex of the random list
            randomSoundIndex = new Random().Next(0, count);
            Bird b = this.randomList[randomSoundIndex];

            int width = 0;
            width = Utils.CalculateBirdSize(count);

            this.view.DataPanel.Controls.Clear();
            foreach (Bird item in this.randomList)
                this.view.DataPanel.Controls.Add(new BirdInfo(item, width, this, true, b, fontSize));

            // start playing sound until the user clicks on a bird's image, then the Utils.StopSound() is called
            Utils.PlaySound(this.randomList[randomSoundIndex].SoundLocation, true);
        }

        public void LoadInfoScreen()
        {
            Utils.StopSound();
            this.correctAnswers = this.incorrectAnswers = 0;
            this.view.Controls.Clear();
            this.view.Controls.Add(new InfoScreen());
        }

        public void PauseGame()
        {
            Utils.StopSound();
        }

        public void ResumeGame()
        {
            Utils.sp.PlayLooping();
        }
        public void CorrectAnswer()
        {
            this.correctAnswers++;

            this.view.DataPanel.Enabled = false;

            if (this.round < Properties.Settings.Default.NumberOfRounds)
            {
                this.view.DataPanel.Enabled = true;
                this.view.NextTurn();
            }
            else
            {
                this.ResetGameState();
                this.view.ShowEndGame();
            }
        }
        public void IncorrectAnswer()
        {
            this.incorrectAnswers++;

            this.view.DataPanel.Enabled = false;

            if (this.round < Properties.Settings.Default.NumberOfRounds)
            {
                this.view.DataPanel.Enabled = true;
                this.view.NextTurn();
            }
            else
            {
                this.ResetGameState();
                this.view.ShowEndGame();
            }
        }
        public void ResetGameState()
        {
            this.round = 0;
            this.correctAnswers = 0;
            this.incorrectAnswers = 0;
        }
    }
}
