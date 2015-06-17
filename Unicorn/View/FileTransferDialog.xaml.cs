using System.Windows;

namespace Unicorn.View
{
    /// <summary>
    /// Interaction logic for FileTransferDialog.xaml
    /// </summary>
    public partial class FileTransferDialog : Window
    {
        public FileTransferDialog()
        {
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
