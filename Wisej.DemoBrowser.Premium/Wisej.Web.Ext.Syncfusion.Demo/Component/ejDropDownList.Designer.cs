﻿namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejDropDownList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ejDropDownList));
            this.ejDropDownList1 = new Wisej.Web.Ext.Syncfusion.ejDropDownList();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.checkBox4 = new Wisej.Web.CheckBox();
            this.ejDropDownList2 = new Wisej.Web.Ext.Syncfusion.ejDropDownList();
            this.checkBox5 = new Wisej.Web.CheckBox();
            this.checkBox6 = new Wisej.Web.CheckBox();
            this.label4 = new Wisej.Web.Label();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/dropdownlist/dropdownlist";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Size = new System.Drawing.Size(250, 540);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox4, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox5, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox6, 0);
            this.groupBox1.Controls.SetChildIndex(this.label4, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 435);
            this.buttonUpdate.TabIndex = 7;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(554, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/bootstrap/dropdownlist/defaultfunctionalit" +
    "ies";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejdropdownlist";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejDropDownList2);
            this.panel.Controls.Add(this.ejDropDownList1);
            this.panel.TabIndex = 7;
            // 
            // ejDropDownList1
            // 
            this.ejDropDownList1.Anchor = Wisej.Web.AnchorStyles.None;
            this.ejDropDownList1.Location = new System.Drawing.Point(394, 229);
            this.ejDropDownList1.Name = "ejDropDownList1";
            this.ejDropDownList1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejDropDownList1.Options"))));
            this.ejDropDownList1.Size = new System.Drawing.Size(300, 30);
            this.ejDropDownList1.TabIndex = 0;
            this.ejDropDownList1.Text = "ejDropDownList1";
            this.ejDropDownList1.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.ejDropDownList_WidgetEvent);
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(28, 112);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 30);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Virtual Scroll";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Location = new System.Drawing.Point(28, 166);
            this.checkBox2.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(195, 29);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Case Sensitive";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Location = new System.Drawing.Point(28, 219);
            this.checkBox3.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(195, 30);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Incremental Search";
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox4.AutoSize = false;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox4.Location = new System.Drawing.Point(28, 273);
            this.checkBox4.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(195, 30);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Filter Search";
            // 
            // ejDropDownList2
            // 
            this.ejDropDownList2.Anchor = Wisej.Web.AnchorStyles.None;
            this.ejDropDownList2.Location = new System.Drawing.Point(394, 299);
            this.ejDropDownList2.Name = "ejDropDownList2";
            this.ejDropDownList2.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse(resources.GetString("ejDropDownList2.Options"))));
            this.ejDropDownList2.Size = new System.Drawing.Size(300, 30);
            this.ejDropDownList2.TabIndex = 1;
            this.ejDropDownList2.Text = "ejDropDownList2";
            this.ejDropDownList2.WidgetEvent += new Wisej.Web.WidgetEventHandler(this.ejDropDownList_WidgetEvent);
            // 
            // checkBox5
            // 
            this.checkBox5.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox5.AutoSize = false;
            this.checkBox5.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox5.Location = new System.Drawing.Point(28, 327);
            this.checkBox5.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(195, 30);
            this.checkBox5.TabIndex = 5;
            this.checkBox5.Text = "Enable Sorting";
            // 
            // checkBox6
            // 
            this.checkBox6.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox6.AutoSize = false;
            this.checkBox6.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox6.Location = new System.Drawing.Point(28, 381);
            this.checkBox6.Margin = new Wisej.Web.Padding(3, 10, 3, 3);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(195, 30);
            this.checkBox6.TabIndex = 6;
            this.checkBox6.Text = "Show Checkbox";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(28, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 47);
            this.label4.TabIndex = 0;
            this.label4.Text = "Note: The properties only affect the top list.";
            // 
            // ejDropDownList
            // 
            this.Name = "ejDropDownList";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejDropDownList ejDropDownList1;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
		private CheckBox checkBox2;
		private CheckBox checkBox1;
		private Syncfusion.ejDropDownList ejDropDownList2;
		private CheckBox checkBox6;
		private CheckBox checkBox5;
		private Label label4;
	}
}
