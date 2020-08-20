using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_M2020_FinalExam
{
    //Student: Gurvir Singh #301108852
    //File: Final Test
    //Course: Programming 2
    //Section: 001
    public partial class FinalForm : Form
    {
        public RaceAndClassForm previousForm { get; set; }

        public FinalForm()
        {
            InitializeComponent();
        }

        //private methods
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Step 1 - instantiate an object of the AboutBox form
            AboutBox aboutBox = new AboutBox();

            // Step 2 - use the ShowDialog method of the aboutbox
            aboutBox.ShowDialog();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.previousForm.Show();
            this.Close();

            //clear the textboxes
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            StrengthTextBox.Clear();
            DexterityTextBox.Clear();
            ConstitutionTextBox.Clear();
            WisdomTextBox.Clear();
            CharismaTextBox.Clear();
            IntelligenceTextBox.Clear();
            RaceTextBox.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //exit application
            Application.Exit();
        }

        private void FinalForm_Load(object sender, EventArgs e)
        {
            //assigned values to textboxes when the form loads
            FirstNameTextBox.Text = Program.character.FirstName;
            LastNameTextBox.Text = Program.character.LastName;
            StrengthTextBox.Text = Program.character.Strength;
            DexterityTextBox.Text = Program.character.Dexterity;
            ConstitutionTextBox.Text = Program.character.Constitution;
            WisdomTextBox.Text = Program.character.Wisdom;
            CharismaTextBox.Text = Program.character.Charisma;
            IntelligenceTextBox.Text = Program.character.Intelligence;
            RaceTextBox.Text = Program.character.Race;
        }

        private void FinalForm_Activated(object sender, EventArgs e)
        {
            //assigned values to textboxes when the form is activated
            FirstNameTextBox.Text = Program.character.FirstName;
            LastNameTextBox.Text = Program.character.LastName;
            StrengthTextBox.Text = Program.character.Strength;
            DexterityTextBox.Text = Program.character.Dexterity;
            ConstitutionTextBox.Text = Program.character.Constitution;
            WisdomTextBox.Text = Program.character.Wisdom;
            CharismaTextBox.Text = Program.character.Charisma;
            IntelligenceTextBox.Text = Program.character.Intelligence;
            RaceTextBox.Text = Program.character.Race;
        }
    }
}
