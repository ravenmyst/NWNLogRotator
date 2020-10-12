﻿using NWNLogRotator.Classes;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace NWNLogRotator
{
    /// <summary>
    /// Interaction logic for ExportConfiguration.xaml
    /// </summary>
    public partial class ExportConfiguration : Window
    {
        public Settings _settings;
        public bool _closed = true;
        public ExportConfiguration(Settings __settings)
        {
            InitializeComponent();
            SetupApplication(Settings_Set(__settings));
        }
        public Settings Settings_Get()
        {
            CurrentSettings_Get();
            return _settings;
        }
        public Settings Settings_Set(Settings __settings)
        {
            _settings = __settings;
            return _settings;
        }

        public bool Closed_Get()
        {
            return _closed;
        }
        private void SetupApplication(Settings _settings)
        {
            if (_settings.UseTheme == "light")
            {
                ActivateLightTheme();
            }
            else if (_settings.UseTheme == "dark")
            {
                ActivateDarkTheme();
            }
            LoadSettings_Handler(_settings);
        }

        public void ActivateDarkTheme()
        {
            LinearGradientBrush myBrush = new LinearGradientBrush();
            myBrush.GradientStops.Add(new GradientStop(Colors.Black, 0.0));
            myBrush.GradientStops.Add(new GradientStop(Colors.Purple, 0.5));
            myBrush.GradientStops.Add(new GradientStop(Colors.Black, 1.0));

            Grid.Background = myBrush;

            ServerNameTextBox.Background = Brushes.Black;
            ServerNameColorTextBox.Background = Brushes.Black;
            MyCharactersTextBox.Background = Brushes.Black;
            MyColorTextBox.Background = Brushes.Black;
            FontNameTextBox.Background = Brushes.Black;
            ActorColorTextBox.Background = Brushes.Black;
            PartyColorTextBox.Background = Brushes.Black;
            EmoteColorTextBox.Background = Brushes.Black;
            TimestampColorTextBox.Background = Brushes.Black;
            ShoutColorTextBox.Background = Brushes.Black;
            TellColorTextBox.Background = Brushes.Black;
            WhisperColorTextBox.Background = Brushes.Black;
            BackgroundColorTextBox.Background = Brushes.Black;
            DefaultColorTextBox.Background = Brushes.Black;

            ServerNameTextBoxLabel.Foreground = new SolidColorBrush(Colors.White);
            ServerNameColorTextBoxLabel.Foreground = new SolidColorBrush(Colors.White);
            ServerNameTextBox.Foreground = new SolidColorBrush(Colors.White);
            ServerNameColorTextBox.Foreground = new SolidColorBrush(Colors.White);
            ServerNameLabelTwo.Foreground = new SolidColorBrush(Colors.White);
            ServerNameColorLabelTwo.Foreground = new SolidColorBrush(Colors.White);
            MyCharactersTextBox.Foreground = new SolidColorBrush(Colors.White);
            MyCharactersTextBoxLabel.Foreground = new SolidColorBrush(Colors.White);
            MyColorTextBoxLabel.Foreground = new SolidColorBrush(Colors.White);
            FontNameTextBox.Foreground = new SolidColorBrush(Colors.White);
            FontNameTextBoxLabel.Foreground = new SolidColorBrush(Colors.White);
            ActorColorTextBox.Foreground = new SolidColorBrush(Colors.White);
            ActorColorTextBoxLabel.Foreground = new SolidColorBrush(Colors.White);
            PartyColorTextBox.Foreground = new SolidColorBrush(Colors.White);
            PartyColorTextBoxLabel.Foreground = new SolidColorBrush(Colors.White);
            EmoteColorTextBox.Foreground = new SolidColorBrush(Colors.White);
            EmoteColorTextBoxLabel.Foreground = new SolidColorBrush(Colors.White);
            TimestampColorTextBox.Foreground = new SolidColorBrush(Colors.White);
            TimestampColorTextBoxLabel.Foreground = new SolidColorBrush(Colors.White);
            ShoutColorTextBox.Foreground = new SolidColorBrush(Colors.White);
            ShoutColorTextBoxLabel.Foreground = new SolidColorBrush(Colors.White);
            TellColorTextBox.Foreground = new SolidColorBrush(Colors.White);
            TellColorTextBoxLabel.Foreground = new SolidColorBrush(Colors.White);
            WhisperColorTextBoxLabel.Foreground = new SolidColorBrush(Colors.White);
            WhisperColorTextBox.Foreground = new SolidColorBrush(Colors.White);
            BackgroundColorTextBoxLabel.Foreground = new SolidColorBrush(Colors.White);
            DefaultColorTextBoxLabel.Foreground = new SolidColorBrush(Colors.White);
            DefaultColorTextBox.Foreground = new SolidColorBrush(Colors.White);
            ResetSettingsButton.Background = Brushes.Black;
            ResetSettingsButton.Foreground = new SolidColorBrush(Colors.White);
            SaveSettingsButton.Background = Brushes.Black;
            SaveSettingsButton.Foreground = new SolidColorBrush(Colors.White);
        }

        public void ActivateLightTheme()
        {
            ServerNameTextBox.Background = Brushes.White;
            ServerNameColorTextBox.Background = Brushes.White;
            ServerNameTextBox.Foreground = new SolidColorBrush(Colors.Black);
            ServerNameColorTextBox.Foreground = new SolidColorBrush(Colors.Black);

            ResetSettingsButton.Background = Brushes.White;
            ResetSettingsButton.Foreground = new SolidColorBrush(Colors.Black);
            SaveSettingsButton.Background = Brushes.White;
            SaveSettingsButton.Foreground = new SolidColorBrush(Colors.Black);
        }
        private void LoadSettings_Handler(Settings _settings)
        {
            ServerNameTextBox.Text = _settings.ServerName;
            ServerNameColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + _settings.ServerNameColor);
            BackgroundColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + _settings.BackgroundColor);
            TimestampColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + _settings.TimestampColor);
            DefaultColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + _settings.DefaultColor);
            ActorColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + _settings.ActorColor);
            PartyColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + _settings.PartyColor);
            EmoteColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + _settings.EmoteColor);
            ShoutColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + _settings.ShoutColor);
            TellColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + _settings.TellColor);
            WhisperColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + _settings.WhisperColor);
            MyColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + _settings.MyColor);
            MyCharactersTextBox.Text = _settings.MyCharacters;
            FontNameTextBox.Text = _settings.FontName;
        }

        private Settings CurrentSettings_Get()
        {
            string OutputDirectory = _settings.OutputDirectory;
            string PathToLog = _settings.PathToLog;
            int MinimumRowsToInteger = _settings.MinimumRowsCount;
            string ServerName = ServerNameTextBox.Text;
            string ServerNameColor = new ColorConverter().ConvertToString(ServerNameColorTextBox.SelectedColor).Substring(3);
            bool EventText = _settings.EventText;
            bool CombatText = _settings.CombatText;
            string UseTheme = _settings.UseTheme;
            bool Silent = _settings.Silent;
            bool Tray = _settings.Tray;
            bool SaveBackup = _settings.SaveBackup;
            bool Notifications = _settings.Notifications;
            string CustomEmotes = _settings.CustomEmotes;
            string FilterLines = _settings.FilterLines;
            string PathToClient = _settings.PathToClient;
            bool RunClientOnLaunch = _settings.RunClientOnLaunch;
            bool CloseOnLogGenerated = _settings.CloseOnLogGenerated;
            string ServerAddress = _settings.ServerAddress;
            string ServerPassword = _settings.ServerPassword;
            bool DM = _settings.DM;
            bool ServerMode = _settings.ServerMode;
            string BackgroundColor = new ColorConverter().ConvertToString(BackgroundColorTextBox.SelectedColor).Substring(3);
            string TimestampColor = new ColorConverter().ConvertToString(TimestampColorTextBox.SelectedColor).Substring(3);
            string DefaultColor = new ColorConverter().ConvertToString(DefaultColorTextBox.SelectedColor).Substring(3);
            string ActorColor = new ColorConverter().ConvertToString(ActorColorTextBox.SelectedColor).Substring(3);
            string PartyColor = new ColorConverter().ConvertToString(PartyColorTextBox.SelectedColor).Substring(3);
            string EmoteColor = new ColorConverter().ConvertToString(EmoteColorTextBox.SelectedColor).Substring(3);
            string ShoutColor = new ColorConverter().ConvertToString(ShoutColorTextBox.SelectedColor).Substring(3);
            string TellColor = new ColorConverter().ConvertToString(TellColorTextBox.SelectedColor).Substring(3);
            string WhisperColor = new ColorConverter().ConvertToString(WhisperColorTextBox.SelectedColor).Substring(3);
            string MyColor = new ColorConverter().ConvertToString(MyColorTextBox.SelectedColor).Substring(3);
            string MyCharacters = MyCharactersTextBox.Text;
            string FontName = FontNameTextBox.Text;

            _settings = new Settings(   OutputDirectory,
                                        PathToLog,
                                        MinimumRowsToInteger,
                                        ServerName,
                                        ServerNameColor,
                                        EventText,
                                        CombatText,
                                        UseTheme,
                                        Silent,
                                        Tray,
                                        SaveBackup,
                                        Notifications,
                                        CustomEmotes,
                                        FilterLines,
                                        PathToClient,
                                        RunClientOnLaunch,
                                        CloseOnLogGenerated,
                                        ServerAddress,
                                        ServerPassword,
                                        DM,
                                        ServerMode,
                                        BackgroundColor,
                                        TimestampColor,
                                        DefaultColor,
                                        ActorColor,
                                        PartyColor,
                                        EmoteColor,
                                        ShoutColor,
                                        TellColor,
                                        WhisperColor,
                                        MyColor,
                                        MyCharacters,
                                        FontName
                                   );
            return _settings;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _settings = CurrentSettings_Get();
            if( _settings.BackgroundColor.Length == 6 &&
               _settings.TimestampColor.Length == 6 &&
               _settings.DefaultColor.Length == 6 &&
               _settings.ActorColor.Length == 6 &&
               _settings.PartyColor.Length == 6 &&
               _settings.EmoteColor.Length == 6 &&
               _settings.ShoutColor.Length == 6 &&
               _settings.TellColor.Length == 6 &&
               _settings.WhisperColor.Length == 6
              )
            {
                _closed = false;
                this.Close();
            } 
            else
            {
                MessageBoxResult _messageBoxResult = MessageBox.Show("Please make sure every color in the Export Options is six characters long.",
                            "Invalid Export Color!",
                            MessageBoxButton.OK,
                            MessageBoxImage.Warning);
            }
            
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            var __settings = new Settings();
            ServerNameColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + __settings.ServerNameColor);
            BackgroundColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + __settings.BackgroundColor);
            TimestampColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + __settings.TimestampColor);
            DefaultColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + __settings.DefaultColor);
            ActorColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + __settings.ActorColor);
            PartyColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + __settings.PartyColor);
            EmoteColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + __settings.EmoteColor);
            ShoutColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + __settings.ShoutColor);
            TellColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + __settings.TellColor);
            WhisperColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + __settings.WhisperColor);
            MyColorTextBox.SelectedColor = (Color)ColorConverter.ConvertFromString("#" + __settings.MyColor);
            FontNameTextBox.Text = __settings.FontName;
            __settings = null;
        }
    }
}
