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
            OldNameTextBox = new TextBox();
            NewNameTextBox = new TextBox();
            CancelButton = new Button();
            EditButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // OldNameTextBox
            // 
            OldNameTextBox.Location = new Point(12, 23);
            OldNameTextBox.Name = "OldNameTextBox";
            OldNameTextBox.Size = new Size(246, 23);
            OldNameTextBox.TabIndex = 0;
            // 
            // NewNameTextBox
            // 
            NewNameTextBox.Location = new Point(12, 64);
            NewNameTextBox.Name = "NewNameTextBox";
            NewNameTextBox.Size = new Size(246, 23);
            NewNameTextBox.TabIndex = 0;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(12, 93);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(158, 93);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(100, 23);
            EditButton.TabIndex = 1;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 2;
            label1.Text = "Название книги";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 49);
            label2.Name = "label2";
            label2.Size = new Size(130, 15);
            label2.TabIndex = 2;
            label2.Text = "Новое название книги";
            // 
            // EditBookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(270, 122);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EditButton);
            Controls.Add(CancelButton);
            Controls.Add(NewNameTextBox);
            Controls.Add(OldNameTextBox);
            Name = "EditBookForm";
            Text = "EditBookForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox OldNameTextBox;
        private TextBox NewNameTextBox;
        private Button CancelButton;
        private Button EditButton;
        private Label label1;
        private Label label2;
    }
}