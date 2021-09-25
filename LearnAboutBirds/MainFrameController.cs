namespace LearnAboutBirds
{
    using System;
    using System.IO;

    public class MainFrameController
    {
        private MainFrame view;

        public MainFrameController(MainFrame view)
        {
            this.view = view;
        }

        public void LoadImages()
        {
            BirdSet data = new BirdSet(Path.Combine(Environment.CurrentDirectory,"sources","birds_sample.csv"));

            if (!data.LoadBirdsFromCSV())
                throw new Exception($"Hiba a madarak betöltése közben a CSV fájlban. {data.CSVPath}");

            foreach (Bird item in data.Birds)
            {
                this.view.DataPanel.Controls.Add
                    (
                        new BirdInfo(item), 
                        this.view.DataPanel.ColumnStyles.Count-1,
                        this.view.DataPanel.RowStyles.Count-1
                    );
                
                if (this.view.DataPanel.Width >= this.view.Width*0.6)
                {
                    this.view.DataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.AutoSize));
                    this.view.DataPanel.RowCount++;
                }
            }                
        }
    }
}
