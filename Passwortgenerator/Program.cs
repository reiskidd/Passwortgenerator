using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Windows;

namespace Passwortgenerator
{
    public class Program
    {
        [STAThread]

        public static void Main(string[] args)
        {
            string[] myPassArray = new string[19];

            Ausgabe(myPassArray);
        }
        private void OnTimedEvent(object sender, ElapsedEventArgs e)
        {

            Clipboard.SetText("******");
        }

        public static List<string> Ausgabe(string[] myPassArray)
        {
            Random rdm = new Random();

            for (int i = 0; i < 19; i++)
            {
                int ziffer;

                ziffer = rdm.Next(1, 18);

                if (i == 4 || i == 9 || i == 14)
                {
                    myPassArray[i] = "-";
                }
                else if (ziffer == 1)
                {
                    myPassArray[i] = "A";
                }
                else if (ziffer == 2)
                {
                    myPassArray[i] = "B";
                }
                else if (ziffer == 3)
                {
                    myPassArray[i] = "C";
                }
                else if (ziffer == 4)
                {
                    myPassArray[i] = "D";
                }
                else if (ziffer == 5)
                {
                    myPassArray[i] = "E";
                }
                else if (ziffer == 6)
                {
                    myPassArray[i] = "F";
                }
                else if (ziffer == 7)
                {
                    myPassArray[i] = "G";
                }
                else if (ziffer == 8)
                {
                    myPassArray[i] = "H";
                }
                else if (ziffer == 9)
                {
                    myPassArray[i] = "I";
                }
                else if (ziffer == 10)
                {
                    myPassArray[i] = "J";
                }
                else if (ziffer == 11)
                {
                    myPassArray[i] = "K";
                }
                else if (ziffer == 12)
                {
                    myPassArray[i] = "L";
                }
                else if (ziffer == 13)
                {
                    myPassArray[i] = "M";
                }
                else if (ziffer == 14)
                {
                    myPassArray[i] = ziffer.ToString();
                }
                else if (ziffer == 15)
                {
                    myPassArray[i] = "%";
                }
                else if (ziffer == 16)
                {
                    myPassArray[i] = "@";
                }
                else if (ziffer == 17)
                {
                    myPassArray[i] = "?";
                }
                else if (ziffer == 18)
                {
                    myPassArray[i] = "!";
                }
            }
            List<string> PassList1 = new List<string>();

            if (myPassArray.Count() == 19)
            {
                foreach (string item in myPassArray)
                {
                    PassList1.Add(item);
                }
            }

            return PassList1;
        }

        public static List<string> Ausgabe2()
        {
            Random rdm = new Random();

            string[] myPassArray2 = new string[19];

            for (int i = 0; i < 19; i++)
            {
                int ziffer;

                ziffer = rdm.Next(1, 18);

                if (i == 4 || i == 9 || i == 14)
                {
                    myPassArray2[i] = "-";
                }
                else if (ziffer == 1)
                {
                    myPassArray2[i] = "Q";
                }
                else if (ziffer == 2)
                {
                    myPassArray2[i] = "W";
                }
                else if (ziffer == 3)
                {
                    myPassArray2[i] = "E";
                }
                else if (ziffer == 4)
                {
                    myPassArray2[i] = "R";
                }
                else if (ziffer == 5)
                {
                    myPassArray2[i] = "V";
                }
                else if (ziffer == 6)
                {
                    myPassArray2[i] = "Ä";
                }
                else if (ziffer == 7)
                {
                    myPassArray2[i] = "H";
                }
                else if (ziffer == 8)
                {
                    myPassArray2[i] = "J";
                }
                else if (ziffer == 9)
                {
                    myPassArray2[i] = "S";
                }
                else if (ziffer == 10)
                {
                    myPassArray2[i] = "Ü";
                }
                else if (ziffer == 11)
                {
                    myPassArray2[i] = "K";
                }
                else if (ziffer == 12)
                {
                    myPassArray2[i] = "F";
                }
                else if (ziffer == 13)
                {
                    myPassArray2[i] = "M";
                }
                else if (ziffer == 14)
                {
                    myPassArray2[i] = ziffer.ToString();
                }
                else if (ziffer == 15)
                {
                    myPassArray2[i] = "%";
                }
                else if (ziffer == 16)
                {
                    myPassArray2[i] = "@";
                }
                else if (ziffer == 17)
                {
                    myPassArray2[i] = "?";
                }
                else if (ziffer == 18)
                {
                    myPassArray2[i] = "C";
                }
            }

            List<string> PassList2 = new List<string>();

            if (myPassArray2.Count() == 19)
            {
                foreach (string item in myPassArray2)
                {
                    PassList2.Add(item);
                }
            }

            return PassList2;
        }

        public static List<string> Ausgabe3()
        {
            Random random = new Random();

            string[] myPassArray3 = new string[19];

            for (int i = 0; i < 19; i++)
            {
                int ziffer;

                ziffer = random.Next(1, 18);

                if (i == 4 || i == 9 || i == 14)
                {
                    myPassArray3[i] = "-";
                }
                else if (ziffer == 1)
                {
                    myPassArray3[i] = "Z";
                }
                else if (ziffer == 2)
                {
                    myPassArray3[i] = "Y";
                }
                else if (ziffer == 3)
                {
                    myPassArray3[i] = "X";
                }
                else if (ziffer == 4)
                {
                    myPassArray3[i] = "C";
                }
                else if (ziffer == 5)
                {
                    myPassArray3[i] = "R";
                }
                else if (ziffer == 6)
                {
                    myPassArray3[i] = "T";
                }
                else if (ziffer == 7)
                {
                    myPassArray3[i] = "U";
                }
                else if (ziffer == 8)
                {
                    myPassArray3[i] = "V";
                }
                else if (ziffer == 9)
                {
                    myPassArray3[i] = "I";
                }
                else if (ziffer == 10)
                {
                    myPassArray3[i] = "F";
                }
                else if (ziffer == 11)
                {
                    myPassArray3[i] = "Ö";
                }
                else if (ziffer == 12)
                {
                    myPassArray3[i] = "L";
                }
                else if (ziffer == 13)
                {
                    myPassArray3[i] = "M";
                }
                else if (ziffer == 14)
                {
                    myPassArray3[i] = ziffer.ToString();
                }
                else if (ziffer == 15)
                {
                    myPassArray3[i] = "%";
                }
                else if (ziffer == 16)
                {
                    myPassArray3[i] = "K";
                }
                else if (ziffer == 17)
                {
                    myPassArray3[i] = "?";
                }
                else if (ziffer == 18)
                {
                    myPassArray3[i] = "!";
                }
            }            
            List<string> PassList3 = new List<string>();

            if (myPassArray3.Count() == 19)
            {
                foreach (string item in myPassArray3)
                {
                    PassList3.Add(item);
                }
            }

            return PassList3;
        }
    }
}