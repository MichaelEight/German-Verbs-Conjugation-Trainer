using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

/**
 * DISCLAIMER
 * 
 * Code originally written somewhere in 2015~2017, may (and will) contain both programming and English mistakes.
 * It'll be corrected in the future.
 */


/**
* EDITOR VERSION: 1.5
* Version number last updated on: 2022.08.10, 02:17 CEST
*/

namespace GERMAN_Word_Editor
{
    public partial class editorMainWindow : Form
    {
        public editorMainWindow()
        {
            InitializeComponent();
            LoadDatabaseFromFile();
        }

        bool[] isGoodToUpdate = new bool[7]; // Checks if e.g. verbbox doesn't contain ','
        bool readyToUpdate; // General bool which checks if every isGoodToUpdate is true
        bool existsInDB; // If verb is in DB

        string[] databaseVerbs; // Verbs from database
        string[] tempVerbInBox = new string[7]; // Temporary verbs in boxes, used for applying changes

        string path = Directory.GetCurrentDirectory() + "\\Data\\Database.txt"; // Set path to DB

        // Load database from file and put it onto list
        private void LoadDatabaseFromFile()
        {
            // Ff file doesn't exists...
            if (!File.Exists(path))
            {
                Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Data"); // Create folder in the current directory
                File.CreateText(path).Close(); // Create empty file Database
            }

            databaseVerbs = File.ReadAllLines(path); // Copy lines into variable

            ReloadDB(); // Load DB onto list
        }

        // load or reload DB onto list
        private void ReloadDB()
        {
            verbListBox.Items.Clear(); // clear the box

            // Current verb, free to modify
            string curVerb = "";
            // Number of letter in line
            int noOfLetter;

            for (int i = 0; i < databaseVerbs.Length; i++)
            {
                // /* If you want to load verbs with ',' just remove "//" and change item, which is added
                noOfLetter = 0; // Reset var, set to first char
                curVerb = databaseVerbs[i]; // Take the next verb

                while (curVerb[noOfLetter] != ',') // Find first ','
                {
                    noOfLetter++;
                }

                curVerb = curVerb.Remove(noOfLetter); // Remove rest after ','
                // */
                verbListBox.Items.Add(curVerb);
            }
        }

        private void DatabaseToFile()
        {
            // If file doesn't exist...
            if (!File.Exists(path))
            {
                using (var sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(""); // ... create empty one
                }
            }

            // Empty content of the DB
            FileStream fileStream = File.Open(path, FileMode.Open);
            fileStream.SetLength(0);
            fileStream.Close(); // This flushes the content, too.

            using (var sw = new StreamWriter(path, true))
            {
                for (int i = 0; i < databaseVerbs.Length; i++) // Fill the file with verbs
                {
                    sw.WriteLine(databaseVerbs[i]);
                }
            }
        }

        // When 'edit' is selected
        private void editCheck_Click(object sender, EventArgs e)
        {
            addNewCheck.Checked = false; // Deselect 'add new' mode

            // Activate boxes to enable editing or disable them, when 'edit mode' is deactivated
            if (editCheck.Checked)
            {
                changeVerbBoxStatus(true);
                addButton.Enabled = true;
            }
            else
            {
                changeVerbBoxStatus(false);
                addButton.Enabled = false;
            }
        }

        // When 'add new' is selected
        private void addNewCheck_Click(object sender, EventArgs e)
        {
            editCheck.Checked = false; // Deselect edit mode
            verbListBox.ClearSelected(); // Deselect, because you're adding new

            // Activate & clear verb boxes, because you're adding new ; or disable, when deactivating 'add new'
            if (addNewCheck.Checked)
            {
                changeVerbBoxStatus(true);
                verbListBox.Enabled = false; // Disable selecting on the list 
                addButton.Enabled = true;
            }
            else
            {
                changeVerbBoxStatus(false);
                verbListBox.Enabled = true; // Reenable selecting on the list
                addButton.Enabled = false;
            }

            // Make boxes blank
            ClearBoxes();
        }

        // Change state of verb boxes
        private void changeVerbBoxStatus(bool state)
        {
            if (state)
            {
                mainVerbBox.Enabled = true;
                verbBox1.Enabled = true;
                verbBox2.Enabled = true;
                verbBox3.Enabled = true;
                verbBox4.Enabled = true;
                verbBox5.Enabled = true;
                verbBox6.Enabled = true;
            }
            else
            {
                mainVerbBox.Enabled = false;
                verbBox1.Enabled = false;
                verbBox2.Enabled = false;
                verbBox3.Enabled = false;
                verbBox4.Enabled = false;
                verbBox5.Enabled = false;
                verbBox6.Enabled = false;
            }
        }

        private void mainVerbBox_TextChanged(object sender, EventArgs e) // check for invalid characters in main verb box
        {
            checkBoxForInvalid(mainVerbBox.Text, border0, 0);
            tempVerbInBox[0] = mainVerbBox.Text; // Moves verb to temporary variable
        }

