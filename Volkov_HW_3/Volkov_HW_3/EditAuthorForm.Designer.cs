﻿namespace Volkov_HW_3
{
    partial class EditAuthorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAuthorForm));
            NewAuthorTextBox = new TextBox();
            CancelButton = new Button();
            EditButton = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // NewAuthorTextBox
            // 
            NewAuthorTextBox.Location = new Point(12, 23);
            NewAuthorTextBox.Name = "NewAuthorTextBox";
            NewAuthorTextBox.Size = new Size(264, 23);
            NewAuthorTextBox.TabIndex = 0;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(12, 58);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(178, 58);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(98, 23);
            EditButton.TabIndex = 1;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 8);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 2;
            label2.Text = "Новое имя автора";
            // 
            // EditAuthorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 90);
            Controls.Add(label2);
            Controls.Add(EditButton);
            Controls.Add(CancelButton);
            Controls.Add(NewAuthorTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EditAuthorForm";
            Text = "Edit author";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox NewAuthorTextBox;
        private Button CancelButton;
        private Button EditButton;
        private Label label2;
    }
}