using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LottoProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int antalRader = 0;
        bool antalDrag = false;

        int firstBox = 0, secondBox = 0, thirdBox = 0, forthBox = 0, fifthBox = 0, sixthBox = 0, seventhBox = 0;
        int fiveCorrect = 0;  // lite väl många deklarationer men det blev så ....
        int sixCorrect = 0;
        int sevenCorrect = 0;
        
        
       
        
        
        private void TextBoxFirst_TextChanged(object sender, EventArgs e)       // dessa funktionerna kollar över värdet på de inmatade lottovärderna 
        {                                                                    // jag har använt mig mycket av tryparse genom programet eftersom det strulade
            int nr = 1;                                                       // när jag körde en vanlig int.parse converter
            string Message = "";
            int inputValue = 0;


           if (Int32.TryParse(TextBoxFirst.Text, out inputValue))
            {

                Message = (checkNumber(inputValue, nr));

                if ((Message == "wrong input" || Message == "already exists") && (firstBox > 0))
                {
                    TextBoxFirst.Text = Message;
                    antalRader--;
                }
                else if (Message == "wrong input" || Message == "already exists")
                {
                    TextBoxFirst.Text = Message;
                }
                else if (firstBox == 0)
                {
                    antalRader++;
                    firstBox++;
                }

            }
            else
                TextBoxFirst.Text = "wrong input";

        }

        private void TextBoxSecond_TextChanged(object sender, EventArgs e)
        {

            int nr = 2;
            string Message = "";
            int inputValue = 0;


            if (Int32.TryParse(TextBoxSecond.Text, out inputValue))
            {

                Message = (checkNumber(inputValue, nr));

                if ((Message == "wrong input" || Message == "already exists") && (secondBox > 0))
                {
                    TextBoxSecond.Text = Message;
                    antalRader--;
                }
                else if (Message == "wrong input" || Message == "already exists")
                {
                    TextBoxSecond.Text = Message;
                }
                else if (secondBox == 0)
                {
                    antalRader++;
                    secondBox++;
                }

            }
            else
                TextBoxSecond.Text = "wrong input";
        }

        private void TextBoxThird_TextChanged(object sender, EventArgs e)
        {

            int nr = 3;
            string Message = "";
            int inputValue = 0;


            if (Int32.TryParse(TextBoxThird.Text, out inputValue))
            {

                Message = (checkNumber(inputValue, nr));

                if ((Message == "wrong input" || Message == "already exists") && (thirdBox > 0))
                {
                    TextBoxThird.Text = Message;
                    antalRader--;
                }
                else if (Message == "wrong input" || Message == "already exists")
                {
                    TextBoxThird.Text = Message;
                }
                else if (thirdBox == 0)
                {
                    antalRader++;
                    thirdBox++;
                }

            }
            else
                TextBoxThird.Text = "wrong input";
        }

            private void TextBoxForth_TextChanged(object sender, EventArgs e)
        {
                int nr = 4;
                string Message = "";
                int inputValue = 0;


                if (Int32.TryParse(TextBoxForth.Text, out inputValue))
                {

                    Message = (checkNumber(inputValue, nr));

                if ((Message == "wrong input" || Message == "already exists") && (forthBox > 0))
                {
                    TextBoxForth.Text = Message;
                    antalRader--;
                }
                else if (Message == "wrong input" || Message == "already exists")
                {
                    TextBoxForth.Text = Message;
                }
                else if (forthBox == 0)
                    {
                        antalRader++;
                        forthBox++;
                    }

                }
            else
                TextBoxForth.Text = "wrong input";
        }

        private void textBoxFifth_TextChanged(object sender, EventArgs e)
        {

            int nr = 5;
            string Message;
            int inputValue = 0;


            if (Int32.TryParse(textBoxFifth.Text, out inputValue))
            {

                Message = (checkNumber(inputValue, nr));

                if ((Message == "wrong input" || Message == "already exists") && (fifthBox > 0))
                {
                    textBoxFifth.Text = Message;
                    antalRader--;
                }
                else if (Message == "wrong input" || Message == "already exists")
                {
                    textBoxFifth.Text = Message;
                }
                else if (fifthBox == 0)
                {
                    antalRader++;
                    fifthBox++;
                }

            }
            else
                textBoxFifth.Text = "wrong input";
        }

        private void textBoxSix_TextChanged(object sender, EventArgs e)
        {

            int nr = 6;
            string Message;
            int inputValue = 0;


            if (Int32.TryParse(textBoxSix.Text, out inputValue))
            {

                Message = (checkNumber(inputValue, nr));

                if ((Message == "wrong input" || Message == "already exists") && (sixthBox > 0))
                {
                    textBoxSix.Text = Message;
                    antalRader--;
                }
                else if (Message == "wrong input" || Message == "already exists")
                {
                    textBoxSix.Text = Message;
                }
                else if (sixthBox == 0)
                {
                    antalRader++;
                    sixthBox++;
                }

            }
            else
                textBoxSix.Text = "wrong input";
        }

        private void textBoxSeven_TextChanged(object sender, EventArgs e)
        {

            int nr = 7;
            string Message;
            int inputValue = 0;


            if (Int32.TryParse(textBoxSeven.Text, out inputValue))
            {

                Message = (checkNumber(inputValue, nr));

                if ((Message == "wrong input" || Message == "already exists") && (seventhBox > 0))
                {
                    textBoxSeven.Text = Message;
                    antalRader--;
                }
                else if (Message == "wrong input" || Message == "already exists")
                {
                    textBoxSeven.Text = Message;
                }
                else if (seventhBox == 0)
                {
                    antalRader++;
                    seventhBox++;
                }

            }
            else
                textBoxSeven.Text = "wrong input";
        }



     

        private void TextBoxAntalDrag_TextChanged(object sender, EventArgs e)         // kollar så att antal dragning textboxen har rätt värden inmatade
        {
            int dragValue;
            antalDrag = false;
            if (Int32.TryParse(TextBoxAntalDrag.Text, out dragValue))
            {

                if (0 >= dragValue)
                {
                    TextBoxAntalDrag.Text = "Invalid Input";
                }
                else                 
                    antalDrag = true;
            }
            else
                TextBoxAntalDrag.Text = "Invalid Input";
        }


        public int valueChecker()           // kollar om något av värdena har ett fel värde precis innan man trycker på start knappen, om man   
        {                                       // kör om programmet ofta
            string MessageTwo = "wrong input";
            string MessageOne = "already exists";
            int inputValue;
            int counter = 0;

            if (Int32.TryParse(textBoxSeven.Text, out inputValue))
            {
                if ((inputValue.ToString() != MessageOne) || (inputValue.ToString() != MessageTwo))
                {
                    counter++;
                }
            }
            if (Int32.TryParse(textBoxSix.Text, out inputValue))
            {
                if ((inputValue.ToString() != MessageOne) || (inputValue.ToString() != MessageTwo))
                {
                    counter++;
                }
            }
            if (Int32.TryParse(textBoxFifth.Text, out inputValue))
            {
                if ((inputValue.ToString() != MessageOne) || (inputValue.ToString() != MessageTwo))
                {
                    counter++;
                }
            }
            if (Int32.TryParse(TextBoxForth.Text, out inputValue))
            {
                if ((inputValue.ToString() != MessageOne) || (inputValue.ToString() != MessageTwo))
                {
                    counter++;
                }
            }
            if (Int32.TryParse(TextBoxThird.Text, out inputValue))
            {
                if ((inputValue.ToString() != MessageOne) || (inputValue.ToString() != MessageTwo))
                {
                    counter++;
                }
            }
            if (Int32.TryParse(TextBoxSecond.Text, out inputValue))
            {
                if ((inputValue.ToString() != MessageOne) || (inputValue.ToString() != MessageTwo))
                {
                    counter++;
                }
            }
            if (Int32.TryParse(TextBoxFirst.Text, out inputValue))
            {
                if ((inputValue.ToString() != MessageOne) || (inputValue.ToString() != MessageTwo))
                {
                    counter++;
                }
            }

            return counter;
        }

        public void StartLottoBtn_Click(object sender, EventArgs e)             // när man klickar på starta lotton knappen så körs en while loop
        {                                                                   // upp till antalet dragningar, i varje loop så körs en for loop 7 gånger
            Random rand = new Random();                                     // där ett nytt tal genereras 
            int randoms;
            int checkN;
            sixCorrect=0;
            fiveCorrect=0;
            sevenCorrect=0;

            int counter = 0;
            int txtBoxParse = int.Parse(TextBoxAntalDrag.Text);

            if ((valueChecker() == 7) && (antalDrag == true))
            {   
                while (counter < txtBoxParse)
                {
                    int radCounter = 0;
                    int firstLimit = 0;
                    int secondLimit = 0;
                    int thirdLimit = 0;
                    int fourthLimit = 0;
                    int fifthLimit = 0;
                    int sixthLimit = 0;
                    int seventhLimit = 0;

                    for (int i = 0; i < 7; i++)
                    {
                        randoms = rand.Next(1, 35);

                        if (Int32.TryParse(TextBoxFirst.Text, out checkN))
                        {
                            if (randoms == checkN && firstLimit == 0) 
                            {
                                radCounter++;
                                firstLimit++;
                            }
                        }
                        if (Int32.TryParse(TextBoxSecond.Text, out checkN))
                        {
                            if (randoms == checkN && secondLimit == 0)
                            {
                                radCounter++;
                                secondLimit++;
                            }
                        }
                        if (Int32.TryParse(TextBoxThird.Text, out checkN))
                        {
                            if (randoms == checkN && thirdLimit == 0)
                            {
                                radCounter++;
                                thirdLimit++;
                            }
                        }
                        if (Int32.TryParse(TextBoxForth.Text, out checkN))
                        {
                            if (randoms == checkN && fourthLimit == 0)
                            {
                                radCounter++;
                                fourthLimit++;
                            }
                        }
                        if (Int32.TryParse(textBoxFifth.Text, out checkN))
                        {
                            if (randoms == checkN && fifthLimit == 0)
                            {
                                radCounter++;
                                fifthLimit++;
                            }
                        }
                        if (Int32.TryParse(textBoxSix.Text, out checkN))
                        {
                            if (randoms == checkN && sixthLimit == 0)
                            {
                                radCounter++;
                                sixthLimit++;
                            }
                        }
                        if (Int32.TryParse(textBoxSeven.Text, out checkN))
                        {
                            if (randoms == checkN && seventhLimit == 0)
                            {
                                radCounter++;
                                seventhLimit++;
                            }
                        }
                    }

                    if (radCounter == 5)
                        fiveCorrect++;
                    if (radCounter == 6)
                    {
                        sixCorrect++;
                        fiveCorrect++;
                    }
                    if (radCounter == 7)
                    {
                        sixCorrect++;
                        fiveCorrect++;
                        sevenCorrect++;
                    }

                    counter++;
                }

                TextBoxFemRatt.Text = fiveCorrect.ToString();
                TextBoxSexRatt.Text = sixCorrect.ToString();
                TextBoxSjuRatt.Text = sevenCorrect.ToString();
         

            }
            else
            {
                MessageBox.Show("Fel lotto rader/antal drag");
            }
                

        }


        private string checkNumber(int number, int check)   // kollar om det inmatade numret inte finns samt, om det är inom 1-35
        {
            string message = "";
            int checkN = 0;


            if (number > 35 || number < 1)
            {
                message = "wrong input";
            }

            if ((Int32.TryParse(TextBoxFirst.Text, out checkN)) && check != 1)
            {
                if (number == checkN)
                {
                    message = "already exists";
                }
            }
            if ((Int32.TryParse(TextBoxSecond.Text, out checkN)) && check != 2)
            {
                if (number == checkN)
                {
                    message = "already exists";
                }
            }
            if ((Int32.TryParse(TextBoxThird.Text, out checkN)) && check != 3)
            {
                if (number == checkN)
                {
                    message = "already exists";
                }
            }
            if ((Int32.TryParse(TextBoxForth.Text, out checkN)) && check != 4)
            {
                if (number == checkN)
                {
                    message = "already exists";
                }
            }
            if ((Int32.TryParse(textBoxFifth.Text, out checkN)) && check != 5)
            {
                if (number == checkN)
                {
                    message = "already exists";
                }
            }
            if ((Int32.TryParse(textBoxSix.Text, out checkN)) && check != 6)
            {
                if (number == checkN)
                {
                    message = "already exists";
                }
            }
            if ((Int32.TryParse(textBoxSeven.Text, out checkN)) && check != 7)
            {
                if (number == checkN)
                {
                    message = "already exists";
                }
            }

            return message;
        }

      
    }
}
