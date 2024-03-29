﻿
using System;

namespace LearnAboutBirds
{
    partial class InfoScreen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.buttonToGame = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // buttonToGame
            // 
            this.buttonToGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToGame.AutoSize = true;
            this.buttonToGame.BackColor = System.Drawing.Color.Gold;
            this.buttonToGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToGame.FlatAppearance.BorderSize = 0;
            this.buttonToGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.buttonToGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonToGame.ForeColor = System.Drawing.Color.White;
            this.buttonToGame.Location = new System.Drawing.Point(581, 405);
            this.buttonToGame.Name = "buttonToGame";
            this.buttonToGame.Padding = new System.Windows.Forms.Padding(10);
            this.buttonToGame.Size = new System.Drawing.Size(147, 69);
            this.buttonToGame.TabIndex = 2;
            this.buttonToGame.Text = "Játék";
            this.buttonToGame.UseVisualStyleBackColor = false;
            this.buttonToGame.Click += new System.EventHandler(this.buttonToGame_Click);
            // 
            // datagrid
            // 
            this.datagrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.datagrid.BackColor = System.Drawing.Color.Transparent;
            this.datagrid.Location = new System.Drawing.Point(190, 133);
            this.datagrid.Margin = new System.Windows.Forms.Padding(0);
            this.datagrid.MinimumSize = new System.Drawing.Size(250, 300);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(250, 300);
            this.datagrid.TabIndex = 4;
            // 
            // InfoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::LearnAboutBirds.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.buttonToGame);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "InfoScreen";
            this.Size = new System.Drawing.Size(731, 477);
            this.Load += new System.EventHandler(this.InfoScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToGame;
        private System.Windows.Forms.FlowLayoutPanel datagrid;
    }
}
