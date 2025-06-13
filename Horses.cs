using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace пр_6._1
{
    internal class Horses
    {
        public Singleton Record { get; set; }
        public void Date(string titleOfHorses, string times, DateTime selectedDate)
        {
            Random random = new Random();
            int chance = random.Next(3);
            switch (chance)
            {
                case 0: MessageBox.Show("Запись обработана!", "Запись", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                    
                    
                    DateTime date = new DateTime(selectedDate.Year, selectedDate.Month, selectedDate.Day);
                    Record = Singleton.getInstance(titleOfHorses, date, times);
                    break;
                case 1: MessageBox.Show("Произошел сбой!\nПожалуйста повторите попытку позже.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); break;
                case 2: MessageBox.Show("Ищем лощадь", "Поиск", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); break;
            }
        }
    }
}
