﻿using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TpmRcDecoder.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Settings : Page
    {
        ApplicationDataContainer roamingSettings = null;
        const string DontShowLandingPageSetting = "DontShowLandingPage";

        public Settings()
        {
            this.InitializeComponent();

            roamingSettings = ApplicationData.Current.RoamingSettings;

            if (roamingSettings.Values[DontShowLandingPageSetting] != null &&
                roamingSettings.Values[DontShowLandingPageSetting].Equals(true.ToString()))
            {
                DontShowLandingPage.IsChecked = true;
            }
            else
            {
                DontShowLandingPage.IsChecked = false;
            }
        }

        private void DontShowLandingPage_Checked(object sender, RoutedEventArgs e)
        {
            roamingSettings.Values[DontShowLandingPageSetting] = DontShowLandingPage.IsChecked.ToString();
        }
    }
}
