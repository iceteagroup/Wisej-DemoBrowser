﻿namespace Wisej.Web.Ext.Webix.Demo.Component
{
	partial class Chat
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
            this.chat1 = new Wisej.Web.Ext.Webix.Chat();
            this.comboBoxChatType = new Wisej.Web.ComboBox();
            this.checkBoxCompact = new Wisej.Web.CheckBox();
            this.checkBoxAllowFile = new Wisej.Web.CheckBox();
            this.groupBox1.SuspendLayout();
            this.panel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // linkDemo
            // 
            this.linkDemo.Text = "https://snippet.webix.com/gallery/chat";
            // 
            // linkAPI
            // 
            this.linkAPI.Text = "https://docs.webix.com/api__refs__ui.chat.html";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.chat1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxCompact);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxAllowFile);
            this.flowLayoutPanel1.Controls.Add(this.comboBoxChatType);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(16, 31);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(218, 441);
            // 
            // chat1
            // 
            this.chat1.Dock = Wisej.Web.DockStyle.Fill;
            this.chat1.Enabled = false;
            this.chat1.Location = new System.Drawing.Point(8, 8);
            this.chat1.Name = "chat1";
            this.chat1.Size = new System.Drawing.Size(1073, 542);
            this.chat1.TabIndex = 11;
            this.chat1.Text = "chat1";
            // 
            // comboBoxChatType
            // 
            this.comboBoxChatType.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.comboBoxChatType.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList;
            this.comboBoxChatType.Focusable = false;
            this.comboBoxChatType.Items.AddRange(new object[] {
            "user",
            "chat"});
            this.comboBoxChatType.LabelText = "Chat type";
            this.comboBoxChatType.Location = new System.Drawing.Point(3, 67);
            this.comboBoxChatType.Name = "comboBoxChatType";
            this.comboBoxChatType.Size = new System.Drawing.Size(212, 46);
            this.comboBoxChatType.TabIndex = 0;
            // 
            // checkBoxCompact
            // 
            this.checkBoxCompact.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxCompact.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxCompact.AutoSize = false;
            this.checkBoxCompact.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxCompact.Location = new System.Drawing.Point(3, 3);
            this.checkBoxCompact.Name = "checkBoxCompact";
            this.checkBoxCompact.Size = new System.Drawing.Size(212, 26);
            this.checkBoxCompact.TabIndex = 1;
            this.checkBoxCompact.Text = "Compact";
            // 
            // checkBoxAllowFile
            // 
            this.checkBoxAllowFile.Anchor = ((Wisej.Web.AnchorStyles)(((Wisej.Web.AnchorStyles.Top | Wisej.Web.AnchorStyles.Left) 
            | Wisej.Web.AnchorStyles.Right)));
            this.checkBoxAllowFile.Appearance = Wisej.Web.Appearance.Switch;
            this.checkBoxAllowFile.AutoSize = false;
            this.checkBoxAllowFile.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAllowFile.Location = new System.Drawing.Point(3, 35);
            this.checkBoxAllowFile.Name = "checkBoxAllowFile";
            this.checkBoxAllowFile.Size = new System.Drawing.Size(212, 26);
            this.checkBoxAllowFile.TabIndex = 2;
            this.checkBoxAllowFile.Text = "Allow files";
            // 
            // Chat
            // 
            this.Name = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private Webix.Chat chat1;
        private CheckBox checkBoxCompact;
        private CheckBox checkBoxAllowFile;
        private ComboBox comboBoxChatType;
    }
}
