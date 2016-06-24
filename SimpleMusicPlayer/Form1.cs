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

namespace SimpleMusicPlayer
{
    public partial class Form1 : Form
    {
        string[] files, path;
        List<string> songlistactivpath = new List<string>();
        List<string> namesongs = new List<string>();
        public Form1()
        {
            InitializeComponent();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.FileName = "";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Multiselect = true;
        }

        private void LoadFiles_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Mp3Audio(.mp3)|*.mp3";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try {
                    files = openFileDialog1.SafeFileNames;
                    path = openFileDialog1.FileNames;
               
                    for (int i = 0; i < files.Length; i++)
                    {
                        string[] items = new string[2];
                        items[0] = files[i];
                        items[1] = path[i];
                        songlistactivpath.Add(path[i]);
                        namesongs.Add(path[i]);
                        ListViewItem lvi = new ListViewItem(items);
                        listView1.Items.Add(lvi);
                    }                       

                }catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
        }

        private void PlayAll_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Txt.txt|*.txt";
            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] pathname = new string[listView1.Items.Count];
                    for (int i = 0; i<songlistactivpath.Count; i++)
                    {
                        ListViewItem lv = listView1.Items[i];
                        pathname[i] =  lv.SubItems[0].Text + "&" + lv.SubItems[1].Text;
                    }
                    File.WriteAllLines(saveFileDialog1.FileName, pathname);

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }            
        }

        private void LoadPlaylistbtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Txt(.txt)|*.txt";
            openFileDialog1.RestoreDirectory = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                path = File.ReadAllLines(openFileDialog1.FileName);
                songlistactivpath.Clear();
                listView1.Items.Clear();
                foreach (string s in path)
                {
                    
                        string[] items = new string[2];
                        items = s.Split('&');
                        songlistactivpath.Add(items[1]);
                        namesongs.Add(items[0]);
                        ListViewItem lv = new ListViewItem(items);
                        listView1.Items.Add(lv);
                    }
                }catch { MessageBox.Show("To nie jest plik playlisty"); return; }
                
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1_Enter(axWindowsMediaPlayer1, e);
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count>0)
                axWindowsMediaPlayer1.URL = songlistactivpath[listView1.FocusedItem.Index];          
        }         

    }
}