        private void verbBox1_TextChanged(object sender, EventArgs e)
        {
            checkBoxForInvalid(verbBox1.Text, border1, 1);
            tempVerbInBox[1] = verbBox1.Text;
        }

        private void verbBox2_TextChanged(object sender, EventArgs e)
        {
            checkBoxForInvalid(verbBox2.Text, border2, 2);
            tempVerbInBox[2] = verbBox2.Text;
        }

        private void verbBox3_TextChanged(object sender, EventArgs e)
        {
            checkBoxForInvalid(verbBox3.Text, border3, 3);
            tempVerbInBox[3] = verbBox3.Text;
        }

        private void verbBox4_TextChanged(object sender, EventArgs e)
        {
            checkBoxForInvalid(verbBox4.Text, border4, 4);
            tempVerbInBox[4] = verbBox4.Text;
        }

        private void verbBox5_TextChanged(object sender, EventArgs e)
        {
            checkBoxForInvalid(verbBox5.Text, border5, 5);
            tempVerbInBox[5] = verbBox5.Text;
        }

        private void verbBox6_TextChanged(object sender, EventArgs e)
        {
            checkBoxForInvalid(verbBox6.Text, border6, 6);
            tempVerbInBox[6] = verbBox6.Text;
        }

        private void checkBoxForInvalid(string text, Label border, int noBox)
        {
            // check if any of these characters occurs
            if (text.Contains(',') || text.Contains('.') || text.Contains('!') || text.Contains('?') || text.Contains(';') || text.Contains(':')
                || text.Contains('0') || text.Contains('1') || text.Contains('2') || text.Contains('3') || text.Contains('4') || text.Contains('5')
                || text.Contains('6') || text.Contains('7') || text.Contains('8') || text.Contains('9') || text.Contains('#') || text.Contains('@')
                || text.Contains('$') || text.Contains('/') || text.Contains('\\') || text.Contains('%') || text.Contains('^') || text.Contains('&')
                || text.Contains('|') || text.Contains('*') || text.Contains('(') || text.Contains(')') || text.Contains('<') || text.Contains('>')
                || text.Contains('-') || text.Contains('+') || text.Contains('=') || text.Contains('~') || text.Contains('`') || text.Contains('\'')
                || text.Contains('\"') || text.Contains('[') || text.Contains(']') || text.Contains('{') || text.Contains('}') || text.Contains('_'))
            {
                border.BackColor = Color.Red; // Change border color to red - indicate mistake
                isGoodToUpdate[noBox] = false; // Disable DB updating
            }
            else
            {
                border.BackColor = Color.Transparent;
                isGoodToUpdate[noBox] = true; // Enable DB updating
            }
        }

