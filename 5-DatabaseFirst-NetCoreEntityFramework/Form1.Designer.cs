﻿namespace _5_DatabaseFirst_NetCoreEntityFramework
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbxNewDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BtAddNewCategory = new System.Windows.Forms.Button();
            this.TbxNewName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LbxCategories = new System.Windows.Forms.ListBox();
            this.BtDeleteCategory = new System.Windows.Forms.Button();
            this.BtGetCategories = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TbxUpdateDesc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtUpdateCategory = new System.Windows.Forms.Button();
            this.TbxUpdateName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ChkIsActiveNewCat = new System.Windows.Forms.CheckBox();
            this.ChkIsActiveUpdCat = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkIsActiveNewCat);
            this.groupBox1.Controls.Add(this.TbxNewDesc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.BtAddNewCategory);
            this.groupBox1.Controls.Add(this.TbxNewName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(249, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 111);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Category";
            // 
            // TbxNewDesc
            // 
            this.TbxNewDesc.Location = new System.Drawing.Point(152, 48);
            this.TbxNewDesc.Name = "TbxNewDesc";
            this.TbxNewDesc.Size = new System.Drawing.Size(100, 23);
            this.TbxNewDesc.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desc:";
            // 
            // BtAddNewCategory
            // 
            this.BtAddNewCategory.Location = new System.Drawing.Point(152, 82);
            this.BtAddNewCategory.Name = "BtAddNewCategory";
            this.BtAddNewCategory.Size = new System.Drawing.Size(100, 23);
            this.BtAddNewCategory.TabIndex = 4;
            this.BtAddNewCategory.Text = "Add New";
            this.BtAddNewCategory.UseVisualStyleBackColor = true;
            this.BtAddNewCategory.Click += new System.EventHandler(this.BtAddNewCategory_Click);
            // 
            // TbxNewName
            // 
            this.TbxNewName.Location = new System.Drawing.Point(152, 19);
            this.TbxNewName.Name = "TbxNewName";
            this.TbxNewName.Size = new System.Drawing.Size(100, 23);
            this.TbxNewName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // LbxCategories
            // 
            this.LbxCategories.FormattingEnabled = true;
            this.LbxCategories.ItemHeight = 15;
            this.LbxCategories.Location = new System.Drawing.Point(12, 45);
            this.LbxCategories.Name = "LbxCategories";
            this.LbxCategories.Size = new System.Drawing.Size(231, 229);
            this.LbxCategories.TabIndex = 8;
            // 
            // BtDeleteCategory
            // 
            this.BtDeleteCategory.Location = new System.Drawing.Point(168, 12);
            this.BtDeleteCategory.Name = "BtDeleteCategory";
            this.BtDeleteCategory.Size = new System.Drawing.Size(75, 23);
            this.BtDeleteCategory.TabIndex = 7;
            this.BtDeleteCategory.Text = "Delete";
            this.BtDeleteCategory.UseVisualStyleBackColor = true;
            this.BtDeleteCategory.Click += new System.EventHandler(this.BtDeleteCategory_Click);
            // 
            // BtGetCategories
            // 
            this.BtGetCategories.Location = new System.Drawing.Point(12, 12);
            this.BtGetCategories.Name = "BtGetCategories";
            this.BtGetCategories.Size = new System.Drawing.Size(101, 23);
            this.BtGetCategories.TabIndex = 6;
            this.BtGetCategories.Text = "Get Categories";
            this.BtGetCategories.UseVisualStyleBackColor = true;
            this.BtGetCategories.Click += new System.EventHandler(this.BtGetCategories_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TbxUpdateDesc);
            this.groupBox2.Controls.Add(this.ChkIsActiveUpdCat);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.BtUpdateCategory);
            this.groupBox2.Controls.Add(this.TbxUpdateName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(249, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(303, 111);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Category";
            // 
            // TbxUpdateDesc
            // 
            this.TbxUpdateDesc.Location = new System.Drawing.Point(152, 48);
            this.TbxUpdateDesc.Name = "TbxUpdateDesc";
            this.TbxUpdateDesc.Size = new System.Drawing.Size(100, 23);
            this.TbxUpdateDesc.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "New Desc:";
            // 
            // BtUpdateCategory
            // 
            this.BtUpdateCategory.Location = new System.Drawing.Point(152, 82);
            this.BtUpdateCategory.Name = "BtUpdateCategory";
            this.BtUpdateCategory.Size = new System.Drawing.Size(100, 23);
            this.BtUpdateCategory.TabIndex = 4;
            this.BtUpdateCategory.Text = "Save";
            this.BtUpdateCategory.UseVisualStyleBackColor = true;
            this.BtUpdateCategory.Click += new System.EventHandler(this.BtUpdateCategory_Click);
            // 
            // TbxUpdateName
            // 
            this.TbxUpdateName.Location = new System.Drawing.Point(152, 19);
            this.TbxUpdateName.Name = "TbxUpdateName";
            this.TbxUpdateName.Size = new System.Drawing.Size(100, 23);
            this.TbxUpdateName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "New Name:";
            // 
            // ChkIsActiveNewCat
            // 
            this.ChkIsActiveNewCat.AutoSize = true;
            this.ChkIsActiveNewCat.Location = new System.Drawing.Point(13, 84);
            this.ChkIsActiveNewCat.Name = "ChkIsActiveNewCat";
            this.ChkIsActiveNewCat.Size = new System.Drawing.Size(70, 19);
            this.ChkIsActiveNewCat.TabIndex = 7;
            this.ChkIsActiveNewCat.Text = "Is Active";
            this.ChkIsActiveNewCat.UseVisualStyleBackColor = true;
            // 
            // ChkIsActiveUpdCat
            // 
            this.ChkIsActiveUpdCat.AutoSize = true;
            this.ChkIsActiveUpdCat.Location = new System.Drawing.Point(13, 84);
            this.ChkIsActiveUpdCat.Name = "ChkIsActiveUpdCat";
            this.ChkIsActiveUpdCat.Size = new System.Drawing.Size(70, 19);
            this.ChkIsActiveUpdCat.TabIndex = 7;
            this.ChkIsActiveUpdCat.Text = "Is Active";
            this.ChkIsActiveUpdCat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 285);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LbxCategories);
            this.Controls.Add(this.BtDeleteCategory);
            this.Controls.Add(this.BtGetCategories);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Database First(NET Core): CRUD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox TbxNewDesc;
        private Label label3;
        private Button BtAddNewCategory;
        private TextBox TbxNewName;
        private Label label1;
        private ListBox LbxCategories;
        private Button BtDeleteCategory;
        private Button BtGetCategories;
        private GroupBox groupBox2;
        private TextBox TbxUpdateDesc;
        private Label label4;
        private Button BtUpdateCategory;
        private TextBox TbxUpdateName;
        private Label label2;
        private CheckBox ChkIsActiveNewCat;
        private CheckBox ChkIsActiveUpdCat;
    }
}