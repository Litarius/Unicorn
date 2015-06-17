using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.TextFormatting;

namespace Unicorn.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Maximize_OnClick(object sender, RoutedEventArgs e)
        {
            if (WindowState != WindowState.Maximized)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                WindowState = WindowState.Normal;
            }

        }

        private void Minimaze_OnClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void SendMessage(object sender, RoutedEventArgs e)
        {
            MainBox.Text += string.Format("[{0}] Пользователь 2: {1}", DateTime.Now, Msg.Text);
        }
    }
}
