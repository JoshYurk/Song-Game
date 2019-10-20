namespace Song_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.selectSongLocationButton = new System.Windows.Forms.Button();
            this.songLocationLabel = new System.Windows.Forms.Label();
            this.secondsToPlay = new System.Windows.Forms.NumericUpDown();
            this.secondsToPlayLabel = new System.Windows.Forms.Label();
            this.playNextSegment = new System.Windows.Forms.Button();
            this.playRandomSong = new System.Windows.Forms.Button();
            this.songNameLabel = new System.Windows.Forms.Label();
            this.songName = new System.Windows.Forms.Label();
            this.songArtistLabel = new System.Windows.Forms.Label();
            this.songArtist = new System.Windows.Forms.Label();
            this.songGenreLabel = new System.Windows.Forms.Label();
            this.songGenre = new System.Windows.Forms.Label();
            this.songYearLabel = new System.Windows.Forms.Label();
            this.songYear = new System.Windows.Forms.Label();
            this.songDurationLabel = new System.Windows.Forms.Label();
            this.playWholeSong = new System.Windows.Forms.Button();
            this.durationLabel = new System.Windows.Forms.Label();
            this.playSpecificSong = new System.Windows.Forms.Button();
            this.songCountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.secondsToPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // selectSongLocationButton
            // 
            this.selectSongLocationButton.Location = new System.Drawing.Point(13, 13);
            this.selectSongLocationButton.Name = "selectSongLocationButton";
            this.selectSongLocationButton.Size = new System.Drawing.Size(141, 30);
            this.selectSongLocationButton.TabIndex = 0;
            this.selectSongLocationButton.Text = "Select Song Locations";
            this.selectSongLocationButton.UseVisualStyleBackColor = true;
            this.selectSongLocationButton.Click += new System.EventHandler(this.SetSongLocation);
            // 
            // songLocationLabel
            // 
            this.songLocationLabel.AutoSize = true;
            this.songLocationLabel.Location = new System.Drawing.Point(160, 18);
            this.songLocationLabel.Name = "songLocationLabel";
            this.songLocationLabel.Size = new System.Drawing.Size(110, 13);
            this.songLocationLabel.TabIndex = 1;
            this.songLocationLabel.Text = "No Location Selected";
            // 
            // secondsToPlay
            // 
            this.secondsToPlay.Location = new System.Drawing.Point(13, 107);
            this.secondsToPlay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.secondsToPlay.Name = "secondsToPlay";
            this.secondsToPlay.Size = new System.Drawing.Size(141, 20);
            this.secondsToPlay.TabIndex = 2;
            this.secondsToPlay.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.secondsToPlay.ValueChanged += new System.EventHandler(this.secondsToPlay_ValueChanged);
            // 
            // secondsToPlayLabel
            // 
            this.secondsToPlayLabel.AutoSize = true;
            this.secondsToPlayLabel.Location = new System.Drawing.Point(160, 109);
            this.secondsToPlayLabel.Name = "secondsToPlayLabel";
            this.secondsToPlayLabel.Size = new System.Drawing.Size(88, 13);
            this.secondsToPlayLabel.TabIndex = 3;
            this.secondsToPlayLabel.Text = "Seconds To Play";
            // 
            // playNextSegment
            // 
            this.playNextSegment.Location = new System.Drawing.Point(2, 249);
            this.playNextSegment.Name = "playNextSegment";
            this.playNextSegment.Size = new System.Drawing.Size(268, 118);
            this.playNextSegment.TabIndex = 4;
            this.playNextSegment.Text = "Next Segment";
            this.playNextSegment.UseVisualStyleBackColor = true;
            this.playNextSegment.Click += new System.EventHandler(this.playNextSegment_Click);
            // 
            // playRandomSong
            // 
            this.playRandomSong.Location = new System.Drawing.Point(330, 249);
            this.playRandomSong.Name = "playRandomSong";
            this.playRandomSong.Size = new System.Drawing.Size(268, 118);
            this.playRandomSong.TabIndex = 5;
            this.playRandomSong.Text = "Random Song";
            this.playRandomSong.UseVisualStyleBackColor = true;
            this.playRandomSong.Click += new System.EventHandler(this.PlayRandomSong);
            // 
            // songNameLabel
            // 
            this.songNameLabel.AutoSize = true;
            this.songNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songNameLabel.Location = new System.Drawing.Point(326, 61);
            this.songNameLabel.Name = "songNameLabel";
            this.songNameLabel.Size = new System.Drawing.Size(97, 20);
            this.songNameLabel.TabIndex = 6;
            this.songNameLabel.Text = "Song Name:";
            // 
            // songName
            // 
            this.songName.AutoSize = true;
            this.songName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songName.Location = new System.Drawing.Point(429, 61);
            this.songName.Name = "songName";
            this.songName.Size = new System.Drawing.Size(125, 20);
            this.songName.TabIndex = 7;
            this.songName.Text = "No Song Playing";
            // 
            // songArtistLabel
            // 
            this.songArtistLabel.AutoSize = true;
            this.songArtistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songArtistLabel.Location = new System.Drawing.Point(326, 91);
            this.songArtistLabel.Name = "songArtistLabel";
            this.songArtistLabel.Size = new System.Drawing.Size(92, 20);
            this.songArtistLabel.TabIndex = 8;
            this.songArtistLabel.Text = "Song Artist:";
            // 
            // songArtist
            // 
            this.songArtist.AutoSize = true;
            this.songArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songArtist.Location = new System.Drawing.Point(429, 91);
            this.songArtist.Name = "songArtist";
            this.songArtist.Size = new System.Drawing.Size(125, 20);
            this.songArtist.TabIndex = 9;
            this.songArtist.Text = "No Song Playing";
            // 
            // songGenreLabel
            // 
            this.songGenreLabel.AutoSize = true;
            this.songGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songGenreLabel.Location = new System.Drawing.Point(326, 121);
            this.songGenreLabel.Name = "songGenreLabel";
            this.songGenreLabel.Size = new System.Drawing.Size(100, 20);
            this.songGenreLabel.TabIndex = 10;
            this.songGenreLabel.Text = "Song Genre:";
            // 
            // songGenre
            // 
            this.songGenre.AutoSize = true;
            this.songGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songGenre.Location = new System.Drawing.Point(429, 121);
            this.songGenre.Name = "songGenre";
            this.songGenre.Size = new System.Drawing.Size(125, 20);
            this.songGenre.TabIndex = 11;
            this.songGenre.Text = "No Song Playing";
            // 
            // songYearLabel
            // 
            this.songYearLabel.AutoSize = true;
            this.songYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songYearLabel.Location = new System.Drawing.Point(326, 151);
            this.songYearLabel.Name = "songYearLabel";
            this.songYearLabel.Size = new System.Drawing.Size(89, 20);
            this.songYearLabel.TabIndex = 12;
            this.songYearLabel.Text = "Song Year:";
            // 
            // songYear
            // 
            this.songYear.AutoSize = true;
            this.songYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songYear.Location = new System.Drawing.Point(429, 151);
            this.songYear.Name = "songYear";
            this.songYear.Size = new System.Drawing.Size(125, 20);
            this.songYear.TabIndex = 13;
            this.songYear.Text = "No Song Playing";
            // 
            // songDurationLabel
            // 
            this.songDurationLabel.AutoSize = true;
            this.songDurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.songDurationLabel.Location = new System.Drawing.Point(429, 181);
            this.songDurationLabel.Name = "songDurationLabel";
            this.songDurationLabel.Size = new System.Drawing.Size(125, 20);
            this.songDurationLabel.TabIndex = 14;
            this.songDurationLabel.Text = "No Song Playing";
            // 
            // playWholeSong
            // 
            this.playWholeSong.Location = new System.Drawing.Point(2, 155);
            this.playWholeSong.Name = "playWholeSong";
            this.playWholeSong.Size = new System.Drawing.Size(268, 88);
            this.playWholeSong.TabIndex = 15;
            this.playWholeSong.Text = "Play Whole/Remaining Song";
            this.playWholeSong.UseVisualStyleBackColor = true;
            this.playWholeSong.Click += new System.EventHandler(this.playWholeSong_Click);
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.durationLabel.Location = new System.Drawing.Point(326, 181);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(74, 20);
            this.durationLabel.TabIndex = 16;
            this.durationLabel.Text = "Duration:";
            // 
            // playSpecificSong
            // 
            this.playSpecificSong.Location = new System.Drawing.Point(604, 249);
            this.playSpecificSong.Name = "playSpecificSong";
            this.playSpecificSong.Size = new System.Drawing.Size(262, 118);
            this.playSpecificSong.TabIndex = 17;
            this.playSpecificSong.Text = "Select Specific Song";
            this.playSpecificSong.UseVisualStyleBackColor = true;
            this.playSpecificSong.Click += new System.EventHandler(this.PlaySelectedSong);
            // 
            // songCountLabel
            // 
            this.songCountLabel.AutoSize = true;
            this.songCountLabel.Location = new System.Drawing.Point(276, 18);
            this.songCountLabel.Name = "songCountLabel";
            this.songCountLabel.Size = new System.Drawing.Size(79, 13);
            this.songCountLabel.TabIndex = 18;
            this.songCountLabel.Text = "0 Songs Found";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.songCountLabel);
            this.Controls.Add(this.playSpecificSong);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.playWholeSong);
            this.Controls.Add(this.songDurationLabel);
            this.Controls.Add(this.songYear);
            this.Controls.Add(this.songYearLabel);
            this.Controls.Add(this.songGenre);
            this.Controls.Add(this.songGenreLabel);
            this.Controls.Add(this.songArtist);
            this.Controls.Add(this.songArtistLabel);
            this.Controls.Add(this.songName);
            this.Controls.Add(this.songNameLabel);
            this.Controls.Add(this.playRandomSong);
            this.Controls.Add(this.playNextSegment);
            this.Controls.Add(this.secondsToPlayLabel);
            this.Controls.Add(this.secondsToPlay);
            this.Controls.Add(this.songLocationLabel);
            this.Controls.Add(this.selectSongLocationButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.secondsToPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button selectSongLocationButton;
        private System.Windows.Forms.Label songLocationLabel;
        private System.Windows.Forms.NumericUpDown secondsToPlay;
        private System.Windows.Forms.Label secondsToPlayLabel;
        private System.Windows.Forms.Button playNextSegment;
        private System.Windows.Forms.Button playRandomSong;
        private System.Windows.Forms.Label songNameLabel;
        private System.Windows.Forms.Label songName;
        private System.Windows.Forms.Label songArtistLabel;
        private System.Windows.Forms.Label songArtist;
        private System.Windows.Forms.Label songGenreLabel;
        private System.Windows.Forms.Label songGenre;
        private System.Windows.Forms.Label songYearLabel;
        private System.Windows.Forms.Label songYear;
        private System.Windows.Forms.Label songDurationLabel;
        private System.Windows.Forms.Button playWholeSong;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.Button playSpecificSong;
        private System.Windows.Forms.Label songCountLabel;
    }
}

