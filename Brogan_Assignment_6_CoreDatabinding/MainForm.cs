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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            db.People.Remove(currentPerson);
            db.SaveChanges();
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }
    }
}
