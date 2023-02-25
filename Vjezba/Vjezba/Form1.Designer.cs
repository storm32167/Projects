namespace Vjezba
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            textBoxSlika = new TextBox();
            textBoxPrezime = new TextBox();
            textBoxIme = new TextBox();
            comboBoxSpol = new ComboBox();
            dateTimePickerGodinaRodjenja = new DateTimePicker();
            dateTimePickerPocetakRada = new DateTimePicker();
            comboBoxVrstaUgovora = new ComboBox();
            comboBoxOdjel = new ComboBox();
            textBoxTrajanjeUgovora = new TextBox();
            textBoxBrojDanaGodisnjegOdmora = new TextBox();
            textBoxBrojSlobodnihDana = new TextBox();
            textBoxBrojDanaPlacenogDopusta = new TextBox();
            buttonAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            buttonDelete = new Button();
            buttonEdit = new Button();
            buttonReset = new Button();
            buttonSave = new Button();
            saveFileDialog1 = new SaveFileDialog();
            openFileDialog1 = new OpenFileDialog();
            buttonOpen = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 195);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 193);
            dataGridView1.TabIndex = 0;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // textBoxSlika
            // 
            textBoxSlika.Location = new Point(138, 70);
            textBoxSlika.Name = "textBoxSlika";
            textBoxSlika.Size = new Size(100, 23);
            textBoxSlika.TabIndex = 1;
            // 
            // textBoxPrezime
            // 
            textBoxPrezime.Location = new Point(138, 41);
            textBoxPrezime.Name = "textBoxPrezime";
            textBoxPrezime.Size = new Size(100, 23);
            textBoxPrezime.TabIndex = 2;
            // 
            // textBoxIme
            // 
            textBoxIme.Location = new Point(138, 12);
            textBoxIme.Name = "textBoxIme";
            textBoxIme.Size = new Size(100, 23);
            textBoxIme.TabIndex = 3;
            // 
            // comboBoxSpol
            // 
            comboBoxSpol.FormattingEnabled = true;
            comboBoxSpol.Items.AddRange(new object[] { "M", "Ž" });
            comboBoxSpol.Location = new Point(138, 99);
            comboBoxSpol.Name = "comboBoxSpol";
            comboBoxSpol.Size = new Size(121, 23);
            comboBoxSpol.TabIndex = 4;
            // 
            // dateTimePickerGodinaRodjenja
            // 
            dateTimePickerGodinaRodjenja.Location = new Point(138, 128);
            dateTimePickerGodinaRodjenja.Name = "dateTimePickerGodinaRodjenja";
            dateTimePickerGodinaRodjenja.Size = new Size(200, 23);
            dateTimePickerGodinaRodjenja.TabIndex = 5;
            // 
            // dateTimePickerPocetakRada
            // 
            dateTimePickerPocetakRada.Location = new Point(138, 157);
            dateTimePickerPocetakRada.Name = "dateTimePickerPocetakRada";
            dateTimePickerPocetakRada.Size = new Size(200, 23);
            dateTimePickerPocetakRada.TabIndex = 6;
            // 
            // comboBoxVrstaUgovora
            // 
            comboBoxVrstaUgovora.FormattingEnabled = true;
            comboBoxVrstaUgovora.Items.AddRange(new object[] { "Određeno", "Neodređeno" });
            comboBoxVrstaUgovora.Location = new Point(583, 12);
            comboBoxVrstaUgovora.Name = "comboBoxVrstaUgovora";
            comboBoxVrstaUgovora.Size = new Size(121, 23);
            comboBoxVrstaUgovora.TabIndex = 7;
            // 
            // comboBoxOdjel
            // 
            comboBoxOdjel.FormattingEnabled = true;
            comboBoxOdjel.Items.AddRange(new object[] { "Informatika", "Računovodstvo", "Ljudski resursi" });
            comboBoxOdjel.Location = new Point(583, 70);
            comboBoxOdjel.Name = "comboBoxOdjel";
            comboBoxOdjel.Size = new Size(121, 23);
            comboBoxOdjel.TabIndex = 8;
            // 
            // textBoxTrajanjeUgovora
            // 
            textBoxTrajanjeUgovora.Location = new Point(583, 41);
            textBoxTrajanjeUgovora.Name = "textBoxTrajanjeUgovora";
            textBoxTrajanjeUgovora.Size = new Size(100, 23);
            textBoxTrajanjeUgovora.TabIndex = 9;
            // 
            // textBoxBrojDanaGodisnjegOdmora
            // 
            textBoxBrojDanaGodisnjegOdmora.Location = new Point(583, 99);
            textBoxBrojDanaGodisnjegOdmora.Name = "textBoxBrojDanaGodisnjegOdmora";
            textBoxBrojDanaGodisnjegOdmora.Size = new Size(100, 23);
            textBoxBrojDanaGodisnjegOdmora.TabIndex = 10;
            // 
            // textBoxBrojSlobodnihDana
            // 
            textBoxBrojSlobodnihDana.Location = new Point(583, 128);
            textBoxBrojSlobodnihDana.Name = "textBoxBrojSlobodnihDana";
            textBoxBrojSlobodnihDana.Size = new Size(100, 23);
            textBoxBrojSlobodnihDana.TabIndex = 11;
            // 
            // textBoxBrojDanaPlacenogDopusta
            // 
            textBoxBrojDanaPlacenogDopusta.Location = new Point(583, 157);
            textBoxBrojDanaPlacenogDopusta.Name = "textBoxBrojDanaPlacenogDopusta";
            textBoxBrojDanaPlacenogDopusta.Size = new Size(100, 23);
            textBoxBrojDanaPlacenogDopusta.TabIndex = 12;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(12, 409);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 13;
            buttonAdd.Text = "Dodaj";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 15);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 14;
            label1.Text = "Ime";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 44);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 15;
            label2.Text = "Prezime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 73);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 16;
            label3.Text = "Slika";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(102, 102);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 17;
            label4.Text = "Spol";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 131);
            label5.Name = "label5";
            label5.Size = new Size(88, 15);
            label5.TabIndex = 18;
            label5.Text = "Godina rođenja";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 163);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 19;
            label6.Text = "Početak rada";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(497, 15);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 20;
            label7.Text = "Vrsta ugovora";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(483, 44);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 21;
            label8.Text = "Trajanje ugovora";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(542, 73);
            label9.Name = "label9";
            label9.Size = new Size(35, 15);
            label9.TabIndex = 22;
            label9.Text = "Odjel";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(420, 102);
            label10.Name = "label10";
            label10.Size = new Size(157, 15);
            label10.TabIndex = 23;
            label10.Text = "Broj dana godišnjeg odmora";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(464, 134);
            label11.Name = "label11";
            label11.Size = new Size(113, 15);
            label11.TabIndex = 24;
            label11.Text = "Broj slobodnih dana";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(422, 163);
            label12.Name = "label12";
            label12.Size = new Size(155, 15);
            label12.TabIndex = 25;
            label12.Text = "Broj dana plaćenog dopusta";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(336, 409);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 26;
            buttonDelete.Text = "Izbriši";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(93, 409);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(75, 23);
            buttonEdit.TabIndex = 27;
            buttonEdit.Text = "Uredi";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(174, 409);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(75, 23);
            buttonReset.TabIndex = 28;
            buttonReset.Text = "Resetiraj";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(255, 409);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 29;
            buttonSave.Text = "Spremi";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(417, 409);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(75, 23);
            buttonOpen.TabIndex = 30;
            buttonOpen.Text = "Otvori";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 444);
            Controls.Add(buttonOpen);
            Controls.Add(buttonSave);
            Controls.Add(buttonReset);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxBrojDanaPlacenogDopusta);
            Controls.Add(textBoxBrojSlobodnihDana);
            Controls.Add(textBoxBrojDanaGodisnjegOdmora);
            Controls.Add(textBoxTrajanjeUgovora);
            Controls.Add(comboBoxOdjel);
            Controls.Add(comboBoxVrstaUgovora);
            Controls.Add(dateTimePickerPocetakRada);
            Controls.Add(dateTimePickerGodinaRodjenja);
            Controls.Add(comboBoxSpol);
            Controls.Add(textBoxIme);
            Controls.Add(textBoxPrezime);
            Controls.Add(textBoxSlika);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxSlika;
        private TextBox textBoxPrezime;
        private TextBox textBoxIme;
        private ComboBox comboBoxSpol;
        private DateTimePicker dateTimePickerGodinaRodjenja;
        private DateTimePicker dateTimePickerPocetakRada;
        private ComboBox comboBoxVrstaUgovora;
        private ComboBox comboBoxOdjel;
        private TextBox textBoxTrajanjeUgovora;
        private TextBox textBoxBrojDanaGodisnjegOdmora;
        private TextBox textBoxBrojSlobodnihDana;
        private TextBox textBoxBrojDanaPlacenogDopusta;
        private Button buttonAdd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Button buttonDelete;
        private Button buttonEdit;
        private Button buttonReset;
        private Button buttonSave;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
        private Button buttonOpen;
    }
}