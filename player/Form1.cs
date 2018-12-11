using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Un4seen.Bass;
using System.Threading;

namespace player
{
    public partial class Form1 : Form
    {
        public object True { get; }

        public Form1()
        {
            InitializeComponent();
            if (playlist.Items.Count == 0) btnResume.Visible = false;
            VolVar.BackColor = System.Drawing.Color.Transparent;
            caption.BackColor = System.Drawing.Color.Transparent;
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            volume.BackColor = System.Drawing.Color.Transparent;
        }


        public void button1_Click(object sender, EventArgs e)
        {
            if ((playlist.Items.Count != 0) && (playlist.SelectedIndex != -1))
            {
                string current = Vars.Files[playlist.SelectedIndex];
                Vars.numberOfSong = playlist.SelectedIndex;
                BassLike.Play(current, BassLike.Volume);
                BassLike.SetVolumeToStream(BassLike.Stream, slVol.Value);
                label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(BassLike.GetTimeOfStream(BassLike.Stream)).ToString();
                labelNumberOfSong.Text = (playlist.SelectedIndex + 1).ToString();
                int time = Convert.ToInt32(BassLike.GetTimeOfStream(BassLike.Stream));
                slTime.Maximum = time;
                int value = Convert.ToInt32(BassLike.GetPosOfStream(BassLike.Stream));
                slTime.Value = value;
                timer1.Enabled = true;
                btnPlay.Visible = false;
                btnResume.Visible = false;
                btnPause.Visible = true;
            }

            else if ((playlist.Items.Count != 0) && (playlist.SelectedIndex == -1))
            {
                string current = Vars.Files[0];
                BassLike.Play(current, BassLike.Volume);
                BassLike.SetVolumeToStream(BassLike.Stream, slVol.Value);
                playlist.SelectedIndex = playlist.TopIndex;
                label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(BassLike.GetTimeOfStream(BassLike.Stream)).ToString();
                labelNumberOfSong.Text = (playlist.SelectedIndex + 1).ToString();
                int time = Convert.ToInt32(BassLike.GetTimeOfStream(BassLike.Stream));
                slTime.Maximum = time;
                int value = Convert.ToInt32(BassLike.GetPosOfStream(BassLike.Stream));
                slTime.Value = value;
                timer1.Enabled = true;
                btnPlay.Visible = false;
                btnResume.Visible = false;
                btnPause.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btnResume.Visible = false;
            btnPause.Visible = false;
            btnPlay.Visible = true;
            BassLike.Stop();
            timer1.Enabled = false;
            slTime.Value = 0;
            label1.Text = "00:00:00";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            BassLike.Stop();
            timer1.Enabled = false;
            slTime.Value = 0;
            label1.Text = "00:00:00";
        }

        private void lista_utworow_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            BassLike.SetPosOfScroll(BassLike.Stream, slVol.Value);
            VolVar.Text = slVol.Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEj_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            int i = 0;
            foreach (String file in openFileDialog1.FileNames)
            {
                Vars.Files.Add(openFileDialog1.FileNames[i]);
                playlist.Items.Add(Vars.GetFileName(openFileDialog1.FileNames[i]));
                i++;
            }
        }

        private void timer1_Tick(object Sender, EventArgs e)
        {
            label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
            slTime.Value = BassLike.GetPosOfStream(BassLike.Stream);
            if ((label1.Text == label2.Text) && (playlist.Items.Count != -1) && (playlist.SelectedIndex != playlist.Items.Count - 1))
            {
                Thread.Sleep(2000);
                btnNext.PerformClick();
            }


        }

        private void slTime_Scroll(object sender, EventArgs e)
        {
            BassLike.SetPosOfScroll(BassLike.Stream, slTime.Value);
        }

        private void VolVar_Click(object sender, EventArgs e)
        {

        }

        private void slVol_Scroll(object sender, EventArgs e)
        { 
            BassLike.SetVolumeToStream(BassLike.Stream, slVol.Value);
            VolVar.Text = slVol.Value.ToString();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
                BassLike.Pause();
                if (playlist.Items.Count != 0) btnResume.Visible = true;
                timer1.Enabled = false;
                btnPause.Visible = false;
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            BassLike.Resume();
            btnResume.Visible = false;
            btnPause.Visible = true;
            timer1.Enabled = true;
        }

