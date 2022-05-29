using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace MathProblemTools
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CalculatorPage : Page
    {
        private bool calculateClicked = false;
        public CalculatorPage()
        {
            this.InitializeComponent();
        }

        private void Write(object sender, RoutedEventArgs e)
        {
            if (calculateClicked)
            {
                Numbers.Text = "";
            }
            calculateClicked = false;

            Button b = (Button)sender;

            if (
                (string)b.Content == "x"
                || (string)b.Content == "-"
                || (string)b.Content == "÷"
                || (string)b.Content == "+"
            )
            {
                Numbers.Text += " " + b.Content + " ";
            }
            else
                Numbers.Text += b.Content;
        }

        private void Calculate(object sender, RoutedEventArgs e)
        {
            calculateClicked = true;

            if (Numbers.Text.Contains('x'))
            {
                string[] s = Numbers.Text.Replace(" ", "").Split("x");
                Numbers.Text = (int.Parse(s[0]) * int.Parse(s[1])).ToString();
            }
            else if (Numbers.Text.Contains('+'))
            {
                string[] s = Numbers.Text.Replace(" ", "").Split("+");
                Numbers.Text = (int.Parse(s[0]) + int.Parse(s[1])).ToString();
            }
            else if (Numbers.Text.Contains('÷'))
            {
                string[] s = Numbers.Text.Replace(" ", "").Split("÷");
                Numbers.Text = (int.Parse(s[0]) / int.Parse(s[1])).ToString();
            }
            else if (Numbers.Text.Contains('-'))
            {
                string[] s = Numbers.Text.Replace(" ", "").Split("-");
                Numbers.Text = (int.Parse(s[0]) - int.Parse(s[1])).ToString();
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e) { }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            Numbers.Text = "";
        }
    }
}
