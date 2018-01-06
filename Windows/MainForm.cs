using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESolutions.TFon.Tapi;

namespace ESolutions.TFon.Windows
{
	public partial class MainForm : Form
	{
		//Constructors
		#region MainForm
		public MainForm()
		{
			InitializeComponent();
		}
		#endregion

		//Methods
		#region AddCallToAllListView
		private void AddCallToAllListView(System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			try
			{
				this.allCallsListView.BeginUpdate();

				foreach (Tapi.Call current in e.NewItems)
				{
					CallListViewItem newItem = new CallListViewItem(current);
					this.allCallsListView.Items.Insert(e.NewStartingIndex, newItem);
				}
			}
			finally
			{
				this.allCallsListView.EndUpdate();
			}
		}
		#endregion

		#region RemoveOldCalls
		private void RemoveOldCalls(System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			foreach (Tapi.Call current in e.OldItems)
			{
				CallUserControl control = this.GetCallUserControlByCall(current);

				if (control != null && !control.HasNote)
				{
					this.activeCallPanel.Controls.Remove(control);
				}
			}
		}
		#endregion

		#region GetCallUserControlByCall
		private CallUserControl GetCallUserControlByCall(Tapi.Call call)
		{
			CallUserControl result = null;

			foreach (Control current in this.activeCallPanel.Controls)
			{
				if (current is CallUserControl && current.Tag == call)
				{
					result = current as CallUserControl;
				}
			}

			return result;
		}
		#endregion

		#region AddNewCalls
		private void AddNewCalls(System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			foreach (Call current in e.NewItems)
			{
				CallUserControl newCall = new CallUserControl(current);
				//newCall.Width = this.activeCallPanel.Width - newCall.Margin.Left - newCall.Margin.Right;
				//newCall.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
				this.activeCallPanel.Controls.Add(newCall);
			}

			this.tabControl1.SelectedTab = this.activeCallTabPage;
			this.FindForm().WindowState = FormWindowState.Normal;
			this.FindForm().BringToFront();
			this.FindForm().TopMost = true;
		}
		#endregion

		#region MainForm_Load
		private void MainForm_Load(object sender, EventArgs e)
		{
			Tapi.TapiController.Default.Events.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(TapiEvents_CollectionChanged);
			Tapi.TapiController.Default.AllCalls.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(AllCalls_CollectionChanged);
			Tapi.TapiController.Default.ActiveCalls.CollectionChanged += new System.Collections.Specialized.NotifyCollectionChangedEventHandler(ActiveCalls_CollectionChanged);
		}
		#endregion

		#region ActiveCalls_CollectionChanged
		void ActiveCalls_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{

			if (this.InvokeRequired)
			{
				this.Invoke(
					new System.Collections.Specialized.NotifyCollectionChangedEventHandler(ActiveCalls_CollectionChanged),
					sender,
					e);
			}
			else
			{
				try
				{
					this.activeCallPanel.SuspendLayout();

					switch (e.Action)
					{
						case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
						{
							this.AddNewCalls(e);
							break;
						}
						case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
						{
							this.RemoveOldCalls(e);
							break;
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.DeepParse());
				}
				finally
				{
					this.activeCallPanel.ResumeLayout();
				}
			}
		}
		#endregion

		#region AllCalls_CollectionChanged
		void AllCalls_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			try
			{
				if (this.InvokeRequired)
				{
					this.Invoke(
						new System.Collections.Specialized.NotifyCollectionChangedEventHandler(AllCalls_CollectionChanged),
						sender,
						e);
				}
				else
				{
					if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
					{
						this.AddCallToAllListView(e);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.DeepParse());
			}

		}
		#endregion

		#region TapiEvents_CollectionChanged
		void TapiEvents_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			try
			{
				if (this.InvokeRequired)
				{
					this.Invoke(
						new System.Collections.Specialized.NotifyCollectionChangedEventHandler(TapiEvents_CollectionChanged),
						sender,
						e);
				}
				else
				{
					if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
					{
						this.eventListView.BeginUpdate();
						foreach (Tapi.TapiEventLogEntry current in e.NewItems)
						{
							ListViewItem newItem = new ListViewItem(
								new String[] { 
									current.Time.ToString(),
									current.LineName.ToString(),
									current.CallHash.ToString(),
									current.Event.ToString(),
									current.Message.ToString(),
								
							});
							this.eventListView.Items.Insert(e.NewStartingIndex, newItem);
						}
					}

					foreach (ColumnHeader current in this.eventListView.Columns)
					{
						current.Width = -1;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.DeepParse());
			}
			finally
			{
				this.eventListView.EndUpdate();
			}
		}
		#endregion

		#region DigitButton_Click
		private void DigitButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.numberTextBox.Text += (sender as Button).Tag.ToString();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.DeepParse());
			}
		}
		#endregion

		#region ClearButton_Click
		private void ClearButton_Click(object sender, EventArgs e)
		{
			try
			{
				this.numberTextBox.Text = String.Empty;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.DeepParse());
			}
		}
		#endregion

		#region CallButton_Click
		private void CallButton_Click(object sender, EventArgs e)
		{
			try
			{
				Tapi.TapiController.Default.CallNumber(this.numberTextBox.Text);
				this.tabControl1.SelectedTab = this.activeCallTabPage;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.DeepParse());
			}
		}
		#endregion

		#region ActiveCallPanel_ControlRemoved
		private void ActiveCallPanel_ControlRemoved(object sender, ControlEventArgs e)
		{
			try
			{
				if (e.Control != this.waitingForCallsLabel)
				{
					if (this.activeCallPanel.Controls.Count <= 0)
					{
						this.activeCallPanel.Controls.Add(this.waitingForCallsLabel);
					}

					this.FindForm().TopMost = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.DeepParse());
			}
		}
		#endregion

		#region ActiveCallPanel_ControlAdded
		private void ActiveCallPanel_ControlAdded(object sender, ControlEventArgs e)
		{
			try
			{
				if (e.Control != this.waitingForCallsLabel)
				{
					if (this.activeCallPanel.Controls.Contains(this.waitingForCallsLabel))
					{
						this.activeCallPanel.Controls.Remove(this.waitingForCallsLabel);
					}

					foreach (ColumnHeader current in this.allCallsListView.Columns)
					{
						current.Width = -1;
					}

					this.ownCountLabel.Text = TapiController.Default.AllCalls.Count(current => current.WasPickedUp).ToString();
					this.totalCountLabel.Text = TapiController.Default.AllCalls.Count.ToString();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.DeepParse());
			}
		}
		#endregion

		#region ActiveCallPanel_Layout
		private void ActiveCallPanel_Layout(object sender, LayoutEventArgs e)
		{
			try
			{
				foreach (Control current in this.activeCallPanel.Controls)
				{
					if (current is CallUserControl)
					{
						current.Width = this.activeCallPanel.Width - this.activeCallPanel.Margin.Left - this.activeCallPanel.Margin.Right;
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.DeepParse());
			}
		}
		#endregion
	}
}