        public void btnNext_Click(object sender, EventArgs e)
        {
            if ((playlist.Items.Count != 0) && (playlist.SelectedIndex == -1))
            {
                string current = Vars.Files[playlist.TopIndex];
                BassLike.Play(current, BassLike.Volume);
                BassLike.SetVolumeToStream(BassLike.Stream, slVol.Value);
                playlist.SelectedIndex = playlist.TopIndex;
                label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(BassLike.GetTimeOfStream(BassLike.Stream)).ToString();
                labelNumberOfSong.Text = (playlist.SelectedIndex + 1).ToString();
                int time = Convert.ToInt32(BassLike.GetTimeOfStream(BassLike.Stream));
                slTime.Maximum = time;
                int value = Convert.ToInt32(BassLike.GetPosOfStream(BassLike.Stream));
                slTime.Value = value;
                timer1.Enabled = true;
                btnPlay.Visible = false;
                btnPause.Visible = true;
            }

            else if ((playlist.Items.Count != 0) && (Vars.numberOfSong + 1 <= playlist.Items.Count))
            {
                Vars.numberOfSong++;
                if (Vars.numberOfSong >= playlist.Items.Count)
                {
                    Vars.numberOfSong = 0;
                }
                string current = Vars.Files[Vars.numberOfSong];
                playlist.SelectedIndex = Vars.numberOfSong;
                BassLike.Play(current, BassLike.Volume);
                BassLike.SetVolumeToStream(BassLike.Stream, slVol.Value);
                label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(BassLike.GetTimeOfStream(BassLike.Stream)).ToString();
                labelNumberOfSong.Text = (playlist.SelectedIndex + 1).ToString();
                int time = Convert.ToInt32(BassLike.GetTimeOfStream(BassLike.Stream));
                slTime.Maximum = time;
                int value = Convert.ToInt32(BassLike.GetPosOfStream(BassLike.Stream));
                slTime.Value = value;
                timer1.Enabled = true;
                btnPlay.Visible = false;
                btnPause.Visible = true;
            }

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if ((playlist.Items.Count != 0) && (playlist.SelectedIndex == -1))
            {
                playlist.SelectedIndex = playlist.Items.Count - 1;
                string current = Vars.Files[playlist.SelectedIndex];
                BassLike.Play(current, BassLike.Volume);
                BassLike.SetVolumeToStream(BassLike.Stream, slVol.Value);
                label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(BassLike.GetTimeOfStream(BassLike.Stream)).ToString();
                labelNumberOfSong.Text = (playlist.SelectedIndex + 1).ToString();
                int time = Convert.ToInt32(BassLike.GetTimeOfStream(BassLike.Stream));
                slTime.Maximum = time;
                int value = Convert.ToInt32(BassLike.GetPosOfStream(BassLike.Stream));
                slTime.Value = value;
                timer1.Enabled = true;
                btnPlay.Visible = false;
                btnPause.Visible = true;
                btnResume.Visible = false;
                Vars.numberOfSong = playlist.SelectedIndex ;
            }

            else if ((playlist.Items.Count != 0) && (Vars.numberOfSong - 1 >= -1))
            {
                Vars.numberOfSong--;              
                if(Vars.numberOfSong < 0)
                {
                    Vars.numberOfSong = playlist.Items.Count - 1;
                }
                string current = Vars.Files[Vars.numberOfSong];
                playlist.SelectedIndex = Vars.numberOfSong;
                BassLike.Play(current, BassLike.Volume);
                BassLike.SetVolumeToStream(BassLike.Stream, slVol.Value);
                label1.Text = TimeSpan.FromSeconds(BassLike.GetPosOfStream(BassLike.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(BassLike.GetTimeOfStream(BassLike.Stream)).ToString();
                labelNumberOfSong.Text = (playlist.SelectedIndex + 1).ToString();
                int time = Convert.ToInt32(BassLike.GetTimeOfStream(BassLike.Stream));
                slTime.Maximum = time;
                int value = Convert.ToInt32(BassLike.GetPosOfStream(BassLike.Stream));
                slTime.Value = value;
                timer1.Enabled = true;
                btnPlay.Visible = false;
                btnPause.Visible = true;
                btnResume.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void playlist_DoubleClick(object sender, EventArgs e)
        {
            btnPlay.Visible = true;
            Vars.numberOfSong = playlist.SelectedIndex;
            btnPlay.PerformClick();
        }

        private void playlist_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Vars.numberOfSong = playlist.SelectedIndex;
                btnPlay.Visible = true;
                btnPlay.PerformClick();
            }

            if(e.KeyCode == Keys.Delete)
            {
                Vars.Files.Remove(Vars.Files[playlist.SelectedIndex]);
                playlist.Items.Remove(playlist.SelectedItem);
                Vars.numberOfSong = playlist.Items.Count;
                
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        { 
            MessageBox.Show("Witam w programie Sowa Player. Oto następujący tutorial:\n1. Aby dodawac muzykę do listy należy nacisnąć przycisk add .mp3, można wybrać wiele utworów poprzez zaznaczenie ich w dialogu bądź poprzez trzymanie klawisza CTRL i zaznaczanie elementow(elementy można dodawać kilkukrotnie).\n2. Nawigowanie po aplikacji następuje z użyciem myszki bądź w wyświetlonym okienku playlisty za pomocą strzałek. Po naciśnięciu klawisza enter lub przycisku play, bądź dwukrotnym kliknięciu myszką nastąpi uruchomienie zaznaczonego utworu.\n3. Aby usunąć utwór z playlisty należy ustawić się na elemencie, a następnie nacisnąć klawisz delete\n\nDziękuję za wybranie mojego produktu.");
        }
    }
}