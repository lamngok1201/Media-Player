﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuViPApp.Music;

namespace MuViPApp
{
    public partial class SubPanelSelect : UserControl
    {
        Form_ListMusic parent;
        ContextMenuStrip toolStrip = new ContextMenuStrip();
        public SubPanelSelect(Form_ListMusic parent = null)
        {
            this.parent = parent;
            InitializeComponent();
            toolStrip.ItemClicked += ClickItem;
        }

        private void ClickItem(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Text)
            {
                case "Now playing":
                    this.parent.AddtoNowPlaying();
                    break;
                case "New playlist":
                    this.parent.AddToNewPlaylist();
                    break;
                default:
                    foreach (PlayListInfo item in Playlist.Instance.GetAllPlayListMusic())
                    {
                        if (item.Name_PL == e.ClickedItem.Text)
                        {
                            this.parent.AddToPlaylist(item);
                            break;
                        }
                    }
                    break;
            }
            toolStrip = null;
            this.parent.AfterClick();
        }

        private void btn_SelectAll_Click(object sender, EventArgs e)
        {
            this.parent.SelectAll();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            this.parent.DeleteMusic();
            this.parent.AfterClick();
        }

        private void btn_Addto_Click(object sender, EventArgs e)
        {
            toolStrip.Items.Clear();
            toolStrip.Items.Add("Now playing");
            toolStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;
            toolStrip.Items.Add("-");
            toolStrip.Items.Add("New playlist");
            int Y = 400;
            foreach (PlayListInfo item in Playlist.Instance.GetAllPlayListMusic())
            {
                toolStrip.Items.Add(item.Name_PL);
                Y -= 22;
            }
            toolStrip.Location = new Point(btn_Addto.Location.X + 70, btn_Addto.Location.Y + Y);
            toolStrip.Show(MousePosition);
            toolStrip.BringToFront();
            toolStrip.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip.Dock = DockStyle.None;
        }

        private void btn_PlayNext_Click(object sender, EventArgs e)
        {
            this.parent.Playnext();
            this.parent.AfterClick();
        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            this.parent.Music_Click(this, new EventArgs());
            this.parent.AfterClick();
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.parent.CancelSelect();
            this.parent.AfterClick();
        }
    }
}
