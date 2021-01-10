using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для UberWindow.xaml
    /// </summary>
    public partial class UberWindow : Window
    {

        private int id; // Рандомный айдишник, который генерируется для выбора случайной пары слов из словаря words
        private string[,] words = {
                { " Client", "Der Kunde"},
                { " New", "Die Nachricht"},
                { " To like smth", "Gefallen"},
                { " Public", "Gemeinsam"},
                { " Waiter", "Der Kellner"},
                { " Bag (package)", "Die Tüte"},
                { " Coat", "Der Mantel"},
                { " To show", "Zeigen"},
                { " To belong", "Empfangen"},
                { " Different", "Verschieden"},
                { " To tell", "Erzählen"},
                { " Candle", "Die Kerze"},
                { " Special", "Speziell"},
                { " Plate", "Der Teller"},
                { " Notebook (paper)", "Das Heft"},
                { " Notebook (paper)", "Das Heft"}
            };

        // init
        public UberWindow()
        {
            InitializeComponent();
            DataContext = this;
            id = randomId();
            englishInput.Text = words[id, 0];
        }
        
        // Фун-ия randomId в возвращает случайное значение от 0 до 16.
        private int randomId() 
        {
            Random rnd = new Random();
            return rnd.Next(0, 16);
        }

        // Булевская переменная, которая хранит в себе 0/1 в зависимости от того, нажат ли шифт или нет
        private bool IsShift { get; set; }

        // Функции OnAUmlautClick, OnOUmlautClick, OnUUmlautClick, OnEscetClick при нажатии добавляют в строку букву алфавита
        private void OnAUmlautClick(object sender, RoutedEventArgs e)
        {
            if (IsShift)
            {
                userInput.Text += "Ä";
            } else {
                userInput.Text += "ä";
            }
            
        }
        private void OnOUmlautClick(object sender, RoutedEventArgs e)
        {
            if (IsShift)
            {
                userInput.Text += "Ö";
            }
            else
            {
                userInput.Text += "ö";
            }
        }
        private void OnUUmlautClick(object sender, RoutedEventArgs e)
        {
            if (IsShift)
            {
                userInput.Text += "Ü";
            }
            else
            {
                userInput.Text += "ü";
            }
        }
        private void OnEscetClick(object sender, RoutedEventArgs e)
        {
            if (IsShift)
            {
                userInput.Text += "ẞ";
            }
            else
            {
                userInput.Text += "ß";
            }
        }

        // Функции PressedBTN и ReleasedBTN отвечают за нажатие кнопок на клавиатуре
        private void PressedBTN(object sender, KeyEventArgs e)
        {
            // Проверка слово по клавише Enter
            if (e.Key == Key.Enter)
            {
                SubmitProcess();
            }

            // Увеличение регистра букв как текста на кнопках
            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
                btn_a_umlaut.Content = "Ä";
                btn_u_umlaut.Content = "Ü";
                btn_o_umlaut.Content = "Ö";
                btn_escet.Content = "ẞ";
                IsShift = true;
            }
        }
        private void ReleasedBTN(object sender, KeyEventArgs e)
        {
            // Уменьшение регистра букв как текста на кнопках
            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
                btn_a_umlaut.Content = "ä";
                btn_u_umlaut.Content = "ü";
                btn_o_umlaut.Content = "ö";
                btn_escet.Content = "ß";
                IsShift = false;
            }
        }

        // Функции SubmitWord и OnEnterPressed вызывают функцию SubmitProcess
        private void SubmitWord(object sender, RoutedEventArgs e)
        {
            SubmitProcess();
        }

        // Функция SubmitProcess вызывает проверку слова со словарём
        private void SubmitProcess()
        {
            string originalTranslation, userTranslation;
            originalTranslation = words[id, 1];
            userTranslation = userInput.Text;

            if (originalTranslation == userTranslation)
            {
                id = randomId();
                englishInput.Text = words[id, 0];
                userInput.Clear();
            }
            else
            {
                userInput.Text = "Bruh.";
            }
        }

    }
}
