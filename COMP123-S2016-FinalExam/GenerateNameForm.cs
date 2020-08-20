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
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        public void GenerateNames()
        {
            //istantiate new random variable of typer Random
            var random = new Random();
            //new variable int to select random index from FirstNameListBox
            int index = random.Next(FirstNameListBox.Items.Count);
            //new variable string firstname
            string firstName = FirstNameListBox.Items[index].ToString();
            FirstNameTextBox.Text = firstName;
            //new variable string lastname
            string lastName = LastNameListBox.Items[index].ToString();
            LastNameTextBox.Text = lastName;
        }

        //private methods
        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            //generateNames method called
            GenerateNames();
            //assigned values to Character class properties
            Program.character.FirstName = FirstNameTextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
            Program.character.FirstName = FirstNameTextBox.Text;
            Program.character.LastName = LastNameTextBox.Text;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Program.abilityGeneratorForm.Show();
            this.Hide();
        }
    }
}
