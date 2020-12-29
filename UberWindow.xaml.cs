using System;
using System.Collections.Generic;
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
        public UberWindow()
        {
            InitializeComponent();
            DataContext = this;
        }
        
        private bool IsShift { get; set; } 

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

        private void PressedBTN(object sender, KeyEventArgs e)
        {
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
            if (e.Key == Key.LeftShift || e.Key == Key.RightShift)
            {
                btn_a_umlaut.Content = "ä";
                btn_u_umlaut.Content = "ü";
                btn_o_umlaut.Content = "ö";
                btn_escet.Content = "ß";
                IsShift = false;
            }
        }
    }
}
