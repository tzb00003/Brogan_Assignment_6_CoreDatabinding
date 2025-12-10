using Microsoft.EntityFrameworkCore;

namespace Brogan_Assignment_6_CoreDatabinding
{
    public partial class MainForm : Form
    {
        private readonly PersonContext db = new PersonContext();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            db.Database.EnsureCreated();
            db.People.Load();
            personBindingSource.DataSource = db.People.Local.ToBindingList();
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
            //Put Dialog code here
            Person p = new Person();
            p.Name = "New Person";
            p.Age = 50;
            db.People.Add(p);
            db.SaveChanges();
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            if (showDeletedCheckBox.Checked)
            {
                personBindingSource.DataSource = db.People.Local
                    .Where(person => (person.Name! ?? "").ToLower()!.Contains(searchTextBox.Text.ToLower()))
                    .OrderBy(person => person.Age)
                    .ToList();
            }
            else
            {
                personBindingSource.DataSource = db.People.Local
                    .Where(person => (person.Name! ?? "").ToLower()!.Contains(searchTextBox.Text.ToLower())
                    && person.IsDeleted == false)
                    .OrderBy(person => person.Age)
                    .ToList();
            }
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
