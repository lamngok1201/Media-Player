﻿namespace MuViPApp
{
    partial class Form_My_Video
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_List = new System.Windows.Forms.Panel();
            this.pn_Top = new System.Windows.Forms.Panel();
            this.lb_view = new System.Windows.Forms.Label();
            this.Cb_My_Music_View = new Bunifu.Framework.UI.BunifuDropdown();
            this.count_items = new System.Windows.Forms.Label();
            this.btn_My_Music_Play_all = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lb_My_Music = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pn_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_List);
            this.panel1.Controls.Add(this.pn_Top);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 4;
            // 
            // panel_List
            // 
            this.panel_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_List.Location = new System.Drawing.Point(0, 133);
            this.panel_List.Name = "panel_List";
            this.panel_List.Size = new System.Drawing.Size(800, 317);
            this.panel_List.TabIndex = 2;
            // 
            // pn_Top
            // 
            this.pn_Top.Controls.Add(this.lb_view);
            this.pn_Top.Controls.Add(this.Cb_My_Music_View);
            this.pn_Top.Controls.Add(this.count_items);
            this.pn_Top.Controls.Add(this.btn_My_Music_Play_all);
            this.pn_Top.Controls.Add(this.lb_My_Music);
            this.pn_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Top.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pn_Top.Location = new System.Drawing.Point(0, 0);
            this.pn_Top.Name = "pn_Top";
            this.pn_Top.Size = new System.Drawing.Size(800, 133);
            this.pn_Top.TabIndex = 1;
            // 
            // lb_view
            // 
            this.lb_view.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_view.AutoSize = true;
            this.lb_view.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_view.Location = new System.Drawing.Point(630, 97);
            this.lb_view.Name = "lb_view";
            this.lb_view.Size = new System.Drawing.Size(42, 16);
            this.lb_view.TabIndex = 11;
            this.lb_view.Text = "View :";
            // 
            // Cb_My_Music_View
            // 
            this.Cb_My_Music_View.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cb_My_Music_View.BackColor = System.Drawing.Color.Transparent;
            this.Cb_My_Music_View.BorderRadius = 3;
            this.Cb_My_Music_View.ForeColor = System.Drawing.Color.MediumOrchid;
            this.Cb_My_Music_View.Items = new string[] {
        "Details",
        "Title",
        "Large icon",
        "Small icon"};
            this.Cb_My_Music_View.Location = new System.Drawing.Point(671, 93);
            this.Cb_My_Music_View.Name = "Cb_My_Music_View";
            this.Cb_My_Music_View.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.Cb_My_Music_View.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.Cb_My_Music_View.selectedIndex = 0;
            this.Cb_My_Music_View.Size = new System.Drawing.Size(117, 25);
            this.Cb_My_Music_View.TabIndex = 10;
            // 
            // count_items
            // 
            this.count_items.AutoSize = true;
            this.count_items.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.count_items.Location = new System.Drawing.Point(221, 44);
            this.count_items.Name = "count_items";
            this.count_items.Size = new System.Drawing.Size(0, 21);
            this.count_items.TabIndex = 9;
            // 
            // btn_My_Music_Play_all
            // 
            this.btn_My_Music_Play_all.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btn_My_Music_Play_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btn_My_Music_Play_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_My_Music_Play_all.BorderRadius = 0;
            this.btn_My_Music_Play_all.ButtonText = "Play all";
            this.btn_My_Music_Play_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_My_Music_Play_all.DisabledColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_My_Music_Play_all.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_My_Music_Play_all.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_My_Music_Play_all.Iconimage = null;
            this.btn_My_Music_Play_all.Iconimage_right = null;
            this.btn_My_Music_Play_all.Iconimage_right_Selected = null;
            this.btn_My_Music_Play_all.Iconimage_Selected = null;
            this.btn_My_Music_Play_all.IconMarginLeft = 0;
            this.btn_My_Music_Play_all.IconMarginRight = 0;
            this.btn_My_Music_Play_all.IconRightVisible = true;
            this.btn_My_Music_Play_all.IconRightZoom = 0D;
            this.btn_My_Music_Play_all.IconVisible = true;
            this.btn_My_Music_Play_all.IconZoom = 35D;
            this.btn_My_Music_Play_all.IsTab = false;
            this.btn_My_Music_Play_all.Location = new System.Drawing.Point(95, 62);
            this.btn_My_Music_Play_all.Name = "btn_My_Music_Play_all";
            this.btn_My_Music_Play_all.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btn_My_Music_Play_all.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btn_My_Music_Play_all.OnHoverTextColor = System.Drawing.Color.DarkViolet;
            this.btn_My_Music_Play_all.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btn_My_Music_Play_all.selected = false;
            this.btn_My_Music_Play_all.Size = new System.Drawing.Size(129, 47);
            this.btn_My_Music_Play_all.TabIndex = 6;
            this.btn_My_Music_Play_all.Text = "Play all";
            this.btn_My_Music_Play_all.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_My_Music_Play_all.Textcolor = System.Drawing.Color.White;
            this.btn_My_Music_Play_all.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lb_My_Music
            // 
            this.lb_My_Music.AutoSize = true;
            this.lb_My_Music.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_My_Music.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_My_Music.Location = new System.Drawing.Point(47, 25);
            this.lb_My_Music.Name = "lb_My_Music";
            this.lb_My_Music.Size = new System.Drawing.Size(176, 47);
            this.lb_My_Music.TabIndex = 0;
            this.lb_My_Music.Text = "My Video";
            // 
            // Form_My_Video
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_My_Video";
            this.Text = "Form_My_Video";
            this.panel1.ResumeLayout(false);
            this.pn_Top.ResumeLayout(false);
            this.pn_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pn_Top;
        private System.Windows.Forms.Label lb_view;
        private Bunifu.Framework.UI.BunifuDropdown Cb_My_Music_View;
        private System.Windows.Forms.Label count_items;
        private Bunifu.Framework.UI.BunifuFlatButton btn_My_Music_Play_all;
        private System.Windows.Forms.Label lb_My_Music;
        private System.Windows.Forms.Panel panel_List;
    }
}