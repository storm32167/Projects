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
            // Stvara novi Employee objekt iz upisanih vrijednosti iz textBoxeva
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

            // Dodaje novi Employee objekt u BindingList<Employee>
            employees.Add(newEmployee);

            // Čisti textBoxeve nakon dodavanja
            textBoxIme.Clear();
            textBoxPrezime.Clear();
            textBoxSlika.Clear();
            textBoxTrajanjeUgovora.Clear();
            textBoxBrojDanaGodisnjegOdmora.Clear();
            textBoxBrojSlobodnihDana.Clear();
            textBoxBrojDanaPlacenogDopusta.Clear();

            // Refresha DataGridView da bi se vidio novi dodani objekt
            dataGridView1.Refresh();
        }



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Pokazuje detaljne informacije o zaposleniku kada se stisne na neki row
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
            // Pokazuje poruku ako row nije označen
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo Vas označite red.");
                return;
            }

            // Uzima označeni Employee objekt
            Employee employeeToEdit = dataGridView1.SelectedRows[0].DataBoundItem as Employee;

            // Radi novu instancu EditForme i prosljeđuje Employee objekt kao parametar za uredit
            EditForm editForm = new EditForm(employeeToEdit);

            // Prikazuje EditForm kao dialog
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                // Refresha DataGridView radi prikaza uređenog objekta
                dataGridView1.Refresh();
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            employees.Clear();  // Čisti BindingListu
            dataGridView1.Refresh();  // Refresha DataGridViewkako bi se prikazala prazna lista
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // Radi novi SaveFileDialog objekt
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // Postavlja initial directory i default file name
            saveFileDialog1.InitialDirectory = @"C:\";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog1.AddExtension = true;

            // Prikazuje SaveFileDialog i dobiva rezultat
            DialogResult result = saveFileDialog1.ShowDialog();

            // Ako je stisnuto ok, savea se file
            if (result == DialogResult.OK)
            {
                // Uzima se selektirani file name i putanja
                string fileName = saveFileDialog1.FileName;

                // Radi novi StreamWriter objekt
                StreamWriter file = new StreamWriter(fileName);

                try
                {
                    string sLine = "";

                    // For petlja ide kroz svaki red u tablici
                    for (int r = 0; r <= dataGridView1.Rows.Count - 1; r++)
                    {

                        //For petlja ide kroz svaki stupac i broj reda je nasljeđen iz gornje for petlje
                        for (int c = 0; c <= dataGridView1.Columns.Count - 1; c++)
                        {
                            sLine = sLine + dataGridView1.Rows[r].Cells[c].Value;
                            if (c != dataGridView1.Columns.Count - 1)
                            {
                                //Zarez je postavljen kao delimiter za odvajanje svakog polja u text fileu
                                sLine = sLine + ", ";
                            }
                        }
                        //Text je zapisan u text file liniju po liniju
                        file.WriteLine(sLine);
                        sLine = "";
                    }
                }
                finally
                {
                    // Zatvara se StreamWriter
                    file.Close();
                }
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            // Radi novi OpenFileDialog 
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.Title = "Open employees data";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Radi novi BindingList<Employee> da bi držao zaposlenike iz filea
                BindingList<Employee> importedEmployees = new BindingList<Employee>();

                // Čita linije iz file
                string[] lines = File.ReadAllLines(openFileDialog.FileName);

                foreach (string line in lines)
                {
                    // Razdvaja svaku liniju u polja
                    string[] fields = line.Split(',');

                    // Radi novi Employee objekt koji popunjuje
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

                    // Dodaje novi Employee objekt u BindingList<Employee>
                    importedEmployees.Add(newEmployee);
                }

                // Čisti postojeće podatke u DataGridViewu
                dataGridView1.DataSource = null;

                // Postavlja DataSource property od DataGridViewau novu BindingList<Employee>
                employees = importedEmployees;
                dataGridView1.DataSource = employees;

                // Refresha DataGridView kako bi pokazalo nove podatke
                dataGridView1.Refresh();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Zahvaća odabrani row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Briše row iz  DataGridView
                dataGridView1.Rows.Remove(selectedRow);

                // Briše odabrani objekt iz BindingListe
                Employee employeeToDelete = selectedRow.DataBoundItem as Employee;
                employees.Remove(employeeToDelete);
            }
        }
    }
}