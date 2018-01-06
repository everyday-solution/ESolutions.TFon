using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESolutions;
using ESolutions.TFon.Tapi;

namespace ESolutions.TFon.Windows
{
	public partial class CallUserControl : UserControl
	{
		//Properties
		#region Call
		public Call Call
		{
			get
			{
				return this.Tag as Tapi.Call;
			}
		}
		#endregion

		#region HasNote
		public Boolean HasNote
		{
			get
			{
				return !String.IsNullOrEmpty(this.Call.Note);
			}
		}
		#endregion

		//Constructors
		#region CallUserControl
		public CallUserControl(Call call)
		{
			InitializeComponent();

			this.Tag = call;

			this.dateLabel.Text = call.Time.ToString("dd.MM. HH:mm");
			this.numberLabel.Text = call.NumberOfCounterpart;
			this.nameLabel.Text = call.NameOfCounterpart;
			this.durationLabel.Text = call.Duration.ToShortTimeString();

			call.PropertyChanged += new PropertyChangedEventHandler(AnyCall_PropertyChanged);
		}
		#endregion

		//Methods
		#region AnyCall_PropertyChanged
		void AnyCall_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if (this.InvokeRequired)
			{
				this.Invoke(
					new PropertyChangedEventHandler(AnyCall_PropertyChanged),
					sender,
					e);
			}
			else
			{
				try
				{
					switch (e.PropertyName)
					{
						case "NameOfCounterpart":
						{
							this.nameLabel.Text = (sender as Tapi.Call).NameOfCounterpart;
							break;
						}
						case "PictureOfCounterpart":
						{
							this.pictureBox1.ImageLocation = (sender as Tapi.Call).PictureOfCounterpart;
							break;
						}
						case "Duration":
						{
							this.durationLabel.Text = (sender as Tapi.Call).Duration.ToShortTimeString();
							break;
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.DeepParse());
				}
			}
		}
		#endregion

		#region NoteTextBox_TextChanged
		private void NoteTextBox_TextChanged(object sender, EventArgs e)
		{
			try
			{
				this.Call.Note = this.noteTextBox.Text;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.DeepParse());
			}
		}
		#endregion

		#region HandOverButton_Click
		private void HandOverButton_Click(object sender, EventArgs e)
		{
			this.handOverList.Show(Cursor.Position.X, Cursor.Position.Y);
		}
		#endregion

		#region HandOverList_Click
		private void HandOverList_Click(object sender, EventArgs e)
		{
			try
			{
				this.Call.HandOver((sender as ToolStripMenuItem).Tag.ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.DeepParse());
			}
		}
		#endregion

		#region CloseButton_Click
		private void CloseButton_Click(object sender, EventArgs e)
		{
			this.Parent.Controls.Remove(this);
		}
		#endregion
	}
}
