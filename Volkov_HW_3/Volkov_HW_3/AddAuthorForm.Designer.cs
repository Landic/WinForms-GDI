namespace Volkov_HW_3
{
    partial class AddAuthorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAuthorForm));
            AuthorName = new TextBox();
            label1 = new Label();
            CancelButton = new Button();
            OkButton = new Button();
            SuspendLayout();
            // 
            // AuthorName
            // 
            AuthorName.Location = new Point(12, 22);
            AuthorName.Name = "AuthorName";
            AuthorName.Size = new Size(250, 23);
            AuthorName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 1;
            label1.Text = "Введите имя автора";
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(12, 51);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(75, 23);
            CancelButton.TabIndex = 2;
            CancelButton.Text = "Отмена";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // OkButton
            // 
            OkButton.DialogResult = DialogResult.OK;
            OkButton.Location = new Point(187, 51);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(75, 23);
            OkButton.TabIndex = 2;
            OkButton.Text = "Добавить";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // AddAuthorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 80);
            Controls.Add(OkButton);
            Controls.Add(CancelButton);
            Controls.Add(label1);
            Controls.Add(AuthorName);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddAuthorForm";
            Text = "Add author";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AuthorName;
        private Label label1;
        private Button CancelButton;
        private Button OkButton;
    }
}