using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Brogan_Assignment_6_CoreDatabinding
{

    public partial class AddDialog : Form
    {
        public string? PersonName { get; private set; }
        public int Age { get; private set; }

        public AddDialog()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrWhiteSpace(nameTextBox.Text) &&
                !string.IsNullOrWhiteSpace(ageTextBox.Text) &&
                int.TryParse(ageTextBox.Text, out var age))
            {
                PersonName = nameTextBox.Text.Trim();
                Age = age;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill out all fields with valid data.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

}
