using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing;

namespace ESolutions.TFon.Windows
{
	internal class CallListViewItem : ListViewItem
	{
		//Properties
		#region Call
		public Tapi.Call Call
		{
			get
			{
				return this.Tag as Tapi.Call;
			}
			set
			{
				this.Tag = value;

				this.SubItems["Time"].Text = value.Time.ToString();
				this.SubItems["Number"].Text = value.NumberOfCounterpart;
				this.SubItems["Name"].Text = value.NameOfCounterpart;
				this.SubItems["Duration"].Text = value.Duration.ToShortTimeString();

				this.ImageIndex = value.Direction == Tapi.Call.Directions.Incoming ? 1 : 0;
				this.BackColor = value.WasPickedUp ? Color.LightGreen : this.BackColor;

				value.PropertyChanged += new PropertyChangedEventHandler(AnyCall_PropertyChanged);
			}
		}
		#endregion

		//Constructors
		#region CallListViewItem
		public CallListViewItem(Tapi.Call current)
		{
			this.SubItems[0].Name = "Time";

			ListViewSubItem numberItem = new ListViewSubItem();
			numberItem.Name = "Number";
			this.SubItems.Add(numberItem);

			ListViewSubItem nameItem = new ListViewSubItem();
			nameItem.Name = "Name";
			this.SubItems.Add(nameItem);

			ListViewSubItem durationItem = new ListViewSubItem();
			durationItem.Name = "Duration";
			this.SubItems.Add(durationItem);

			this.Call = current;
		}
		#endregion

		//Methods
		#region AnyCall_PropertyChanged
		void AnyCall_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			Form parentForm = this.ListView.FindForm();
			if (parentForm.InvokeRequired)
			{
				parentForm.Invoke(new PropertyChangedEventHandler(this.AnyCall_PropertyChanged), sender, e);
			}
			else
			{
				try
				{
					Tapi.Call value = sender as Tapi.Call;

					switch (e.PropertyName)
					{
						case "Duration":
						{
							this.SubItems["Duration"].Text = value.Duration.ToShortTimeString();
							break;
						}
						case "NameOfCounterpart":
						{
							this.SubItems["Name"].Text = value.NameOfCounterpart;
							break;
						}
						case "WasPickedUp":
						{
							this.BackColor = value.WasPickedUp ? Color.LightGreen : this.BackColor;
							break;
						}
						case "Note":
						{
							this.ToolTipText = this.Call.Note;
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
	}
}
