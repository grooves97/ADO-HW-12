using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CityPhone.DataAcces;
using CityPhone.Models;

namespace CityPhone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (var context = new DataContext())
            {
                foreach (var city in context.Cities.ToList())
                {
                    comboBoxCities.Items.Add(city.Name);
                }
            }
        }

        private void ComboBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDataGridViewNumbers();

            using (var context = new DataContext())
            {
                textBoxCode.Text = context.Cities.Where(c => c.Name == comboBoxCities.SelectedItem.ToString()).FirstOrDefault().Code.ToString();
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string number = maskedTextBoxNumber.Text;

            if (textBoxCode.Text == "XXXX")
            {
                MessageBox.Show("Выберете город");
                return;
            }

            number = number.Replace("-", string.Empty);
            if (number.Length != 6)
            {
                MessageBox.Show("Неверный формат телефона");
                return;
            }

            using (var context = new DataContext())
            {
                City selectedCity = context.Cities.Where(c => c.Name == comboBoxCities.SelectedItem.ToString()).FirstOrDefault();

                if (selectedCity != null)
                {
                    context.Numbers.Add(
                        new Number
                        {
                            CityId = selectedCity.Id,
                            City = selectedCity,
                            PhoneNumber = Convert.ToInt32(number)
                        });
                    context.SaveChanges();
                    maskedTextBoxNumber.Text = "";
                    LoadDataGridViewNumbers();
                }
            }
        }

        private void LoadDataGridViewNumbers()
        {
            dataGridViewNumbers.Rows.Clear();
            dataGridViewNumbers.Columns.Clear();

            dataGridViewNumbers.Columns.Add("Code", "Код города");
            dataGridViewNumbers.Columns.Add("Number", "Номер");

            using (var context = new DataContext())
            {
                var numbers = context.Numbers.Where(n => n.City.Name == comboBoxCities.SelectedItem.ToString()).ToList();

                for (int i = 0; i < numbers.Count(); i++)
                {
                    List<string> data = new List<string>();

                    data.Add(numbers[i].City.Code.ToString());
                    data.Add(numbers[i].PhoneNumber.ToString());

                    dataGridViewNumbers.Rows.Add(data.ToArray());
                }
            }

        }
    }
}
