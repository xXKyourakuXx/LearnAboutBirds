namespace LearnAboutBirds
{
    using System;
    using System.Collections.Generic;
	using System.Linq;

    public class BirdSet
	{
		public BirdSet(string CSVpath) { this.CSVpath = CSVpath; }
	
		private string CSVpath;
		private IList<Bird> birds;
	
		public string CSVPath 
		{ 
			get { return this.CSVpath; } 
			set { this.CSVpath = value; } 
		}
		public IList<Bird> Birds 
		{ 
			get { return this.birds; } 
			set { this.birds = value; } 
		}
	
		public bool LoadBirdsFromCSV()
		{
			this.birds = DataLoader.LoadFromCSV(this.CSVpath);
			return !(this.birds == null || this.birds.Count == 0);
		}

		public IList<Bird> GetRandomBirds(int size, int level = 1)
		{
			Random r = new Random();

			List<Bird> baseBirds = this.birds.Where(x => x.Level <= level).ToList<Bird>();
			List<Bird> outList = new List<Bird>();

			int count = 0;
			while(count < size && baseBirds.Count > 0)
            {
				// generate a bird
				Bird chosen = baseBirds[r.Next(0, baseBirds.Count)];

				// filter the incompatible birds from baseBirds
				foreach (string name in chosen.IncompatibleWithOtherBirds)
					baseBirds = baseBirds.Where(x => !x.Name.Equals(name)).ToList();

				outList.Add(chosen);
				baseBirds.Remove(chosen);
				count++;
			}

			return outList;
		}

        public override string ToString()
            => string.Join("\n", this.birds);
    }
}