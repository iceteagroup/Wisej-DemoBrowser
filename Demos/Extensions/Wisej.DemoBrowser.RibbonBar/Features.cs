﻿using System;
using System.IO;
using Wisej.DemoBrowser.Common;
using Wisej.Web;
using Wisej.Web.Ext.RibbonBar;

namespace Wisej.DemoBrowser.RibbonBar
{
    public partial class Features : DemoView
    {
        public Features()
        {
            InitializeComponent();
            this.ribbonBarItemCheckBox1.Checked = true;
            this.ribbonBar.MenuButtonItemClick += RibbonBar_MenuButtonItemClick;

            this.ribbonBarItemComboBox1.Items = new string[] {
                "One", "Two", "Three"
            };
            this.ribbonBarItemComboBox1.Value = "One";
            this.ribbonBarItemTextBox2.Value = "Text2";
        }

        private void RibbonBar_MenuButtonItemClick(object sender, RibbonBarMenuItemEventArgs e)
        {
            var button = e.Item;
            AlertBox.Show(button.ToString() + " => " + e.Item.ToString());
        }

        private void ribbonBar_ItemClick(object sender, Web.Ext.RibbonBar.RibbonBarItemEventArgs e)
        {
            AlertBox.Show(e.Item.ToString(), showProgressBar: true);
        }

        private void ribbonBar_GroupClick(object sender, RibbonBarGroupEventArgs e)
        {
            AlertBox.Show(e.Group.ToString(), showProgressBar: true);
        }

        private void ribbonBar_AppButtonClick(object sender, EventArgs e)
        {
            AlertBox.Show("App Button Clicked");
        }

        private void ribbonBar_ToolClick(object sender, ToolClickEventArgs e)
        {
            AlertBox.Show("Tool Click: " + e.Tool.Name);
        }
	}
}
