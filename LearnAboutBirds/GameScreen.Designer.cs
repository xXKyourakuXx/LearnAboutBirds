
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
            this.buttonToInfo = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // buttonToInfo
            // 
            this.buttonToInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonToInfo.AutoSize = true;
            this.buttonToInfo.BackColor = System.Drawing.Color.Gold;
            this.buttonToInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonToInfo.FlatAppearance.BorderSize = 0;
            this.buttonToInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.buttonToInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonToInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonToInfo.ForeColor = System.Drawing.Color.White;
            this.buttonToInfo.Location = new System.Drawing.Point(537, 401);
            this.buttonToInfo.Name = "buttonToInfo";
            this.buttonToInfo.Padding = new System.Windows.Forms.Padding(10);
            this.buttonToInfo.Size = new System.Drawing.Size(154, 69);
            this.buttonToInfo.TabIndex = 2;
            this.buttonToInfo.Text = "Vissza";
            this.buttonToInfo.UseVisualStyleBackColor = false;
            this.buttonToInfo.Click += new System.EventHandler(this.buttonToInfo_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRestart.AutoSize = true;
            this.buttonRestart.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRestart.FlatAppearance.BorderSize = 0;
            this.buttonRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRestart.ForeColor = System.Drawing.Color.White;
            this.buttonRestart.Location = new System.Drawing.Point(3, 401);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Padding = new System.Windows.Forms.Padding(10);
            this.buttonRestart.Size = new System.Drawing.Size(154, 69);
            this.buttonRestart.TabIndex = 3;
            this.buttonRestart.Text = "Újra";
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
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.BackgroundImage = global::LearnAboutBirds.Properties.Resources.gameBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.buttonToInfo);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(694, 473);
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToInfo;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.FlowLayoutPanel datagrid;
    }
}
