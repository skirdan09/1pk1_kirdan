using Microsoft.Win32;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_39_02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<string> purchases;
        public MainWindow()
        {
            InitializeComponent();
            purchases = new ObservableCollection<string> { };
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string purchase = purchasesTextBox.Text;
            // добавление нового объекта
            purchases.Add(purchase);
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                DefaultExt = ".txt",
                Title = "Сохранить",
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
            };

            try
            {
                if (saveFileDialog.ShowDialog() == true)
                {
                    string fileName = saveFileDialog.FileName;
                    File.WriteAllText(fileName, purchasesTextBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "ошибка",
                    MessageBoxButton.YesNoCancel,
                    MessageBoxImage.Warning);
            }
        }
    }
}