using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace G_Code_Generator
{
    public partial class GMTable : Form
    {
        public GMTable()
        {
            InitializeComponent();

          
        }

        private void GMTable_Load(object sender, EventArgs e)
        {
            //Заполнение таблицы 1, редактировать ее нельзя по свойствам
            dataGridView1.Rows.Add("G00", "Ускоренное перемещение на холостом ходу");
            dataGridView1.Rows.Add("G01", "Линейная интерполяция");
            dataGridView1.Rows.Add("G02", "Круговая интерполяция по часовой стрелке");
            dataGridView1.Rows.Add("G03", "Круговая интерполяция против часовой стрелки");
            dataGridView1.Rows.Add("G04", "Включение задержки (в милисекундах)");
            dataGridView1.Rows.Add("G10", "Задание новых начальных точек отсчета");
            dataGridView1.Rows.Add("G11", "Отмена");
            dataGridView1.Rows.Add("G15", "Отмена полярной системы координат");
            dataGridView1.Rows.Add("G16", "Полярной системы координат (Х радиус Y радиус)");
            dataGridView1.Rows.Add("G17", "Выбор рабочей плоскости X-Y");
            dataGridView1.Rows.Add("G18", "Выбор рабочей плоскости Z-X");
            dataGridView1.Rows.Add("G19", "Выбор рабочей плоскости Y-Z");
            dataGridView1.Rows.Add("G40", "Отмена копмпенсации размера инструмента");
            dataGridView1.Rows.Add("G41", "Компенсировать радиус инструмента слева от траектории");
            dataGridView1.Rows.Add("G42", "Компенсировать радиус инструмента справа от траектории");
            dataGridView1.Rows.Add("G43", "Компенсировать длину инструмента положительно");
            dataGridView1.Rows.Add("G44", "Компенсировать длину инструмента отрицательно");
            dataGridView1.Rows.Add("G90", "Задание абсолютных координат опорных точек траектории");
            dataGridView1.Rows.Add("G91", "Относительная система координат");
            dataGridView1.Rows.Add("G94", "F (подача) — в формате мм/мин");
            dataGridView1.Rows.Add("G95", "F (подача) — в формате мм/об");


            //Заполнение таблицы 2, редактировать ее нельзя по свойствам
            dataGridView2.Rows.Add("M00", "Приостановить работу станка до нажатия кнопки «старт» на пульте управления -«технологический останов»");
            dataGridView2.Rows.Add("M01", "Приостановить работу станка до нажатия кнопки «старт», если включён режим подтверждения останова»");
            dataGridView2.Rows.Add("M02", "Конец программы, без сброса модальных функций");
            dataGridView2.Rows.Add("M03", "Начать вращение шпинделя по часовой стрелке");
            dataGridView2.Rows.Add("M04", "Начать вращение шпинделя против часовой стрелки");
            dataGridView2.Rows.Add("M05", "Остановить вращение шпинделя");
            dataGridView2.Rows.Add("M06", "Сменить инструмент");
            dataGridView2.Rows.Add("M07", "Включить дополнительное охлаждение");
            dataGridView2.Rows.Add("M08", "Включить основное охлаждение");
            dataGridView2.Rows.Add("M09", "Выключить охлаждение");
            dataGridView2.Rows.Add("M13", "Включить охлаждение и вращение шпинделя по часовой стрелке");
            dataGridView2.Rows.Add("M14", "Включить охлаждение и вращение шпинделя против часовой стрелки");
            dataGridView2.Rows.Add("M17", "Конец подпрограммы");
            dataGridView2.Rows.Add("M30", "Конец программы, со сбросом модальных функций");
            dataGridView2.Rows.Add("M98", "Запуск подпрограммы, находящейся отдельно от основной программы (P -номер подпрограммы)");
            dataGridView2.Rows.Add("M99", "Конец подпрограммы");

        }
    }
}
