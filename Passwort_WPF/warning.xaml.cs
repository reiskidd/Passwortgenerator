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
using System.Windows.Shapes;

namespace Passwort_WPF
{
    /// <summary>
    /// Interaktionslogik für warning.xaml
    /// </summary>
    public partial class warning : Window
    {
        public warning()
        {
            InitializeComponent();
        }

        private void Button_warning_Click(object sender, RoutedEventArgs e)
        {
            MainWindow warning = new MainWindow();
            warning.Close();
            this.Close();
        }
        
    }
}
