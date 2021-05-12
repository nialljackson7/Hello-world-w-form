using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Forms;

namespace WpfApp2
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string Name = this.inputbox.Text; // to get the text from the textbox and set it to a variable 
            System.Windows.MessageBox.Show($"Hello World, {Name}!");// a messagebox appear that shows the hello word and the variable
        }

   

        private void Button_Click_2(object sender, RoutedEventArgs e)// when the from button clicks
        {
            Form1 f1 = new Form1(); // create variable for the form 
            f1.ShowDialog();// show form 
        }
    }
}
