using System.Windows.Controls;

namespace BarakaTool.Pages
{
    public partial class SupportPage : Page
    {
        public SupportPage()
        {
            InitializeComponent();
        }

        private void WhatsAppButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            // Open WhatsApp with pre-filled message
            string phoneNumber = "255782700859"; // Tanzania country code
            string message = "Hello BARAKA TOOL Support, I need assistance.";
            
            // WhatsApp URL format
            string whatsappUrl = $"https://wa.me/{phoneNumber}/?text={System.Uri.EscapeDataString(message)}";
            
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = whatsappUrl,
                    UseShellExecute = true
                });
            }
            catch
            {
                System.Windows.MessageBox.Show("Could not open WhatsApp. Please contact: 0782700859", "Support Contact");
            }
        }
    }
}
