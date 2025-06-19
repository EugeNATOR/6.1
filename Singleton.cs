using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace пр_6._1
{
    internal class Singleton
    {
        static Singleton instance;
        string titleOfHorses;
        DateTime date;
        string times;
        Singleton(string titleOfHorses, DateTime date, string times) 
        {
            this.titleOfHorses = titleOfHorses;
            this.date = date;
            this.times = times;
            GetInfo();
        }
        public static Singleton getInstance(string titleOfHorses, DateTime date, string times) 
        {
            if (instance == null )
            {
                instance = new Singleton(titleOfHorses, date, times);
            }
            else
            {
                MessageBox.Show("Лошадь уже ждет! \nСинглтон не даст тебе второй раз записаться (гы)", "Одиночка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                return instance;
        }
        void GetInfo() 
        {
            MessageBox.Show($"Вы забронировали кобылу!\nЛошадь: {titleOfHorses}\nДата: {date.ToString("dd.MM.yyyy")}\nВремя: {times}", "Бронирование", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
