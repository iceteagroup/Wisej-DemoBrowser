﻿namespace Wisej.Web.Ext.Syncfusion.Demo.Component
{
	partial class ejSlider
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
            this.label4 = new Wisej.Web.Label();
            this.ejSlider1 = new Wisej.Web.Ext.Syncfusion.ejSlider();
            this.label6 = new Wisej.Web.Label();
            this.checkBox2 = new Wisej.Web.CheckBox();
            this.checkBox1 = new Wisej.Web.CheckBox();
            this.checkBox3 = new Wisej.Web.CheckBox();
            this.checkBox4 = new Wisej.Web.CheckBox();
            this.comboBox1 = new Wisej.Web.ComboBox();
            this.label5 = new Wisej.Web.Label();
            this.ejSlider2 = new Wisej.Web.Ext.Syncfusion.ejSlider();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkDocs
            // 
            this.linkDocs.TabIndex = 4;
            this.linkDocs.Text = "https://help.syncfusion.com/js/slider/overview";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Size = new System.Drawing.Size(250, 517);
            this.groupBox1.Controls.SetChildIndex(this.buttonUpdate, 0);
            this.groupBox1.Controls.SetChildIndex(this.label6, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox2, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox1, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox3, 0);
            this.groupBox1.Controls.SetChildIndex(this.checkBox4, 0);
            this.groupBox1.Controls.SetChildIndex(this.comboBox1, 0);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(28, 425);
            this.buttonUpdate.TabIndex = 6;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Size = new System.Drawing.Size(606, 24);
            this.linkDemo.TabIndex = 6;
            this.linkDemo.Text = "https://js.syncfusion.com/demos/web/#!/flatlight/slider/DefaultFunctionalities";
            // 
            // linkAPI
            // 
            this.linkAPI.TabIndex = 5;
            this.linkAPI.Text = "https://help.syncfusion.com/api/js/ejslider";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ejSlider1);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label5);
            this.panel.Controls.Add(this.ejSlider2);
            this.panel.TabIndex = 7;
            this.panel.Text = "x";
            // 
            // label4
            // 
            this.label4.Anchor = Wisej.Web.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Range";
            // 
            // ejSlider1
            // 
            this.ejSlider1.Anchor = Wisej.Web.AnchorStyles.None;
            this.ejSlider1.Location = new System.Drawing.Point(353, 233);
            this.ejSlider1.Name = "ejSlider1";
            this.ejSlider1.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"sliderType\":\"range\",\"values\":[30,60]}")));
            this.ejSlider1.Size = new System.Drawing.Size(383, 32);
            this.ejSlider1.TabIndex = 1;
            this.ejSlider1.Text = "ejSlider1";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(28, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 69);
            this.label6.TabIndex = 0;
            this.label6.Text = "Note: Property changes only affect the \"Range\" slider";
            // 
            // checkBox2
            // 
            this.checkBox2.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox2.AutoSize = false;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Location = new System.Drawing.Point(28, 123);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(195, 38);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Allow Mouse Wheel";
            // 
            // checkBox1
            // 
            this.checkBox1.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox1.AutoSize = false;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(28, 179);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(195, 38);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Show Buttons";
            // 
            // checkBox3
            // 
            this.checkBox3.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox3.AutoSize = false;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Location = new System.Drawing.Point(28, 235);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(195, 38);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Show Scale";
            // 
            // checkBox4
            // 
            this.checkBox4.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBox4.AutoSize = false;
            this.checkBox4.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox4.Checked = true;
            this.checkBox4.Location = new System.Drawing.Point(28, 291);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(195, 38);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Show Small Ticks";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoSize = false;
            this.comboBox1.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBox1.Items.AddRange(new object[] {
            "Default",
            "MinRange",
            "Range"});
            this.comboBox1.Label.Size = 50;
            this.comboBox1.Label.SizeType = Wisej.Web.SizeType.Percent;
            this.comboBox1.LabelText = "Slider Type";
            this.comboBox1.Location = new System.Drawing.Point(28, 347);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 60);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "Default";
            // 
            // label5
            // 
            this.label5.Anchor = Wisej.Web.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(353, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Min-Range";
            // 
            // ejSlider2
            // 
            this.ejSlider2.Anchor = Wisej.Web.AnchorStyles.None;
            this.ejSlider2.Location = new System.Drawing.Point(353, 322);
            this.ejSlider2.Name = "ejSlider2";
            this.ejSlider2.Options = ((Wisej.Core.DynamicObject)(Wisej.Core.WisejSerializer.Parse("{\"value\":60,\"sliderType\":\"minrange\"}")));
            this.ejSlider2.Size = new System.Drawing.Size(383, 32);
            this.ejSlider2.TabIndex = 3;
            this.ejSlider2.Text = "ejSlider2";
            // 
            // ejSlider
            // 
            this.Name = "ejSlider";
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Syncfusion.ejSlider ejSlider1;
		private Label label4;
		private Label label6;
		private ComboBox comboBox1;
		private CheckBox checkBox4;
		private CheckBox checkBox3;
		private CheckBox checkBox1;
		private CheckBox checkBox2;
		private Label label5;
		private Syncfusion.ejSlider ejSlider2;
	}
}
