namespace LearnAboutBirds
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    static public class DataLoader
    {
        static public IList<Bird> LoadFromCSV(string path = "")
        {
            IList<Bird> birds = new List<Bird>();

            if (path == string.Empty)
                path = Path.Combine(Environment.CurrentDirectory, "birds_sample.csv");

            using (FileStream f = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
            using (StreamReader r = new StreamReader(f, Encoding.Default))
            {
                while (!r.EndOfStream)
                {
                    string[] line = r.ReadLine().Split(';');

                    string name, soundPath, imagePath;
                    int level;
                    List<string> incompatibleWith;

                    name = line[0];
                    soundPath = line[1];
                    imagePath = line[2];
                    level = Convert.ToInt32(line[3]);
                    incompatibleWith = line[4].Split(',').ToList<string>();

                    birds.Add(new Bird(name, soundPath, imagePath, level, incompatibleWith));
                }
            }

            return birds;
        }
    }
}
