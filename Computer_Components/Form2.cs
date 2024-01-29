using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_Components
{
    public partial class Form2 : Form
    {
        private Dictionary<string, int> components1;

        public Form2(Dictionary<string, int> components)
        {
            InitializeComponent();
            this.components1 = components;
            PopulateComponentList();
            changeButton.Enabled = false;
        }

        private void PopulateComponentList()
        {
            foreach (string component in components1.Keys)
            {
                componentListBox.Items.Add(component);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (componentListBox.SelectedItem != null)
            {
                string selectedComponent = componentListBox.SelectedItem.ToString();
                int price = components1[selectedComponent];
                MessageBox.Show($"Ціна {selectedComponent}: {price}");
                // Додайте можливість редагування ціни чи інших характеристик тут
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть компонент для редагування.");
            }
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            string newComponentName = componentNameTextBox.Text;
            int newComponentPrice;
            if (!int.TryParse(componentPriceTextBox.Text, out newComponentPrice))
            {
                MessageBox.Show("Будь ласка, введіть коректну ціну для компонента.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            components1.Add(newComponentName, newComponentPrice);
            componentListBox.Items.Add(newComponentName);

            // Очистка полів для наступного вводу
            componentNameTextBox.Text = "";
            componentPriceTextBox.Text = "";
        }

        public Dictionary<string, int> GetComponents()
        {
            return components1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changeButton.Enabled = true;
            if (componentListBox.SelectedItem != null)
            {
                // Отримання обраного компонента
                string selectedComponent = componentListBox.SelectedItem.ToString();

                // Отримання ціни для обраного компонента
                int price = components1[selectedComponent];

                // Перенесення назви та ціни до текстових полів
                componentNameTextBox.Text = selectedComponent;
                componentPriceTextBox.Text = price.ToString();
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть компонент для редагування.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (componentListBox.SelectedItem != null)
            {
                // Виконуйте дії для зміни компонента, наприклад, зміна ціни
                string selectedComponent = componentListBox.SelectedItem.ToString();
                if (int.TryParse(componentPriceTextBox.Text, out int newPrice))
                {
                    components1[selectedComponent] = newPrice;
                    MessageBox.Show($"Ціна {selectedComponent} була оновлена: {newPrice}");
                }
                else
                {
                    MessageBox.Show("Будь ласка, введіть коректну ціну.", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть компонент для оновлення ціни.", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}