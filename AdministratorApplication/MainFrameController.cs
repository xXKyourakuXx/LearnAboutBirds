namespace AdministratorApplication
{
    using LearnAboutBirds;
    using System;
    using System.IO;
    using System.Text;
    using System.Linq;

    public class MainFrameController
    {
        private MainFrame view;
        private BirdSet data;

        public MainFrameController(MainFrame view)
        {
            this.view = view;
        }

        public void LoadBirds()
        {
            this.data = new BirdSet(Path.Combine(Environment.CurrentDirectory, "sources", "birds_sample.csv"));

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

        private void UpdateCSV()
        {
            string path = Path.Combine(Environment.CurrentDirectory, "sources", "birds_sample.csv");
            
            if (File.Exists(path))
                File.Delete(path);

            using (FileStream f = new FileStream(path, FileMode.Create, FileAccess.Write, FileShare.Write))
            using (StreamWriter w = new StreamWriter(f, Encoding.Default))
                foreach (Bird b in this.data.Birds)
                    w.WriteLine(b);
        }

        public void SaveBirds(Bird bird)
        {
            // find the bird with the same name
            Bird tmp = this.data.Birds.Where(x => x.Name.Equals(bird.Name)).FirstOrDefault();
            // remove it
            if( ! (tmp is null) )
                this.data.Birds.Remove(tmp);

            this.data.Birds.Add(bird);
            
            this.UpdateCSV();
        }
    }
}
