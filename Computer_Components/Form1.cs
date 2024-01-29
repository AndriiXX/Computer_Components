using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Computer_Components
{
    public partial class Form1 : Form
    {
        private Dictionary<string, int> components1 = new Dictionary<string, int>()
        {
            { "Процесор", 5000 },
            { "Відеокарта", 7000 },
            { "Оперативна пам'ять", 2000 },
            { "Материнська плата", 3000 }
            // Додайте інші компоненти тут
        };


        private List<string> currentSales = new List<string>();

        public Form1()
        {
            InitializeComponent();
            PopulateComponentDropdown();
        }

        private void PopulateComponentDropdown()
        {
            foreach (var component in components1)
            {
                componentDropdown.Items.Add(component.Key);
            }
        }

        private void componentDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedComponent = componentDropdown.SelectedItem.ToString();
            int price = components1[selectedComponent];
            priceTextBox.Text = price.ToString();
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            string selectedComponent = componentDropdown.SelectedItem.ToString();
            currentSales.Add(selectedComponent);
            UpdateTotal();
        }

        public void UpdateComponents(Dictionary<string, int> newComponents)
        {
            components1 = newComponents;
            componentDropdown.Items.Clear();
            PopulateComponentDropdown();
        }
        private void UpdateTotal()
        {
            int total = 0;
            foreach (string component in currentSales)
            {
                total += components1[component];
            }
            totalLabel.Text = "Загальна вартість: " + total.ToString();
        }
        private void editButton_Click_1(object sender, EventArgs e)
        {
            Form2 editorForm = new Form2(components1);
            editorForm.ShowDialog();
            // Оновлення комбо бокса після закриття другої форми
            UpdateComponents(editorForm.GetComponents());
        }
    }
}
