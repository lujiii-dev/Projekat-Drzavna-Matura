namespace Projekat_Drzavna_Matura
{
    partial class Form
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            Profili = new TabPage();
            Refresh = new Button();
            Skola = new ComboBox();
            label21 = new Label();
            tPrezime = new TextBox();
            TabelaSvihUnetihUcenika = new DataGridView();
            label12 = new Label();
            Obrisi = new Button();
            Sacuvaj = new Button();
            DodajNovog = new Button();
            Izmeni = new Button();
            Predmet3 = new ComboBox();
            label10 = new Label();
            Predmet2 = new ComboBox();
            label11 = new Label();
            Predmet1 = new ComboBox();
            label9 = new Label();
            TipMature = new ComboBox();
            label8 = new Label();
            Jezik = new ComboBox();
            Odeljenje = new ComboBox();
            Sabloni = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tIme = new TextBox();
            Primeni = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Evidencija = new TabPage();
            TabelaSablona = new DataGridView();
            SRefresh = new Button();
            SObrisi = new Button();
            SSacuvaj = new Button();
            SDodaj = new Button();
            SIzmeni = new Button();
            SSkola = new ComboBox();
            label16 = new Label();
            SPredmet3 = new ComboBox();
            label17 = new Label();
            SPredmet2 = new ComboBox();
            label18 = new Label();
            SPredmet1 = new ComboBox();
            label19 = new Label();
            STipMature = new ComboBox();
            label20 = new Label();
            SJezik = new ComboBox();
            SOdeljenje = new ComboBox();
            label22 = new Label();
            label23 = new Label();
            label15 = new Label();
            tNazivSablona = new TextBox();
            label14 = new Label();
            label13 = new Label();
            tabControl1.SuspendLayout();
            Profili.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TabelaSvihUnetihUcenika).BeginInit();
            Evidencija.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TabelaSablona).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Profili);
            tabControl1.Controls.Add(Evidencija);
            tabControl1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(12, 8);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1315, 616);
            tabControl1.TabIndex = 0;
            // 
            // Profili
            // 
            Profili.Controls.Add(Refresh);
            Profili.Controls.Add(Skola);
            Profili.Controls.Add(label21);
            Profili.Controls.Add(tPrezime);
            Profili.Controls.Add(TabelaSvihUnetihUcenika);
            Profili.Controls.Add(label12);
            Profili.Controls.Add(Obrisi);
            Profili.Controls.Add(Sacuvaj);
            Profili.Controls.Add(DodajNovog);
            Profili.Controls.Add(Izmeni);
            Profili.Controls.Add(Predmet3);
            Profili.Controls.Add(label10);
            Profili.Controls.Add(Predmet2);
            Profili.Controls.Add(label11);
            Profili.Controls.Add(Predmet1);
            Profili.Controls.Add(label9);
            Profili.Controls.Add(TipMature);
            Profili.Controls.Add(label8);
            Profili.Controls.Add(Jezik);
            Profili.Controls.Add(Odeljenje);
            Profili.Controls.Add(Sabloni);
            Profili.Controls.Add(label7);
            Profili.Controls.Add(label6);
            Profili.Controls.Add(label5);
            Profili.Controls.Add(label4);
            Profili.Controls.Add(tIme);
            Profili.Controls.Add(Primeni);
            Profili.Controls.Add(label3);
            Profili.Controls.Add(label2);
            Profili.Controls.Add(label1);
            Profili.Font = new Font("Segoe UI", 9F);
            Profili.Location = new Point(4, 26);
            Profili.Name = "Profili";
            Profili.Padding = new Padding(3);
            Profili.Size = new Size(1307, 586);
            Profili.TabIndex = 0;
            Profili.Text = "Evidencija Maturanata";
            Profili.UseVisualStyleBackColor = true;
            // 
            // Refresh
            // 
            Refresh.Font = new Font("Microsoft Sans Serif", 12F);
            Refresh.Location = new Point(115, 286);
            Refresh.Name = "Refresh";
            Refresh.Size = new Size(95, 28);
            Refresh.TabIndex = 31;
            Refresh.Text = "Refresh";
            Refresh.UseVisualStyleBackColor = true;
            Refresh.Click += Refresh_Click;
            // 
            // Skola
            // 
            Skola.DropDownStyle = ComboBoxStyle.DropDownList;
            Skola.Font = new Font("Microsoft Sans Serif", 12F);
            Skola.FormattingEnabled = true;
            Skola.Items.AddRange(new object[] { "Treća beogradska gimnazija", "Prva beogradska gimnazija", "Peta beogradska gimnazija", "Deveta gimnazija \"Mihailo Petrović Alas\"", "Deseta gimnazija \"Mihajlo Pupin\"", "Četrnaesta beogradska gimnazija", "Četvrta beogradska gimnazija", "Trinaesta beogradska gimnazija", "Sedma beogradska gimnazija", "Osma beogradska gimnazija", "Dvanaesta beogradska gimnazija", "Gimnazija \"Patrijarh Pavle\"", "Zemunska gimnazija", "Šesta beogradska gimnazija", "Matematička gimnazija", "Filološka gimnazija", "Sportska gimnazija", "Gimnazija \"Sveti Sava\"", "Peta ekonomska škola \"Rakovica\"", "Prva ekonomska škola", "Druga ekonomska škola", "Pravno-poslovna škola Beograd", "Ekonomska škola \"Nada Dimić\"", "Medicinska škola \"Beograd\"", "Medicinska škola na Zvezdari", "Zubotehnička škola", "Farmaceutsko-fizioterapeutska škola", "Srednja medicinska škola \"Nadežda Petrović\"", "Elektrotehnička škola \"Nikola Tesla\"", "Elektrotehnička škola \"Stari grad\"", "Elektrotehnička škola \"Rade Končar\"", "Elektrotehnička škola \"Zemun\"", "Politehnika - škola za nove tehnologije", "Vazduhoplovna akademija", "Građevinska škola Beograd", "Arhitektonska tehnička škola", "Geodetska tehnička škola", "Saobraćajno-tehnička škola", "Tehnička škola GSP", "Ugostiteljsko-turistička škola", "Srednja turistička škola", "Trgovačka škola", "Hemijsko-prehrambena tehnološka škola", "Škola za negu lepote", "Škola za dizajn", "Tehnoart Beograd", "Muzička škola \"Mokranjac\"", "Muzička škola \"Stanković\"", "Baletska škola \"Lujo Davičo\"", "Škola za dizajn tekstila" });
            Skola.Location = new Point(900, 153);
            Skola.Name = "Skola";
            Skola.Size = new Size(391, 28);
            Skola.TabIndex = 30;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft Sans Serif", 12F);
            label21.Location = new Point(841, 153);
            label21.Name = "label21";
            label21.Size = new Size(53, 20);
            label21.TabIndex = 29;
            label21.Text = "Škola:";
            // 
            // tPrezime
            // 
            tPrezime.Font = new Font("Microsoft Sans Serif", 12F);
            tPrezime.Location = new Point(340, 111);
            tPrezime.Name = "tPrezime";
            tPrezime.Size = new Size(248, 26);
            tPrezime.TabIndex = 28;
            // 
            // TabelaSvihUnetihUcenika
            // 
            TabelaSvihUnetihUcenika.AllowUserToAddRows = false;
            TabelaSvihUnetihUcenika.AllowUserToDeleteRows = false;
            TabelaSvihUnetihUcenika.AllowUserToResizeColumns = false;
            TabelaSvihUnetihUcenika.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TabelaSvihUnetihUcenika.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TabelaSvihUnetihUcenika.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            TabelaSvihUnetihUcenika.DefaultCellStyle = dataGridViewCellStyle2;
            TabelaSvihUnetihUcenika.Location = new Point(14, 343);
            TabelaSvihUnetihUcenika.MultiSelect = false;
            TabelaSvihUnetihUcenika.Name = "TabelaSvihUnetihUcenika";
            TabelaSvihUnetihUcenika.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            TabelaSvihUnetihUcenika.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            TabelaSvihUnetihUcenika.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelaSvihUnetihUcenika.Size = new Size(1277, 229);
            TabelaSvihUnetihUcenika.TabIndex = 27;
            TabelaSvihUnetihUcenika.RowPostPaint += TabelaSvihUnetihUcenika_RowPostPaint;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label12.Location = new Point(14, 317);
            label12.Name = "label12";
            label12.Size = new Size(275, 20);
            label12.TabIndex = 26;
            label12.Text = "SPISAK SVIH UNETIH UCENIKA";
            // 
            // Obrisi
            // 
            Obrisi.Font = new Font("Microsoft Sans Serif", 12F);
            Obrisi.Location = new Point(1196, 286);
            Obrisi.Name = "Obrisi";
            Obrisi.Size = new Size(95, 28);
            Obrisi.TabIndex = 25;
            Obrisi.Text = "Obriši";
            Obrisi.UseVisualStyleBackColor = true;
            Obrisi.Click += Obrisi_Click;
            // 
            // Sacuvaj
            // 
            Sacuvaj.Font = new Font("Microsoft Sans Serif", 12F);
            Sacuvaj.Location = new Point(1095, 286);
            Sacuvaj.Name = "Sacuvaj";
            Sacuvaj.Size = new Size(95, 28);
            Sacuvaj.TabIndex = 24;
            Sacuvaj.Text = "Sačuvaj";
            Sacuvaj.UseVisualStyleBackColor = true;
            Sacuvaj.Click += Sacuvaj_Click;
            // 
            // DodajNovog
            // 
            DodajNovog.Font = new Font("Microsoft Sans Serif", 12F);
            DodajNovog.Location = new Point(994, 286);
            DodajNovog.Name = "DodajNovog";
            DodajNovog.Size = new Size(95, 28);
            DodajNovog.TabIndex = 23;
            DodajNovog.Text = "+ Dodaj novog";
            DodajNovog.UseVisualStyleBackColor = true;
            DodajNovog.Click += DodajNovog_Click;
            // 
            // Izmeni
            // 
            Izmeni.Font = new Font("Microsoft Sans Serif", 12F);
            Izmeni.Location = new Point(14, 286);
            Izmeni.Name = "Izmeni";
            Izmeni.Size = new Size(95, 28);
            Izmeni.TabIndex = 22;
            Izmeni.Text = "Izmeni";
            Izmeni.UseVisualStyleBackColor = true;
            Izmeni.Click += Izmeni_Click;
            // 
            // Predmet3
            // 
            Predmet3.DropDownStyle = ComboBoxStyle.DropDownList;
            Predmet3.Font = new Font("Microsoft Sans Serif", 12F);
            Predmet3.FormattingEnabled = true;
            Predmet3.Location = new Point(110, 239);
            Predmet3.Name = "Predmet3";
            Predmet3.Size = new Size(478, 28);
            Predmet3.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F);
            label10.Location = new Point(14, 240);
            label10.Name = "label10";
            label10.Size = new Size(90, 20);
            label10.TabIndex = 19;
            label10.Text = "3. Predmet:";
            // 
            // Predmet2
            // 
            Predmet2.DropDownStyle = ComboBoxStyle.DropDownList;
            Predmet2.Font = new Font("Microsoft Sans Serif", 12F);
            Predmet2.FormattingEnabled = true;
            Predmet2.Items.AddRange(new object[] { "Matematika" });
            Predmet2.Location = new Point(110, 210);
            Predmet2.Name = "Predmet2";
            Predmet2.Size = new Size(478, 28);
            Predmet2.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F);
            label11.Location = new Point(14, 211);
            label11.Name = "label11";
            label11.Size = new Size(90, 20);
            label11.TabIndex = 17;
            label11.Text = "2. Predmet:";
            // 
            // Predmet1
            // 
            Predmet1.DropDownStyle = ComboBoxStyle.DropDownList;
            Predmet1.Font = new Font("Microsoft Sans Serif", 12F);
            Predmet1.FormattingEnabled = true;
            Predmet1.Items.AddRange(new object[] { "Srpski jezik i književnost", "Albanski jezik i književnost", "Bosanski jezik i književnost", "Bugarski jezik i književnost", "Mađarski jezik i književnost", "Rumunski jezik i književnost", "Rusinski jezik i književnost", "Slovački jezik i književnost", "Hrvatski jezik i književnost" });
            Predmet1.Location = new Point(110, 181);
            Predmet1.Name = "Predmet1";
            Predmet1.Size = new Size(478, 28);
            Predmet1.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F);
            label9.Location = new Point(14, 182);
            label9.Name = "label9";
            label9.Size = new Size(90, 20);
            label9.TabIndex = 15;
            label9.Text = "1. Predmet:";
            // 
            // TipMature
            // 
            TipMature.DropDownStyle = ComboBoxStyle.DropDownList;
            TipMature.Font = new Font("Microsoft Sans Serif", 12F);
            TipMature.FormattingEnabled = true;
            TipMature.Items.AddRange(new object[] { "OPŠTA MATURA", "STRUČNA MATURA", "UMETNIČKA MATURA" });
            TipMature.Location = new Point(110, 152);
            TipMature.Name = "TipMature";
            TipMature.Size = new Size(478, 28);
            TipMature.TabIndex = 14;
            TipMature.SelectedIndexChanged += TipMature_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F);
            label8.Location = new Point(14, 153);
            label8.Name = "label8";
            label8.Size = new Size(88, 20);
            label8.TabIndex = 13;
            label8.Text = "Tip Mature:";
            // 
            // Jezik
            // 
            Jezik.DropDownStyle = ComboBoxStyle.DropDownList;
            Jezik.Font = new Font("Microsoft Sans Serif", 12F);
            Jezik.FormattingEnabled = true;
            Jezik.Items.AddRange(new object[] { "Srpski jezik i književnost", "Albanski jezik i književnost", "Bosanski jezik i književnost", "Bugarski jezik i književnost", "Mađarski jezik i književnost", "Rumunski jezik i književnost", "Rusinski jezik i književnost", "Slovački jezik i književnost", "Hrvatski jezik i književnost" });
            Jezik.Location = new Point(900, 211);
            Jezik.Name = "Jezik";
            Jezik.Size = new Size(391, 28);
            Jezik.TabIndex = 12;
            Jezik.SelectedIndexChanged += Jezik_SelectedIndexChanged;
            // 
            // Odeljenje
            // 
            Odeljenje.DropDownStyle = ComboBoxStyle.DropDownList;
            Odeljenje.Font = new Font("Microsoft Sans Serif", 12F);
            Odeljenje.FormattingEnabled = true;
            Odeljenje.Items.AddRange(new object[] { "III-1", "III-2", "III-3", "III-4", "IV-1", "IV-2", "IV-3", "IV-4" });
            Odeljenje.Location = new Point(900, 182);
            Odeljenje.Name = "Odeljenje";
            Odeljenje.Size = new Size(391, 28);
            Odeljenje.TabIndex = 11;
            // 
            // Sabloni
            // 
            Sabloni.DropDownStyle = ComboBoxStyle.DropDownList;
            Sabloni.Font = new Font("Microsoft Sans Serif", 12F);
            Sabloni.FormattingEnabled = true;
            Sabloni.Location = new Point(121, 46);
            Sabloni.Name = "Sabloni";
            Sabloni.Size = new Size(467, 28);
            Sabloni.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 12F);
            label7.Location = new Point(845, 211);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 9;
            label7.Text = "Jezik:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F);
            label6.Location = new Point(819, 182);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 8;
            label6.Text = "Odeljenje:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F);
            label5.Location = new Point(264, 111);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 7;
            label5.Text = "Prezime:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F);
            label4.Location = new Point(14, 113);
            label4.Name = "label4";
            label4.Size = new Size(40, 20);
            label4.TabIndex = 5;
            label4.Text = "Ime:";
            // 
            // tIme
            // 
            tIme.BackColor = Color.White;
            tIme.Font = new Font("Microsoft Sans Serif", 12F);
            tIme.Location = new Point(60, 111);
            tIme.Name = "tIme";
            tIme.Size = new Size(198, 26);
            tIme.TabIndex = 4;
            // 
            // Primeni
            // 
            Primeni.Font = new Font("Microsoft Sans Serif", 12F);
            Primeni.Location = new Point(594, 46);
            Primeni.Name = "Primeni";
            Primeni.Size = new Size(95, 28);
            Primeni.TabIndex = 3;
            Primeni.Text = "Primeni";
            Primeni.UseVisualStyleBackColor = true;
            Primeni.Click += Primeni_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F);
            label3.Location = new Point(14, 50);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 2;
            label3.Text = "Učitaj Šablon:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(14, 83);
            label2.Name = "label2";
            label2.Size = new Size(271, 20);
            label2.TabIndex = 1;
            label2.Text = "PODACI O UČENIKU I ISPITIMA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label1.Location = new Point(14, 22);
            label1.Name = "label1";
            label1.Size = new Size(232, 20);
            label1.TabIndex = 0;
            label1.Text = "BRZI UNOS (Izbor šablona)";
            // 
            // Evidencija
            // 
            Evidencija.Controls.Add(TabelaSablona);
            Evidencija.Controls.Add(SRefresh);
            Evidencija.Controls.Add(SObrisi);
            Evidencija.Controls.Add(SSacuvaj);
            Evidencija.Controls.Add(SDodaj);
            Evidencija.Controls.Add(SIzmeni);
            Evidencija.Controls.Add(SSkola);
            Evidencija.Controls.Add(label16);
            Evidencija.Controls.Add(SPredmet3);
            Evidencija.Controls.Add(label17);
            Evidencija.Controls.Add(SPredmet2);
            Evidencija.Controls.Add(label18);
            Evidencija.Controls.Add(SPredmet1);
            Evidencija.Controls.Add(label19);
            Evidencija.Controls.Add(STipMature);
            Evidencija.Controls.Add(label20);
            Evidencija.Controls.Add(SJezik);
            Evidencija.Controls.Add(SOdeljenje);
            Evidencija.Controls.Add(label22);
            Evidencija.Controls.Add(label23);
            Evidencija.Controls.Add(label15);
            Evidencija.Controls.Add(tNazivSablona);
            Evidencija.Controls.Add(label14);
            Evidencija.Controls.Add(label13);
            Evidencija.Location = new Point(4, 26);
            Evidencija.Name = "Evidencija";
            Evidencija.Padding = new Padding(3);
            Evidencija.Size = new Size(1307, 586);
            Evidencija.TabIndex = 1;
            Evidencija.Text = "Profili/Šabloni";
            Evidencija.UseVisualStyleBackColor = true;
            // 
            // TabelaSablona
            // 
            TabelaSablona.AllowUserToAddRows = false;
            TabelaSablona.AllowUserToDeleteRows = false;
            TabelaSablona.AllowUserToResizeColumns = false;
            TabelaSablona.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            TabelaSablona.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            TabelaSablona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            TabelaSablona.DefaultCellStyle = dataGridViewCellStyle5;
            TabelaSablona.Location = new Point(15, 284);
            TabelaSablona.MultiSelect = false;
            TabelaSablona.Name = "TabelaSablona";
            TabelaSablona.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            TabelaSablona.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            TabelaSablona.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelaSablona.Size = new Size(1277, 287);
            TabelaSablona.TabIndex = 54;
            // 
            // SRefresh
            // 
            SRefresh.Font = new Font("Microsoft Sans Serif", 12F);
            SRefresh.Location = new Point(115, 218);
            SRefresh.Name = "SRefresh";
            SRefresh.Size = new Size(95, 28);
            SRefresh.TabIndex = 53;
            SRefresh.Text = "Refresh";
            SRefresh.UseVisualStyleBackColor = true;
            SRefresh.Click += SRefresh_Click;
            // 
            // SObrisi
            // 
            SObrisi.Font = new Font("Microsoft Sans Serif", 12F);
            SObrisi.Location = new Point(1196, 218);
            SObrisi.Name = "SObrisi";
            SObrisi.Size = new Size(95, 28);
            SObrisi.TabIndex = 52;
            SObrisi.Text = "Obriši";
            SObrisi.UseVisualStyleBackColor = true;
            SObrisi.Click += SObrisi_Click;
            // 
            // SSacuvaj
            // 
            SSacuvaj.Font = new Font("Microsoft Sans Serif", 12F);
            SSacuvaj.Location = new Point(1095, 218);
            SSacuvaj.Name = "SSacuvaj";
            SSacuvaj.Size = new Size(95, 28);
            SSacuvaj.TabIndex = 51;
            SSacuvaj.Text = "Sačuvaj";
            SSacuvaj.UseVisualStyleBackColor = true;
            SSacuvaj.Click += SSacuvaj_Click;
            // 
            // SDodaj
            // 
            SDodaj.Font = new Font("Microsoft Sans Serif", 12F);
            SDodaj.Location = new Point(994, 218);
            SDodaj.Name = "SDodaj";
            SDodaj.Size = new Size(95, 28);
            SDodaj.TabIndex = 50;
            SDodaj.Text = "+ Dodaj novog";
            SDodaj.UseVisualStyleBackColor = true;
            SDodaj.Click += SDodajNovog_Click;
            // 
            // SIzmeni
            // 
            SIzmeni.Font = new Font("Microsoft Sans Serif", 12F);
            SIzmeni.Location = new Point(14, 218);
            SIzmeni.Name = "SIzmeni";
            SIzmeni.Size = new Size(95, 28);
            SIzmeni.TabIndex = 49;
            SIzmeni.Text = "Izmeni";
            SIzmeni.UseVisualStyleBackColor = true;
            SIzmeni.Click += SIzmeni_Click;
            // 
            // SSkola
            // 
            SSkola.DropDownStyle = ComboBoxStyle.DropDownList;
            SSkola.Font = new Font("Microsoft Sans Serif", 12F);
            SSkola.FormattingEnabled = true;
            SSkola.Items.AddRange(new object[] { "Treća beogradska gimnazija", "Prva beogradska gimnazija", "Peta beogradska gimnazija", "Deveta gimnazija \"Mihailo Petrović Alas\"", "Deseta gimnazija \"Mihajlo Pupin\"", "Četrnaesta beogradska gimnazija", "Četvrta beogradska gimnazija", "Trinaesta beogradska gimnazija", "Sedma beogradska gimnazija", "Osma beogradska gimnazija", "Dvanaesta beogradska gimnazija", "Gimnazija \"Patrijarh Pavle\"", "Zemunska gimnazija", "Šesta beogradska gimnazija", "Matematička gimnazija", "Filološka gimnazija", "Sportska gimnazija", "Gimnazija \"Sveti Sava\"", "Peta ekonomska škola \"Rakovica\"", "Prva ekonomska škola", "Druga ekonomska škola", "Pravno-poslovna škola Beograd", "Ekonomska škola \"Nada Dimić\"", "Medicinska škola \"Beograd\"", "Medicinska škola na Zvezdari", "Zubotehnička škola", "Farmaceutsko-fizioterapeutska škola", "Srednja medicinska škola \"Nadežda Petrović\"", "Elektrotehnička škola \"Nikola Tesla\"", "Elektrotehnička škola \"Stari grad\"", "Elektrotehnička škola \"Rade Končar\"", "Elektrotehnička škola \"Zemun\"", "Politehnika - škola za nove tehnologije", "Vazduhoplovna akademija", "Građevinska škola Beograd", "Arhitektonska tehnička škola", "Geodetska tehnička škola", "Saobraćajno-tehnička škola", "Tehnička škola GSP", "Ugostiteljsko-turistička škola", "Srednja turistička škola", "Trgovačka škola", "Hemijsko-prehrambena tehnološka škola", "Škola za negu lepote", "Škola za dizajn", "Tehnoart Beograd", "Muzička škola \"Mokranjac\"", "Muzička škola \"Stanković\"", "Baletska škola \"Lujo Davičo\"", "Škola za dizajn tekstila" });
            SSkola.Location = new Point(900, 90);
            SSkola.Name = "SSkola";
            SSkola.Size = new Size(391, 28);
            SSkola.TabIndex = 48;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 12F);
            label16.Location = new Point(841, 90);
            label16.Name = "label16";
            label16.Size = new Size(53, 20);
            label16.TabIndex = 47;
            label16.Text = "Škola:";
            // 
            // SPredmet3
            // 
            SPredmet3.DropDownStyle = ComboBoxStyle.DropDownList;
            SPredmet3.Font = new Font("Microsoft Sans Serif", 12F);
            SPredmet3.FormattingEnabled = true;
            SPredmet3.Location = new Point(110, 176);
            SPredmet3.Name = "SPredmet3";
            SPredmet3.Size = new Size(478, 28);
            SPredmet3.TabIndex = 45;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 12F);
            label17.Location = new Point(14, 177);
            label17.Name = "label17";
            label17.Size = new Size(90, 20);
            label17.TabIndex = 44;
            label17.Text = "3. Predmet:";
            // 
            // SPredmet2
            // 
            SPredmet2.DropDownStyle = ComboBoxStyle.DropDownList;
            SPredmet2.Font = new Font("Microsoft Sans Serif", 12F);
            SPredmet2.FormattingEnabled = true;
            SPredmet2.Items.AddRange(new object[] { "Matematika" });
            SPredmet2.Location = new Point(110, 147);
            SPredmet2.Name = "SPredmet2";
            SPredmet2.Size = new Size(478, 28);
            SPredmet2.TabIndex = 43;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 12F);
            label18.Location = new Point(14, 148);
            label18.Name = "label18";
            label18.Size = new Size(90, 20);
            label18.TabIndex = 42;
            label18.Text = "2. Predmet:";
            // 
            // SPredmet1
            // 
            SPredmet1.DropDownStyle = ComboBoxStyle.DropDownList;
            SPredmet1.Font = new Font("Microsoft Sans Serif", 12F);
            SPredmet1.FormattingEnabled = true;
            SPredmet1.Items.AddRange(new object[] { "Srpski jezik i književnost", "Albanski jezik i književnost", "Bosanski jezik i književnost", "Bugarski jezik i književnost", "Mađarski jezik i književnost", "Rumunski jezik i književnost", "Rusinski jezik i književnost", "Slovački jezik i književnost", "Hrvatski jezik i književnost" });
            SPredmet1.Location = new Point(110, 118);
            SPredmet1.Name = "SPredmet1";
            SPredmet1.Size = new Size(478, 28);
            SPredmet1.TabIndex = 41;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 12F);
            label19.Location = new Point(14, 119);
            label19.Name = "label19";
            label19.Size = new Size(90, 20);
            label19.TabIndex = 40;
            label19.Text = "1. Predmet:";
            // 
            // STipMature
            // 
            STipMature.DropDownStyle = ComboBoxStyle.DropDownList;
            STipMature.Font = new Font("Microsoft Sans Serif", 12F);
            STipMature.FormattingEnabled = true;
            STipMature.Items.AddRange(new object[] { "OPŠTA MATURA", "STRUČNA MATURA", "UMETNIČKA MATURA" });
            STipMature.Location = new Point(110, 89);
            STipMature.Name = "STipMature";
            STipMature.Size = new Size(478, 28);
            STipMature.TabIndex = 39;
            STipMature.SelectedIndexChanged += STipMature_SelectedIndexChanged;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft Sans Serif", 12F);
            label20.Location = new Point(14, 90);
            label20.Name = "label20";
            label20.Size = new Size(88, 20);
            label20.TabIndex = 38;
            label20.Text = "Tip Mature:";
            // 
            // SJezik
            // 
            SJezik.DropDownStyle = ComboBoxStyle.DropDownList;
            SJezik.Font = new Font("Microsoft Sans Serif", 12F);
            SJezik.FormattingEnabled = true;
            SJezik.Items.AddRange(new object[] { "Srpski jezik i književnost", "Albanski jezik i književnost", "Bosanski jezik i književnost", "Bugarski jezik i književnost", "Mađarski jezik i književnost", "Rumunski jezik i književnost", "Rusinski jezik i književnost", "Slovački jezik i književnost", "Hrvatski jezik i književnost" });
            SJezik.Location = new Point(900, 148);
            SJezik.Name = "SJezik";
            SJezik.Size = new Size(391, 28);
            SJezik.TabIndex = 37;
            // 
            // SOdeljenje
            // 
            SOdeljenje.DropDownStyle = ComboBoxStyle.DropDownList;
            SOdeljenje.Font = new Font("Microsoft Sans Serif", 12F);
            SOdeljenje.FormattingEnabled = true;
            SOdeljenje.Items.AddRange(new object[] { "III-1", "III-2", "III-3", "III-4", "IV-1", "IV-2", "IV-3", "IV-4" });
            SOdeljenje.Location = new Point(900, 119);
            SOdeljenje.Name = "SOdeljenje";
            SOdeljenje.Size = new Size(391, 28);
            SOdeljenje.TabIndex = 36;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Microsoft Sans Serif", 12F);
            label22.Location = new Point(845, 148);
            label22.Name = "label22";
            label22.Size = new Size(49, 20);
            label22.TabIndex = 35;
            label22.Text = "Jezik:";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Microsoft Sans Serif", 12F);
            label23.Location = new Point(819, 119);
            label23.Name = "label23";
            label23.Size = new Size(79, 20);
            label23.TabIndex = 34;
            label23.Text = "Odeljenje:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F);
            label15.Location = new Point(14, 49);
            label15.Name = "label15";
            label15.Size = new Size(111, 20);
            label15.TabIndex = 30;
            label15.Text = "Naziv šablona:";
            // 
            // tNazivSablona
            // 
            tNazivSablona.Location = new Point(131, 48);
            tNazivSablona.Name = "tNazivSablona";
            tNazivSablona.Size = new Size(265, 25);
            tNazivSablona.TabIndex = 29;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label14.Location = new Point(14, 22);
            label14.Name = "label14";
            label14.Size = new Size(266, 20);
            label14.TabIndex = 2;
            label14.Text = "KREIRANJE NOVOG ŠABLONA";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.Location = new Point(15, 256);
            label13.Name = "label13";
            label13.Size = new Size(164, 21);
            label13.TabIndex = 1;
            label13.Text = "POSTOJEĆI ŠABLONI";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 636);
            Controls.Add(tabControl1);
            MaximumSize = new Size(1355, 675);
            MinimumSize = new Size(1355, 675);
            Name = "Form";
            Text = "Projekat Drzavna Matura";
            Load += Form_Load;
            tabControl1.ResumeLayout(false);
            Profili.ResumeLayout(false);
            Profili.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TabelaSvihUnetihUcenika).EndInit();
            Evidencija.ResumeLayout(false);
            Evidencija.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TabelaSablona).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Profili;
        private TabPage Evidencija;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tIme;
        private Button Primeni;
        private ComboBox Predmet3;
        private Label label10;
        private ComboBox Predmet2;
        private Label label11;
        private ComboBox Predmet1;
        private Label label9;
        private ComboBox TipMature;
        private Label label8;
        private ComboBox Jezik;
        private ComboBox Odeljenje;
        private ComboBox Sabloni;
        private DataGridView TabelaSvihUnetihUcenika;
        private Label label12;
        private Button Obrisi;
        private Button Sacuvaj;
        private Button DodajNovog;
        private Button Izmeni;
        private TextBox tPrezime;
        private Label label14;
        private Label label13;
        private Label label15;
        private TextBox tNazivSablona;
        private ComboBox Skola;
        private Label label21;
        private Button Refresh;
        private ComboBox SSkola;
        private Label label16;
        private ComboBox SPredmet3;
        private Label label17;
        private ComboBox SPredmet2;
        private Label label18;
        private ComboBox SPredmet1;
        private Label label19;
        private ComboBox STipMature;
        private Label label20;
        private ComboBox SJezik;
        private ComboBox SOdeljenje;
        private Label label22;
        private Label label23;
        private Button SRefresh;
        private Button SObrisi;
        private Button SSacuvaj;
        private Button SDodaj;
        private Button SIzmeni;
        private DataGridView TabelaSablona;
    }
}
