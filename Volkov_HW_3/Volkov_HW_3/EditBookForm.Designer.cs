namespace Volkov_HW_3
{
    partial class EditBookForm
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
            NewNameTextBox = new TextBox();
            CancelButton = new Button();
            EditButton = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // NewNameTextBox
            // 
            NewNameTextBox.Location = new Point(12, 22);
            NewNameTextBox.Name = "NewNameTextBox";
            NewNameTextBox.Size = new Size(246, 23);
            NewNameTextBox.TabIndex = 0;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(12, 51);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(158, 51);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(100, 23);
            EditButton.TabIndex = 1;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 7);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 2;
            label2.Text = "Новое название книги";
            // 
            // EditBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 81);
            Controls.Add(label2);
            Controls.Add(EditButton);
            Controls.Add(CancelButton);
            Controls.Add(NewNameTextBox);
            MaximizeBox = false;
            Name = "EditBookForm";
            Text = "EditBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox NewNameTextBox;
        private Button CancelButton;
        private Button EditButton;
        private Label label2;
    }
}