﻿namespace Volkov_HW_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            menuStrip1 = new MenuStrip();
            Button_Retry = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 119);
            button1.Name = "button1";
            button1.Size = new Size(75, 74);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 119);
            button2.Name = "button2";
            button2.Size = new Size(75, 74);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button_Click;
            // 
            // button3
            // 
            button3.Location = new Point(174, 119);
            button3.Name = "button3";
            button3.Size = new Size(75, 74);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 199);
            button4.Name = "button4";
            button4.Size = new Size(75, 74);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button_Click;
            // 
            // button5
            // 
            button5.Location = new Point(93, 199);
            button5.Name = "button5";
            button5.Size = new Size(75, 74);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button_Click;
            // 
            // button6
            // 
            button6.Location = new Point(171, 199);
            button6.Name = "button6";
            button6.Size = new Size(75, 74);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button_Click;
            // 
            // button7
            // 
            button7.Location = new Point(12, 279);
            button7.Name = "button7";
            button7.Size = new Size(75, 74);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = true;
            button7.Click += Button_Click;
            // 
            // button8
            // 
            button8.Location = new Point(93, 279);
            button8.Name = "button8";
            button8.Size = new Size(75, 74);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = true;
            button8.Click += Button_Click;
            // 
            // button9
            // 
            button9.Location = new Point(174, 279);
            button9.Name = "button9";
            button9.Size = new Size(75, 74);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = true;
            button9.Click += Button_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(57, 19);
            radioButton1.TabIndex = 9;
            radioButton1.TabStop = true;
            radioButton1.Text = "Легко";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(6, 44);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 19);
            radioButton2.TabIndex = 10;
            radioButton2.TabStop = true;
            radioButton2.Text = "Сложно";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(130, 44);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(116, 69);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Сложность";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton4);
            groupBox2.Controls.Add(radioButton3);
            groupBox2.Location = new Point(12, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(101, 69);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Тип игры";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(6, 44);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(71, 19);
            radioButton4.TabIndex = 12;
            radioButton4.TabStop = true;
            radioButton4.Text = "С ботом";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(6, 22);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(56, 19);
            radioButton3.TabIndex = 11;
            radioButton3.TabStop = true;
            radioButton3.Text = "1 на 1";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { Button_Retry });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(257, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // Button_Retry
            // 
            Button_Retry.Name = "Button_Retry";
            Button_Retry.Size = new Size(99, 20);
            Button_Retry.Text = "Начать заново";
            Button_Retry.Click += Button_Retry_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(257, 357);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Tic Tac Toe";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Button_Retry;
    }
}