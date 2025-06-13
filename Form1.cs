using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пр_6._1
{
    public partial class Form1 : Form
    {
        List<string> doctors = new List<string> { "Мустанг", "КоньЧай","ДжерсиКонь","Черная Мамба","Тинкер", "Русская Торпеда", "Королевский Кобыл" };
        List<string> timesOfDay = new List<string> {"12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00"};
        public Form1()
        {
            InitializeComponent();
            comboBoxHorses.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTime.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void SingUp_Click(object sender, EventArgs e)
        {
            
            try
            {
                string titleOfHorses = comboBoxHorses.SelectedItem.ToString();
                string selectedTime = comboBoxTime.SelectedItem.ToString();
                DateTime selectedDate = dateTimePicker.Value;
                DateTime now = DateTime.Now;
                DateTime dateNow = now.Date;
                if (selectedDate >= dateNow)
                {
                    Horses horses = new Horses();
                    horses.Date(titleOfHorses, selectedTime, selectedDate);
                }
                else MessageBox.Show($"Дата должна быть не раньше {dateNow}!","Дата", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (NullReferenceException) { MessageBox.Show("Поля не могут быть пустыми!", "Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (string doctor in doctors)
            {
                comboBoxHorses.Items.Add((string)doctor);
            }
            foreach(string timeOfDay in timesOfDay)
            {
                comboBoxTime.Items.Add(timeOfDay);
            }
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            comboBoxHorses.SelectedIndex = -1;
            comboBoxTime.SelectedIndex = -1;
            dateTimePicker.Value = DateTime.Now;
        }

        private void записатьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SingUp.PerformClick();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }
    }
}
