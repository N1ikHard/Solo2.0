using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Solo2._0
{
    public partial class Solo2 : Form
    {
        #region Данные для перемещения      
        private bool isDragging;             //Флаг , для перетаскивания формы
        private Point oldPos;                //Объект для сохранения координат текущей позиции
        #endregion
        #region Данные для программы
        int TotalSymbols;                 //Конечное число символов
        int TypedSymbols;                 //Текущее количество символов
        int Speed;                        //Скорость
        int Mistakes;                     //Ошибки
        DateTime StartTime;               //Начала печати
        DateTime CurrentTime;             //Конец печати
        int count;                        //Счетичик
        string Path = "TextForSolo.txt";  //Путь до файла
        #endregion
        public Solo2()
        {
            InitializeComponent();
        }
        #region Методы
        private void Initialization()                           //Иницициализация переменных
        {
            try                                                 //Попытка закачать строку(и) из файла
            {
                LabelTextTuped.Text = File.ReadAllText(Path);   
            }
            catch                                               //Вариант  на случай неудачи
            {   
                LabelTextTuped.Text = "Файл не найден , пишите это сообщение :)";
            }
            TotalSymbols = LabelTextTuped.Text.Length;
            TypedSymbols = 0;
            Mistakes = 0;
            StartTime = DateTime.Now;
            CurrentTime = DateTime.Now;
            Speed = 0;
            timer.Enabled = false;
            count = 0;
        }
        private void Start()                                    //Подсчет значений
        {
            TypedSymbols = richTextBoxTuped.Text.Length;        //Количество набранных символов
            labelTyped.Text = TypedSymbols.ToString() + "/" + TotalSymbols.ToString();
            if (TypedSymbols <= TotalSymbols)                   //Пока набранных меньше , чем общее количество
            {
                CurrentTime = DateTime.Now;                     //Запись текущего времени
                double seconds = (CurrentTime.Ticks - StartTime.Ticks) / 10000000.0;
                labelTime.Text = seconds.ToString("0.0") + "сек.";
                if (TypedSymbols > 0) Speed = Convert.ToInt16(TypedSymbols * 60 / seconds);
                else Speed = 0;
                labelSpeed.Text = Speed.ToString() + " симв/мин";
                labelMistake.Text = Mistakes.ToString();
                if (TotalSymbols == TypedSymbols) timer.Enabled = false; ;
            }
        }
        #endregion

        #region Функционал формы
        //Перетаскивание за верхнюю рамку
        //Закрытие по эмблеме
        private void panelDesign2_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void panelDesign1_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            oldPos = new Point();
            oldPos.X = e.X;
            oldPos.Y = e.Y;
        }
        private void panelDesign1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                Point tmp = new Point(Location.X, Location.Y);
                tmp.X += e.X - oldPos.X;
                tmp.Y += e.Y - oldPos.Y;
                Location = tmp;
            }
        }
        private void panelDesign1_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
        #endregion

        #region События
        private void richTextBoxTuped_KeyUp(object sender, KeyEventArgs e)
        { 
            Start();                                                      //При нажатии кнопки-рассчет характеристик

        }   
        private void richTextBoxTuped_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TotalSymbols == TypedSymbols & Mistakes==0) return;
            if (!((e.KeyChar >= 32 & e.KeyChar < 122 || e.KeyChar == 8))) //Если нажатая клавиша не английской раскладки
                e.Handled = true;                                         // , базовый символ или Backspace , то данные 
                                                                          // в строку НЕ выводятся
            else
            {
                timer.Enabled = true;                                     //Запуск таймера
                if (e.KeyChar == 8)                                       //Если нажат BackSpace
                {
                    if (count >= 1) count -= 1;                            //Счетчик в прежднее положение
                    richTextBoxTuped.Select(count, 1);                     //Выделяем текст
                    if (richTextBoxTuped.SelectionColor == Color.Red)      //Если красный , то отнимает 1 из счетчика ошибок
                        if (Mistakes > 0) Mistakes -= 1;
                    if (count == 0)                                         //Если счетчик стал равен 0 , то обнуляем все
                        Initialization();                                   //показатели
                }
                else                                                        //Если пользователь вводит данные нужного перечня 
                {
                    if (e.KeyChar != LabelTextTuped.Text[count])            //Если сравнивываемый символ не равен символу в 
                    {                                                       //исходной строке , то счетчик ошибок увеличивае-
                        Mistakes++;                                         //ся , последний введеный символ выделяется и
                        richTextBoxTuped.Select(count, 1);                  //закрашивается красным цветом
                        richTextBoxTuped.SelectionColor = Color.Red;
                    }
                    else                                                    //Если символ равен символу исходной строки
                    {                                                       //он выделяется и окрашивается черным(если до
                        richTextBoxTuped.Select(count, 1);                  // был поставлен красный цвет
                        richTextBoxTuped.SelectionColor = Color.Black;
                    }
                        if (count < TotalSymbols-1)                         //Если счетчик ниже запредельного значения 
                              count += 1;                                   //Увеличение его на 1
                    }
            }
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            Start();
        }
        private void Solo2_Load(object sender, EventArgs e)
        {
            Initialization();
        }
        #endregion
    }
}
