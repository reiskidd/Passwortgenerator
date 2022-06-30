using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Passwort_WPF
{
    /// <summary>
    /// Interaktionslogik für PasswörterListe.xaml
    /// </summary>
    public partial class PasswörterListe : Window
    {
        public List<TextBox> TextBoxes { get; set; } = new List<TextBox>();
        public PasswörterListe()
        {
            InitializeComponent();
            TextBoxes.Add(passwort1);
            TextBoxes.Add(passwort2);
            TextBoxes.Add(passwort3);
            TextBoxes.Add(passwort4);
            TextBoxes.Add(passwort5);
            TextBoxes.Add(passwort6);
            TextBoxes.Add(passwort7);
            TextBoxes.Add(passwort8);
            TextBoxes.Add(passwort9);
            TextBoxes.Add(passwort10);
            TextBoxes.Add(passwort11);
            TextBoxes.Add(passwort12);
            TextBoxes.Add(passwort13);
            TextBoxes.Add(passwort14);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;




            switch (button.Tag)
            {
                case "1":
                    Clipboard.SetText(passwort1.Text);
                    break;

                case "2":
                    Clipboard.SetText(passwort2.Text);
                    break;

                case "3":
                    Clipboard.SetText(passwort3.Text);
                    break;

                case "4":
                    Clipboard.SetText(passwort4.Text);
                    break;

                case "5":
                    Clipboard.SetText(passwort5.Text);
                    break;

                case "6":
                    Clipboard.SetText(passwort6.Text);
                    break;

                case "7":
                    Clipboard.SetText(passwort7.Text);
                    break;

                case "8":
                    Clipboard.SetText(passwort8.Text);
                    break;

                case "9":
                    Clipboard.SetText(passwort9.Text);
                    break;

                case "10":
                    Clipboard.SetText(passwort10.Text);
                    break;

                case "11":
                    Clipboard.SetText(passwort11.Text);
                    break;

                case "12":
                    Clipboard.SetText(passwort12.Text);
                    break;

                case "13":
                    Clipboard.SetText(passwort13.Text);
                    break;

                case "14":
                    Clipboard.SetText(passwort14.Text);
                    break;
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
    }
}