﻿
namespace Wisej.Web.Ext.Kendo.Demo.Component
{
	partial class kendoWizard
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

		#region Wisej Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kendoWizard));
			Wisej.Web.Ext.Kendo.kendoBase.WidgetFunction widgetFunction1 = new Wisej.Web.Ext.Kendo.kendoBase.WidgetFunction();
			Wisej.Web.Ext.Kendo.kendoBase.WidgetFunction widgetFunction2 = new Wisej.Web.Ext.Kendo.kendoBase.WidgetFunction();
			Wisej.Web.Ext.Kendo.kendoBase.WidgetFunction widgetFunction3 = new Wisej.Web.Ext.Kendo.kendoBase.WidgetFunction();
			Wisej.Web.Ext.Kendo.kendoBase.WidgetFunction widgetFunction4 = new Wisej.Web.Ext.Kendo.kendoBase.WidgetFunction();
			this.button1 = new Wisej.Web.Button();
			this.button2 = new Wisej.Web.Button();
			this.kendoWizard1 = new Wisej.Web.Ext.Kendo.kendoWizard();
			this.panel.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.Controls.Add(this.kendoWizard1);
			this.panel.Size = new System.Drawing.Size(618, 469);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Size = new System.Drawing.Size(250, 469);
			this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
			this.groupBox1.Controls.SetChildIndex(this.button1, 0);
			this.groupBox1.Controls.SetChildIndex(this.button2, 0);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(28, 388);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(28, 46);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(195, 35);
			this.button1.TabIndex = 1;
			this.button1.Text = "Previous Step";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(28, 87);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(195, 35);
			this.button2.TabIndex = 2;
			this.button2.Text = "Next Step";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// kendoWizard1
			// 
			this.kendoWizard1.Dock = Wisej.Web.DockStyle.Fill;
			this.kendoWizard1.Location = new System.Drawing.Point(8, 8);
			this.kendoWizard1.Name = "kendoWizard1";
			this.kendoWizard1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("kendoWizard1.Options"))));
			this.kendoWizard1.Size = new System.Drawing.Size(600, 451);
			this.kendoWizard1.TabIndex = 0;
			this.kendoWizard1.Text = "kendoWizard1";
			widgetFunction1.Name = "paymentEditor";
			widgetFunction1.Source = resources.GetString("widgetFunction1.Source");
			widgetFunction2.Name = "validatePayment";
			widgetFunction2.Source = resources.GetString("widgetFunction2.Source");
			widgetFunction3.Name = "validmaskNumber";
			widgetFunction3.Source = resources.GetString("widgetFunction3.Source");
			widgetFunction4.Name = "validmaskCSV";
			widgetFunction4.Source = resources.GetString("widgetFunction4.Source");
			this.kendoWizard1.WidgetFunctions = new Wisej.Web.Ext.Kendo.kendoBase.WidgetFunction[] {
        widgetFunction1,
        widgetFunction2,
        widgetFunction3,
        widgetFunction4};
			// 
			// kendoWizard
			// 
			this.Name = "kendoWizard";
			this.Size = new System.Drawing.Size(1027, 659);
			this.panel.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Kendo.kendoWizard kendoWizard1;
		private Button button1;
		private Button button2;
	}
}
