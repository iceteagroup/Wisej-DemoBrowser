﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Syncfusion2.Demo.Component
{
	public partial class SmithChart : TestBase
	{
		public SmithChart()
		{
			InitializeComponent();
		}

		private void SmithChart_Load(object sender, EventArgs e)
		{
			this.smithChart1.Options.title = new
			{
				text = "Transmission"
			};
			this.smithChart1.Options.series = new object[]
			{
				new
				{
					dataSource = new object[]
					{
						new {resistance = 0, reactance = 0.05}, new {resistance = 0, reactance = 0.05},
						new {resistance = 0, reactance = 0.05}, new {resistance = 0, reactance = 0.05},
						new {resistance = 0, reactance = 0.05}, new {resistance = 0, reactance = 0.05},
						new {resistance = 0, reactance = 0.05}, new {resistance = 0, reactance = 0.05},
						new {resistance = 0, reactance = 0.05}, new {resistance = 0, reactance = 0.05},
						new {resistance = 0.3, reactance = 0.1}, new {resistance = 0.5, reactance = 0.2},
						new {resistance = 1.5, reactance = 0.5}, new {resistance = 2, reactance = 0.5},
						new {resistance = 2.5, reactance = 0.4}, new {resistance = 3.5, reactance = 0},
						new {resistance = 2.5, reactance = 0.4}, new {resistance = 3.5, reactance = 0},
						new {resistance = 2.5, reactance = 0.4}, new {resistance = 3.5, reactance = 0},
						new {resistance = 4.5, reactance = -0.5}, new {resistance = 5, reactance = -1}
					},
					name = "Transmission1",
					enableAnimation = true, tooltip = new
					{
						visible = true
					},
					marker = new
					{
						shape = "Circle",
						visible = true,
						border = new
						{
							width = 2
						}
					},
					reactance = "reactance",
					resistance = "resistance"
				},
				new
				{
					points = new object[]
					{
						new {resistance = 0, reactance = 0.15}, new {resistance = 0, reactance = 0.15},
						new {resistance = 0, reactance = 0.15}, new {resistance = 0.3, reactance = 0.2},
						new {resistance = 0.3, reactance = 0.2}, new {resistance = 0.3, reactance = 0.2},
						new {resistance = 0.3, reactance = 0.2}, new {resistance = 0.3, reactance = 0.2},
						new {resistance = 0.5, reactance = 0.4}, new {resistance = 1, reactance = 0.8},
						new {resistance = 2.5, reactance = 1.3}, new {resistance = 3.5, reactance = 1.6},
						new {resistance = 3.5, reactance = 1.6}, new {resistance = 3.5, reactance = 1.6},
						new {resistance = 4.5, reactance = 2}, new {resistance = 6, reactance = 4.5},
						new {resistance = 8, reactance = 6}, new {resistance = 10, reactance = 25}
					},
					name = "Transmission2",
					enableAnimation = true, tooltip = new
					{
						visible = true
					},
					marker = new
					{
						shape = "Rectangle",
						visible = true,
						border = new
						{
							width = 2
						}
					}
				}
			};
			this.smithChart1.Options.legendSettings = new
			{
				visible = true,
				shape = "Circle"
			};
		}

		private void smithChart1_tooltipRender(object sender, WidgetEventArgs e)
		{
			AlertBox.Show($"<b>{e.Type}</b><br/>{JSON.Stringify(e.Data)}",
						MessageBoxIcon.Information);

			Application.Play(MessageBoxIcon.Information);
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			this.smithChart1.Options.title.text = this.textBoxTitle.Text;
			this.smithChart1.Options.series[0].marker.shape = this.comboBoxShapeType.Text;
			this.smithChart1.Options.series[1].marker.shape = this.comboBoxShapeType.Text;
			this.smithChart1.Options.series[1].marker.visible = this.checkBoxMarkerVisible.Checked;
			this.smithChart1.Options.series[0].marker.visible = this.checkBoxMarkerVisible.Checked;
			this.smithChart1.Options.legendSettings.visible = this.checkBoxLegendVisibility.Checked;

			this.smithChart1.Update();
		}
	}
}