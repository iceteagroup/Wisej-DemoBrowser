﻿namespace Wisej.DemoBrowser.DataGridView
{
    partial class Features
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
            this.components = new System.ComponentModel.Container();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle1 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle5 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle2 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle3 = new Wisej.Web.DataGridViewCellStyle();
            Wisej.Web.DataGridViewCellStyle dataGridViewCellStyle4 = new Wisej.Web.DataGridViewCellStyle();
            this.dataGridView1 = new Wisej.Web.DataGridView();
            this.Column0 = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colAvatar = new Wisej.Web.DataGridViewImageColumn();
            this.colFirstname = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colLastname = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colId = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colBirthday = new Wisej.Web.DataGridViewDateTimePickerColumn();
            this.colGender = new Wisej.Web.DataGridViewComboBoxColumn();
            this.genderBindingSource = new Wisej.Web.BindingSource(this.components);
            this.colCartid = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colSSN = new Wisej.Web.DataGridViewMaskedTextBoxColumn();
            this.colRating = new Wisej.Web.DataGridViewTextBoxColumn();
            this.colAccountActive = new Wisej.Web.DataGridViewCheckBoxColumn();
            this.colButton = new Wisej.Web.DataGridViewButtonColumn();
            this.personBindingSource = new Wisej.Web.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.CellBorderStyle = Wisej.Web.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = Wisej.Web.DataGridViewCellBorderStyle.Horizontal;
            dataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("default", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 42;
            this.dataGridView1.Columns.AddRange(new Wisej.Web.DataGridViewColumn[] {
            this.Column0,
            this.colAvatar,
            this.colFirstname,
            this.colLastname,
            this.colId,
            this.colBirthday,
            this.colGender,
            this.colCartid,
            this.colSSN,
            this.colRating,
            this.colAccountActive,
            this.colButton});
            this.dataGridView1.CssStyle = "border-radius: 4px;";
            this.dataGridView1.DataSource = this.personBindingSource;
            dataGridViewCellStyle5.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Dock = Wisej.Web.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(16, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1390, 442);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new Wisej.Web.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column0
            // 
            this.Column0.DataPropertyName = "UserName";
            this.Column0.HeaderText = "Username";
            this.Column0.Name = "Column0";
            this.Column0.Width = 150;
            // 
            // colAvatar
            // 
            this.colAvatar.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet;
            this.colAvatar.DataPropertyName = "Avatar";
            this.colAvatar.HeaderText = "Avatar";
            this.colAvatar.Name = "colAvatar";
            // 
            // colFirstname
            // 
            this.colFirstname.DataPropertyName = "FirstName";
            this.colFirstname.HeaderText = "First Name";
            this.colFirstname.Name = "colFirstname";
            this.colFirstname.Width = 150;
            // 
            // colLastname
            // 
            this.colLastname.DataPropertyName = "LastName";
            this.colLastname.HeaderText = "Last Name";
            this.colLastname.Name = "colLastname";
            this.colLastname.Width = 150;
            // 
            // colId
            // 
            this.colId.AllowHtml = true;
            this.colId.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter;
            this.colId.DefaultCellStyle = dataGridViewCellStyle2;
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            this.colId.Width = 50;
            // 
            // colBirthday
            // 
            this.colBirthday.DataPropertyName = "Birthday";
            dataGridViewCellStyle3.Format = "G";
            this.colBirthday.DefaultCellStyle = dataGridViewCellStyle3;
            this.colBirthday.HeaderText = "Birthday";
            this.colBirthday.Name = "colBirthday";
            this.colBirthday.Width = 200;
            // 
            // colGender
            // 
            this.colGender.AllowHtml = true;
            this.colGender.DataPropertyName = "Gender";
            this.colGender.DataSource = this.genderBindingSource;
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            // 
            // colCartid
            // 
            this.colCartid.DataPropertyName = "CartId";
            this.colCartid.HeaderText = "Cart ID";
            this.colCartid.Name = "colCartid";
            this.colCartid.Visible = false;
            // 
            // colSSN
            // 
            this.colSSN.DataPropertyName = "SSN";
            this.colSSN.HeaderText = "SSN";
            this.colSSN.Mask = "***-**-____";
            this.colSSN.Name = "colSSN";
            this.colSSN.ReadOnly = true;
            // 
            // colRating
            // 
            this.colRating.AllowHtml = true;
            this.colRating.DataPropertyName = "Rating";
            dataGridViewCellStyle4.Padding = new Wisej.Web.Padding(0, 0, 24, 0);
            this.colRating.DefaultCellStyle = dataGridViewCellStyle4;
            this.colRating.HeaderImageSource = "resource.wx/Wisej.Ext.VisualStudioIcons/Rating.svg";
            this.colRating.HeaderText = "Rating";
            this.colRating.Name = "colRating";
            this.colRating.Width = 150;
            // 
            // colAccountActive
            // 
            this.colAccountActive.DataPropertyName = "AccountActive";
            this.colAccountActive.HeaderImageSource = "resource.wx/Wisej.Ext.VisualStudioIcons/CheckBox.svg";
            this.colAccountActive.HeaderText = "Account Active";
            this.colAccountActive.Name = "colAccountActive";
            this.colAccountActive.ReadOnly = true;
            this.colAccountActive.Width = 150;
            // 
            // colButton
            // 
            this.colButton.HeaderText = "Action";
            this.colButton.Name = "colButton";
            this.colButton.Text = "Delete";
            this.colButton.UseColumnTextForButtonValue = true;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataSource = typeof(Wisej.DemoBrowser.DataGridView.Person);
            // 
            // Features
            // 
            this.Controls.Add(this.dataGridView1);
            this.Name = "Features";
            this.Padding = new Wisej.Web.Padding(16);
            this.Load += new System.EventHandler(this.ColumnTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Web.DataGridView dataGridView1;
        private Web.BindingSource personBindingSource;
        private Web.DataGridViewTextBoxColumn colFirstname;
        private Web.DataGridViewTextBoxColumn colLastname;
        private Web.DataGridViewComboBoxColumn colGender;
        private Web.DataGridViewTextBoxColumn colCartid;
        private Web.DataGridViewMaskedTextBoxColumn colSSN;
        private Web.DataGridViewTextBoxColumn colRating;
        private Web.DataGridViewButtonColumn colButton;
        private Web.DataGridViewTextBoxColumn colId;
        private Web.BindingSource genderBindingSource;
        private Web.DataGridViewImageColumn colAvatar;
        private Web.DataGridViewCheckBoxColumn colAccountActive;
        private Web.DataGridViewTextBoxColumn Column0;
        private Web.DataGridViewDateTimePickerColumn colBirthday;
    }
}
