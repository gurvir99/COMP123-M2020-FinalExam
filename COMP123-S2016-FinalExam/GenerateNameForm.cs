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
    public partial class GenerateNameForm : Form
    {
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        public void GenerateNames()
        {
            var random = new Random();
            
            int index = random.Next(FirstNameListBox.Items.Count);
            string firstName = FirstNameListBox.Items[index].ToString();
            FirstNameTextBox.Text = firstName;
            string lastName = LastNameListBox.Items[index].ToString();
            LastNameTextBox.Text = lastName;
        }

        private void GenerateNameForm_Load(object sender, EventArgs e)
        {
            GenerateNames();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            GenerateNames();
        }
    }
}
