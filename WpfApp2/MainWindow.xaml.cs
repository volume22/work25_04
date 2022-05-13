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
using WpfApp2.Model;


namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_choose_Click(object sender, RoutedEventArgs e)
        {
            DateTime from=DateTime.MinValue;
            DateTime to=DateTime.MinValue;
            if (DateFrom.SelectedDate != null)
                from = (DateTime)DateFrom.SelectedDate;
            else
                MessageBox.Show("Выберите дату С");

            if (DateTo.SelectedDate != null)
                to = (DateTime)DateTo.SelectedDate;
            else
                MessageBox.Show("Выберите дату по");

            DataSettings setings = new DataSettings();

            List<newEquipment> newEquipments = setings.getListOfCars( from, to);
            if(!newEquipments.Any())
            {
                MessageBox.Show("Данных по выбранным ");
            }
            else
            {
                if ()
                {
                    
                }
            }
        }
    }
}
