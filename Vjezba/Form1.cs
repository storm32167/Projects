using System.ComponentModel;
using System.Windows.Forms;

namespace Vjezba
{
    public partial class Form1 : Form
    {

        private BindingList<Employee> employees = new BindingList<Employee>();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = employees;

            comboBoxSpol.SelectedIndex = 0;
            comboBoxOdjel.SelectedIndex = 0;
            comboBoxVrstaUgovora.SelectedIndex = 0;

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Create a new Employee object from the values entered in the TextBoxes
            Employee newEmployee = new Employee()
            {
                Ime = textBoxIme.Text,
                Prezime = textBoxPrezime.Text,
                Slika = textBoxSlika.Text,
                Spol = (string)comboBoxSpol.SelectedItem,
                Godina_rodjenja = dateTimePickerGodinaRodjenja.Value,
                Pocetak_rada = dateTimePickerPocetakRada.Value,
                Vrsta_ugovora = (string)comboBoxVrstaUgovora.SelectedItem,
                Trajanje_ugovora = textBoxTrajanjeUgovora.Text,
                Odjel = (string)comboBoxOdjel.SelectedItem,
                Broj_dana_godisnjeg_odmora = textBoxBrojDanaGodisnjegOdmora.Text,
                Broj_slobodnih_dana = textBoxBrojSlobodnihDana.Text,
                Broj_dana_placenog_dopusta = textBoxBrojDanaPlacenogDopusta.Text
            };

            // Add the new Employee object to the BindingList<Employee>
            employees.Add(newEmployee);

            // Clear the TextBoxes
            textBoxIme.Clear();
            textBoxPrezime.Clear();
            textBoxSlika.Clear();
            textBoxTrajanjeUgovora.Clear();
            textBoxBrojDanaGodisnjegOdmora.Clear();
            textBoxBrojSlobodnihDana.Clear();
            textBoxBrojDanaPlacenogDopusta.Clear();

            // Refresh the DataGridView to show the new Employee object
            dataGridView1.Refresh();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Make sure a row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Get the corresponding Employee object
            Employee employeeToDelete = (Employee)selectedRow.DataBoundItem;

            // Remove the Employee object from the BindingList<Employee>
            employees.Remove(employeeToDelete);

            // Remove the selected row from the DataGridView
            dataGridView1.Rows.Remove(selectedRow);

            // Refresh the DataGridView to show the updated data
            dataGridView1.Refresh();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                Employee selectedEmployee = (Employee)row.DataBoundItem;
                DetailsForm detailsForm = new DetailsForm(selectedEmployee);
                detailsForm.Show();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            // Make sure a row is selected
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.");
                return;
            }

            // Get the selected Employee object
            Employee employeeToEdit = dataGridView1.SelectedRows[0].DataBoundItem as Employee;

            // Create a new instance of the EditForm, passing the Employee object to edit as a parameter
            EditForm editForm = new EditForm(employeeToEdit);

            // Show the EditForm as a dialog
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Refresh the DataGridView to show the updated data
                dataGridView1.Refresh();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            employees.Clear();  // Clear the BindingList
            dataGridView1.Refresh();  // Refresh the DataGridView to show the empty list
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Create a new SaveFileDialog object
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // Set the initial directory and default file name
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog1.AddExtension = true;

            // Display the SaveFileDialog and get the result
            DialogResult result = saveFileDialog1.ShowDialog();

            // If the user clicked OK, save the file
            if (result == DialogResult.OK)
            {
                // Get the selected file name and path
                string fileName = saveFileDialog1.FileName;

                // Create a new StreamWriter object
                StreamWriter file = new StreamWriter(fileName);

                try
                {
                    string sLine = "";

                    //This for loop loops through each row in the table
                    for (int r = 0; r <= dataGridView1.Rows.Count - 1; r++)
                    {
                        //This for loop loops through each column, and the row number
                        //is passed from the for loop above.
                        for (int c = 0; c <= dataGridView1.Columns.Count - 1; c++)
                        {
                            sLine = sLine + dataGridView1.Rows[r].Cells[c].Value;
                            if (c != dataGridView1.Columns.Count - 1)
                            {
                                //A comma is added as a text delimiter in order
                                //to separate each field in the text file.
                                //You can choose another character as a delimiter.
                                sLine = sLine + ", ";
                            }
                        }
                        //The exported text is written to the text file, one line at a time.
                        file.WriteLine(sLine);
                        sLine = "";
                    }
                }
                finally
                {
                    // Close the StreamWriter
                    file.Close();
                }
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.Title = "Open employees data";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Create a new BindingList<Employee> to hold the employees from the file
                BindingList<Employee> importedEmployees = new BindingList<Employee>();

                // Read the lines from the file
                string[] lines = File.ReadAllLines(openFileDialog.FileName);

                foreach (string line in lines)
                {
                    // Split each line into fields
                    string[] fields = line.Split(',');

                    // Create a new Employee object and populate it with the fields
                    Employee newEmployee = new Employee()
                    {
                        Ime = fields[0],
                        Prezime = fields[1],
                        Slika = fields[2],
                        Spol = fields[3],
                        Godina_rodjenja = DateTime.Parse(fields[4]),
                        Pocetak_rada = DateTime.Parse(fields[5]),
                        Vrsta_ugovora = fields[6],
                        Trajanje_ugovora = fields[7],
                        Odjel = fields[8],
                        Broj_dana_godisnjeg_odmora = fields[9],
                        Broj_slobodnih_dana = fields[10],
                        Broj_dana_placenog_dopusta = fields[11]
                    };

                    // Add the new Employee object to the BindingList<Employee>
                    importedEmployees.Add(newEmployee);
                }

                // Clear the existing data in the DataGridView
                dataGridView1.DataSource = null;

                // Set the DataSource property of the DataGridView to the new BindingList<Employee>
                employees = importedEmployees;
                dataGridView1.DataSource = employees;

                // Refresh the DataGridView to show the new data
                dataGridView1.Refresh();
            }
        }
    }
}