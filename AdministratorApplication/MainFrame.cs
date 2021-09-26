namespace AdministratorApplication
{
    using LearnAboutBirds;
    using System;
    using System.Windows.Forms;

    public partial class MainFrame : Form
    {
        private readonly MainFrameController controller;

        public FlowLayoutPanel DataPanel { get { return this.flowLayoutPanelLeft; } }

        public MainFrame()
        {
            InitializeComponent();
            this.controller = new MainFrameController(this);
            this.Icon = Properties.Resources.icon;
        }

        private void MainFrame_Load(object sender, EventArgs e)
            => this.controller.LoadBirds();

        private void buttonBrowseSound_Click(object sender, EventArgs e)
            => this.BrowseSoundFile();

        private void buttonBrowseImage_Click(object sender, EventArgs e)
            => this.BrowseImageFile();

        private void BrowseSoundFile()
        {
            this.openFile.Filter = "Hangfájlok |*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV";
            this.openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.openFile.CheckFileExists = true;
            this.openFile.Multiselect = false;
            this.openFile.Title = "Kérem, válassza ki a hangfájlt";
            if(this.openFile.ShowDialog().Equals(DialogResult.OK))
                this.textBoxSoundLocation.Text = this.openFile.FileName;            
        }

        private void BrowseImageFile()
        {
            this.openFile.Filter = "Képfájlok |*.bmp;*.jpg;*.gif;*.png;*.tif";
            this.openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            this.openFile.CheckFileExists = true;
            this.openFile.Multiselect = false;
            this.openFile.Title = "Kérem, válassza ki a képet (háttér nélkülit érdemes)";
            if (this.openFile.ShowDialog().Equals(DialogResult.OK))
                this.textBoxImageLocation.Text = this.openFile.FileName;
        }

        public void UpdateBird(Bird bird)
        {
            if (bird is null)
                return;

            this.textBoxImageLocation.Text = bird.ImageLocation;
            this.textBoxSoundLocation.Text = bird.SoundLocation;
            this.textBoxName.Text = bird.Name;
            this.numericUpDownLevel.Value = Convert.ToDecimal(bird.Level);
            this.buttonSave.Enabled = this.CheckValues();
        }

        private bool CheckValues()
        {
            try
            {
                if (!this.CheckText(this.textBoxName.Text))
                    throw new Exception("A madár neve nem lehet üres vagy 3 karakternél rövidebb!");
                else if (!this.CheckText(this.textBoxImageLocation.Text))
                    throw new Exception("A képfájl elérési útja nem lehet üres vagy 3 karakternél rövidebb!");
                else if (!this.CheckText(this.textBoxSoundLocation.Text))
                    throw new Exception("A hangfájl elérési útja nem lehet üres vagy 3 karakternél rövidebb!");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            return true;
        }

        private bool CheckText(string text)
        {
            string trimmed = text.Trim();
            return !string.IsNullOrWhiteSpace(trimmed) && trimmed.Length > 3;
        }

        private void textBoxes_Leave(object sender, EventArgs e)
            => this.buttonSave.Enabled = this.CheckValues();
    }
}
