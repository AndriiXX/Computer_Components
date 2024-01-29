namespace Computer_Components
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
            componentDropdown = new ComboBox();
            editButton = new Button();
            addButton = new Button();
            totalLabel = new Label();
            priceTextBox = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // componentDropdown
            // 
            componentDropdown.FormattingEnabled = true;
            componentDropdown.Location = new Point(321, 138);
            componentDropdown.Name = "componentDropdown";
            componentDropdown.Size = new Size(157, 23);
            componentDropdown.TabIndex = 0;
            // 
            // editButton
            // 
            editButton.Location = new Point(321, 356);
            editButton.Name = "editButton";
            editButton.Size = new Size(139, 23);
            editButton.TabIndex = 2;
            editButton.Text = "Змінити Компоненти";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click_1;
            // 
            // addButton
            // 
            addButton.Location = new Point(353, 327);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 3;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click_1;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(330, 120);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(0, 15);
            totalLabel.TabIndex = 4;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(340, 385);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(100, 23);
            priceTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(340, 164);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 5;
            label1.Text = "Оберіть компонент";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(totalLabel);
            Controls.Add(addButton);
            Controls.Add(editButton);
            Controls.Add(priceTextBox);
            Controls.Add(componentDropdown);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox componentDropdown;
        private Button editButton;
        private Button addButton;
        private Label totalLabel;
        private TextBox priceTextBox;
        private Label label1;
    }
}
