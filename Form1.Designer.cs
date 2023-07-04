
namespace WindowsFormsApp1
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
            this.lblTitleChooseSongFile = new System.Windows.Forms.Label();
            this.btnBrowseSongFile = new System.Windows.Forms.Button();
            this.pnlChosenFileInfo = new System.Windows.Forms.Panel();
            this.lblCoverPictureFileName = new System.Windows.Forms.Label();
            this.btnBrowseCoverPictureFile = new System.Windows.Forms.Button();
            this.lblTitleChooseCoverPictureFile = new System.Windows.Forms.Label();
            this.lblMainTitleCoverPicture = new System.Windows.Forms.Label();
            this.btnChangeCoverPicture = new System.Windows.Forms.Button();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.lblTitleGenre = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblTitle_Year = new System.Windows.Forms.Label();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.lblTitle_AlbumName = new System.Windows.Forms.Label();
            this.txtAlbumArtist = new System.Windows.Forms.TextBox();
            this.lblTitle_Title = new System.Windows.Forms.Label();
            this.lblTitle_AlbumArtist = new System.Windows.Forms.Label();
            this.btnChangeSongAttribute = new System.Windows.Forms.Button();
            this.txtSongTitle = new System.Windows.Forms.TextBox();
            this.lblChosenFileName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog_SongFile = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog_CoverPicture = new System.Windows.Forms.OpenFileDialog();
            this.pbMusicCoverPicture = new System.Windows.Forms.PictureBox();
            this.pnlChosenFileInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusicCoverPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleChooseSongFile
            // 
            this.lblTitleChooseSongFile.AutoSize = true;
            this.lblTitleChooseSongFile.Location = new System.Drawing.Point(43, 27);
            this.lblTitleChooseSongFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleChooseSongFile.Name = "lblTitleChooseSongFile";
            this.lblTitleChooseSongFile.Size = new System.Drawing.Size(167, 17);
            this.lblTitleChooseSongFile.TabIndex = 0;
            this.lblTitleChooseSongFile.Text = "Choose Song/Music File :";
            // 
            // btnBrowseSongFile
            // 
            this.btnBrowseSongFile.Location = new System.Drawing.Point(237, 21);
            this.btnBrowseSongFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowseSongFile.Name = "btnBrowseSongFile";
            this.btnBrowseSongFile.Size = new System.Drawing.Size(124, 28);
            this.btnBrowseSongFile.TabIndex = 1;
            this.btnBrowseSongFile.Text = "Browse Song";
            this.btnBrowseSongFile.UseVisualStyleBackColor = true;
            this.btnBrowseSongFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // pnlChosenFileInfo
            // 
            this.pnlChosenFileInfo.Controls.Add(this.pbMusicCoverPicture);
            this.pnlChosenFileInfo.Controls.Add(this.lblCoverPictureFileName);
            this.pnlChosenFileInfo.Controls.Add(this.btnBrowseCoverPictureFile);
            this.pnlChosenFileInfo.Controls.Add(this.lblTitleChooseCoverPictureFile);
            this.pnlChosenFileInfo.Controls.Add(this.lblMainTitleCoverPicture);
            this.pnlChosenFileInfo.Controls.Add(this.btnChangeCoverPicture);
            this.pnlChosenFileInfo.Controls.Add(this.txtGenre);
            this.pnlChosenFileInfo.Controls.Add(this.lblTitleGenre);
            this.pnlChosenFileInfo.Controls.Add(this.txtYear);
            this.pnlChosenFileInfo.Controls.Add(this.lblTitle_Year);
            this.pnlChosenFileInfo.Controls.Add(this.txtAlbumName);
            this.pnlChosenFileInfo.Controls.Add(this.lblTitle_AlbumName);
            this.pnlChosenFileInfo.Controls.Add(this.txtAlbumArtist);
            this.pnlChosenFileInfo.Controls.Add(this.lblTitle_Title);
            this.pnlChosenFileInfo.Controls.Add(this.lblTitle_AlbumArtist);
            this.pnlChosenFileInfo.Controls.Add(this.btnChangeSongAttribute);
            this.pnlChosenFileInfo.Controls.Add(this.txtSongTitle);
            this.pnlChosenFileInfo.Controls.Add(this.lblChosenFileName);
            this.pnlChosenFileInfo.Controls.Add(this.label3);
            this.pnlChosenFileInfo.Location = new System.Drawing.Point(47, 97);
            this.pnlChosenFileInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlChosenFileInfo.Name = "pnlChosenFileInfo";
            this.pnlChosenFileInfo.Size = new System.Drawing.Size(944, 388);
            this.pnlChosenFileInfo.TabIndex = 2;
            this.pnlChosenFileInfo.Visible = false;
            // 
            // lblCoverPictureFileName
            // 
            this.lblCoverPictureFileName.AutoSize = true;
            this.lblCoverPictureFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoverPictureFileName.Location = new System.Drawing.Point(259, 265);
            this.lblCoverPictureFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoverPictureFileName.Name = "lblCoverPictureFileName";
            this.lblCoverPictureFileName.Size = new System.Drawing.Size(0, 20);
            this.lblCoverPictureFileName.TabIndex = 17;
            // 
            // btnBrowseCoverPictureFile
            // 
            this.btnBrowseCoverPictureFile.Location = new System.Drawing.Point(190, 289);
            this.btnBrowseCoverPictureFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowseCoverPictureFile.Name = "btnBrowseCoverPictureFile";
            this.btnBrowseCoverPictureFile.Size = new System.Drawing.Size(171, 28);
            this.btnBrowseCoverPictureFile.TabIndex = 16;
            this.btnBrowseCoverPictureFile.Text = "Browse Cover Picture";
            this.btnBrowseCoverPictureFile.UseVisualStyleBackColor = true;
            this.btnBrowseCoverPictureFile.Click += new System.EventHandler(this.btnBrowseCoverPictureFile_Click);
            // 
            // lblTitleChooseCoverPictureFile
            // 
            this.lblTitleChooseCoverPictureFile.AutoSize = true;
            this.lblTitleChooseCoverPictureFile.Location = new System.Drawing.Point(5, 295);
            this.lblTitleChooseCoverPictureFile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleChooseCoverPictureFile.Name = "lblTitleChooseCoverPictureFile";
            this.lblTitleChooseCoverPictureFile.Size = new System.Drawing.Size(179, 17);
            this.lblTitleChooseCoverPictureFile.TabIndex = 15;
            this.lblTitleChooseCoverPictureFile.Text = "Choose Cover Picture File :";
            // 
            // lblMainTitleCoverPicture
            // 
            this.lblMainTitleCoverPicture.AutoSize = true;
            this.lblMainTitleCoverPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainTitleCoverPicture.Location = new System.Drawing.Point(4, 265);
            this.lblMainTitleCoverPicture.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMainTitleCoverPicture.Name = "lblMainTitleCoverPicture";
            this.lblMainTitleCoverPicture.Size = new System.Drawing.Size(227, 20);
            this.lblMainTitleCoverPicture.TabIndex = 14;
            this.lblMainTitleCoverPicture.Text = "Cover Picture File Name :";
            this.lblMainTitleCoverPicture.UseMnemonic = false;
            // 
            // btnChangeCoverPicture
            // 
            this.btnChangeCoverPicture.Location = new System.Drawing.Point(432, 339);
            this.btnChangeCoverPicture.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChangeCoverPicture.Name = "btnChangeCoverPicture";
            this.btnChangeCoverPicture.Size = new System.Drawing.Size(161, 28);
            this.btnChangeCoverPicture.TabIndex = 13;
            this.btnChangeCoverPicture.Text = "Change Cover Picture";
            this.btnChangeCoverPicture.UseVisualStyleBackColor = true;
            this.btnChangeCoverPicture.Visible = false;
            this.btnChangeCoverPicture.Click += new System.EventHandler(this.btnChangeCoverPicture_Click);
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(125, 140);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(280, 22);
            this.txtGenre.TabIndex = 12;
            // 
            // lblTitleGenre
            // 
            this.lblTitleGenre.AutoSize = true;
            this.lblTitleGenre.Location = new System.Drawing.Point(25, 140);
            this.lblTitleGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleGenre.Name = "lblTitleGenre";
            this.lblTitleGenre.Size = new System.Drawing.Size(56, 17);
            this.lblTitleGenre.TabIndex = 11;
            this.lblTitleGenre.Text = "Genre :";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(597, 92);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(132, 22);
            this.txtYear.TabIndex = 10;
            // 
            // lblTitle_Year
            // 
            this.lblTitle_Year.AutoSize = true;
            this.lblTitle_Year.Location = new System.Drawing.Point(475, 97);
            this.lblTitle_Year.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle_Year.Name = "lblTitle_Year";
            this.lblTitle_Year.Size = new System.Drawing.Size(46, 17);
            this.lblTitle_Year.TabIndex = 9;
            this.lblTitle_Year.Text = "Year :";
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(597, 49);
            this.txtAlbumName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(279, 22);
            this.txtAlbumName.TabIndex = 8;
            // 
            // lblTitle_AlbumName
            // 
            this.lblTitle_AlbumName.AutoSize = true;
            this.lblTitle_AlbumName.Location = new System.Drawing.Point(475, 49);
            this.lblTitle_AlbumName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle_AlbumName.Name = "lblTitle_AlbumName";
            this.lblTitle_AlbumName.Size = new System.Drawing.Size(96, 17);
            this.lblTitle_AlbumName.TabIndex = 7;
            this.lblTitle_AlbumName.Text = "Album Name :";
            // 
            // txtAlbumArtist
            // 
            this.txtAlbumArtist.Location = new System.Drawing.Point(125, 94);
            this.txtAlbumArtist.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAlbumArtist.Name = "txtAlbumArtist";
            this.txtAlbumArtist.Size = new System.Drawing.Size(280, 22);
            this.txtAlbumArtist.TabIndex = 6;
            // 
            // lblTitle_Title
            // 
            this.lblTitle_Title.AutoSize = true;
            this.lblTitle_Title.Location = new System.Drawing.Point(25, 53);
            this.lblTitle_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle_Title.Name = "lblTitle_Title";
            this.lblTitle_Title.Size = new System.Drawing.Size(43, 17);
            this.lblTitle_Title.TabIndex = 0;
            this.lblTitle_Title.Text = "Title :";
            // 
            // lblTitle_AlbumArtist
            // 
            this.lblTitle_AlbumArtist.AutoSize = true;
            this.lblTitle_AlbumArtist.Location = new System.Drawing.Point(25, 94);
            this.lblTitle_AlbumArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle_AlbumArtist.Name = "lblTitle_AlbumArtist";
            this.lblTitle_AlbumArtist.Size = new System.Drawing.Size(48, 17);
            this.lblTitle_AlbumArtist.TabIndex = 5;
            this.lblTitle_AlbumArtist.Text = "Artist :";
            // 
            // btnChangeSongAttribute
            // 
            this.btnChangeSongAttribute.Location = new System.Drawing.Point(28, 170);
            this.btnChangeSongAttribute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChangeSongAttribute.Name = "btnChangeSongAttribute";
            this.btnChangeSongAttribute.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnChangeSongAttribute.Size = new System.Drawing.Size(135, 28);
            this.btnChangeSongAttribute.TabIndex = 4;
            this.btnChangeSongAttribute.Text = "Change Attribute";
            this.btnChangeSongAttribute.UseVisualStyleBackColor = true;
            this.btnChangeSongAttribute.Click += new System.EventHandler(this.btnChangeSongAttribute_Click);
            // 
            // txtSongTitle
            // 
            this.txtSongTitle.Location = new System.Drawing.Point(125, 46);
            this.txtSongTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSongTitle.Name = "txtSongTitle";
            this.txtSongTitle.Size = new System.Drawing.Size(280, 22);
            this.txtSongTitle.TabIndex = 3;
            // 
            // lblChosenFileName
            // 
            this.lblChosenFileName.AutoSize = true;
            this.lblChosenFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChosenFileName.Location = new System.Drawing.Point(165, 5);
            this.lblChosenFileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChosenFileName.Name = "lblChosenFileName";
            this.lblChosenFileName.Size = new System.Drawing.Size(0, 20);
            this.lblChosenFileName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Music File Name :";
            this.label3.UseMnemonic = false;
            // 
            // openFileDialog_SongFile
            // 
            this.openFileDialog_SongFile.DefaultExt = "mp3";
            this.openFileDialog_SongFile.FileName = "openFileDialog_SongFile";
            this.openFileDialog_SongFile.Filter = "MP3 files|*.mp3";
            this.openFileDialog_SongFile.RestoreDirectory = true;
            this.openFileDialog_SongFile.Title = "Choose MP3 File";
            // 
            // openFileDialog_CoverPicture
            // 
            this.openFileDialog_CoverPicture.FileName = "openFileDialog_CoverPicture";
            this.openFileDialog_CoverPicture.Filter = "Images files|*.jpg|*.jpeg|";
            this.openFileDialog_CoverPicture.RestoreDirectory = true;
            // 
            // pbMusicCoverPicture
            // 
            this.pbMusicCoverPicture.Location = new System.Drawing.Point(478, 140);
            this.pbMusicCoverPicture.Name = "pbMusicCoverPicture";
            this.pbMusicCoverPicture.Size = new System.Drawing.Size(366, 120);
            this.pbMusicCoverPicture.TabIndex = 18;
            this.pbMusicCoverPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 509);
            this.Controls.Add(this.pnlChosenFileInfo);
            this.Controls.Add(this.btnBrowseSongFile);
            this.Controls.Add(this.lblTitleChooseSongFile);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlChosenFileInfo.ResumeLayout(false);
            this.pnlChosenFileInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMusicCoverPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleChooseSongFile;
        private System.Windows.Forms.Button btnBrowseSongFile;
        private System.Windows.Forms.Panel pnlChosenFileInfo;
        private System.Windows.Forms.OpenFileDialog openFileDialog_SongFile;
        private System.Windows.Forms.Label lblTitle_Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblChosenFileName;
        private System.Windows.Forms.TextBox txtSongTitle;
        private System.Windows.Forms.Button btnChangeSongAttribute;
        private System.Windows.Forms.TextBox txtAlbumArtist;
        private System.Windows.Forms.Label lblTitle_AlbumArtist;
        private System.Windows.Forms.TextBox txtAlbumName;
        private System.Windows.Forms.Label lblTitle_AlbumName;
        private System.Windows.Forms.Label lblTitle_Year;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.Label lblTitleGenre;
        private System.Windows.Forms.Button btnChangeCoverPicture;
        private System.Windows.Forms.Label lblTitleChooseCoverPictureFile;
        private System.Windows.Forms.Label lblMainTitleCoverPicture;
        private System.Windows.Forms.Button btnBrowseCoverPictureFile;
        private System.Windows.Forms.Label lblCoverPictureFileName;
        private System.Windows.Forms.OpenFileDialog openFileDialog_CoverPicture;
        private System.Windows.Forms.PictureBox pbMusicCoverPicture;
    }
}

