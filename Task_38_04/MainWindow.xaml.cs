using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task_38_04
{
    
    public partial class MainWindow : Window
    {

        private string Surname;
        private string Name;
        private string Patronymic;
        private string Gender;
        private string Birthday;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = TextBirthday.SelectedDate;

            MessageBox.Show(selectedDate.Value.Date.ToShortDateString());
        }


        private void Add_Click(object sender, RoutedEventArgs e)
        {
            ListBox listBox = new ListBox();
            Surname = surnameTextBox.Text;
            Name = nameTextBox.Text;
            Patronymic = patronymicTextBox.Text;
            Gender = genderComboBox.Text;
            DateTime? selectedDate = TextBirthday.SelectedDate;
            string Info = $"{Surname} {Name} {Patronymic} {Gender} {selectedDate}";
            listBox.Items.Add(Info);
            MessageBox.Show("Данные добавлены");

        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            string newFile = "file.json";
            Surname = surnameTextBox.Text;
            Name = nameTextBox.Text;
            Patronymic = patronymicTextBox.Text;
            Gender = genderComboBox.Text;
            DateTime? selectedDate = TextBirthday.SelectedDate;
            string Info = $"ФИО: {Surname} {Name} {Patronymic} Пол: {Gender} Дата рождения: {selectedDate}";
            var options = new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                WriteIndented = true
            };
            string JsonSerializeFile = JsonSerializer.Serialize(Info, options);
            File.WriteAllText(newFile, JsonSerializeFile);
            MessageBox.Show("Данные сохранены");

        }
    }
}