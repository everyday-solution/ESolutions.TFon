namespace ESolutions.TFon.Windows
{
	partial class MainForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.TabPage tabPage3;
			System.Windows.Forms.TabPage tabPage2;
			System.Windows.Forms.Label label3;
			System.Windows.Forms.Label label1;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			System.Windows.Forms.TabPage tabPage4;
			this.eventListView = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.ownCountLabel = new System.Windows.Forms.Label();
			this.totalCountLabel = new System.Windows.Forms.Label();
			this.allCallsListView = new System.Windows.Forms.ListView();
			this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.clearButton = new System.Windows.Forms.Button();
			this.callButton = new System.Windows.Forms.Button();
			this.zeroButton = new System.Windows.Forms.Button();
			this.nineButton = new System.Windows.Forms.Button();
			this.eightButton = new System.Windows.Forms.Button();
			this.sevenButton = new System.Windows.Forms.Button();
			this.sixButton = new System.Windows.Forms.Button();
			this.fiveButton = new System.Windows.Forms.Button();
			this.fourButton = new System.Windows.Forms.Button();
			this.threeButton = new System.Windows.Forms.Button();
			this.twoButton = new System.Windows.Forms.Button();
			this.oneButton = new System.Windows.Forms.Button();
			this.numberTextBox = new System.Windows.Forms.TextBox();
			this.activeCallTabPage = new System.Windows.Forms.TabPage();
			this.activeCallPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.waitingForCallsLabel = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			tabPage3 = new System.Windows.Forms.TabPage();
			tabPage2 = new System.Windows.Forms.TabPage();
			label3 = new System.Windows.Forms.Label();
			label1 = new System.Windows.Forms.Label();
			tabPage4 = new System.Windows.Forms.TabPage();
			tabPage3.SuspendLayout();
			tabPage2.SuspendLayout();
			tabPage4.SuspendLayout();
			this.activeCallTabPage.SuspendLayout();
			this.activeCallPanel.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabPage3
			// 
			tabPage3.Controls.Add(this.eventListView);
			tabPage3.Location = new System.Drawing.Point(4, 22);
			tabPage3.Name = "tabPage3";
			tabPage3.Size = new System.Drawing.Size(740, 508);
			tabPage3.TabIndex = 2;
			tabPage3.Text = "Ereignisse";
			tabPage3.UseVisualStyleBackColor = true;
			// 
			// eventListView
			// 
			this.eventListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.eventListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
			this.eventListView.FullRowSelect = true;
			this.eventListView.Location = new System.Drawing.Point(3, 3);
			this.eventListView.Name = "eventListView";
			this.eventListView.Size = new System.Drawing.Size(734, 428);
			this.eventListView.TabIndex = 0;
			this.eventListView.UseCompatibleStateImageBehavior = false;
			this.eventListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Time";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Line";
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Call";
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Event";
			// 
			// columnHeader5
			// 
			this.columnHeader5.Text = "Message";
			// 
			// tabPage2
			// 
			tabPage2.Controls.Add(this.ownCountLabel);
			tabPage2.Controls.Add(label3);
			tabPage2.Controls.Add(this.totalCountLabel);
			tabPage2.Controls.Add(label1);
			tabPage2.Controls.Add(this.allCallsListView);
			tabPage2.Location = new System.Drawing.Point(4, 22);
			tabPage2.Name = "tabPage2";
			tabPage2.Padding = new System.Windows.Forms.Padding(3);
			tabPage2.Size = new System.Drawing.Size(740, 508);
			tabPage2.TabIndex = 1;
			tabPage2.Text = "Alle Anrufe";
			tabPage2.UseVisualStyleBackColor = true;
			// 
			// ownCountLabel
			// 
			this.ownCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.ownCountLabel.AutoSize = true;
			this.ownCountLabel.Location = new System.Drawing.Point(70, 485);
			this.ownCountLabel.Name = "ownCountLabel";
			this.ownCountLabel.Size = new System.Drawing.Size(13, 13);
			this.ownCountLabel.TabIndex = 4;
			this.ownCountLabel.Text = "0";
			// 
			// label3
			// 
			label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(6, 485);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(43, 13);
			label3.TabIndex = 3;
			label3.Text = "Eigene:";
			// 
			// totalCountLabel
			// 
			this.totalCountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.totalCountLabel.AutoSize = true;
			this.totalCountLabel.Location = new System.Drawing.Point(70, 466);
			this.totalCountLabel.Name = "totalCountLabel";
			this.totalCountLabel.Size = new System.Drawing.Size(13, 13);
			this.totalCountLabel.TabIndex = 2;
			this.totalCountLabel.Text = "0";
			// 
			// label1
			// 
			label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			label1.AutoSize = true;
			label1.Location = new System.Drawing.Point(6, 466);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(58, 13);
			label1.TabIndex = 1;
			label1.Text = "Insgesamt:";
			// 
			// allCallsListView
			// 
			this.allCallsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.allCallsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
			this.allCallsListView.FullRowSelect = true;
			this.allCallsListView.LargeImageList = this.imageList1;
			this.allCallsListView.Location = new System.Drawing.Point(6, 6);
			this.allCallsListView.Name = "allCallsListView";
			this.allCallsListView.ShowItemToolTips = true;
			this.allCallsListView.Size = new System.Drawing.Size(728, 443);
			this.allCallsListView.SmallImageList = this.imageList1;
			this.allCallsListView.TabIndex = 0;
			this.allCallsListView.UseCompatibleStateImageBehavior = false;
			this.allCallsListView.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader6
			// 
			this.columnHeader6.Text = "Zeit";
			// 
			// columnHeader7
			// 
			this.columnHeader7.Text = "Nummer";
			// 
			// columnHeader8
			// 
			this.columnHeader8.Text = "Name";
			// 
			// columnHeader9
			// 
			this.columnHeader9.Text = "Dauer";
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "arrow_left_blue.png");
			this.imageList1.Images.SetKeyName(1, "arrow_right_green.png");
			// 
			// tabPage4
			// 
			tabPage4.Controls.Add(this.clearButton);
			tabPage4.Controls.Add(this.callButton);
			tabPage4.Controls.Add(this.zeroButton);
			tabPage4.Controls.Add(this.nineButton);
			tabPage4.Controls.Add(this.eightButton);
			tabPage4.Controls.Add(this.sevenButton);
			tabPage4.Controls.Add(this.sixButton);
			tabPage4.Controls.Add(this.fiveButton);
			tabPage4.Controls.Add(this.fourButton);
			tabPage4.Controls.Add(this.threeButton);
			tabPage4.Controls.Add(this.twoButton);
			tabPage4.Controls.Add(this.oneButton);
			tabPage4.Controls.Add(this.numberTextBox);
			tabPage4.Location = new System.Drawing.Point(4, 22);
			tabPage4.Name = "tabPage4";
			tabPage4.Size = new System.Drawing.Size(740, 508);
			tabPage4.TabIndex = 3;
			tabPage4.Text = "Neuer Anruf";
			tabPage4.UseVisualStyleBackColor = true;
			// 
			// clearButton
			// 
			this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.clearButton.Location = new System.Drawing.Point(147, 237);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(60, 60);
			this.clearButton.TabIndex = 13;
			this.clearButton.Text = "C";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
			// 
			// callButton
			// 
			this.callButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.callButton.Location = new System.Drawing.Point(15, 303);
			this.callButton.Name = "callButton";
			this.callButton.Size = new System.Drawing.Size(192, 60);
			this.callButton.TabIndex = 12;
			this.callButton.Text = "Anrufen";
			this.callButton.UseVisualStyleBackColor = true;
			this.callButton.Click += new System.EventHandler(this.CallButton_Click);
			// 
			// zeroButton
			// 
			this.zeroButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.zeroButton.Location = new System.Drawing.Point(81, 237);
			this.zeroButton.Name = "zeroButton";
			this.zeroButton.Size = new System.Drawing.Size(60, 60);
			this.zeroButton.TabIndex = 10;
			this.zeroButton.Tag = "0";
			this.zeroButton.Text = "0";
			this.zeroButton.UseVisualStyleBackColor = true;
			this.zeroButton.Click += new System.EventHandler(this.DigitButton_Click);
			// 
			// nineButton
			// 
			this.nineButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.nineButton.Location = new System.Drawing.Point(147, 171);
			this.nineButton.Name = "nineButton";
			this.nineButton.Size = new System.Drawing.Size(60, 60);
			this.nineButton.TabIndex = 9;
			this.nineButton.Tag = "9";
			this.nineButton.Text = "9";
			this.nineButton.UseVisualStyleBackColor = true;
			this.nineButton.Click += new System.EventHandler(this.DigitButton_Click);
			// 
			// eightButton
			// 
			this.eightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.eightButton.Location = new System.Drawing.Point(81, 171);
			this.eightButton.Name = "eightButton";
			this.eightButton.Size = new System.Drawing.Size(60, 60);
			this.eightButton.TabIndex = 8;
			this.eightButton.Tag = "8";
			this.eightButton.Text = "8";
			this.eightButton.UseVisualStyleBackColor = true;
			this.eightButton.Click += new System.EventHandler(this.DigitButton_Click);
			// 
			// sevenButton
			// 
			this.sevenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sevenButton.Location = new System.Drawing.Point(15, 171);
			this.sevenButton.Name = "sevenButton";
			this.sevenButton.Size = new System.Drawing.Size(60, 60);
			this.sevenButton.TabIndex = 7;
			this.sevenButton.Tag = "7";
			this.sevenButton.Text = "7";
			this.sevenButton.UseVisualStyleBackColor = true;
			this.sevenButton.Click += new System.EventHandler(this.DigitButton_Click);
			// 
			// sixButton
			// 
			this.sixButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sixButton.Location = new System.Drawing.Point(147, 105);
			this.sixButton.Name = "sixButton";
			this.sixButton.Size = new System.Drawing.Size(60, 60);
			this.sixButton.TabIndex = 6;
			this.sixButton.Tag = "6";
			this.sixButton.Text = "6";
			this.sixButton.UseVisualStyleBackColor = true;
			this.sixButton.Click += new System.EventHandler(this.DigitButton_Click);
			// 
			// fiveButton
			// 
			this.fiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fiveButton.Location = new System.Drawing.Point(81, 105);
			this.fiveButton.Name = "fiveButton";
			this.fiveButton.Size = new System.Drawing.Size(60, 60);
			this.fiveButton.TabIndex = 5;
			this.fiveButton.Tag = "5";
			this.fiveButton.Text = "5";
			this.fiveButton.UseVisualStyleBackColor = true;
			this.fiveButton.Click += new System.EventHandler(this.DigitButton_Click);
			// 
			// fourButton
			// 
			this.fourButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.fourButton.Location = new System.Drawing.Point(15, 105);
			this.fourButton.Name = "fourButton";
			this.fourButton.Size = new System.Drawing.Size(60, 60);
			this.fourButton.TabIndex = 4;
			this.fourButton.Tag = "4";
			this.fourButton.Text = "4";
			this.fourButton.UseVisualStyleBackColor = true;
			this.fourButton.Click += new System.EventHandler(this.DigitButton_Click);
			// 
			// threeButton
			// 
			this.threeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.threeButton.Location = new System.Drawing.Point(147, 39);
			this.threeButton.Name = "threeButton";
			this.threeButton.Size = new System.Drawing.Size(60, 60);
			this.threeButton.TabIndex = 3;
			this.threeButton.Tag = "3";
			this.threeButton.Text = "3";
			this.threeButton.UseVisualStyleBackColor = true;
			this.threeButton.Click += new System.EventHandler(this.DigitButton_Click);
			// 
			// twoButton
			// 
			this.twoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.twoButton.Location = new System.Drawing.Point(81, 39);
			this.twoButton.Name = "twoButton";
			this.twoButton.Size = new System.Drawing.Size(60, 60);
			this.twoButton.TabIndex = 2;
			this.twoButton.Tag = "2";
			this.twoButton.Text = "2";
			this.twoButton.UseVisualStyleBackColor = true;
			this.twoButton.Click += new System.EventHandler(this.DigitButton_Click);
			// 
			// oneButton
			// 
			this.oneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.oneButton.Location = new System.Drawing.Point(15, 39);
			this.oneButton.Name = "oneButton";
			this.oneButton.Size = new System.Drawing.Size(60, 60);
			this.oneButton.TabIndex = 1;
			this.oneButton.Tag = "1";
			this.oneButton.Text = "1";
			this.oneButton.UseVisualStyleBackColor = true;
			this.oneButton.Click += new System.EventHandler(this.DigitButton_Click);
			// 
			// numberTextBox
			// 
			this.numberTextBox.Location = new System.Drawing.Point(15, 13);
			this.numberTextBox.Name = "numberTextBox";
			this.numberTextBox.Size = new System.Drawing.Size(192, 20);
			this.numberTextBox.TabIndex = 0;
			// 
			// activeCallTabPage
			// 
			this.activeCallTabPage.Controls.Add(this.activeCallPanel);
			this.activeCallTabPage.Location = new System.Drawing.Point(4, 22);
			this.activeCallTabPage.Name = "activeCallTabPage";
			this.activeCallTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.activeCallTabPage.Size = new System.Drawing.Size(740, 508);
			this.activeCallTabPage.TabIndex = 0;
			this.activeCallTabPage.Text = "Aktuelle Anrufe";
			this.activeCallTabPage.UseVisualStyleBackColor = true;
			// 
			// activeCallPanel
			// 
			this.activeCallPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.activeCallPanel.AutoScroll = true;
			this.activeCallPanel.Controls.Add(this.waitingForCallsLabel);
			this.activeCallPanel.Location = new System.Drawing.Point(6, 6);
			this.activeCallPanel.Name = "activeCallPanel";
			this.activeCallPanel.Size = new System.Drawing.Size(728, 496);
			this.activeCallPanel.TabIndex = 0;
			this.activeCallPanel.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.ActiveCallPanel_ControlAdded);
			this.activeCallPanel.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.ActiveCallPanel_ControlRemoved);
			this.activeCallPanel.Layout += new System.Windows.Forms.LayoutEventHandler(this.ActiveCallPanel_Layout);
			// 
			// waitingForCallsLabel
			// 
			this.waitingForCallsLabel.AutoSize = true;
			this.waitingForCallsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.waitingForCallsLabel.Location = new System.Drawing.Point(3, 0);
			this.waitingForCallsLabel.Name = "waitingForCallsLabel";
			this.waitingForCallsLabel.Size = new System.Drawing.Size(162, 20);
			this.waitingForCallsLabel.TabIndex = 0;
			this.waitingForCallsLabel.Text = "Warte auf Anrufe...";
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.activeCallTabPage);
			this.tabControl1.Controls.Add(tabPage4);
			this.tabControl1.Controls.Add(tabPage2);
			this.tabControl1.Controls.Add(tabPage3);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(748, 534);
			this.tabControl1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(772, 558);
			this.Controls.Add(this.tabControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.Text = "Telefon-Wächter";
			this.Load += new System.EventHandler(this.MainForm_Load);
			tabPage3.ResumeLayout(false);
			tabPage2.ResumeLayout(false);
			tabPage2.PerformLayout();
			tabPage4.ResumeLayout(false);
			tabPage4.PerformLayout();
			this.activeCallTabPage.ResumeLayout(false);
			this.activeCallPanel.ResumeLayout(false);
			this.activeCallPanel.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.ListView eventListView;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader3;
		private System.Windows.Forms.ColumnHeader columnHeader4;
		private System.Windows.Forms.ColumnHeader columnHeader5;
		private System.Windows.Forms.ListView allCallsListView;
		private System.Windows.Forms.ColumnHeader columnHeader6;
		private System.Windows.Forms.ColumnHeader columnHeader7;
		private System.Windows.Forms.ColumnHeader columnHeader8;
		private System.Windows.Forms.ColumnHeader columnHeader9;
		private System.Windows.Forms.FlowLayoutPanel activeCallPanel;
		private System.Windows.Forms.Label ownCountLabel;
		private System.Windows.Forms.Label totalCountLabel;
		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label waitingForCallsLabel;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button callButton;
		private System.Windows.Forms.Button zeroButton;
		private System.Windows.Forms.Button nineButton;
		private System.Windows.Forms.Button eightButton;
		private System.Windows.Forms.Button sevenButton;
		private System.Windows.Forms.Button sixButton;
		private System.Windows.Forms.Button fiveButton;
		private System.Windows.Forms.Button fourButton;
		private System.Windows.Forms.Button threeButton;
		private System.Windows.Forms.Button twoButton;
		private System.Windows.Forms.Button oneButton;
		private System.Windows.Forms.TextBox numberTextBox;
		private System.Windows.Forms.TabPage activeCallTabPage;
	}
}

