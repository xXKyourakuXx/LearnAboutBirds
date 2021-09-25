
namespace LearnAboutBirds
{
    partial class MainFrame
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
            this.datagrid = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // datagrid
            // 
            this.datagrid.AutoSize = true;
            this.datagrid.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.datagrid.BackColor = System.Drawing.Color.Transparent;
            this.datagrid.ColumnCount = 1;
            this.datagrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.datagrid.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.datagrid.Location = new System.Drawing.Point(152, 132);
            this.datagrid.Margin = new System.Windows.Forms.Padding(0);
            this.datagrid.Name = "datagrid";
            this.datagrid.RowCount = 1;
            this.datagrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.datagrid.Size = new System.Drawing.Size(0, 0);
            this.datagrid.TabIndex = 0;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::LearnAboutBirds.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.datagrid);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1366, 768);
            this.Name = "MainFrame";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Tanuljunk a madarakról!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel datagrid;
    }
}

