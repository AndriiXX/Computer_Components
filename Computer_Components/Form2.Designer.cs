namespace Computer_Components
{
    partial class Form2
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
            componentListBox = new ListBox();
            componentNameTextBox = new TextBox();
            componentPriceTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            addbutton = new Button();
            button2 = new Button();
            button3 = new Button();
            changeButton = new Button();
            SuspendLayout();
            // 
            // componentListBox
            // 
            componentListBox.FormattingEnabled = true;
            componentListBox.ItemHeight = 15;
            componentListBox.Location = new Point(263, 72);
            componentListBox.Name = "componentListBox";
            componentListBox.Size = new Size(306, 139);
            componentListBox.TabIndex = 0;
            // 
            // componentNameTextBox
            // 
            componentNameTextBox.Location = new Point(339, 217);
            componentNameTextBox.Name = "componentNameTextBox";
            componentNameTextBox.Size = new Size(168, 23);
            componentNameTextBox.TabIndex = 1;
            // 
            // componentPriceTextBox
            // 
            componentPriceTextBox.Location = new Point(339, 249);
            componentPriceTextBox.Name = "componentPriceTextBox";
            componentPriceTextBox.Size = new Size(168, 23);
            componentPriceTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 220);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 3;
            label1.Text = "Назва ->";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(290, 252);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 4;
            label2.Text = "Ціна ->";
            // 
            // addbutton
            // 
            addbutton.Location = new Point(263, 314);
            addbutton.Name = "addbutton";
            addbutton.Size = new Size(75, 23);
            addbutton.TabIndex = 5;
            addbutton.Text = "Додати";
            addbutton.UseVisualStyleBackColor = true;
            addbutton.Click += addbutton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(380, 314);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "Оновити";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(494, 314);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Закрити";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // changeButton
            // 
            changeButton.Location = new Point(380, 343);
            changeButton.Name = "changeButton";
            changeButton.Size = new Size(75, 23);
            changeButton.TabIndex = 8;
            changeButton.Text = "Змінити";
            changeButton.UseVisualStyleBackColor = true;
            changeButton.Click += changeButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(changeButton);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(addbutton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(componentPriceTextBox);
            Controls.Add(componentNameTextBox);
            Controls.Add(componentListBox);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox componentListBox;
        private TextBox componentNameTextBox;
        private TextBox componentPriceTextBox;
        private Label label1;
        private Label label2;
        private Button addbutton;
        private Button button2;
        private Button button3;
        private Button changeButton;
    }
}