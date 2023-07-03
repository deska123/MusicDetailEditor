
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.pnlChosenFileInfo = new System.Windows.Forms.Panel();
            this.lblChosenFileName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTitle_Title = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.txtSongTitle = new System.Windows.Forms.TextBox();
            this.btnChangeSongAttribute = new System.Windows.Forms.Button();
            this.lblTitle_AlbumArtist = new System.Windows.Forms.Label();
            this.txtAlbumArtist = new System.Windows.Forms.TextBox();
            this.lblTitle_AlbumName = new System.Windows.Forms.Label();
            this.txtAlbumName = new System.Windows.Forms.TextBox();
            this.lblTitle_Year = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblTitleGenre = new System.Windows.Forms.Label();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.pnlChosenFileInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose File :";
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(120, 17);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseFile.TabIndex = 1;
            this.btnBrowseFile.Text = "Browse";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnChooseFile_Click);
            // 
            // pnlChosenFileInfo
            // 
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
            this.pnlChosenFileInfo.Location = new System.Drawing.Point(35, 79);
            this.pnlChosenFileInfo.Name = "pnlChosenFileInfo";
            this.pnlChosenFileInfo.Size = new System.Drawing.Size(708, 243);
            this.pnlChosenFileInfo.TabIndex = 2;
            this.pnlChosenFileInfo.Visible = false;
            // 
            // lblChosenFileName
            // 
            this.lblChosenFileName.AutoSize = true;
            this.lblChosenFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChosenFileName.Location = new System.Drawing.Point(124, 4);
            this.lblChosenFileName.Name = "lblChosenFileName";
            this.lblChosenFileName.Size = new System.Drawing.Size(0, 16);
            this.lblChosenFileName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "File Name :";
            this.label3.UseMnemonic = false;
            // 
            // lblTitle_Title
            // 
            this.lblTitle_Title.AutoSize = true;
            this.lblTitle_Title.Location = new System.Drawing.Point(19, 43);
            this.lblTitle_Title.Name = "lblTitle_Title";
            this.lblTitle_Title.Size = new System.Drawing.Size(33, 13);
            this.lblTitle_Title.TabIndex = 0;
            this.lblTitle_Title.Text = "Title :";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "mp3";
            this.openFileDialog.FileName = "ChosenFileName";
            this.openFileDialog.Filter = "MP3 files|*.mp3";
            this.openFileDialog.Title = "Choose MP3 File";
            // 
            // txtSongTitle
            // 
            this.txtSongTitle.Location = new System.Drawing.Point(94, 40);
            this.txtSongTitle.Name = "txtSongTitle";
            this.txtSongTitle.Size = new System.Drawing.Size(211, 20);
            this.txtSongTitle.TabIndex = 3;
            // 
            // btnChangeSongAttribute
            // 
            this.btnChangeSongAttribute.Location = new System.Drawing.Point(356, 214);
            this.btnChangeSongAttribute.Name = "btnChangeSongAttribute";
            this.btnChangeSongAttribute.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnChangeSongAttribute.Size = new System.Drawing.Size(75, 23);
            this.btnChangeSongAttribute.TabIndex = 4;
            this.btnChangeSongAttribute.Text = "Change Attribute";
            this.btnChangeSongAttribute.UseVisualStyleBackColor = true;
            this.btnChangeSongAttribute.Click += new System.EventHandler(this.btnChangeSongAttribute_Click);
            // 
            // lblTitle_AlbumArtist
            // 
            this.lblTitle_AlbumArtist.AutoSize = true;
            this.lblTitle_AlbumArtist.Location = new System.Drawing.Point(19, 76);
            this.lblTitle_AlbumArtist.Name = "lblTitle_AlbumArtist";
            this.lblTitle_AlbumArtist.Size = new System.Drawing.Size(36, 13);
            this.lblTitle_AlbumArtist.TabIndex = 5;
            this.lblTitle_AlbumArtist.Text = "Artist :";
            // 
            // txtAlbumArtist
            // 
            this.txtAlbumArtist.Location = new System.Drawing.Point(94, 76);
            this.txtAlbumArtist.Name = "txtAlbumArtist";
            this.txtAlbumArtist.Size = new System.Drawing.Size(211, 20);
            this.txtAlbumArtist.TabIndex = 6;
            // 
            // lblTitle_AlbumName
            // 
            this.lblTitle_AlbumName.AutoSize = true;
            this.lblTitle_AlbumName.Location = new System.Drawing.Point(356, 40);
            this.lblTitle_AlbumName.Name = "lblTitle_AlbumName";
            this.lblTitle_AlbumName.Size = new System.Drawing.Size(73, 13);
            this.lblTitle_AlbumName.TabIndex = 7;
            this.lblTitle_AlbumName.Text = "Album Name :";
            // 
            // txtAlbumName
            // 
            this.txtAlbumName.Location = new System.Drawing.Point(448, 40);
            this.txtAlbumName.Name = "txtAlbumName";
            this.txtAlbumName.Size = new System.Drawing.Size(210, 20);
            this.txtAlbumName.TabIndex = 8;
            // 
            // lblTitle_Year
            // 
            this.lblTitle_Year.AutoSize = true;
            this.lblTitle_Year.Location = new System.Drawing.Point(356, 79);
            this.lblTitle_Year.Name = "lblTitle_Year";
            this.lblTitle_Year.Size = new System.Drawing.Size(35, 13);
            this.lblTitle_Year.TabIndex = 9;
            this.lblTitle_Year.Text = "Year :";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(448, 75);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 10;
            // 
            // lblTitleGenre
            // 
            this.lblTitleGenre.AutoSize = true;
            this.lblTitleGenre.Location = new System.Drawing.Point(19, 114);
            this.lblTitleGenre.Name = "lblTitleGenre";
            this.lblTitleGenre.Size = new System.Drawing.Size(42, 13);
            this.lblTitleGenre.TabIndex = 11;
            this.lblTitleGenre.Text = "Genre :";
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(94, 114);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(211, 20);
            this.txtGenre.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlChosenFileInfo);
            this.Controls.Add(this.btnBrowseFile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlChosenFileInfo.ResumeLayout(false);
            this.pnlChosenFileInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.Panel pnlChosenFileInfo;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
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
    }
}

