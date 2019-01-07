using System;
using System.IO;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Shell;
using Song_Game.Properties;
using WMPLib;

namespace Song_Game
{
    public partial class Form1 : Form
    {
        private string _songLocation = "";
        private string[] _files = { };
        private int _songNumber;
        private WindowsMediaPlayer _windowsMediaPlayer;
        private static readonly System.Timers.Timer PlayTimer = new System.Timers.Timer();
        private TimeSpan _songDuration;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _windowsMediaPlayer = new WindowsMediaPlayer();
            Text = @"Song Game";
            Width = 1100;
            selectSongLocationButton.TabStop = false;
            secondsToPlay.TabStop = false;
            playNextSegment.TabStop = false;
            playWholeSong.TabStop = false;
            playRandomSong.TabStop = false;
            MaximizeBox = false;
            playRandomSong.Enabled = false;
            playNextSegment.Enabled = false;
            songName.AutoSize = true;
            songYear.AutoSize = true;
            songArtist.AutoSize = true;
            songGenre.AutoSize = true;
            songArtist.UseMnemonic = false;
            songName.UseMnemonic = false;
            songYear.UseMnemonic = false;
            songGenre.UseMnemonic = false;
            playWholeSong.Enabled = false;
            playSpecificSong.Enabled = false;

            PlayTimer.Elapsed += _playTimer_Elapsed;

            songName.Text = Resources.DefaultLabelText;
            songArtist.Text = Resources.DefaultLabelText;
            songYear.Text = Resources.DefaultLabelText;
            songGenre.Text = Resources.DefaultLabelText;
            songDurationLabel.Text = Resources.DefaultLabelText;
        }

        private void SetSongLocation(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            var result = dialog.ShowDialog();
            if (result != DialogResult.OK || string.IsNullOrWhiteSpace(dialog.SelectedPath)) return;

            songLocationLabel.Text = dialog.SelectedPath;
            _songLocation = dialog.SelectedPath;
            _files = Directory.EnumerateFiles(_songLocation, "*", SearchOption.AllDirectories).Where(file => file.ToLower().EndsWith("mp4")
                                                                     || file.ToLower().EndsWith("mp3")
                                                                     || file.ToLower().EndsWith("m4a")).ToArray();
            //            MessageBox.Show(@"Files Found: " + _files.Length.ToString(), @"Files Found");
            playRandomSong.Enabled = true;
            playNextSegment.Enabled = true;
            playWholeSong.Enabled = true;
            playSpecificSong.Enabled = true;

            songName.Text = Resources.DefaultLabelText;
            songArtist.Text = Resources.DefaultLabelText;
            songYear.Text = Resources.DefaultLabelText;
            songGenre.Text = Resources.DefaultLabelText;
            songDurationLabel.Text = Resources.DefaultLabelText;
        }

        private void GetSongMetadata(string songNameParameter = "")
        {
            var currentSong = string.IsNullOrWhiteSpace(songNameParameter) ? _files[_songNumber] : songNameParameter;

            using (var shell = ShellObject.FromParsingName(currentSong))
            {
                var songTitle = shell.Properties.System.Title.Value ?? shell.Properties.System.FileName.Value ?? "No Title Found";
                var year = shell.Properties.System.Media.Year.Value != null ? shell.Properties.System.Media.Year.Value.ToString() : "No Year Found";
                var artist = shell.Properties.System.Music.Artist.Value != null ? string.Join(",", shell.Properties.System.Music.Artist.Value) : "No Artist Found";
                var genre = shell.Properties.System.Music.Genre.Value != null ? string.Join(",", shell.Properties.System.Music.Genre.Value) : "No Genre Found";
                var t = (ulong?)shell.Properties.System.Media.Duration?.ValueAsObject ?? 0;
                var timeSpan = TimeSpan.FromTicks((long)t);
                _songDuration = new TimeSpan(timeSpan.Days, timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
                songDurationLabel.Text = _songDuration.ToString();

                songArtist.Text = artist;
                songYear.Text = year;
                songName.Text = songTitle;
                songGenre.Text = genre;
            }
        }

        private void PlaySelectedSong(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog { InitialDirectory = _songLocation };

            _windowsMediaPlayer.controls.stop();
            if (dialog.ShowDialog() != DialogResult.OK) return;

            var fileName = dialog.FileName;
            GetSongMetadata(fileName);
            _windowsMediaPlayer.URL = fileName;
            _windowsMediaPlayer.controls.stop();

            PlayTimer.Interval = (double)secondsToPlay.Value * 1000;
        }

        private void PlayRandomSong(object sender, EventArgs e)
        {
            _windowsMediaPlayer.controls.stop();
            var random = new Random();
            _songNumber = random.Next(_files.Length);
            GetSongMetadata();
            _windowsMediaPlayer.URL = _files[_songNumber];
            _windowsMediaPlayer.controls.stop();

            PlayTimer.Interval = (double)secondsToPlay.Value * 1000;
        }

        private void _playTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            _windowsMediaPlayer.controls.pause();
            PlayTimer.Stop();
        }

        private void playNextSegment_Click(object sender, EventArgs e)
        {
            PlayTimer.Start();
            _windowsMediaPlayer.controls.play();
        }

        private void secondsToPlay_ValueChanged(object sender, EventArgs e)
        {
            PlayTimer.Interval = (double)secondsToPlay.Value * 1000;
        }

        private void playWholeSong_Click(object sender, EventArgs e)
        {
            _windowsMediaPlayer.controls.play();
        }
    }
}
