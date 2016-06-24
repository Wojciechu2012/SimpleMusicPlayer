namespace SimpleMusicPlayer
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
            this.LoadFiles = new System.Windows.Forms.Button();
            this.PlayAll = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.LoadPlaylistbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadFiles
            // 
            this.LoadFiles.Location = new System.Drawing.Point(12, 479);
            this.LoadFiles.Name = "LoadFiles";
            this.LoadFiles.Size = new System.Drawing.Size(142, 57);
            this.LoadFiles.TabIndex = 0;
            this.LoadFiles.Text = "Add Music";
            this.LoadFiles.UseVisualStyleBackColor = true;
            this.LoadFiles.Click += new System.EventHandler(this.LoadFiles_Click);
            // 
            // PlayAll
            // 
            this.PlayAll.Location = new System.Drawing.Point(173, 479);
            this.PlayAll.Name = "PlayAll";
            this.PlayAll.Size = new System.Drawing.Size(142, 57);
            this.PlayAll.TabIndex = 1;
            this.PlayAll.Text = "Save Playlist";
            this.PlayAll.UseVisualStyleBackColor = true;
            this.PlayAll.Click += new System.EventHandler(this.PlayAll_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Location = new System.Drawing.Point(12, 367);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(760, 106);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 500;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Locaction";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 12);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(760, 349);
            this.axWindowsMediaPlayer1.TabIndex = 3;
            this.axWindowsMediaPlayer1.Enter += new System.EventHandler(this.axWindowsMediaPlayer1_Enter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LoadPlaylistbtn
            // 
            this.LoadPlaylistbtn.Location = new System.Drawing.Point(354, 479);
            this.LoadPlaylistbtn.Name = "LoadPlaylistbtn";
            this.LoadPlaylistbtn.Size = new System.Drawing.Size(91, 57);
            this.LoadPlaylistbtn.TabIndex = 5;
            this.LoadPlaylistbtn.Text = "Wczytaj playliste";
            this.LoadPlaylistbtn.UseVisualStyleBackColor = true;
            this.LoadPlaylistbtn.Click += new System.EventHandler(this.LoadPlaylistbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.LoadPlaylistbtn);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.PlayAll);
            this.Controls.Add(this.LoadFiles);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.Text = "Media Player";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadFiles;
        private System.Windows.Forms.Button PlayAll;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button LoadPlaylistbtn;
    }
}

