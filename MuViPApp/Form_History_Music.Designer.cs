﻿namespace MuViPApp
{
    partial class Form_History_Music
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
            this.pn_Top = new System.Windows.Forms.Panel();
            this.lb_History_Music = new System.Windows.Forms.Label();
            this.pn_List = new System.Windows.Forms.Panel();
            this.pn_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Top
            // 
            this.pn_Top.Controls.Add(this.lb_History_Music);
            this.pn_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_Top.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pn_Top.Location = new System.Drawing.Point(0, 0);
            this.pn_Top.Name = "pn_Top";
            this.pn_Top.Size = new System.Drawing.Size(800, 100);
            this.pn_Top.TabIndex = 2;
            // 
            // lb_History_Music
            // 
            this.lb_History_Music.AutoSize = true;
            this.lb_History_Music.Font = new System.Drawing.Font("Microsoft Tai Le", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_History_Music.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lb_History_Music.Location = new System.Drawing.Point(47, 25);
            this.lb_History_Music.Name = "lb_History_Music";
            this.lb_History_Music.Size = new System.Drawing.Size(137, 47);
            this.lb_History_Music.TabIndex = 0;
            this.lb_History_Music.Text = "History";
            // 
            // pn_List
            // 
            this.pn_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_List.Location = new System.Drawing.Point(0, 100);
            this.pn_List.Name = "pn_List";
            this.pn_List.Size = new System.Drawing.Size(800, 350);
            this.pn_List.TabIndex = 4;
            // 
            // Form_History_Music
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pn_List);
            this.Controls.Add(this.pn_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_History_Music";
            this.Text = "Form_History_Music";
            this.pn_Top.ResumeLayout(false);
            this.pn_Top.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Top;
        private System.Windows.Forms.Label lb_History_Music;
        private System.Windows.Forms.Panel pn_List;
    }
}