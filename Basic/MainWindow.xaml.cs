using System.Windows;
using System.Windows.Controls;

namespace Basic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }



        private void Applybutton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This Description is ", this.DescriptionText.Text);
        }

        private void Resetbutton_Click(object sender, RoutedEventArgs e)
        {
            this.WeldCheckbox.IsChecked = this.LatheCheckbox.IsChecked = this.AssemblyCheckbox.IsChecked = this.DrillCheckbox.IsChecked = this.PlasmaCheckbox.IsChecked = this.FoldCheckbox.IsChecked = this.LaserCheckbox.IsChecked = this.RollCheckbox.IsChecked = this.PurchaseCheckbox.IsChecked = this.SawCheckbox.IsChecked = false;
        }

        private void Checkbox_Checked(object sender, RoutedEventArgs e)
        {
            this.LengthText.Text += ((CheckBox)sender).Content;
        }

        private void FinishDropdown_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (this.NoteText == null)
            {
                return;
            }
            var combo = (ComboBox)sender;
            var value = (ComboBoxItem)combo.SelectedValue;
            this.NoteText.Text = (string)value.Content;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FinishDropdown_SelectionChanged(this.FinishDropdown, null);
        }

        private void SupplierNametext_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.MassText.Text = this.SupplierNametext.Text;
        }
    }
}
