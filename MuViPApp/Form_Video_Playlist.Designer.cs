﻿namespace MuViPApp
{
    partial class Form_Video_Playlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Video_Playlist));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.Date_create = new System.Windows.Forms.Label();
            this.Number_song_video = new System.Windows.Forms.Label();
            this.lb_NamePl = new System.Windows.Forms.Label();
            this.btn_Rename = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Addto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_Playall = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pn_List = new System.Windows.Forms.Panel();
            this.btn_goto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            this.pn_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.Date_create);
            this.panel1.Controls.Add(this.Number_song_video);
            this.panel1.Controls.Add(this.lb_NamePl);
            this.panel1.Controls.Add(this.btn_Rename);
            this.panel1.Controls.Add(this.btn_Addto);
            this.panel1.Controls.Add(this.btn_Playall);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 99);
            this.panel1.TabIndex = 2;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(74, 12);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(82, 69);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 12;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            // 
            // Date_create
            // 
            this.Date_create.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Date_create.AutoSize = true;
            this.Date_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_create.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Date_create.Location = new System.Drawing.Point(259, 42);
            this.Date_create.Name = "Date_create";
            this.Date_create.Size = new System.Drawing.Size(66, 13);
            this.Date_create.TabIndex = 9;
            this.Date_create.Text = "Date_create";
            // 
            // Number_song_video
            // 
            this.Number_song_video.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Number_song_video.AutoSize = true;
            this.Number_song_video.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number_song_video.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Number_song_video.Location = new System.Drawing.Point(193, 42);
            this.Number_song_video.Name = "Number_song_video";
            this.Number_song_video.Size = new System.Drawing.Size(42, 13);
            this.Number_song_video.TabIndex = 8;
            this.Number_song_video.Text = "0 video";
            // 
            // lb_NamePl
            // 
            this.lb_NamePl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_NamePl.AutoSize = true;
            this.lb_NamePl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NamePl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_NamePl.Location = new System.Drawing.Point(191, 12);
            this.lb_NamePl.Name = "lb_NamePl";
            this.lb_NamePl.Size = new System.Drawing.Size(70, 25);
            this.lb_NamePl.TabIndex = 7;
            this.lb_NamePl.Text = "name";
            // 
            // btn_Rename
            // 
            this.btn_Rename.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Rename.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Rename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btn_Rename.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Rename.BorderRadius = 0;
            this.btn_Rename.ButtonText = "Rename";
            this.btn_Rename.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Rename.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Rename.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rename.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Rename.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Rename.Iconimage")));
            this.btn_Rename.Iconimage_right = null;
            this.btn_Rename.Iconimage_right_Selected = null;
            this.btn_Rename.Iconimage_Selected = null;
            this.btn_Rename.IconMarginLeft = 0;
            this.btn_Rename.IconMarginRight = 0;
            this.btn_Rename.IconRightVisible = true;
            this.btn_Rename.IconRightZoom = 0D;
            this.btn_Rename.IconVisible = true;
            this.btn_Rename.IconZoom = 35D;
            this.btn_Rename.IsTab = false;
            this.btn_Rename.Location = new System.Drawing.Point(409, 70);
            this.btn_Rename.Name = "btn_Rename";
            this.btn_Rename.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btn_Rename.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btn_Rename.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Rename.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Rename.selected = false;
            this.btn_Rename.Size = new System.Drawing.Size(82, 20);
            this.btn_Rename.TabIndex = 5;
            this.btn_Rename.Text = "Rename";
            this.btn_Rename.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Rename.Textcolor = System.Drawing.Color.White;
            this.btn_Rename.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rename.Click += new System.EventHandler(this.btn_Rename_Click);
            // 
            // btn_Addto
            // 
            this.btn_Addto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Addto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Addto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btn_Addto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Addto.BorderRadius = 0;
            this.btn_Addto.ButtonText = "Add to";
            this.btn_Addto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Addto.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Addto.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Addto.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Addto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Addto.Iconimage")));
            this.btn_Addto.Iconimage_right = null;
            this.btn_Addto.Iconimage_right_Selected = null;
            this.btn_Addto.Iconimage_Selected = null;
            this.btn_Addto.IconMarginLeft = 0;
            this.btn_Addto.IconMarginRight = 0;
            this.btn_Addto.IconRightVisible = true;
            this.btn_Addto.IconRightZoom = 0D;
            this.btn_Addto.IconVisible = true;
            this.btn_Addto.IconZoom = 35D;
            this.btn_Addto.IsTab = false;
            this.btn_Addto.Location = new System.Drawing.Point(300, 70);
            this.btn_Addto.Name = "btn_Addto";
            this.btn_Addto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btn_Addto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btn_Addto.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Addto.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Addto.selected = false;
            this.btn_Addto.Size = new System.Drawing.Size(72, 20);
            this.btn_Addto.TabIndex = 4;
            this.btn_Addto.Text = "Add to";
            this.btn_Addto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Addto.Textcolor = System.Drawing.Color.White;
            this.btn_Addto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Addto.Click += new System.EventHandler(this.btn_Addto_Click);
            // 
            // btn_Playall
            // 
            this.btn_Playall.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_Playall.AllowDrop = true;
            this.btn_Playall.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Playall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btn_Playall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Playall.BorderRadius = 0;
            this.btn_Playall.ButtonText = "Play All";
            this.btn_Playall.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Playall.DisabledColor = System.Drawing.Color.Gray;
            this.btn_Playall.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Playall.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_Playall.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn_Playall.Iconimage")));
            this.btn_Playall.Iconimage_right = null;
            this.btn_Playall.Iconimage_right_Selected = null;
            this.btn_Playall.Iconimage_Selected = null;
            this.btn_Playall.IconMarginLeft = 0;
            this.btn_Playall.IconMarginRight = 0;
            this.btn_Playall.IconRightVisible = true;
            this.btn_Playall.IconRightZoom = 0D;
            this.btn_Playall.IconVisible = true;
            this.btn_Playall.IconZoom = 35D;
            this.btn_Playall.IsTab = false;
            this.btn_Playall.Location = new System.Drawing.Point(196, 70);
            this.btn_Playall.Name = "btn_Playall";
            this.btn_Playall.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btn_Playall.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(42)))), ((int)(((byte)(56)))));
            this.btn_Playall.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_Playall.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_Playall.selected = false;
            this.btn_Playall.Size = new System.Drawing.Size(75, 20);
            this.btn_Playall.TabIndex = 3;
            this.btn_Playall.Text = "Play All";
            this.btn_Playall.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Playall.Textcolor = System.Drawing.Color.White;
            this.btn_Playall.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // pn_List
            // 
            this.pn_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(45)))));
            this.pn_List.Controls.Add(this.btn_goto);
            this.pn_List.Controls.Add(this.label1);
            this.pn_List.Controls.Add(this.bunifuImageButton1);
            this.pn_List.Controls.Add(this.label2);
            this.pn_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_List.Location = new System.Drawing.Point(0, 99);
            this.pn_List.Name = "pn_List";
            this.pn_List.Size = new System.Drawing.Size(643, 312);
            this.pn_List.TabIndex = 3;
            // 
            // btn_goto
            // 
            this.btn_goto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btn_goto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btn_goto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_goto.BorderRadius = 0;
            this.btn_goto.ButtonText = "Go to my video";
            this.btn_goto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_goto.DisabledColor = System.Drawing.Color.DarkOrchid;
            this.btn_goto.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goto.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_goto.Iconimage = null;
            this.btn_goto.Iconimage_right = null;
            this.btn_goto.Iconimage_right_Selected = null;
            this.btn_goto.Iconimage_Selected = null;
            this.btn_goto.IconMarginLeft = 0;
            this.btn_goto.IconMarginRight = 0;
            this.btn_goto.IconRightVisible = true;
            this.btn_goto.IconRightZoom = 0D;
            this.btn_goto.IconVisible = true;
            this.btn_goto.IconZoom = 35D;
            this.btn_goto.IsTab = false;
            this.btn_goto.Location = new System.Drawing.Point(109, 119);
            this.btn_goto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_goto.Name = "btn_goto";
            this.btn_goto.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btn_goto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btn_goto.OnHoverTextColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_goto.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.btn_goto.selected = false;
            this.btn_goto.Size = new System.Drawing.Size(156, 20);
            this.btn_goto.TabIndex = 14;
            this.btn_goto.Text = "Go to my video";
            this.btn_goto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_goto.Textcolor = System.Drawing.Color.DarkOrchid;
            this.btn_goto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_goto.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(109, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Add song from my video";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(59, 102);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(37, 34);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 11;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(55, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "What\'s a playlist without video?";
            // 
            // Form_Video_Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 411);
            this.Controls.Add(this.pn_List);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Video_Playlist";
            this.Text = "Form_Video_Playlist";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            this.pn_List.ResumeLayout(false);
            this.pn_List.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Date_create;
        private System.Windows.Forms.Label Number_song_video;
        public System.Windows.Forms.Label lb_NamePl;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Rename;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Addto;
        private Bunifu.Framework.UI.BunifuFlatButton btn_Playall;
        private System.Windows.Forms.Panel pn_List;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_goto;
    }
}