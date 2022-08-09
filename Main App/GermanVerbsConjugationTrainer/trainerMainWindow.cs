using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace GERMAN_Trainer
{
    public partial class MainWindow : Form
    {
        /// TECHNICAL INFO
        string version = "2.7";

        public MainWindow()
        {
            InitializeComponent();
            loadDatabase();
        }        
        // table containing verbs from database (whole lines)
        string[] databaseVerbs;

        // get local dir, add name of the database file
        string path = Directory.GetCurrentDirectory() + "\\Data\\Database.txt";

        // func to load verbs database 
        private void loadDatabase()
        {
            // if the file doesn't exist ...
            if (!File.Exists(path)) 
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Data"); // create folder on : current dir 
                File.CreateText(path).Close(); // create empty file Database
            }

            // load all lines from database
            databaseVerbs = System.IO.File.ReadAllLines(path);
        }
        
        // table of 6 places for verbs
        string[] verbOption = new string[6];

        // if it's irregular verb
        bool isVerbIrregular = false;

        // function that inserts options in specific order (1 of X schemes) to comboBoxes
        public void insertOptions(ComboBox box, int scheme)
        {
            if (isVerbIrregular)
            {
                // scheme for more words, 'cause verb's irregular
                switch (scheme)
                {
                    case 1: // scheme 2-5-3-1-4-6
                        box.Items.Add(verbOption[1]);
                        box.Items.Add(verbOption[4]);
                        if (verbOption[2] != verbOption[0]) // if there's diff 1st-3rd person
                        {
                            box.Items.Add(verbOption[2]);
                        }
                        box.Items.Add(verbOption[0]);
                        box.Items.Add(verbOption[3]);
                        if (verbOption[5] != verbOption[3]) // if diff 4-6 person
                        {
                            box.Items.Add(verbOption[5]);
                        }
                        break;
                    case 2: // scheme 4-5-3-1-6-2
                        box.Items.Add(verbOption[3]);
                        box.Items.Add(verbOption[4]);
                        if (verbOption[2] != verbOption[0]) // if there's diff 1st-3rd person
                        {
                            box.Items.Add(verbOption[2]);
                        }
                        box.Items.Add(verbOption[0]);
                        if (verbOption[5] != verbOption[3]) // if diff 4-6 person
                        {
                            box.Items.Add(verbOption[5]);
                        }
                        box.Items.Add(verbOption[1]);
                        break;
                    case 3: // scheme 5-1-4-2-6-3
                        box.Items.Add(verbOption[4]);
                        box.Items.Add(verbOption[0]);
                        box.Items.Add(verbOption[3]);
                        box.Items.Add(verbOption[1]);
                        if (verbOption[5] != verbOption[3]) // if diff 4-6 person
                        {
                            box.Items.Add(verbOption[5]);
                        }
                        if (verbOption[2] != verbOption[0]) // if there's diff 1st-3rd person
                        {
                            box.Items.Add(verbOption[2]);
                        }
                        break;
                    case 4: // scheme 3-1-6-2-5-4
                        if (verbOption[2] != verbOption[0]) // if there's diff 1st-3rd person
                        {
                            box.Items.Add(verbOption[2]);
                        }
                        box.Items.Add(verbOption[0]);
                        if (verbOption[5] != verbOption[3]) // if diff 4-6 person
                        {
                            box.Items.Add(verbOption[5]);
                        }
                        box.Items.Add(verbOption[1]);
                        box.Items.Add(verbOption[4]);
                        box.Items.Add(verbOption[3]);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                // regular scheme to avoid unneccessary repeats
                switch (scheme)
                {
                    case 1: // scheme 2-3-1-4
                        box.Items.Add(verbOption[1]);
                        box.Items.Add(verbOption[2]);
                        box.Items.Add(verbOption[0]);
                        box.Items.Add(verbOption[3]);
                        break;
                    case 2: // scheme 4-3-1-2
                        box.Items.Add(verbOption[3]);
                        box.Items.Add(verbOption[2]);
                        box.Items.Add(verbOption[0]);
                        box.Items.Add(verbOption[1]);
                        break;
                    case 3: // scheme 1-4-2-3
                        box.Items.Add(verbOption[0]);
                        box.Items.Add(verbOption[3]);
                        box.Items.Add(verbOption[1]);
                        box.Items.Add(verbOption[2]);
                        break;
                    case 4: // scheme 3-1-2-4
                        box.Items.Add(verbOption[2]);
                        box.Items.Add(verbOption[0]);
                        box.Items.Add(verbOption[1]);
                        box.Items.Add(verbOption[3]);
                        break;
                    default:
                        break;
                }
            }
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if (inputBox.Text.Length > 2 && inputBox.Text != "") // if input longer than 2 & isn't blank
            {
                inputBorder.BackColor = Color.Transparent;

                // clear all boxes
                comboBox1.Items.Clear();
                comboBox2.Items.Clear();
                comboBox3.Items.Clear();
                comboBox4.Items.Clear();
                comboBox5.Items.Clear();
                comboBox6.Items.Clear();
                // clear all borders
                border1.BackColor = Color.LightGray;
                border2.BackColor = Color.LightGray;
                border3.BackColor = Color.LightGray;
                border4.BackColor = Color.LightGray;
                border5.BackColor = Color.LightGray;
                border6.BackColor = Color.LightGray;
                // reenable boxes
                comboBox1.Enabled = true;
                comboBox2.Enabled = true;
                comboBox3.Enabled = true;
                comboBox4.Enabled = true;
                comboBox5.Enabled = true;
                comboBox6.Enabled = true;

                // take verb from box
                string mainVerb = inputBox.Text;

                // check if verb is irregular
                if(!isIrregular(mainVerb)){
                    // remove end of verb
                    mainVerb = mainVerb.Substring(0, mainVerb.Length - 2);

                    // make 4 verb options (+2 as bugfix)
                    verbOption[0] = mainVerb + "e";
                    verbOption[1] = mainVerb + "st";
                    verbOption[2] = mainVerb + "t";
                    verbOption[3] = mainVerb + "en";
                    //bugfix
                    verbOption[4] = mainVerb + "t";
                    verbOption[5] = mainVerb + "en";
                }

                // generate answers placing schemes
                Random rnd = new Random();
                int[] scheme = new int[6]; // 6-elements table for 6 random numbers
                for (int i = 0; i <= 5; i++)
                {
                    scheme[i] = rnd.Next(1, 4); // randomly choose scheme
                }

                // insert options
                // # could be improved by 'for' & comboBox + 'X'... maybe. idk if object accepts string
                insertOptions(comboBox1, scheme[0]);
                insertOptions(comboBox2, scheme[1]);
                insertOptions(comboBox3, scheme[2]);
                insertOptions(comboBox4, scheme[3]);
                insertOptions(comboBox5, scheme[4]);
                insertOptions(comboBox6, scheme[5]);
            }
            else // if input < 2 or blank
            {
                inputBorder.BackColor = Color.Red;
            }
        }

        private bool isIrregular(string verb)
        {
            // var that holds 1st verb from current line in file
            string firstVerbFromLine = "";
            // copy of database verb, NEVER EVER work on original DB (modif. stay through app's runtime)
            string dbVerb; 

            // loop to find irregular verb
            for(int i = 0; i < databaseVerbs.Length; i++)
            {
                // user's verb must be <= than line in database
                if (verb.Length <= databaseVerbs[i].Length) {

                    dbVerb = databaseVerbs[i]; // copy specific verb from DB

                    firstVerbFromLine = databaseVerbs[i].Remove(verb.Length); // get only part with 1st verb

                    if (verb == firstVerbFromLine) // if it's that verb...
                    {
                        dbVerb = dbVerb.Remove(0, verb.Length + 1); // remove 1st verb
                        verbOption = dbVerb.Split(','); // ... split it by ',' and proceed 
                        isVerbIrregular = true; // so it's irregular
                        return true;
                    }
                }              
            }

            isVerbIrregular = false; // nope, not irregular
            return false; // it's regular
        }

        public void checkAnswers(ComboBox box, string target, string target2, Label border)
        {
            if (border.BackColor != Color.Yellow) // if solution isn't shown (yellow border)
            {
                if (box.Text == target || box.Text == target2) // if answer is good
                {
                    border.BackColor = Color.Green;
                    box.Enabled = false;
                }
                else // if answer is incorrect
                {
                    border.BackColor = Color.Red;
                }
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (isVerbIrregular) 
            {
                // irregular check
                if(verbOption[0] == verbOption[2]) // if 1-3 are the same
                {
                    checkAnswers(comboBox1, verbOption[0], verbOption[2], border1); // ich
                    checkAnswers(comboBox3, verbOption[2], verbOption[0], border3); // er sie es
                }
                else // if they are different
                {
                    checkAnswers(comboBox1, verbOption[0], "X", border1); // ich
                    checkAnswers(comboBox3, verbOption[2], "X", border3); // er sie es
                }

                if (verbOption[0] == verbOption[2]) // if 4-6 are the same
                {
                    checkAnswers(comboBox4, verbOption[3], verbOption[5], border4); // wir
                    checkAnswers(comboBox6, verbOption[5], verbOption[3], border6); // sie Sie 
                }
                else // if they are different
                {
                    checkAnswers(comboBox4, verbOption[3], "X", border4); // wir
                    checkAnswers(comboBox6, verbOption[5], "X", border6); // sie Sie 
                }
                checkAnswers(comboBox2, verbOption[1], "X", border2); // du
                checkAnswers(comboBox5, verbOption[4], "X", border5); // ihr  

            }
            else // is regular
            {
                // check individually each box
                checkAnswers(comboBox1, verbOption[0], "X", border1); // ich
                checkAnswers(comboBox2, verbOption[1], "X", border2); // du
                checkAnswers(comboBox3, verbOption[2], "X", border3); // er sie es
                checkAnswers(comboBox4, verbOption[3], "X", border4); // wir
                checkAnswers(comboBox5, verbOption[2], "X", border5); // ihr
                checkAnswers(comboBox6, verbOption[3], "X", border6); // sie Sie        
            }
        }

        public void ShowCorrectAnswer(ComboBox box, string target, Label border)
        {
            // if it is wrong, unsolved, already revealed...
            if(border.BackColor == Color.Red || border.BackColor == Color.Transparent || border.BackColor == Color.Yellow)
            {
                box.SelectedItem = target; // change to correct verb
                border.BackColor = Color.Yellow;
                box.Enabled = false; // prevent solved >> good
            }
        }

        private void answerButton_Click(object sender, EventArgs e)
        {
            // show answer if it's not good (green)
            ShowCorrectAnswer(comboBox1, verbOption[0], border1);
            ShowCorrectAnswer(comboBox2, verbOption[1], border2);
            ShowCorrectAnswer(comboBox3, verbOption[2], border3);
            ShowCorrectAnswer(comboBox4, verbOption[3], border4);
            ShowCorrectAnswer(comboBox5, verbOption[4], border5);
            ShowCorrectAnswer(comboBox6, verbOption[5], border6);
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            // in MsgBox display info about app : author + version
            MessageBox.Show("Author: Michael '8' \nVersion: " + version, "About");
        }

        private void inputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                insertButton.PerformClick();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // clear content of every box
            inputBox.Clear();
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();

            // reset colors
            border1.BackColor = Color.Transparent;
            border2.BackColor = Color.Transparent;
            border3.BackColor = Color.Transparent;
            border4.BackColor = Color.Transparent;
            border5.BackColor = Color.Transparent;
            border6.BackColor = Color.Transparent;

            // reset state
            comboBox1.Enabled = true;
            comboBox2.Enabled = true;
            comboBox3.Enabled = true;
            comboBox4.Enabled = true;
            comboBox5.Enabled = true;
            comboBox6.Enabled = true;
        }
    }
}
