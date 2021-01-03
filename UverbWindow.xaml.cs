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
    /// Логика взаимодействия для UverbWindow.xaml
    /// </summary>
    public partial class UverbWindow : Window
    {
        TextBox lastUserInput;
        byte index;
        Dictionary<TextBox, byte> fields;
        public UverbWindow()
        {
            InitializeComponent();
            ichInput.Focus();
        }
       



        private bool IsShift { get; set; }
        

        private void OnAUmlautClick(object sender, RoutedEventArgs e)
        {
            if (IsShift)
            {
                lastUserInput.Text += "Ä";
            }
            else
            {
                lastUserInput.Text += "ä";
            }

        }
        private void OnOUmlautClick(object sender, RoutedEventArgs e)
        {
            if (IsShift)
            {
                lastUserInput.Text += "Ö";
            }
            else
            {
                lastUserInput.Text += "ö";
            }
        }
        private void OnUUmlautClick(object sender, RoutedEventArgs e)
        {
            if (IsShift)
            {
                lastUserInput.Text += "Ü";
            }
            else
            {
                lastUserInput.Text += "ü";
            }
        }
        private void OnEscetClick(object sender, RoutedEventArgs e)
        {
            if (IsShift)
            {
                lastUserInput.Text += "ẞ";
            }
            else
            {
                lastUserInput.Text += "ß";
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

        private void OnUserClick(object sender, MouseButtonEventArgs e)
        {
        }
    }
}
