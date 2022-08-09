using System;
using System.Drawing;
using System.Windows.Forms;

/**
 * DISCLAIMER
 * 
 * Originally this app didn't need any special security, so any simple code did the job. So I know... this sucks!
 * The loginForm is now probably obsolete and may be deleted in the future.
 *
 */

namespace GERMAN_Trainer
{
    public partial class trainerLoginWindow : Form
    {
        public trainerLoginWindow()
        {
            InitializeComponent();
            loginBox.Focus();
        }

        // Define, how many users can exist
        int howManyUsers = 3;

        // Set logins and passwords
        string[] logins = new string[] { "Eight", "Teacher", "German" };
        string[] passwords = new string[] { "ZeroEight", "Grochozajac", "Kalifornia64" };

        public static void ThreadProc()
        {
            Application.Run(new MainWindow());
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            // Load username and password from input boxes
            string login = loginBox.Text;
            string pass = passBox.Text;

            // Check w/DB if there are any matches
            for(int i = 0; i < howManyUsers; i++)
            {
                if (login == logins[i] && pass == passwords[i]) // If they match
                {
                    // Ppen main window
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
                    t.Start();

                    this.Close(); // Close login form
                }
            }

            if(login == "admin" || pass == "123" || login == "123" || pass == "admin")
            {
                MessageBox.Show("LOL... wait, you're serious?"); // Funny easter egg
            }

            // If login / password was incorrect
            loginName.ForeColor = Color.Red;
            passName.ForeColor = Color.Red;
        }

        private void loginBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if <enter> is pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Mute sound
                passBox.Focus(); // Change focus to password box
            }
        }

        private void passBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If <enter> is pressed
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Mute sound
                loginButton.PerformClick(); // Simulate pressing login button
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Reset colors
            loginName.ForeColor = Color.Black;
            passName.ForeColor = Color.Black;

            //Reset text
            loginBox.Clear();
            passBox.Clear();
        }
    }
}
