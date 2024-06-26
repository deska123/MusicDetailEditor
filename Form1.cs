﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string mainMusicFileName = string.Empty;
        public string coverMusicFileName = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseMainSongFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog_SongFile.ShowDialog().Equals(DialogResult.OK))
                {
                    FileInfo mainFileInfo = new FileInfo(openFileDialog_SongFile.FileName.Trim());
                    if (mainFileInfo.IsReadOnly)
                    {
                        MessageBox.Show(string.Concat("File '", openFileDialog_SongFile.FileName.Trim(), "' is read-only. Please remove read-only attribute."), "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    txtMusicFileName.Text = Path.GetFileNameWithoutExtension(openFileDialog_SongFile.FileName.Trim());

                    mainMusicFileName = openFileDialog_SongFile.FileName;
                    lblChosenFileName.Text = mainMusicFileName;

                    var tagFile = TagLib.File.Create(mainMusicFileName);
                    txtSongTitle.Text = tagFile.Tag.Title;
                    txtAlbumArtist.Text = tagFile.Tag.FirstAlbumArtist;
                    txtAlbumName.Text = tagFile.Tag.Album;
                    txtYear.Text = tagFile.Tag.Year.ToString();
                    txtGenre.Text = tagFile.Tag.FirstGenre;

                    //Copied from : https://stackoverflow.com/a/35103554
                    var mStream = new MemoryStream();
                    var firstPicture = tagFile.Tag.Pictures.FirstOrDefault();
                    pbMusicCoverPicture.Visible = false;
                    if (firstPicture != null)
                    {
                        byte[] pData = firstPicture.Data.Data;
                        mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                        var bm = new Bitmap(mStream, false);
                        mStream.Dispose();
                        pbMusicCoverPicture.Image = bm;
                        pbMusicCoverPicture.SizeMode = PictureBoxSizeMode.StretchImage; //Copied from https://stackoverflow.com/a/16822190
                        pbMusicCoverPicture.Refresh();
                        pbMusicCoverPicture.Visible = true;
                    }

                    pnlChosenFileInfo.Visible = true;
                }
            } catch(Exception ex)
            {
                MessageBox.Show(string.Concat("Error ", ex.Message.Trim(), " | ", ex.StackTrace.Trim()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangeSongAttribute_Click(object sender, EventArgs e)
        {
            try
            {
                if(chkFlagChangeMusicFileName.Checked)
                {
                    if(string.IsNullOrEmpty(txtMusicFileName.Text))
                    {
                        MessageBox.Show("Music file name must be filled !", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    string newMusicFileName = string.Concat(Path.GetDirectoryName(mainMusicFileName), @"\", txtMusicFileName.Text.Trim(), Path.GetExtension(mainMusicFileName));
                    File.Move(mainMusicFileName, newMusicFileName);
                    mainMusicFileName = newMusicFileName;
                }

                var tagFile = TagLib.File.Create(mainMusicFileName);
                tagFile.Tag.Title = txtSongTitle.Text.Trim();
                tagFile.Tag.AlbumArtists = new string[1] { txtAlbumArtist.Text.Trim() };
                tagFile.Tag.Genres = new string[1] { txtGenre.Text.Trim() };
                tagFile.Tag.Album = txtAlbumName.Text.Trim();
                tagFile.Tag.Year = Convert.ToUInt32(txtYear.Text.Trim());

                tagFile.Save();

                mainMusicFileName = string.Empty;
                coverMusicFileName = string.Empty;
                pnlChosenFileInfo.Visible = false;
                MessageBox.Show("Attribute of song is successfully changed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch(Exception ex)
            {
                MessageBox.Show(string.Concat("Error ", ex.Message.Trim(), " | ", ex.StackTrace.Trim()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseCoverPictureFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog_CoverPicture.ShowDialog().Equals(DialogResult.OK))
                {
                    coverMusicFileName = openFileDialog_CoverPicture.FileName;
                    lblCoverPictureFileName.Text = coverMusicFileName;
                    btnChangeCoverPicture.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Error ", ex.Message.Trim(), " | ", ex.StackTrace.Trim()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangeCoverPicture_Click(object sender, EventArgs e)
        {
            try
            {
                var tagFile = TagLib.File.Create(mainMusicFileName);

                //Copied from : https://stackoverflow.com/a/50437638
                tagFile.Tag.Pictures = new TagLib.IPicture[]
                {
                new TagLib.Picture(new TagLib.ByteVector((byte[])new System.Drawing.ImageConverter().ConvertTo(System.Drawing.Image.FromFile(coverMusicFileName), typeof(byte[]))))
                {
                    Type = TagLib.PictureType.FrontCover,
                    Description = "Cover",
                    MimeType = System.Net.Mime.MediaTypeNames.Image.Jpeg
                }
                };

                tagFile.Save();

                btnChangeCoverPicture.Visible = false;
                coverMusicFileName = string.Empty;
                lblCoverPictureFileName.Text = string.Empty;
                pnlChosenFileInfo.Visible = false;
                MessageBox.Show("Cover picture of song is successfully changed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Concat("Error ", ex.Message.Trim(), " | ", ex.StackTrace.Trim()), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkFlagChangeMusicFileName_CheckedChanged(object sender, EventArgs e)
        {
            if(chkFlagChangeMusicFileName.Checked)
            {
                txtMusicFileName.Enabled = true; 
            } else
            {
                txtMusicFileName.Enabled = false;
            }
        }

        private void lblTitleChooseCoverPictureFile_Click(object sender, EventArgs e)
        {

        }
    }
}
