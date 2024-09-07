using System.Text;

namespace WordGuessApplication
{
    public partial class Guess_The_Word : Form
    {
        public Guess_The_Word()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] words =
               {
                "compiler"
                
                };//array of words, [so that I can input more words someday]
            Random random = new Random();
            string wordsToGuess = words[random.Next(0, words.Length)];//Random pick from the array of words

            string guessedWords = GuessWordTextBox.Text; //access the textbox
            int attempts = 0;
            if (wordsToGuess != guessedWords.ToLower())
            {
                StringBuilder list = new StringBuilder(guessedWords);
                GuessList.Items.Add(list); //adds to list if guessed is wrong
                GuessWordTextBox.Clear(); // clears the textbox to be able to attempt again
                attempts++;
                if (attempts == 10)
                {
                    MessageBox.Show("Mostly use by Programmers");
                }
                if(attempts == 20)
                {
                    MessageBox.Show("Starts with letter c");
                }
            }
            else
            {
                MessageBox.Show("Congratulations! you've guessed the word");
                GuessList.Items.Clear();
                GuessWordTextBox.Clear();
                //reset
            }

        }
        private void GuessList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
        private void GuessWordTextBox_TextChanged(object sender, EventArgs e)
        {
            //
        }
        private void WrongGuessLabel_Click(object sender, EventArgs e)
        {
            //
        }
        
    }
}//made by january Toribio Jr
