using System.Windows;

namespace WpfTouchKeyboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;

            // Disables inking in the WPF application and enables us to track touch events to properly trigger the touch keyboard
            InkInputHelper.DisableWPFTabletSupport();
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            //Windows 8 API to enable touch keyboard to monitor for focus tracking in this WPF application
            InputPanelConfiguration cp = new InputPanelConfiguration();
            IInputPanelConfiguration icp = cp as IInputPanelConfiguration;
            if (icp != null)
                icp.EnableFocusTracking();
        }
    }
}
