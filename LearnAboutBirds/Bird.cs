namespace LearnAboutBirds
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    public class Bird
	{
		public string Name{get;set;}
		public string SoundLocation{get;set;}
		public string ImageLocation{get;set;}
		/*
		 * <summary>If this property is equal to 1, 
		 * then it is in the game, otherwise, it appears only in the information window.</summary>
		 */ 
		public int Level{get;set;}
		public IList<string> IncompatibleWithOtherBirds { get; set; }

		public Bird() : this("Ismeretlen") {}
		public Bird(string name)
		{
			this.Name = name;
			this.SoundLocation = Path.Combine(Environment.CurrentDirectory, "sources", $"{this.Name}.wav");
			this.ImageLocation = Path.Combine(Environment.CurrentDirectory, "sources", $"{this.Name}.png");
			this.Level = 1;
			this.IncompatibleWithOtherBirds = null;
		}
		public Bird(string name, string soundLocation, string imageLocation, int level = 1, IList<string> incompat = null)
		{
			this.Name = name;
			
			if(soundLocation == string.Empty)
				soundLocation = Path.Combine(Environment.CurrentDirectory, "sources", $"{this.Name}.wav");
			this.SoundLocation = soundLocation;

			if (imageLocation == string.Empty)
				imageLocation = Path.Combine(Environment.CurrentDirectory, "sources", $"{this.Name}.png");
			this.ImageLocation = imageLocation;

			this.Level = level;
			this.IncompatibleWithOtherBirds = incompat;
		}

		public Bird(Bird bird)
		{
            this.Name = bird.Name;
            this.Level = bird.Level;
            this.SoundLocation = bird.SoundLocation;
            this.ImageLocation = bird.ImageLocation;
            this.IncompatibleWithOtherBirds = bird.IncompatibleWithOtherBirds;
		}

        public override string ToString()
        {
			if (this.IncompatibleWithOtherBirds is null)
				this.IncompatibleWithOtherBirds = new List<string>();

			StringBuilder b = new StringBuilder($"{this.Name};{this.SoundLocation};{this.ImageLocation};{this.Level};{string.Join(",", this.IncompatibleWithOtherBirds)}");

			return b.ToString();
        }
    }
}
