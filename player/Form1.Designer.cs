namespace player
{

    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playlist = new System.Windows.Forms.ListBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnEj = new System.Windows.Forms.Button();
            this.slTime = new System.Windows.Forms.TrackBar();
            this.slVol = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.caption = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.Label();
            this.VolVar = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.labelNumberOfSong = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slVol)).BeginInit();
            this.SuspendLayout();
            // 
            // playlist
            // 
            this.playlist.AllowDrop = true;
            this.playlist.BackColor = System.Drawing.Color.RoyalBlue;
            this.playlist.ForeColor = System.Drawing.SystemColors.WindowText;
            this.playlist.FormattingEnabled = true;
            this.playlist.ItemHeight = 19;
            this.playlist.Location = new System.Drawing.Point(31, 36);
            this.playlist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playlist.Name = "playlist";
            this.playlist.Size = new System.Drawing.Size(364, 213);
            this.playlist.TabIndex = 0;
            this.playlist.SelectedIndexChanged += new System.EventHandler(this.lista_utworow_SelectedIndexChanged);
            this.playlist.DoubleClick += new System.EventHandler(this.playlist_DoubleClick);
            this.playlist.KeyDown += new System.Windows.Forms.KeyEventHandler(this.playlist_KeyDown);
            // 
            // btnPlay
            // 
            this.btnPlay.AutoSize = true;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(85, 323);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(46, 40);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "|>";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStop
            // 
            this.btnStop.AutoSize = true;
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(193, 323);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(46, 40);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "☐";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEj
            // 
            this.btnEj.AutoSize = true;
            this.btnEj.BackColor = System.Drawing.Color.Transparent;
            this.btnEj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEj.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnEj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEj.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEj.ForeColor = System.Drawing.Color.White;
            this.btnEj.Location = new System.Drawing.Point(289, 323);
            this.btnEj.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEj.Name = "btnEj";
            this.btnEj.Size = new System.Drawing.Size(106, 40);
            this.btnEj.TabIndex = 3;
            this.btnEj.Text = "Add .mp3";
            this.btnEj.UseVisualStyleBackColor = false;
            this.btnEj.Click += new System.EventHandler(this.btnEj_Click);
            // 
            // slTime
            // 
            this.slTime.AutoSize = false;
            this.slTime.BackColor = System.Drawing.Color.MidnightBlue;
            this.slTime.LargeChange = 2;
            this.slTime.Location = new System.Drawing.Point(31, 285);
            this.slTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.slTime.Maximum = 100;
            this.slTime.Name = "slTime";
            this.slTime.Size = new System.Drawing.Size(192, 20);
            this.slTime.TabIndex = 4;
            this.slTime.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slTime.Scroll += new System.EventHandler(this.slTime_Scroll);
            // 
            // slVol
            // 
            this.slVol.AutoSize = false;
            this.slVol.BackColor = System.Drawing.Color.MidnightBlue;
            this.slVol.Location = new System.Drawing.Point(255, 285);
            this.slVol.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.slVol.Maximum = 100;
            this.slVol.Name = "slVol";
            this.slVol.Size = new System.Drawing.Size(140, 20);
            this.slVol.TabIndex = 5;
            this.slVol.TickStyle = System.Windows.Forms.TickStyle.None;
            this.slVol.Value = 100;
            this.slVol.Scroll += new System.EventHandler(this.slVol_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(73, 261);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "00:00:00";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(151, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "00:00:00";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "\"All Supported Audio | *.mp3; *.wma | MP3s | *.mp3 | .wma | *.wma\";";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // caption
            // 
            this.caption.AutoSize = true;
            this.caption.BackColor = System.Drawing.Color.Black;
            this.caption.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.caption.ForeColor = System.Drawing.Color.White;
            this.caption.Location = new System.Drawing.Point(27, 261);
            this.caption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.caption.Name = "caption";
            this.caption.Size = new System.Drawing.Size(53, 26);
            this.caption.TabIndex = 8;
            this.caption.Text = "Time:";
            // 
            // volume
            // 
            this.volume.AutoSize = true;
            this.volume.BackColor = System.Drawing.Color.Black;
            this.volume.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.volume.ForeColor = System.Drawing.Color.White;
            this.volume.Location = new System.Drawing.Point(274, 259);
            this.volume.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(71, 26);
            this.volume.TabIndex = 9;
            this.volume.Text = "Volume:";
            // 
            // VolVar
            // 
            this.VolVar.AutoSize = true;
            this.VolVar.BackColor = System.Drawing.Color.Black;
            this.VolVar.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.VolVar.ForeColor = System.Drawing.Color.White;
            this.VolVar.Location = new System.Drawing.Point(334, 259);
            this.VolVar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VolVar.Name = "VolVar";
            this.VolVar.Size = new System.Drawing.Size(45, 26);
            this.VolVar.TabIndex = 10;
            this.VolVar.Text = "100";
            this.VolVar.Click += new System.EventHandler(this.VolVar_Click);
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Transparent;
            this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPause.ForeColor = System.Drawing.Color.White;
            this.btnPause.Location = new System.Drawing.Point(85, 323);
            this.btnPause.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(46, 40);
            this.btnPause.TabIndex = 11;
            this.btnPause.Text = "||";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Visible = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnResume
            // 
            this.btnResume.AutoSize = true;
            this.btnResume.BackColor = System.Drawing.Color.Transparent;
            this.btnResume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResume.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnResume.ForeColor = System.Drawing.Color.White;
            this.btnResume.Location = new System.Drawing.Point(85, 323);
            this.btnResume.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(46, 40);
            this.btnResume.TabIndex = 12;
            this.btnResume.Text = "|>";
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.AutoSize = true;
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrev.ForeColor = System.Drawing.Color.White;
            this.btnPrev.Location = new System.Drawing.Point(31, 323);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(46, 40);
            this.btnPrev.TabIndex = 13;
            this.btnPrev.Text = "<-";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.AutoSize = true;
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(139, 323);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(46, 40);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "->";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // labelNumberOfSong
            // 
            this.labelNumberOfSong.AutoSize = true;
            this.labelNumberOfSong.Location = new System.Drawing.Point(402, 133);
            this.labelNumberOfSong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumberOfSong.Name = "labelNumberOfSong";
            this.labelNumberOfSong.Size = new System.Drawing.Size(0, 19);
            this.labelNumberOfSong.TabIndex = 15;
            this.labelNumberOfSong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // btnHelp
            // 
            this.btnHelp.AutoSize = true;
            this.btnHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Location = new System.Drawing.Point(402, 323);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(32, 38);
            this.btnHelp.TabIndex = 16;
            this.btnHelp.Text = "?";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::player.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(431, 370);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.labelNumberOfSong);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.VolVar);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.caption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.slVol);
            this.Controls.Add(this.slTime);
            this.Controls.Add(this.btnEj);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.playlist);
            this.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(447, 409);
            this.Name = "Form1";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sowa Player";
            this.TransparencyKey = System.Drawing.Color.Pink;
            ((System.ComponentModel.ISupportInitialize)(this.slTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slVol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox playlist;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnEj;
        private System.Windows.Forms.TrackBar slTime;
        private System.Windows.Forms.TrackBar slVol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label caption;
        private System.Windows.Forms.Label volume;
        private System.Windows.Forms.Label VolVar;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label labelNumberOfSong;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnHelp;
    }
}

