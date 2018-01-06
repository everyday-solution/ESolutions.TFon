namespace ESolutions.TFon.Windows
{
	partial class CallUserControl
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallUserControl));
			this.numberLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.noteTextBox = new System.Windows.Forms.TextBox();
			this.dateLabel = new System.Windows.Forms.Label();
			this.durationLabel = new System.Windows.Forms.Label();
			this.handOverList = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.closeButton = new System.Windows.Forms.PictureBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.handOverButton = new System.Windows.Forms.PictureBox();
			this.handOverList.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.handOverButton)).BeginInit();
			this.SuspendLayout();
			// 
			// numberLabel
			// 
			this.numberLabel.AutoSize = true;
			this.numberLabel.BackColor = System.Drawing.Color.Transparent;
			this.numberLabel.Location = new System.Drawing.Point(130, 75);
			this.numberLabel.Name = "numberLabel";
			this.numberLabel.Size = new System.Drawing.Size(97, 13);
			this.numberLabel.TabIndex = 0;
			this.numberLabel.Text = "+49 151 18404140";
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nameLabel.Location = new System.Drawing.Point(3, 0);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(187, 20);
			this.nameLabel.TabIndex = 1;
			this.nameLabel.Text = "(unbekannte Nummer)";
			// 
			// noteTextBox
			// 
			this.noteTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.noteTextBox.Location = new System.Drawing.Point(377, 12);
			this.noteTextBox.Multiline = true;
			this.noteTextBox.Name = "noteTextBox";
			this.noteTextBox.Size = new System.Drawing.Size(248, 116);
			this.noteTextBox.TabIndex = 3;
			this.noteTextBox.TextChanged += new System.EventHandler(this.NoteTextBox_TextChanged);
			// 
			// dateLabel
			// 
			this.dateLabel.AutoSize = true;
			this.dateLabel.BackColor = System.Drawing.Color.Transparent;
			this.dateLabel.Location = new System.Drawing.Point(131, 17);
			this.dateLabel.Name = "dateLabel";
			this.dateLabel.Size = new System.Drawing.Size(91, 13);
			this.dateLabel.TabIndex = 4;
			this.dateLabel.Text = "31.12.2011 23:59";
			// 
			// durationLabel
			// 
			this.durationLabel.AutoSize = true;
			this.durationLabel.BackColor = System.Drawing.Color.Transparent;
			this.durationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.durationLabel.Location = new System.Drawing.Point(130, 30);
			this.durationLabel.Name = "durationLabel";
			this.durationLabel.Size = new System.Drawing.Size(54, 20);
			this.durationLabel.TabIndex = 5;
			this.durationLabel.Text = "00:00";
			// 
			// handOverList
			// 
			this.handOverList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem1,
            this.toolStripMenuItem5,
            this.toolStripMenuItem2,
            this.toolStripMenuItem4,
            this.toolStripMenuItem6});
			this.handOverList.Name = "handOverList";
			this.handOverList.Size = new System.Drawing.Size(140, 136);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(139, 22);
			this.toolStripMenuItem3.Tag = "14";
			this.toolStripMenuItem3.Text = "Arne (14)";
			this.toolStripMenuItem3.Click += new System.EventHandler(this.HandOverList_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
			this.toolStripMenuItem1.Tag = "13";
			this.toolStripMenuItem1.Text = "Bernd (13)";
			this.toolStripMenuItem1.Click += new System.EventHandler(this.HandOverList_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(139, 22);
			this.toolStripMenuItem5.Tag = "11";
			this.toolStripMenuItem5.Text = "Michael (11)";
			this.toolStripMenuItem5.Click += new System.EventHandler(this.HandOverList_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(139, 22);
			this.toolStripMenuItem2.Tag = "12";
			this.toolStripMenuItem2.Text = "Peter (12)";
			this.toolStripMenuItem2.Click += new System.EventHandler(this.HandOverList_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(139, 22);
			this.toolStripMenuItem4.Tag = "10";
			this.toolStripMenuItem4.Text = "Sabine (10)";
			this.toolStripMenuItem4.Click += new System.EventHandler(this.HandOverList_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(139, 22);
			this.toolStripMenuItem6.Tag = "15";
			this.toolStripMenuItem6.Text = "NSL (15)";
			this.toolStripMenuItem6.Click += new System.EventHandler(this.HandOverList_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
			this.flowLayoutPanel1.Controls.Add(this.nameLabel);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(133, 91);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(237, 37);
			this.flowLayoutPanel1.TabIndex = 9;
			// 
			// closeButton
			// 
			this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeButton.BackColor = System.Drawing.Color.Transparent;
			this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.closeButton.Image = global::ESolutions.CM.Windows.Properties.Resources.error;
			this.closeButton.Location = new System.Drawing.Point(631, 12);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(25, 25);
			this.closeButton.TabIndex = 8;
			this.closeButton.TabStop = false;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(11, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(115, 115);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// handOverButton
			// 
			this.handOverButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.handOverButton.BackColor = System.Drawing.Color.Transparent;
			this.handOverButton.ContextMenuStrip = this.handOverList;
			this.handOverButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.handOverButton.Image = global::ESolutions.CM.Windows.Properties.Resources.users_into;
			this.handOverButton.Location = new System.Drawing.Point(631, 43);
			this.handOverButton.Name = "handOverButton";
			this.handOverButton.Size = new System.Drawing.Size(25, 25);
			this.handOverButton.TabIndex = 7;
			this.handOverButton.TabStop = false;
			this.handOverButton.Click += new System.EventHandler(this.HandOverButton_Click);
			// 
			// CallUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::ESolutions.CM.Windows.Properties.Resources.Gradient;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.durationLabel);
			this.Controls.Add(this.dateLabel);
			this.Controls.Add(this.noteTextBox);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.numberLabel);
			this.Controls.Add(this.handOverButton);
			this.Name = "CallUserControl";
			this.Size = new System.Drawing.Size(659, 142);
			this.handOverList.ResumeLayout(false);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.handOverButton)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label numberLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TextBox noteTextBox;
		private System.Windows.Forms.Label dateLabel;
		private System.Windows.Forms.Label durationLabel;
		private System.Windows.Forms.PictureBox handOverButton;
		private System.Windows.Forms.ContextMenuStrip handOverList;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
		private System.Windows.Forms.PictureBox closeButton;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}
