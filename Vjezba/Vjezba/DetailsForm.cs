using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vjezba
{
    public partial class DetailsForm : Form
    {
        private Employee employee;

        public DetailsForm(Employee selectedEmployee)
        {
            InitializeComponent();
            this.employee = selectedEmployee;
            DisplayDetails();
        }

        private void DisplayDetails()
        {
            // Prikazuje detalje o zaposleniku 
            label13.Text = employee.Ime;
            label14.Text = employee.Prezime;
            pictureBox1.ImageLocation = employee.Slika;
            label16.Text = employee.Spol;
            label17.Text = employee.Godina_rodjenja.ToString();
            label18.Text = employee.Pocetak_rada.ToString();
            label19.Text = employee.Vrsta_ugovora;
            label20.Text = employee.Trajanje_ugovora;
            label21.Text = employee.Odjel;
            label22.Text = employee.Broj_dana_godisnjeg_odmora;
            label23.Text = employee.Broj_slobodnih_dana;
            label24.Text = employee.Broj_dana_placenog_dopusta;

        }
    }

}
