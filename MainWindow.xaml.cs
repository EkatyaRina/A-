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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Анкета
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string DefaultNameText = "Введите имя";
        public MainWindow()
        {
            InitializeComponent();
            SetDefaultText(NameTextBox, DefaultNameText);
        }
        private void SetDefaultText(TextBox textBox, string defaultText)
        {
            textBox.Text = defaultText;
            textBox.Foreground = Brushes.Gray;
        }
        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == DefaultNameText)
            {
                textBox.Text = string.Empty;
                textBox.Foreground = Brushes.Plum;
            }
        }
        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                SetDefaultText(textBox == NameTextBox ? DefaultNameText : DefaultNameText);
            }
        }

        private void SetDefaultText(string v)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            
        }
    }
}
