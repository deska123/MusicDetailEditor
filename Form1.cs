using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string fileName = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog().Equals(DialogResult.OK))
            {
                fileName = openFileDialog.FileName;
                lblChosenFileName.Text = fileName;

                var tagFile = TagLib.File.Create(fileName);
                txtSongTitle.Text = tagFile.Tag.Title;
                txtAlbumArtist.Text = tagFile.Tag.FirstAlbumArtist;
                txtAlbumName.Text = tagFile.Tag.Album;
                txtYear.Text = tagFile.Tag.Year.ToString();
                txtGenre.Text = tagFile.Tag.FirstGenre;

                pnlChosenFileInfo.Visible = true;
            }
        }

        private void btnChangeSongAttribute_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtSongTitle.Text))
            {
                MessageBox.Show("Title must be filled", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtAlbumArtist.Text))
            {
                MessageBox.Show("Artist must be filled", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtGenre.Text))
            {
                MessageBox.Show("Genre must be filled", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtAlbumName.Text))
            {
                MessageBox.Show("Album Name must be filled", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtYear.Text))
            {
                MessageBox.Show("Year must be filled", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var tagFile = TagLib.File.Create(fileName);
            tagFile.Tag.Title = txtSongTitle.Text.Trim();
            tagFile.Tag.AlbumArtists = new string[1] { txtAlbumArtist.Text.Trim() };
            tagFile.Tag.Genres = new string[1] { txtGenre.Text.Trim() };
            tagFile.Tag.Album = txtAlbumName.Text.Trim();
            tagFile.Tag.Year = Convert.ToUInt32(txtYear.Text.Trim());
            tagFile.Save();

            MessageBox.Show("Attribute of song is successfully changed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
