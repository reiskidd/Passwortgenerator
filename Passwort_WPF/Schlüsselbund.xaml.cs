using Passwortgenerator;
using System.Windows;
using System.Security.Cryptography;
using System.Text;

namespace Passwort_WPF
{
    /// <summary>
    /// Interaktionslogik für Schlüsselbund.xaml
    /// </summary>
    public partial class Schlüsselbund : Window
    {
        public PasswörterListe PasswörterListe { get; set; }
        public SavePassword SavePassword { get; set; }

        public Schlüsselbund()
        {
            InitializeComponent();
        }

        private void MasterPassButton_Click(object sender, RoutedEventArgs e)
        {
            var passwordText = PasswordEingabe.Password;

            SHA256 hashInstance = SHA256.Create();
            byte[] buffer = Encoding.UTF8.GetBytes(passwordText);
            byte[] hashBuffer = hashInstance.ComputeHash(buffer);
            StringBuilder builder = new StringBuilder();
            foreach (var binary in hashBuffer)
            {
                builder.Append(binary.ToString("x2"));
            }
            string hashedPassword = builder.ToString();

            if (hashedPassword == "33c5ebbb01d608c254b3b12413bdb03e46c12797e591770ccf20f5e2819929b2")
            {
                PasswörterListe = new PasswörterListe();
                PasswörterListe.Show();
            }
            else
            {
                Info.Visibility = Visibility.Visible;
            }

            

            string[] lines = SavePassword.FileOutput();
            int arrayLength = lines.Length;

            for (int i = 0; i < arrayLength; i++)
            {
                if (PasswörterListe.TextBoxes[i].Text == string.Empty)
                {
                    PasswörterListe.TextBoxes[i].Text = lines[i];
                }
            }

            
            
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            PasswordEingabe.Visibility = Visibility.Hidden;
            PasswordTextBox.Text = PasswordEingabe.Password;
            PasswordTextBox.Focus();
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            PasswordEingabe.Visibility = Visibility.Visible;
            PasswordEingabe.Focus();
            PasswordEingabe.Password = PasswordTextBox.Text;
        }
    }
}