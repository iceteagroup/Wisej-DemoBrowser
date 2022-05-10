﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.DevExtreme.Demo.Component
{
	public partial class dxList : TestBase
	{
		public dxList()
		{
			InitializeComponent();

			this.comboBox1.DataBindings.Add(new Binding("Enabled", this.checkBox1, "Checked"));
			
			this.dxList1.Instance.onItemClick += new WidgetEventHandler(dxList1_WidgetEvent);
			this.dxList1.Instance.onPullRefresh += new WidgetEventHandler(dxList1_WidgetEvent);
		}

		private void dxList1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.dxList1.Options.bounceEnabled = this.checkBox2.Checked;
			this.dxList1.Options.searchEnabled = this.checkBox1.Checked;

			if(this.checkBox1.Checked)
				this.dxList1.Options.searchMode = this.comboBox1.SelectedItem;
			
			this.dxList1.Options.selectionMode = this.comboBox2.SelectedItem;
			this.dxList1.Options.itemDeleteMode = this.comboBox3.SelectedItem;
			this.dxList1.Options.showSelectionControls = this.checkBox5.Checked;

			this.dxList1.Update();
		}

        private void dxList_Load(object sender, EventArgs e)
        {
			this.comboBox1.SelectedIndex = 0;
			this.comboBox2.SelectedIndex = 0;
			this.comboBox3.SelectedIndex = 0;

		}
	}
}
