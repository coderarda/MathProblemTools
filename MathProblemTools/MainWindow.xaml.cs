using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using System.Linq;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MathProblemTools {
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window {
        private string selectedItemName;
        public MainWindow() {
            InitializeComponent();
            MainFrame.Navigate(typeof(CalculatorPage));
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args) {
            switch (args.InvokedItemContainer.Content) {
                case "Home":
                    if (args.InvokedItemContainer.Content.ToString() != selectedItemName) {
                        MainFrame.Navigate(typeof(CalculatorPage));
                    }
                    break;
            }
        }

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args) {
            selectedItemName = args.SelectedItemContainer.Content.ToString();
        }
    }
}
