using System;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class GameOverForm : Form
    {
        private Form1 gameForm;

        // Constructor that accepts the game form reference
        public GameOverForm(Form1 parentForm = null)
        {
            this.gameForm = parentForm;
            InitializeComponent();
        }

        // Event handler for the Exit button
        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the application
            Application.Exit();
        }

        // Event handler for the Main Menu button
        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            // Show the WelcomeForm
            WelcomeForm welcomeForm = new WelcomeForm();
            welcomeForm.Show();

            // Close the current form and the game form safely
            this.Close();
            if (gameForm != null && !gameForm.IsDisposed)
            {
                gameForm.Close();
            }
        }
    }
}
