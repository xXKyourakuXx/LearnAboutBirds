
namespace LearnAboutBirds
{
    partial class GameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameScreen));
            this.buttonToInfo = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonLevel1 = new System.Windows.Forms.Button();
            this.buttonLevel2 = new System.Windows.Forms.Button();
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonToInfo
            // 
            this.buttonToInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonToInfo.AutoSize = true;
            this.buttonToInfo.BackColor = System.Drawing.Color.Gold;
            this.buttonToInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonToInfo.BackgroundImage")));
            this.buttonToInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonToInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToInfo.FlatAppearance.BorderSize = 0;
            this.buttonToInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.buttonToInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonToInfo.ForeColor = System.Drawing.Color.White;
            this.buttonToInfo.Location = new System.Drawing.Point(3, 401);
            this.buttonToInfo.Name = "buttonToInfo";
            this.buttonToInfo.Padding = new System.Windows.Forms.Padding(10);
            this.buttonToInfo.Size = new System.Drawing.Size(106, 69);
            this.buttonToInfo.TabIndex = 2;
            this.buttonToInfo.UseVisualStyleBackColor = false;
            this.buttonToInfo.Click += new System.EventHandler(this.buttonToInfo_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRestart.AutoSize = true;
            this.buttonRestart.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonRestart.BackgroundImage = global::LearnAboutBirds.Properties.Resources.reset;
            this.buttonRestart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRestart.FlatAppearance.BorderSize = 0;
            this.buttonRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRestart.ForeColor = System.Drawing.Color.White;
            this.buttonRestart.Location = new System.Drawing.Point(540, 401);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Padding = new System.Windows.Forms.Padding(10);
            this.buttonRestart.Size = new System.Drawing.Size(154, 69);
            this.buttonRestart.TabIndex = 3;
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // datagrid
            // 
            this.datagrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.datagrid.BackColor = System.Drawing.Color.Transparent;
            this.datagrid.Location = new System.Drawing.Point(168, 118);
            this.datagrid.Margin = new System.Windows.Forms.Padding(0);
            this.datagrid.Name = "datagrid";
            this.datagrid.Size = new System.Drawing.Size(200, 100);
            this.datagrid.TabIndex = 4;
            // 
            // buttonLevel1
            // 
            this.buttonLevel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLevel1.AutoSize = true;
            this.buttonLevel1.BackColor = System.Drawing.Color.Teal;
            this.buttonLevel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLevel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLevel1.Enabled = false;
            this.buttonLevel1.FlatAppearance.BorderSize = 0;
            this.buttonLevel1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.buttonLevel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLevel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLevel1.ForeColor = System.Drawing.Color.White;
            this.buttonLevel1.Location = new System.Drawing.Point(3, 3);
            this.buttonLevel1.Name = "buttonLevel1";
            this.buttonLevel1.Padding = new System.Windows.Forms.Padding(1);
            this.buttonLevel1.Size = new System.Drawing.Size(55, 58);
            this.buttonLevel1.TabIndex = 5;
            this.buttonLevel1.Text = "1";
            this.buttonLevel1.UseVisualStyleBackColor = false;
            this.buttonLevel1.Click += new System.EventHandler(this.buttonLevel1_Click);
            // 
            // buttonLevel2
            // 
            this.buttonLevel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLevel2.AutoSize = true;
            this.buttonLevel2.BackColor = System.Drawing.Color.Brown;
            this.buttonLevel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonLevel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLevel2.FlatAppearance.BorderSize = 0;
            this.buttonLevel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.buttonLevel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLevel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLevel2.ForeColor = System.Drawing.Color.White;
            this.buttonLevel2.Location = new System.Drawing.Point(3, 67);
            this.buttonLevel2.Name = "buttonLevel2";
            this.buttonLevel2.Padding = new System.Windows.Forms.Padding(1);
            this.buttonLevel2.Size = new System.Drawing.Size(55, 58);
            this.buttonLevel2.TabIndex = 6;
            this.buttonLevel2.Text = "2";
            this.buttonLevel2.UseVisualStyleBackColor = false;
            this.buttonLevel2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartStop.AutoSize = true;
            this.buttonStartStop.BackColor = System.Drawing.Color.Transparent;
            this.buttonStartStop.BackgroundImage = global::LearnAboutBirds.Properties.Resources.stop;
            this.buttonStartStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonStartStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartStop.FlatAppearance.BorderSize = 0;
            this.buttonStartStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.buttonStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStartStop.ForeColor = System.Drawing.Color.White;
            this.buttonStartStop.Location = new System.Drawing.Point(436, 401);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Padding = new System.Windows.Forms.Padding(10);
            this.buttonStartStop.Size = new System.Drawing.Size(86, 69);
            this.buttonStartStop.TabIndex = 7;
            this.buttonStartStop.UseVisualStyleBackColor = false;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = global::LearnAboutBirds.Properties.Resources.gameBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.buttonStartStop);
            this.Controls.Add(this.buttonLevel2);
            this.Controls.Add(this.buttonLevel1);
            this.Controls.Add(this.buttonToInfo);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.datagrid);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(697, 473);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToInfo;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.FlowLayoutPanel datagrid;
        private System.Windows.Forms.Button buttonLevel1;
        private System.Windows.Forms.Button buttonLevel2;
        private System.Windows.Forms.Button buttonStartStop;
    }
}
