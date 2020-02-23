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

namespace ATC.Views.ClearenceDelivery
{
    /// <summary>
    /// Interaction logic for ClearenceDeliveryWindow.xaml
    /// </summary>
    public partial class ClearenceDeliveryWindow : Window
    {
        public ClearenceDeliveryWindow(string airportIcao, string controllerPosition)
        {
            InitializeComponent();
            Title = $"{airportIcao} - {controllerPosition}";
            airportIcaoLbl.Content = $"Airport: {airportIcao}";
            controllerPositionLbl.Content = $"Position: {controllerPosition}";
            frequencyAtisLbl.Content = $"{airportIcao} ATIS:";
            frequencyDelLbl.Content = $"{airportIcao} DEL:";
            frequencyGndLbl.Content = $"{airportIcao} GND:";
            frequencyTwrLbl.Content = $"{airportIcao} TWR:";
            frequencyDirLbl.Content = $"{airportIcao} DIR:";
            frequencyAppLbl.Content = $"{airportIcao} APP:";
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }

        private void HomePage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
