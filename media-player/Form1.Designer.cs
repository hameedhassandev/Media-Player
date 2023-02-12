namespace media_player
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.browseFile = new System.Windows.Forms.ToolStripMenuItem();
            this.videoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.playList = new System.Windows.Forms.ListBox();
            this.showFileName = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Label();
            this.timerEvent = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileDropDown});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileDropDown
            // 
            this.fileDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseFile});
            this.fileDropDown.Name = "fileDropDown";
            this.fileDropDown.Size = new System.Drawing.Size(37, 20);
            this.fileDropDown.Text = "File";
            // 
            // browseFile
            // 
            this.browseFile.Name = "browseFile";
            this.browseFile.Size = new System.Drawing.Size(148, 22);
            this.browseFile.Text = "Browse Folder";
            this.browseFile.Click += new System.EventHandler(this.BrowseFileEvent);
            // 
            // videoPlayer
            // 
            this.videoPlayer.Enabled = true;
            this.videoPlayer.Location = new System.Drawing.Point(0, 27);
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("videoPlayer.OcxState")));
            this.videoPlayer.Size = new System.Drawing.Size(661, 433);
            this.videoPlayer.TabIndex = 1;
            this.videoPlayer.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.mediaPlayerStateEvent);
            this.videoPlayer.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // playList
            // 
            this.playList.FormattingEnabled = true;
            this.playList.Location = new System.Drawing.Point(667, 27);
            this.playList.Name = "playList";
            this.playList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.playList.Size = new System.Drawing.Size(201, 433);
            this.playList.TabIndex = 2;
            this.playList.SelectedIndexChanged += new System.EventHandler(this.playList_SelectedIndexChanged);
            // 
            // showFileName
            // 
            this.showFileName.AutoSize = true;
            this.showFileName.Location = new System.Drawing.Point(12, 473);
            this.showFileName.Name = "showFileName";
            this.showFileName.Size = new System.Drawing.Size(49, 13);
            this.showFileName.TabIndex = 3;
            this.showFileName.Text = "file name";
            this.showFileName.Click += new System.EventHandler(this.label1_Click);
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Location = new System.Drawing.Point(673, 473);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(59, 13);
            this.duration.TabIndex = 4;
            this.duration.Text = "Duration: 0";
            this.duration.Click += new System.EventHandler(this.duration_Click);
            // 
            // timerEvent
            // 
            this.timerEvent.Tick += new System.EventHandler(this.TimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 495);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.showFileName);
            this.Controls.Add(this.playList);
            this.Controls.Add(this.videoPlayer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "my media player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileDropDown;
        private System.Windows.Forms.ToolStripMenuItem browseFile;
        private AxWMPLib.AxWindowsMediaPlayer videoPlayer;
        private System.Windows.Forms.ListBox playList;
        private System.Windows.Forms.Label showFileName;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.Timer timerEvent;
    }
}

