using Microsoft.EntityFrameworkCore;

namespace Brogan_Assignment_6_CoreDatabinding
{
    public partial class MainForm : Form
    {
        private readonly IPersonGetter db;
        public MainForm(IPersonGetter personGetter)
        {
            db = personGetter;
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            //personBindingSource.DataSource = db.People.Local.ToBindingList();
            ApplyFilter();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            db.SaveChanges();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Person currentPerson = (Person)personBindingSource.Current;
            if (currentPerson == null)
                return;
            currentPerson.IsDeleted = !currentPerson.IsDeleted;
            db.SaveChanges();
            ApplyFilter();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            var add = new AddDialog();

            // Show the modal dialog and proceed only if user clicked OK
            if (add.ShowDialog() == DialogResult.OK)
            {
                var p = new Person
                {
                    Name = add.PersonName,   // renamed property
                    Age = add.Age,
                    IsDeleted = false
                };

                db.Add(p);          // or db.People.Add(p); depending on your context
                db.SaveChanges();
                ApplyFilter();
            }
        }


        private void ApplyFilter()
        {
           personBindingSource.DataSource = db.GetPeople(searchTextBox.Text, showDeletedCheckBox.Checked);
        }
        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void showDeletedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

  
    }
}
