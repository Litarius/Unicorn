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

namespace Unicorn.View
{
    /// <summary>
    /// Interaction logic for PersonalChatWindow.xaml
    /// </summary>
    public partial class PersonalChatWindow : Window
    {
        public PersonalChatWindow()
        {
            InitializeComponent();
        }

        private void Minimaze_OnClick(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
