﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	public partial class ejRating : Wisej.Web.Ext.Syncfusion.Demo.Component.TestBase
	{
		public ejRating()
		{
			InitializeComponent();

			this.ejRating1.Instance.click += new WidgetEventHandler(ejRating1_WidgetEvent);
			this.ejRating1.Instance.change += new WidgetEventHandler(ejRating1_WidgetEvent);
		}

		private void ejRating1_WidgetEvent(object sender, WidgetEventArgs e)
		{
			AlertBox.Show(
				$"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
				MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.ejRating1.Options.maxValue = this.numericUpDown1.Value;
			this.ejRating1.Options.incrementStep = this.numericUpDown2.Value;
			this.ejRating1.Options.precision = this.comboBox1.SelectedItem.ToString().ToLower();

			this.ejRating1.Update();
		}
	}
}
