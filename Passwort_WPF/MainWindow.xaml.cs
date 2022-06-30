using Passwortgenerator;
using System;
using System.Collections.Generic;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;
using System.IO;

namespace Passwort_WPF
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Schlüsselbund _schlüsselbund;
        public PasswörterListe PasswörterListe { get; set; }
        //public List<TextBox> TextBoxesSave { get; set; } = new List<TextBox>();
        public MainWindow()
        {
            InitializeComponent();
          //TextBoxesSave.Add(PasswörterListe.passwort1);
          //TextBoxesSave.Add(PasswörterListe.passwort2);
          //TextBoxesSave.Add(PasswörterListe.passwort3);
          //TextBoxesSave.Add(PasswörterListe.passwort4);
          //TextBoxesSave.Add(PasswörterListe.passwort5);
          //TextBoxesSave.Add(PasswörterListe.passwort6);
          //TextBoxesSave.Add(PasswörterListe.passwort7);
          //TextBoxesSave.Add(PasswörterListe.passwort8);
          //TextBoxesSave.Add(PasswörterListe.passwort9);
          //TextBoxesSave.Add(PasswörterListe.passwort10);
          //TextBoxesSave.Add(PasswörterListe.passwort11);
          //TextBoxesSave.Add(PasswörterListe.passwort12);
          //TextBoxesSave.Add(PasswörterListe.passwort13);
          //TextBoxesSave.Add(PasswörterListe.passwort14);
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (textbox1.Text.Contains("KFC"))
            {
                textbox1.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                ButtonStart.IsEnabled = false;
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (textbox2.Text.Contains("KFC"))
            {
                textbox2.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                ButtonStart.IsEnabled = false;
            }
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            if (textbox3.Text.Contains("KFC"))
            {
                textbox3.Background = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));
                ButtonStart.IsEnabled = false;
            }
        }



        private void ButtonStart_Click(object sender, RoutedEventArgs e)
        {

            string[] myPassArray = new string[19];
            

            List<string> passwordOutput = Program.Ausgabe(myPassArray);
            var passwordOne = string.Join(string.Empty, passwordOutput);
            textbox1.Text = passwordOne;
            passwordOutput.Clear();

            List<string> passwordOutputTwo = Program.Ausgabe2();
            var passwordTwo = string.Join(string.Empty, passwordOutputTwo);
            textbox2.Text = passwordTwo;
            passwordOutput.Clear();

            List<string> passwordOutputThird = Program.Ausgabe3();
            var passwordThird = string.Join(string.Empty, passwordOutputThird);
            textbox3.Text = passwordThird;
            passwordOutput.Clear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;            
            
            
            
            //Liste.passwort1.Text =  

            var savePassword = String.Empty;

            switch (button.Tag)
            {
                case "1":
                    Clipboard.SetText(textbox1.Text);
                    savePassword = textbox1.Text;
                    break;
                case "2":
                    Clipboard.SetText(textbox2.Text);
                    savePassword = textbox2.Text;
                    break;
                case "3":
                    Clipboard.SetText(textbox3.Text);
                    savePassword = textbox3.Text;
                    break;
               
            }

            if (_schlüsselbund != null && _schlüsselbund.PasswörterListe != null)
            {
                PasswörterListe Liste = _schlüsselbund.PasswörterListe;

                if (Liste.passwort1.Text == String.Empty)
                {
                    Liste.passwort1.Text = savePassword;
                    SavePassword.SaveFile(savePassword);
                    
                }
                else if (Liste.passwort2.Text == String.Empty)
                {
                    Liste.passwort2.Text = savePassword;
                    SavePassword.SaveFile(savePassword);
                }
                else if (Liste.passwort3.Text == String.Empty)
                {
                    Liste.passwort3.Text = savePassword;
                    SavePassword.SaveFile(savePassword);
                }
                else if (Liste.passwort4.Text == String.Empty)
                {
                    Liste.passwort4.Text = savePassword;
                    SavePassword.SaveFile(savePassword);
                }
                else if (Liste.passwort5.Text == String.Empty)
                {
                    Liste.passwort5.Text = savePassword;
                    SavePassword.SaveFile(savePassword);
                }
                else if (Liste.passwort6.Text == String.Empty)
                {
                    Liste.passwort6.Text = savePassword;
                    SavePassword.SaveFile(savePassword);
                }
                else if (Liste.passwort7.Text == String.Empty)
                {
                    Liste.passwort7.Text = savePassword;
                    SavePassword.SaveFile(savePassword);
                }
                else if (Liste.passwort7.Text == String.Empty)
                {
                    Liste.passwort7.Text = savePassword;
                    SavePassword.SaveFile(savePassword);
                }
                else if (Liste.passwort8.Text == String.Empty)
                {
                    Liste.passwort8.Text = savePassword;
                    SavePassword.SaveFile(savePassword);
                }
                else if (Liste.passwort9.Text == String.Empty)
                {
                    Liste.passwort9.Text = savePassword;
                    SavePassword.SaveFile(savePassword);
                }
                else if (Liste.passwort10.Text == String.Empty)
                {
                    Liste.passwort10.Text = savePassword;
                    SavePassword.SaveFile(savePassword);
                }
                else if (Liste.passwort11.Text == String.Empty)
                {
                    Liste.passwort11.Text = savePassword;
                    SavePassword.SaveFile(savePassword);
                }
                else if (Liste.passwort12.Text == String.Empty)
                {
                    Liste.passwort12.Text = savePassword;
                    SavePassword.SaveFile(savePassword);
                }
                else if (Liste.passwort13.Text == String.Empty)
                {
                    Liste.passwort13.Text = savePassword;
                    SavePassword.SaveFile(savePassword);
                }
                else if (Liste.passwort14.Text == String.Empty)
                {
                    Liste.passwort14.Text = savePassword;
                    SavePassword.SaveFile(savePassword);
                }
            }

            warning warning = new warning();
            warning.Show();

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(30);
            timer.Tick += Timer_Tick;
            timer.Start();            
        }


        void Timer_Tick(object sender, EventArgs e)
        {            
            Clipboard.SetText("******");
        }

        private void ButtonMaster_Click(object sender, RoutedEventArgs e)
        {
            _schlüsselbund = new Schlüsselbund();
            _schlüsselbund.Show();
        }


    }
}