namespace Volkov_HW_3
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
            OldAuthorTextBox = new TextBox();
            NewAuthorTextBox = new TextBox();
            CancelButton = new Button();
            EditButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // OldAuthorTextBox
            // 
            OldAuthorTextBox.Location = new Point(12, 22);
            OldAuthorTextBox.Name = "OldAuthorTextBox";
            OldAuthorTextBox.Size = new Size(264, 23);
            OldAuthorTextBox.TabIndex = 0;
            // 
            // NewAuthorTextBox
            // 
            NewAuthorTextBox.Location = new Point(12, 63);
            NewAuthorTextBox.Name = "NewAuthorTextBox";
            NewAuthorTextBox.Size = new Size(264, 23);
            NewAuthorTextBox.TabIndex = 0;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(12, 98);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(178, 98);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(98, 23);
            EditButton.TabIndex = 1;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Автор";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(107, 15);
            label2.TabIndex = 2;
            label2.Text = "Новое имя автора";
            // 
            // EditAuthorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(288, 133);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EditButton);
            Controls.Add(CancelButton);
            Controls.Add(NewAuthorTextBox);
            Controls.Add(OldAuthorTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "EditAuthorForm";
            Text = "Edit author";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox OldAuthorTextBox;
        private TextBox NewAuthorTextBox;
        private Button CancelButton;
        private Button EditButton;
        private Label label1;
        private Label label2;
    }
}