using ATC.Models.Handlers;
using ATC.Models.Simulation;
using ATC.Models.Traffic;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows;

namespace ATC.Views.ClearenceDelivery
{
    /// <summary>
    /// Interaction logic for ClearenceDeliveryWindow.xaml
    /// </summary>
    public partial class ClearenceDeliveryWindow : Window
    {
        public TrafficSim simulation;
        public List<ITraffic> trafficsList = new List<ITraffic>();

        public ClearenceDeliveryWindow()
        {
            InitializeComponent();
            simulation = new TrafficSim();
            Title = $"{AirportConfig.AirportIcao} - Clearence";
            airportIcaoLbl.Content = $"Airport: {AirportConfig.AirportIcao}";
            controllerPositionLbl.Content = $"Position: Clearence";
            frequency1Lbl.Content = $"{AirportConfig.AirportIcao} {AirportConfig.Frequencies[0].ShortName}:";
            frequency2Lbl.Content = $"{AirportConfig.AirportIcao} {AirportConfig.Frequencies[1].ShortName}:";
            frequency3Lbl.Content = $"{AirportConfig.AirportIcao} {AirportConfig.Frequencies[2].ShortName}:";
            frequency4Lbl.Content = $"{AirportConfig.AirportIcao} {AirportConfig.Frequencies[3].ShortName}:";
            frequency5Lbl.Content = $"{AirportConfig.AirportIcao} {AirportConfig.Frequencies[4].ShortName}:";
            frequency6Lbl.Content = $"{AirportConfig.AirportIcao} {AirportConfig.Frequencies[5].ShortName}:";
            frequency1ValueLbl.Content = $"{AirportConfig.Frequencies[0].Value}";
            frequency2ValueLbl.Content = $"{AirportConfig.Frequencies[1].Value}";
            frequency3ValueLbl.Content = $"{AirportConfig.Frequencies[2].Value}";
            frequency4ValueLbl.Content = $"{AirportConfig.Frequencies[3].Value}";
            frequency5ValueLbl.Content = $"{AirportConfig.Frequencies[4].Value}";
            frequency6ValueLbl.Content = $"{AirportConfig.Frequencies[5].Value}";

            simulation.Run();

            var timer = new Timer((e) =>
            {
                trafficsList = simulation.trafficList;
            }, null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
        }

        void Exit_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        void HomePage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}