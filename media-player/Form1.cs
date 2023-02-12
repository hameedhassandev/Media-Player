using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace media_player
{
    public partial class Form1 : Form
    {
        List<string> listFiles = new List<string>(); 
        FolderBrowserDialog browser = new FolderBrowserDialog();
        int currentChooseFile = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void BrowseFileEvent(object sender, EventArgs e)
        {
            videoPlayer.Ctlcontrols.stop();
            if (listFiles.Count > 1)
            {
                listFiles.Clear();
                listFiles = null;

                playList.Items.Clear();

                currentChooseFile = 0;
            }
            DialogResult result = browser.ShowDialog();
            if (result == DialogResult.OK)
            {
                listFiles = Directory.GetFiles(browser.SelectedPath, "*.*").Where(file => file.ToLower().EndsWith("webm")
                || file.ToLower().EndsWith("mp4") || file.ToLower().EndsWith("avi") || file.ToLower().EndsWith("wmv")
                || file.ToLower().EndsWith("mkv"))
                .ToList();

                loadPlaylist();
            }
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void mediaPlayerStateEvent(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            //undefind loaded
            if (e.newState == 0) duration.Text = "Media played is ready to loaded...";
            //file is topped
            else if (e.newState == 1) duration.Text = "Media player is stopped!";
            //file is playing
            else if (e.newState == 3) duration.Text = "Duration: " + videoPlayer.currentMedia.durationString;
            //media ended here 
            else if(e.newState == 8)
            {
                if (currentChooseFile >= listFiles.Count - 1)
                    currentChooseFile = 0;
                else
                    currentChooseFile += 1;

                playList.SelectedIndex = currentChooseFile;
                ShowFileName(showFileName);
            }
            //mediaplayer loaded a new video
            if (e.newState == 9) duration.Text = "Loading video...";
            //play again
            if (e.newState == 10) timerEvent.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void playList_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentChooseFile = playList.SelectedIndex;
            loadFile(playList.SelectedItem.ToString());
            ShowFileName(showFileName);
        }

        private void duration_Click(object sender, EventArgs e)
        {

        }

        private void TimerEvent(object sender, EventArgs e)
        {
            videoPlayer.Ctlcontrols.play();
            timerEvent.Stop();

        }

        private void loadPlaylist()
        {
            videoPlayer.currentPlaylist = videoPlayer.newPlaylist("PlayList", "");
            foreach(string video in listFiles)
            {
                videoPlayer.currentPlaylist.appendItem(videoPlayer.newMedia(video));
                playList.Items.Add(video);
            }
            if(listFiles.Count > 0)
            {
                showFileName.Text = "Files found: " + listFiles.Count();
                playList.SelectedIndex = currentChooseFile;
                loadFile(playList.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("No video(s) found in this directory");
            }

        }
        private void loadFile(string url)
        {
            videoPlayer.URL = url;
        }

        private void ShowFileName(Label fileName)
        {
            string file = Path.GetFileName(playList.SelectedItem.ToString());
            fileName.Text = "Currently video " + file;
        }
    }
}
