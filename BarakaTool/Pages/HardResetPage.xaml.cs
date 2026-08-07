using System.Windows.Controls;
using System.Windows;

namespace BarakaTool.Pages
{
    public partial class HardResetPage : Page
    {
        private string selectedBrand = "";

        public HardResetPage()
        {
            InitializeComponent();
        }

        private void SamsungHardReset_Click(object sender, RoutedEventArgs e)
        {
            SelectBrand("Samsung");
        }

        private void XiaomiHardReset_Click(object sender, RoutedEventArgs e)
        {
            SelectBrand("Xiaomi");
        }

        private void TecnoHardReset_Click(object sender, RoutedEventArgs e)
        {
            SelectBrand("Tecno");
        }

        private void InfinixHardReset_Click(object sender, RoutedEventArgs e)
        {
            SelectBrand("Infinix");
        }

        private void OppoHardReset_Click(object sender, RoutedEventArgs e)
        {
            SelectBrand("Oppo");
        }

        private void VivoHardReset_Click(object sender, RoutedEventArgs e)
        {
            SelectBrand("Vivo");
        }

        private void SelectBrand(string brand)
        {
            selectedBrand = brand;
            SelectedDeviceText.Text = $"✓ Selected: {brand}";
            
            // Enable button only if both checkboxes are checked
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            StartHardResetButton.IsEnabled = 
                !string.IsNullOrEmpty(selectedBrand) && 
                ConfirmCheckbox.IsChecked == true && 
                BackupConfirmCheckbox.IsChecked == true;
        }

        private void ConfirmCheckbox_CheckedChanged(object sender, RoutedEventArgs e)
        {
            UpdateButtonState();
        }

        private void BackupConfirmCheckbox_CheckedChanged(object sender, RoutedEventArgs e)
        {
            UpdateButtonState();
        }

        private void StartHardReset_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(selectedBrand))
            {
                MessageBox.Show("Please select a device brand first!", "Error");
                return;
            }

            // Final confirmation
            MessageBoxResult result = MessageBox.Show(
                $"FINAL WARNING!\n\n" +
                $"You are about to perform a hard reset on your {selectedBrand} device.\n\n" +
                $"ALL DATA WILL BE PERMANENTLY DELETED.\n" +
                $"This action CANNOT be undone.\n\n" +
                $"Are you absolutely sure you want to continue?",
                "Hard Reset Confirmation",
                MessageBoxButton.YesNo,
                MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                ExecuteHardReset();
            }
        }

        private void ExecuteHardReset()
        {
            // Show progress
            ProgressSection.Visibility = Visibility.Visible;
            StartHardResetButton.IsEnabled = false;

            // Simulate hard reset process
            System.Threading.Tasks.Task.Run(async () =>
            {
                int steps = 5;
                for (int i = 1; i <= steps; i++)
                {
                    string[] statuses = new string[]
                    {
                        "Initializing hard reset process...",
                        "Erasing user data...",
                        "Clearing cache and temporary files...",
                        "Resetting to factory settings...",
                        "Finalizing hard reset..."
                    };

                    Dispatcher.Invoke(() =>
                    {
                        ProgressStatusText.Text = statuses[i - 1];
                        HardResetProgressBar.Value = (i / (double)steps) * 100;
                    });

                    await System.Threading.Tasks.Task.Delay(2000); // Simulate processing
                }

                Dispatcher.Invoke(() =>
                {
                    ProgressSection.Visibility = Visibility.Collapsed;
                    MessageBox.Show(
                        $"Hard reset completed successfully!\n\n" +
                        $"Your {selectedBrand} device has been reset to factory settings.\n" +
                        $"Please set up your device as new.",
                        "Hard Reset Complete",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);

                    ResetUI();
                });
            });
        }

        private void ResetUI()
        {
            selectedBrand = "";
            SelectedDeviceText.Text = "No device selected";
            ConfirmCheckbox.IsChecked = false;
            BackupConfirmCheckbox.IsChecked = false;
            StartHardResetButton.IsEnabled = false;
            HardResetProgressBar.Value = 0;
        }
    }
}
