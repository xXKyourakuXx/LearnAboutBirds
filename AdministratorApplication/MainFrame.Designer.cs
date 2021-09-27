
namespace AdministratorApplication
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
            this.panelRight = new System.Windows.Forms.Panel();
            this.groupBoxBirdInfo = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelDetails = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBrowseSound = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLevel = new System.Windows.Forms.Label();
            this.labelSoundLocation = new System.Windows.Forms.Label();
            this.labelImageLocation = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.numericUpDownLevel = new System.Windows.Forms.NumericUpDown();
            this.textBoxSoundLocation = new System.Windows.Forms.TextBox();
            this.textBoxImageLocation = new System.Windows.Forms.TextBox();
            this.buttonBrowseImage = new System.Windows.Forms.Button();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.flowLayoutPanelLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.panelRight.SuspendLayout();
            this.groupBoxBirdInfo.SuspendLayout();
            this.tableLayoutPanelDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.groupBoxBirdInfo);
            this.panelRight.Controls.Add(this.panelButtons);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(401, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(0);
            this.panelRight.MinimumSize = new System.Drawing.Size(300, 200);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(783, 561);
            this.panelRight.TabIndex = 3;
            // 
            // groupBoxBirdInfo
            // 
            this.groupBoxBirdInfo.Controls.Add(this.tableLayoutPanelDetails);
            this.groupBoxBirdInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBirdInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxBirdInfo.Location = new System.Drawing.Point(0, 0);
            this.groupBoxBirdInfo.Margin = new System.Windows.Forms.Padding(0);
            this.groupBoxBirdInfo.MinimumSize = new System.Drawing.Size(400, 400);
            this.groupBoxBirdInfo.Name = "groupBoxBirdInfo";
            this.groupBoxBirdInfo.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxBirdInfo.Size = new System.Drawing.Size(783, 481);
            this.groupBoxBirdInfo.TabIndex = 0;
            this.groupBoxBirdInfo.TabStop = false;
            this.groupBoxBirdInfo.Text = "A kiválasztott madár adatai";
            // 
            // tableLayoutPanelDetails
            // 
            this.tableLayoutPanelDetails.AutoSize = true;
            this.tableLayoutPanelDetails.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanelDetails.ColumnCount = 3;
            this.tableLayoutPanelDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.58365F));
            this.tableLayoutPanelDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.63985F));
            this.tableLayoutPanelDetails.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.90421F));
            this.tableLayoutPanelDetails.Controls.Add(this.buttonBrowseSound, 2, 3);
            this.tableLayoutPanelDetails.Controls.Add(this.labelName, 0, 1);
            this.tableLayoutPanelDetails.Controls.Add(this.labelLevel, 0, 2);
            this.tableLayoutPanelDetails.Controls.Add(this.labelSoundLocation, 0, 3);
            this.tableLayoutPanelDetails.Controls.Add(this.labelImageLocation, 0, 4);
            this.tableLayoutPanelDetails.Controls.Add(this.pictureBoxImage, 1, 0);
            this.tableLayoutPanelDetails.Controls.Add(this.textBoxName, 1, 1);
            this.tableLayoutPanelDetails.Controls.Add(this.numericUpDownLevel, 1, 2);
            this.tableLayoutPanelDetails.Controls.Add(this.textBoxSoundLocation, 1, 3);
            this.tableLayoutPanelDetails.Controls.Add(this.textBoxImageLocation, 1, 4);
            this.tableLayoutPanelDetails.Controls.Add(this.buttonBrowseImage, 2, 4);
            this.tableLayoutPanelDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDetails.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanelDetails.Name = "tableLayoutPanelDetails";
            this.tableLayoutPanelDetails.RowCount = 5;
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelDetails.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanelDetails.Size = new System.Drawing.Size(783, 453);
            this.tableLayoutPanelDetails.TabIndex = 0;
            // 
            // buttonBrowseSound
            // 
            this.buttonBrowseSound.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBrowseSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrowseSound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBrowseSound.FlatAppearance.BorderSize = 0;
            this.buttonBrowseSound.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBrowseSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseSound.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBrowseSound.Location = new System.Drawing.Point(592, 343);
            this.buttonBrowseSound.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBrowseSound.Name = "buttonBrowseSound";
            this.buttonBrowseSound.Size = new System.Drawing.Size(186, 46);
            this.buttonBrowseSound.TabIndex = 0;
            this.buttonBrowseSound.Text = "Tallózás...";
            this.buttonBrowseSound.UseVisualStyleBackColor = false;
            this.buttonBrowseSound.Click += new System.EventHandler(this.buttonBrowseSound_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.Location = new System.Drawing.Point(0, 226);
            this.labelName.Margin = new System.Windows.Forms.Padding(0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(168, 56);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Madár neve:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLevel
            // 
            this.labelLevel.AutoSize = true;
            this.labelLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLevel.Location = new System.Drawing.Point(0, 282);
            this.labelLevel.Margin = new System.Windows.Forms.Padding(0);
            this.labelLevel.Name = "labelLevel";
            this.labelLevel.Size = new System.Drawing.Size(168, 56);
            this.labelLevel.TabIndex = 2;
            this.labelLevel.Text = "Madár szintje";
            this.labelLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSoundLocation
            // 
            this.labelSoundLocation.AutoSize = true;
            this.labelSoundLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSoundLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSoundLocation.Location = new System.Drawing.Point(0, 338);
            this.labelSoundLocation.Margin = new System.Windows.Forms.Padding(0);
            this.labelSoundLocation.Name = "labelSoundLocation";
            this.labelSoundLocation.Size = new System.Drawing.Size(168, 56);
            this.labelSoundLocation.TabIndex = 3;
            this.labelSoundLocation.Text = "Hangfájl helye:";
            this.labelSoundLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelImageLocation
            // 
            this.labelImageLocation.AutoSize = true;
            this.labelImageLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelImageLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelImageLocation.Location = new System.Drawing.Point(0, 394);
            this.labelImageLocation.Margin = new System.Windows.Forms.Padding(0);
            this.labelImageLocation.Name = "labelImageLocation";
            this.labelImageLocation.Size = new System.Drawing.Size(168, 59);
            this.labelImageLocation.TabIndex = 4;
            this.labelImageLocation.Text = "Kép helye:";
            this.labelImageLocation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxImage.Location = new System.Drawing.Point(178, 10);
            this.pictureBoxImage.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBoxImage.Size = new System.Drawing.Size(399, 206);
            this.pictureBoxImage.TabIndex = 0;
            this.pictureBoxImage.TabStop = false;
            // 
            // textBoxName
            // 
            this.tableLayoutPanelDetails.SetColumnSpan(this.textBoxName, 2);
            this.textBoxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxName.Location = new System.Drawing.Point(168, 226);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxName.MaxLength = 30;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(615, 35);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDownLevel
            // 
            this.numericUpDownLevel.AutoSize = true;
            this.tableLayoutPanelDetails.SetColumnSpan(this.numericUpDownLevel, 2);
            this.numericUpDownLevel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDownLevel.Location = new System.Drawing.Point(168, 282);
            this.numericUpDownLevel.Margin = new System.Windows.Forms.Padding(0);
            this.numericUpDownLevel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownLevel.Name = "numericUpDownLevel";
            this.numericUpDownLevel.Size = new System.Drawing.Size(615, 35);
            this.numericUpDownLevel.TabIndex = 8;
            this.numericUpDownLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownLevel.ThousandsSeparator = true;
            this.numericUpDownLevel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBoxSoundLocation
            // 
            this.textBoxSoundLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSoundLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxSoundLocation.Location = new System.Drawing.Point(168, 338);
            this.textBoxSoundLocation.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSoundLocation.Name = "textBoxSoundLocation";
            this.textBoxSoundLocation.Size = new System.Drawing.Size(419, 29);
            this.textBoxSoundLocation.TabIndex = 5;
            this.textBoxSoundLocation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxImageLocation
            // 
            this.textBoxImageLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxImageLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxImageLocation.Location = new System.Drawing.Point(168, 394);
            this.textBoxImageLocation.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxImageLocation.Name = "textBoxImageLocation";
            this.textBoxImageLocation.Size = new System.Drawing.Size(419, 29);
            this.textBoxImageLocation.TabIndex = 6;
            // 
            // buttonBrowseImage
            // 
            this.buttonBrowseImage.AutoSize = true;
            this.buttonBrowseImage.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonBrowseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBrowseImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBrowseImage.FlatAppearance.BorderSize = 0;
            this.buttonBrowseImage.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.buttonBrowseImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowseImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonBrowseImage.Location = new System.Drawing.Point(592, 399);
            this.buttonBrowseImage.Margin = new System.Windows.Forms.Padding(5);
            this.buttonBrowseImage.Name = "buttonBrowseImage";
            this.buttonBrowseImage.Size = new System.Drawing.Size(186, 49);
            this.buttonBrowseImage.TabIndex = 9;
            this.buttonBrowseImage.Text = "Tallózás...";
            this.buttonBrowseImage.UseVisualStyleBackColor = false;
            this.buttonBrowseImage.Click += new System.EventHandler(this.buttonBrowseImage_Click);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonAddNew);
            this.panelButtons.Controls.Add(this.buttonDelete);
            this.panelButtons.Controls.Add(this.buttonSave);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 481);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(0);
            this.panelButtons.MinimumSize = new System.Drawing.Size(250, 80);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(783, 80);
            this.panelButtons.TabIndex = 1;
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddNew.AutoSize = true;
            this.buttonAddNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAddNew.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buttonAddNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddNew.FlatAppearance.BorderSize = 0;
            this.buttonAddNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.buttonAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddNew.Location = new System.Drawing.Point(267, 19);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(266, 49);
            this.buttonAddNew.TabIndex = 2;
            this.buttonAddNew.Text = "Új hozzáadása";
            this.buttonAddNew.UseVisualStyleBackColor = false;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDelete.BackColor = System.Drawing.Color.Crimson;
            this.buttonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(611, 24);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(160, 41);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Eltávolítás";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.AutoSize = true;
            this.buttonSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSave.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Enabled = false;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(37, 19);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(144, 49);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Mentés";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // flowLayoutPanelLeft
            // 
            this.flowLayoutPanelLeft.AutoScroll = true;
            this.flowLayoutPanelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelLeft.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelLeft.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelLeft.MinimumSize = new System.Drawing.Size(200, 200);
            this.flowLayoutPanelLeft.Name = "flowLayoutPanelLeft";
            this.flowLayoutPanelLeft.Size = new System.Drawing.Size(401, 561);
            this.flowLayoutPanelLeft.TabIndex = 0;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.flowLayoutPanelLeft);
            this.Controls.Add(this.panelRight);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "MainFrame";
            this.Text = "Adminisztrációs felület";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.panelRight.ResumeLayout(false);
            this.groupBoxBirdInfo.ResumeLayout(false);
            this.groupBoxBirdInfo.PerformLayout();
            this.tableLayoutPanelDetails.ResumeLayout(false);
            this.tableLayoutPanelDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLevel)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelLeft;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.GroupBox groupBoxBirdInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDetails;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelLevel;
        private System.Windows.Forms.Label labelSoundLocation;
        private System.Windows.Forms.Label labelImageLocation;
        private System.Windows.Forms.TextBox textBoxSoundLocation;
        private System.Windows.Forms.TextBox textBoxImageLocation;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.NumericUpDown numericUpDownLevel;
        private System.Windows.Forms.Button buttonBrowseSound;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button buttonBrowseImage;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAddNew;
    }
}

