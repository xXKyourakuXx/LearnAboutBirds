
namespace LearnAboutBirds
{
    partial class InfoScreen
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
            this.buttonToGame = new System.Windows.Forms.Button();
            this.datagrid = new System.Windows.Forms.TableLayoutPanel();
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
            this.buttonToGame.Location = new System.Drawing.Point(581, 338);
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
            this.datagrid.AutoSize = true;
            this.datagrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.datagrid.BackColor = System.Drawing.Color.Transparent;
            this.datagrid.ColumnCount = 1;
            this.datagrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.datagrid.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.datagrid.Location = new System.Drawing.Point(365, 205);
            this.datagrid.Margin = new System.Windows.Forms.Padding(0);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowCount = 1;
            this.datagrid.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.datagrid.Size = new System.Drawing.Size(0, 0);
            this.datagrid.TabIndex = 3;
            // 
            // InfoScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::LearnAboutBirds.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Controls.Add(this.datagrid);
            this.Controls.Add(this.buttonToGame);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "InfoScreen";
            this.Size = new System.Drawing.Size(731, 410);
            this.Load += new System.EventHandler(this.InfoScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToGame;
        private System.Windows.Forms.TableLayoutPanel datagrid;
    }
}