        private void verbListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!addNewCheck.Checked && verbListBox.SelectedIndex >= 0) // If 'add new' isn't selected
            {
                string[] selectedVerbs = databaseVerbs[verbListBox.SelectedIndex].Split(','); // Load and split line of selected verb

                // Put changed verbs into boxes
                mainVerbBox.Text = selectedVerbs[0];
                verbBox1.Text = selectedVerbs[1];
                verbBox2.Text = selectedVerbs[2];
                verbBox3.Text = selectedVerbs[3];
                verbBox4.Text = selectedVerbs[4];
                verbBox5.Text = selectedVerbs[5];
                verbBox6.Text = selectedVerbs[6];

                delButton.Enabled = true;
                editCheck.Enabled = true;
            }
            else
            {
                delButton.Enabled = false;
                editCheck.Enabled = false;
                editCheck.Checked = false;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CheckIfCorrect();

            if (readyToUpdate)
            {
                string verbsToLine = tempVerbInBox[0]; // Add first word
                for (int i = 1; i <= 6; i++) // Add the rest
                {
                    verbsToLine += "," + tempVerbInBox[i];
                }

                if (addNewCheck.Checked && !existsInDB) // If selected 'add new'
                {
                    string[] tempDB = new string[databaseVerbs.Length + 1]; // Create temporary DB
                    for (int i = 0; i < databaseVerbs.Length; i++) // Move data from DB to tempDB
                    {
                        tempDB[i] = databaseVerbs[i];
                    }
                    tempDB[tempDB.Length - 1] = verbsToLine; // Add new element
                    databaseVerbs = new string[tempDB.Length];
                    databaseVerbs = tempDB;

                    DatabaseToFile(); // Insert DB to file
                    ReloadDB(); // Reload DB to have newest verbs

                    ClearBoxes(); // Clear after successfully adding verb
                }
                else if (addNewCheck.Checked && existsInDB)
                {
                    MessageBox.Show("That verb already exists on the list!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (editCheck.Checked) // If selected 'edit'
                {
                    databaseVerbs[verbListBox.SelectedIndex] = verbsToLine; // Modify that verb

                    DatabaseToFile();
                    ReloadDB();
                }
            }
        }

        // func which checks: if boxes are empty, if there's invalid char or if it already exists
        private void CheckIfCorrect()
        {
            // reset state to default (allow add)
            for (int i = 0; i <= 6; i++)
            {
                isGoodToUpdate[i] = true;
            }
            existsInDB = false;

            // check for invalid chars
            checkBoxForInvalid(mainVerbBox.Text, border0, 0);
            checkBoxForInvalid(verbBox1.Text, border1, 1);
            checkBoxForInvalid(verbBox2.Text, border2, 2);
            checkBoxForInvalid(verbBox3.Text, border3, 3);
            checkBoxForInvalid(verbBox4.Text, border4, 4);
            checkBoxForInvalid(verbBox5.Text, border5, 5);
            checkBoxForInvalid(verbBox6.Text, border6, 6);

            // check if empty or too short
            CheckBoxesIfEmpty();

            if (verbListBox.Items.Contains(mainVerbBox.Text)) // check if exists
            {
                existsInDB = true;
            }

            // check if everything's okey
            if (isGoodToUpdate[0] && isGoodToUpdate[1] && isGoodToUpdate[2] && isGoodToUpdate[3] && isGoodToUpdate[4] && isGoodToUpdate[5] && isGoodToUpdate[6])
            {
                readyToUpdate = true;
            }
            else
            {
                readyToUpdate = false;
            }
        }

        // func to check if text in box is too short / blank
        private void CheckBoxesIfEmpty()
        {
            int minLetters = 3; // minimum letters required to make verb

            if (mainVerbBox.Text.Length < minLetters)
            {
                border0.BackColor = Color.Red;
                isGoodToUpdate[0] = false;
            }

            if (verbBox1.Text.Length < minLetters)
            {
                border1.BackColor = Color.Red;
                isGoodToUpdate[1] = false;
            }

            if (verbBox2.Text.Length < minLetters)
            {
                border2.BackColor = Color.Red;
                isGoodToUpdate[2] = false;
            }

            if (verbBox3.Text.Length < minLetters)
            {
                border3.BackColor = Color.Red;
                isGoodToUpdate[3] = false;
            }

            if (verbBox4.Text.Length < minLetters)
            {
                border4.BackColor = Color.Red;
                isGoodToUpdate[4] = false;
            }

            if (verbBox5.Text.Length < minLetters)
            {
                border5.BackColor = Color.Red;
                isGoodToUpdate[5] = false;
            }

            if (verbBox6.Text.Length < minLetters)
            {
                border6.BackColor = Color.Red;
                isGoodToUpdate[6] = false;
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (verbListBox.SelectedIndex >= 0) // if there's any selected item
            {
                for (int i = verbListBox.SelectedIndex; i < databaseVerbs.Length - 1; i++)
                {
                    databaseVerbs[i] = databaseVerbs[i + 1]; // shift everything
                }

                string[] tempDB = new string[databaseVerbs.Length - 1]; // temp DB to make original shorter
                for (int i = 0; i < tempDB.Length; i++)
                {
                    tempDB[i] = databaseVerbs[i]; // move all elements DB >> tempDB
                }
                databaseVerbs = new string[databaseVerbs.Length - 1]; // remake original DB
                databaseVerbs = tempDB; // tempDB >> DB

                editCheck.Checked = false;
                editCheck.Enabled = false;
                changeVerbBoxStatus(false);
                addButton.Enabled = false;
                delButton.Enabled = false;

                DatabaseToFile(); // update file
                ReloadDB(); // reload DB
            }
        }

        private void mainVerbBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.ActiveControl = verbBox1;
                e.Handled = true;  // silent press
            }
        }

        private void verbBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.ActiveControl = verbBox2;
                e.Handled = true;  // silent press
            }
        }

        private void verbBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.ActiveControl = verbBox3;
                e.Handled = true;  // silent press
            }
        }

        private void verbBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.ActiveControl = verbBox4;
                e.Handled = true;  // silent press
            }
        }

        private void verbBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.ActiveControl = verbBox5;
                e.Handled = true;  // silent press
            }
        }

        private void verbBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.ActiveControl = verbBox6;
                e.Handled = true;  // silent press ^^ oh what a relief
            }
        }

        private void verbBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                addButton.PerformClick(); // simulate pressing addButton
                this.ActiveControl = mainVerbBox; // go back to main verb box, easier to add multiple verbs
                e.Handled = true;  // silent press
            }
        }
        
        private void ClearBoxes()
        {
            mainVerbBox.Text = "";
            verbBox1.Text = "";
            verbBox2.Text = "";
            verbBox3.Text = "";
            verbBox4.Text = "";
            verbBox5.Text = "";
            verbBox6.Text = "";
        }
    }
}
