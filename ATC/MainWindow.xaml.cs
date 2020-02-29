using ATC.Models.Handlers;
using ATC.Views.ClearenceDelivery;
using System;
using System.IO;
using System.Windows;
using System.Xml;

namespace ATC
{
    public partial class MainWindow : Window
    {
        const string configExtension = ".xml";

        public MainWindow()
        {
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            InitializeComponent();
        }

        void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            LoadAirportConfig(airportIcaoLbl.Text);
            ClearenceDeliveryWindow gameWindow = new ClearenceDeliveryWindow();
            gameWindow.Show();
            Close();
        }

        void LoadAirportConfig(string airportIcao)
        {
            XmlDocument config = new XmlDocument();
            var configFilename = airportIcao + configExtension;
            var airportConfigPath = Path.Combine(ConstantPaths.configsPath, "Airports", configFilename);
            try
            {
                config.Load(airportConfigPath);
                ParseAirportConfig(config);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception occured: + {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        void ParseAirportConfig(XmlDocument config)
        {
            AirportConfig.AirportName = config.GetElementsByTagName("AirportName")[0].InnerText;
            AirportConfig.AirportIcao = config.GetElementsByTagName("AirportIcao")[0].InnerText;
            foreach (XmlNode runway in config.GetElementsByTagName("Runway"))
            {
                var name = runway.ChildNodes[0].InnerText;
                var heading = int.Parse(runway.ChildNodes[1].InnerText);
                var length = int.Parse(runway.ChildNodes[2].InnerText);
                var width = int.Parse(runway.ChildNodes[3].InnerText);

                AirportConfig.Runways.Add(new Runway(name, heading, length, width));
            }
            foreach (XmlNode runway in config.GetElementsByTagName("Frequency"))
            {
                var name = runway.ChildNodes[0].InnerText;
                var shortName = runway.ChildNodes[1].InnerText;
                var value = decimal.Parse(runway.ChildNodes[2].InnerText);

                AirportConfig.Frequencies.Add(new Frequency(name, shortName, value));
            }
            foreach (XmlNode runway in config.GetElementsByTagName("Airline"))
            {
                var name = runway.ChildNodes[0].InnerText;
                var icao = runway.ChildNodes[1].InnerText;
                var iata = runway.ChildNodes[2].InnerText;
                var callsign = runway.ChildNodes[3].InnerText;

                AirportConfig.Airlines.Add(new Airline(name, icao, iata, callsign));
            }
        }
    }
}