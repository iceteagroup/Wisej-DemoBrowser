﻿using System;
using Wisej.Web;

namespace Wisej.Web.Ext.Webix.Demo.Component
{
    public partial class DocumentManager : ViewBase
    {
        private void DocumentManager_Load(object sender, EventArgs e)
        {
            this.documentManager1.Options.url = "https://docs.webix.com/docmanager-backend/";
        }

        public DocumentManager()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.comboBoxMode.SelectedIndex = 0;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.documentManager1.Options.mode = this.comboBoxMode.SelectedText;

            this.documentManager1.Update();
        }
    }
}
