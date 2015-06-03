using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight.Messaging;
using Unicorn.Messages;

namespace Unicorn.View
{
    /// <summary>
    /// Interaction logic for StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
            Messenger.Default.Register<StartMessage>(true, CloseWindow);
        }

        private void CloseWindow(StartMessage obj)
        {
            if (obj != null)
            {
                MainWindow a = new MainWindow();
                a.Show();
                Close();
            }
        }

        private void UIElement_OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
