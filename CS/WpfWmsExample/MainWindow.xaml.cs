using System.Windows;
using DevExpress.Xpf.Map;

namespace WpfWmsExample {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }
        private void OnResponseCapabilities(object sender, CapabilitiesRespondedEventArgs e) {
            listBox.ItemsSource = e.Layers;
        }
    }
}
