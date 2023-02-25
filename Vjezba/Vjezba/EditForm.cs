using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Vjezba
{
    public partial class EditForm : Form
    {
        private Employee employeeToEdit;

        public EditForm(Employee employee)
        {
            InitializeComponent();
            employeeToEdit = employee;

            // Popunjava TextBoxeve sa trenutnim podacim
            textBoxIme1.Text = employeeToEdit.Ime;
            textBoxPrezime1.Text = employeeToEdit.Prezime;
            textBoxSlika1.Text = employeeToEdit.Slika;
            comboBoxSpol1.SelectedItem = employeeToEdit.Spol;
            dateTimePickerGodinaRodjenja1.Value = employeeToEdit.Godina_rodjenja;
            dateTimePickerPocetakRada1.Value = employeeToEdit.Pocetak_rada;
            comboBoxVrstaUgovora1.SelectedItem = employeeToEdit.Vrsta_ugovora;
            textBoxTrajanjeUgovora1.Text = employeeToEdit.Trajanje_ugovora;
            comboBoxOdjel1.SelectedItem = employeeToEdit.Odjel;
            textBoxBrojDanaGodisnjegOdmora1.Text = employeeToEdit.Broj_dana_godisnjeg_odmora;
            textBoxBrojSlobodnihDana1.Text = employeeToEdit.Broj_slobodnih_dana;
            textBoxBrojDanaPlacenogDopusta1.Text = employeeToEdit.Broj_dana_placenog_dopusta;

        }

        private void buttonSave1_Click(object sender, EventArgs e)
        {
            // Updatea Employee objekt sa novim podacim
            employeeToEdit.Ime = textBoxIme1.Text;
            employeeToEdit.Prezime = textBoxPrezime1.Text;
            employeeToEdit.Slika = textBoxSlika1.Text;
            employeeToEdit.Spol = (string)comboBoxSpol1.SelectedItem;
            employeeToEdit.Godina_rodjenja = dateTimePickerGodinaRodjenja1.Value;
            employeeToEdit.Pocetak_rada = dateTimePickerPocetakRada1.Value;
            employeeToEdit.Vrsta_ugovora = (string)comboBoxVrstaUgovora1.SelectedItem;
            employeeToEdit.Trajanje_ugovora = textBoxTrajanjeUgovora1.Text;
            employeeToEdit.Odjel = (string)comboBoxOdjel1.SelectedItem;
            employeeToEdit.Broj_dana_godisnjeg_odmora = textBoxBrojDanaGodisnjegOdmora1.Text;
            employeeToEdit.Broj_slobodnih_dana = textBoxBrojSlobodnihDana1.Text;
            employeeToEdit.Broj_dana_placenog_dopusta = textBoxBrojDanaPlacenogDopusta1.Text;

            // Zatvara EditForm sa DialogResult.OK kako bi pokazalo da su podaci spremljeni
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
