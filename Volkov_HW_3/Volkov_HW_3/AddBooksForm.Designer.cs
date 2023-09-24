﻿namespace Volkov_HW_3
{
    partial class AddBooksForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooksForm));
            AuthorTextBox = new TextBox();
            BookTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            CancelButton = new Button();
            OkButton = new Button();
            SuspendLayout();
            // 
            // AuthorTextBox
            // 
            resources.ApplyResources(AuthorTextBox, "AuthorTextBox");
            AuthorTextBox.Name = "AuthorTextBox";
            // 
            // BookTextBox
            // 
            resources.ApplyResources(BookTextBox, "BookTextBox");
            BookTextBox.Name = "BookTextBox";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // CancelButton
            // 
            resources.ApplyResources(CancelButton, "CancelButton");
            CancelButton.Name = "CancelButton";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // OkButton
            // 
            resources.ApplyResources(OkButton, "OkButton");
            OkButton.DialogResult = DialogResult.OK;
            OkButton.Name = "OkButton";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // AddBooksForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OkButton);
            Controls.Add(CancelButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BookTextBox);
            Controls.Add(AuthorTextBox);
            Name = "AddBooksForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AuthorTextBox;
        private TextBox BookTextBox;
        private Label label1;
        private Label label2;
        private Button CancelButton;
        private Button OkButton;
    }
}