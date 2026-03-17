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
            tabControl1 = new TabControl();
            Profili = new TabPage();
            Skola = new ComboBox();
            label21 = new Label();
            tPrezime = new TextBox();
            TabelaSvihUnetihUcenika = new DataGridView();
            label12 = new Label();
            Obrisi = new Button();
            Sacuvaj = new Button();
            DodajNovog = new Button();
            Sledeci = new Button();
            Prethodni = new Button();
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
            ObrisiSablon = new Button();
            SacuvajSablon = new Button();
            Predmet3S = new ComboBox();
            label20 = new Label();
            Predmet2S = new ComboBox();
            label19 = new Label();
            Predmet1S = new ComboBox();
            label18 = new Label();
            JezikS = new ComboBox();
            label17 = new Label();
            TipMatureS = new ComboBox();
            label16 = new Label();
            label15 = new Label();
            tNazivSablona = new TextBox();
            TabelaSablona = new DataGridView();
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
            tabControl1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tabControl1.Location = new Point(12, 8);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(929, 577);
            tabControl1.TabIndex = 0;
            // 
            // Profili
            // 
            Profili.Controls.Add(Skola);
            Profili.Controls.Add(label21);
            Profili.Controls.Add(tPrezime);
            Profili.Controls.Add(TabelaSvihUnetihUcenika);
            Profili.Controls.Add(label12);
            Profili.Controls.Add(Obrisi);
            Profili.Controls.Add(Sacuvaj);
            Profili.Controls.Add(DodajNovog);
            Profili.Controls.Add(Sledeci);
            Profili.Controls.Add(Prethodni);
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
            Profili.Location = new Point(4, 24);
            Profili.Name = "Profili";
            Profili.Padding = new Padding(3);
            Profili.Size = new Size(921, 549);
            Profili.TabIndex = 0;
            Profili.Text = "Evidencija Maturanata";
            Profili.UseVisualStyleBackColor = true;
            // 
            // Skola
            // 
            Skola.DropDownStyle = ComboBoxStyle.DropDownList;
            Skola.FormattingEnabled = true;
            Skola.Items.AddRange(new object[] { "Treća beogradska gimnazija", "Prva beogradska gimnazija", "Peta beogradska gimnazija", "Deveta gimnazija \"Mihailo Petrović Alas\"", "Deseta gimnazija \"Mihajlo Pupin\"", "Četrnaesta beogradska gimnazija", "Četvrta beogradska gimnazija", "Trinaesta beogradska gimnazija", "Sedma beogradska gimnazija", "Osma beogradska gimnazija", "Dvanaesta beogradska gimnazija", "Gimnazija \"Patrijarh Pavle\"", "Zemunska gimnazija", "Šesta beogradska gimnazija", "Matematička gimnazija", "Filološka gimnazija", "Sportska gimnazija", "Gimnazija \"Sveti Sava\"", "Peta ekonomska škola \"Rakovica\"", "Prva ekonomska škola", "Druga ekonomska škola", "Pravno-poslovna škola Beograd", "Ekonomska škola \"Nada Dimić\"", "Medicinska škola \"Beograd\"", "Medicinska škola na Zvezdari", "Zubotehnička škola", "Farmaceutsko-fizioterapeutska škola", "Srednja medicinska škola \"Nadežda Petrović\"", "Elektrotehnička škola \"Nikola Tesla\"", "Elektrotehnička škola \"Stari grad\"", "Elektrotehnička škola \"Rade Končar\"", "Elektrotehnička škola \"Zemun\"", "Politehnika - škola za nove tehnologije", "Vazduhoplovna akademija", "Građevinska škola Beograd", "Arhitektonska tehnička škola", "Geodetska tehnička škola", "Saobraćajno-tehnička škola", "Tehnička škola GSP", "Ugostiteljsko-turistička škola", "Srednja turistička škola", "Trgovačka škola", "Hemijsko-prehrambena tehnološka škola", "Škola za negu lepote", "Škola za dizajn", "Tehnoart Beograd", "Muzička škola \"Mokranjac\"", "Muzička škola \"Stanković\"", "Baletska škola \"Lujo Davičo\"", "Škola za dizajn tekstila" });
            Skola.Location = new Point(620, 153);
            Skola.Name = "Skola";
            Skola.Size = new Size(286, 23);
            Skola.TabIndex = 30;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(576, 156);
            label21.Name = "label21";
            label21.Size = new Size(38, 15);
            label21.TabIndex = 29;
            label21.Text = "Škola:";
            // 
            // tPrezime
            // 
            tPrezime.Location = new Point(258, 108);
            tPrezime.Name = "tPrezime";
            tPrezime.Size = new Size(144, 23);
            tPrezime.TabIndex = 28;
            // 
            // TabelaSvihUnetihUcenika
            // 
            TabelaSvihUnetihUcenika.AllowUserToAddRows = false;
            TabelaSvihUnetihUcenika.AllowUserToDeleteRows = false;
            TabelaSvihUnetihUcenika.AllowUserToOrderColumns = true;
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
            TabelaSvihUnetihUcenika.Location = new Point(14, 323);
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
            TabelaSvihUnetihUcenika.Size = new Size(892, 205);
            TabelaSvihUnetihUcenika.TabIndex = 27;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.Location = new Point(14, 305);
            label12.Name = "label12";
            label12.Size = new Size(180, 15);
            label12.TabIndex = 26;
            label12.Text = "SPISAK SVIH UNETIH UCENIKA";
            // 
            // Obrisi
            // 
            Obrisi.Location = new Point(811, 269);
            Obrisi.Name = "Obrisi";
            Obrisi.Size = new Size(95, 23);
            Obrisi.TabIndex = 25;
            Obrisi.Text = "Obriši";
            Obrisi.UseVisualStyleBackColor = true;
            Obrisi.Click += Obrisi_Click;
            // 
            // Sacuvaj
            // 
            Sacuvaj.Location = new Point(710, 269);
            Sacuvaj.Name = "Sacuvaj";
            Sacuvaj.Size = new Size(95, 23);
            Sacuvaj.TabIndex = 24;
            Sacuvaj.Text = "Sačuvaj";
            Sacuvaj.UseVisualStyleBackColor = true;
            Sacuvaj.Click += Sacuvaj_Click;
            // 
            // DodajNovog
            // 
            DodajNovog.Location = new Point(609, 269);
            DodajNovog.Name = "DodajNovog";
            DodajNovog.Size = new Size(95, 23);
            DodajNovog.TabIndex = 23;
            DodajNovog.Text = "+ Dodaj novog";
            DodajNovog.UseVisualStyleBackColor = true;
            DodajNovog.Click += DodajNovog_Click;
            // 
            // Sledeci
            // 
            Sledeci.Location = new Point(115, 269);
            Sledeci.Name = "Sledeci";
            Sledeci.Size = new Size(95, 23);
            Sledeci.TabIndex = 22;
            Sledeci.Text = "Sledeći >>";
            Sledeci.UseVisualStyleBackColor = true;
            Sledeci.Click += Sledeci_Click;
            // 
            // Prethodni
            // 
            Prethodni.Location = new Point(14, 269);
            Prethodni.Name = "Prethodni";
            Prethodni.Size = new Size(95, 23);
            Prethodni.TabIndex = 21;
            Prethodni.Text = "<< Prethodni";
            Prethodni.UseVisualStyleBackColor = true;
            Prethodni.Click += Prethodni_Click;
            // 
            // Predmet3
            // 
            Predmet3.DropDownStyle = ComboBoxStyle.DropDownList;
            Predmet3.FormattingEnabled = true;
            Predmet3.Items.AddRange(new object[] { "Biologija", "Geografija", "Engleski jezik", "Istorija", "Italijanski jezik", "Nemački jezik", "Ruski jezik", "Srpski kao nematernji jezik", "Fizika", "Francuski jezik", "Hemija", "Španski jezik", "Zootehničar", "Tehničar za biotehnologiju", "Tehničar poljoprivredne tehnike", "Tehničar hortikulture", "Tehničar za pejzažnu arhitekturu", "Šumarski tehničar", "Geološki tehničar za geotehniku i hidrogeologiju", "Geološki tehničar za istraživanje mineralnih sirovina", "Rudarski tehničar", "Rudarski tehničar za pripremu mineralnih sirovina", "Brodomašinski tehničar", "Mašinski tehničar za kompjutersko konstruisanje", "Mašinski tehničar merne i regulacione tehnike", "Mašinski tehničar motornih vozila", "Tehničar grejanja i klimatizacije", "Tehničar za kompjutersko upravljanje (CNC) mašina", "Tehničar za robotiku", "Tehničar mašinske energetike", "Tehničar optike", "Objedinjeni test za obrazovne profile:", "Elektrotehničar automatike", "Elektrotehničar elektromotornih pogona", "Elektrotehničar elektronike", "Elektrotehničar energetike", "Elektrotehničar za termičke i rashladne uređaje", "Elektrotehničar informacionih tehnologija", "Elektrotehničar procesnog upravljanja", "Elektrotehničar računara", "Tehničar grafičke dorade", "Tehničar za zaštitu životne sredine", "Tehničar za industrijsku farmaceutsku tehnologiju", "Tehničar štampe", "Fotograf", "Hemijski laborant", "Hemijsko-tehnološki tehničar", "Tekstilni tehničar", "Građevinski tehničar za laboratorijska ispitivanja", "Građevinski tehničar za hidrogradnju", "Izvođač instalaterskih i završnih građevinskih radova", "Nautički tehničar – rečni smer", "Saobraćajno-transportni tehničar", "Tehničar vuče", "Tehničar PTT saobraćaja", "Tehničar unutrašnjeg transporta", "Transportni komercijalista", "Objedinjeni test za obrazovne profile: Aranžer u trgovini i Trgovinski tehničar", "Kulinarski tehničar", "Ugostiteljski tehničar", "Objedinjeni test za obrazovne profile:", "Ekonomski tehničar", "Finansijski tehničar", "Carinski tehničar", "Ginekološko-akušerska sestra", "Zubni tehničar", "Medicinska sestra – vaspitač", "Pedijatrijska sestra – tehničar", "Sanitarno-ekološki tehničar", "Scenski masker i vlasuljar", "Solfeđo i harmonija" });
            Predmet3.Location = new Point(87, 237);
            Predmet3.Name = "Predmet3";
            Predmet3.Size = new Size(286, 23);
            Predmet3.TabIndex = 20;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 240);
            label10.Name = "label10";
            label10.Size = new Size(67, 15);
            label10.TabIndex = 19;
            label10.Text = "3. Predmet:";
            // 
            // Predmet2
            // 
            Predmet2.DropDownStyle = ComboBoxStyle.DropDownList;
            Predmet2.FormattingEnabled = true;
            Predmet2.Items.AddRange(new object[] { "Matematika" });
            Predmet2.Location = new Point(87, 208);
            Predmet2.Name = "Predmet2";
            Predmet2.Size = new Size(286, 23);
            Predmet2.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(14, 211);
            label11.Name = "label11";
            label11.Size = new Size(67, 15);
            label11.TabIndex = 17;
            label11.Text = "2. Predmet:";
            // 
            // Predmet1
            // 
            Predmet1.DropDownStyle = ComboBoxStyle.DropDownList;
            Predmet1.FormattingEnabled = true;
            Predmet1.Items.AddRange(new object[] { "Srpski jezik i književnost", "Albanski jezik i književnost", "Bosanski jezik i književnost", "Bugarski jezik i književnost", "Mađarski jezik i književnost", "Rumunski jezik i književnost", "Rusinski jezik i književnost", "Slovački jezik i književnost", "Hrvatski jezik i književnost" });
            Predmet1.Location = new Point(87, 179);
            Predmet1.Name = "Predmet1";
            Predmet1.Size = new Size(286, 23);
            Predmet1.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 182);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 15;
            label9.Text = "1. Predmet:";
            // 
            // TipMature
            // 
            TipMature.DropDownStyle = ComboBoxStyle.DropDownList;
            TipMature.FormattingEnabled = true;
            TipMature.Items.AddRange(new object[] { "OPŠTA MATURA", "STRUČNA MATURA", "UMETNIČKA MATURA" });
            TipMature.Location = new Point(87, 150);
            TipMature.Name = "TipMature";
            TipMature.Size = new Size(286, 23);
            TipMature.TabIndex = 14;
            TipMature.SelectedIndexChanged += TipMature_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(14, 153);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 13;
            label8.Text = "Tip Mature:";
            // 
            // Jezik
            // 
            Jezik.DropDownStyle = ComboBoxStyle.DropDownList;
            Jezik.FormattingEnabled = true;
            Jezik.Items.AddRange(new object[] { "Srpski jezik i književnost", "Albanski jezik i književnost", "Bosanski jezik i književnost", "Bugarski jezik i književnost", "Mađarski jezik i književnost", "Rumunski jezik i književnost", "Rusinski jezik i književnost", "Slovački jezik i književnost", "Hrvatski jezik i književnost" });
            Jezik.Location = new Point(620, 211);
            Jezik.Name = "Jezik";
            Jezik.Size = new Size(286, 23);
            Jezik.TabIndex = 12;
            Jezik.SelectedIndexChanged += Jezik_SelectedIndexChanged;
            // 
            // Odeljenje
            // 
            Odeljenje.DropDownStyle = ComboBoxStyle.DropDownList;
            Odeljenje.FormattingEnabled = true;
            Odeljenje.Items.AddRange(new object[] { "III-1", "III-2", "III-3", "III-4", "IV-1", "IV-2", "IV-3", "IV-4" });
            Odeljenje.Location = new Point(620, 182);
            Odeljenje.Name = "Odeljenje";
            Odeljenje.Size = new Size(286, 23);
            Odeljenje.TabIndex = 11;
            // 
            // Sabloni
            // 
            Sabloni.DropDownStyle = ComboBoxStyle.DropDownList;
            Sabloni.FormattingEnabled = true;
            Sabloni.Location = new Point(121, 46);
            Sabloni.Name = "Sabloni";
            Sabloni.Size = new Size(281, 23);
            Sabloni.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(580, 214);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 9;
            label7.Text = "Jezik:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(554, 185);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 8;
            label6.Text = "Odeljenje:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(200, 111);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 7;
            label5.Text = "Prezime:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 111);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 5;
            label4.Text = "Ime:";
            // 
            // tIme
            // 
            tIme.BackColor = Color.White;
            tIme.Location = new Point(50, 108);
            tIme.Name = "tIme";
            tIme.Size = new Size(144, 23);
            tIme.TabIndex = 4;
            // 
            // Primeni
            // 
            Primeni.Location = new Point(408, 46);
            Primeni.Name = "Primeni";
            Primeni.Size = new Size(128, 23);
            Primeni.TabIndex = 3;
            Primeni.Text = "Primeni";
            Primeni.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 50);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 2;
            label3.Text = "Učitaj Šablon:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(14, 82);
            label2.Name = "label2";
            label2.Size = new Size(180, 15);
            label2.TabIndex = 1;
            label2.Text = "PODACI O UČENIKU I ISPITIMA";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(14, 22);
            label1.Name = "label1";
            label1.Size = new Size(155, 15);
            label1.TabIndex = 0;
            label1.Text = "BRZI UNOS (Izbor šablona)";
            // 
            // Evidencija
            // 
            Evidencija.Controls.Add(ObrisiSablon);
            Evidencija.Controls.Add(SacuvajSablon);
            Evidencija.Controls.Add(Predmet3S);
            Evidencija.Controls.Add(label20);
            Evidencija.Controls.Add(Predmet2S);
            Evidencija.Controls.Add(label19);
            Evidencija.Controls.Add(Predmet1S);
            Evidencija.Controls.Add(label18);
            Evidencija.Controls.Add(JezikS);
            Evidencija.Controls.Add(label17);
            Evidencija.Controls.Add(TipMatureS);
            Evidencija.Controls.Add(label16);
            Evidencija.Controls.Add(label15);
            Evidencija.Controls.Add(tNazivSablona);
            Evidencija.Controls.Add(TabelaSablona);
            Evidencija.Controls.Add(label14);
            Evidencija.Controls.Add(label13);
            Evidencija.Location = new Point(4, 24);
            Evidencija.Name = "Evidencija";
            Evidencija.Padding = new Padding(3);
            Evidencija.Size = new Size(921, 549);
            Evidencija.TabIndex = 1;
            Evidencija.Text = "Profili/Šabloni";
            Evidencija.UseVisualStyleBackColor = true;
            // 
            // ObrisiSablon
            // 
            ObrisiSablon.Font = new Font("Segoe UI", 9F);
            ObrisiSablon.Location = new Point(533, 245);
            ObrisiSablon.Name = "ObrisiSablon";
            ObrisiSablon.Size = new Size(119, 23);
            ObrisiSablon.TabIndex = 42;
            ObrisiSablon.Text = "Obriši";
            ObrisiSablon.UseVisualStyleBackColor = true;
            // 
            // SacuvajSablon
            // 
            SacuvajSablon.Font = new Font("Segoe UI", 9F);
            SacuvajSablon.Location = new Point(357, 245);
            SacuvajSablon.Name = "SacuvajSablon";
            SacuvajSablon.Size = new Size(119, 23);
            SacuvajSablon.TabIndex = 41;
            SacuvajSablon.Text = "+ Sačuvaj šablon";
            SacuvajSablon.UseVisualStyleBackColor = true;
            // 
            // Predmet3S
            // 
            Predmet3S.DropDownStyle = ComboBoxStyle.DropDownList;
            Predmet3S.FormattingEnabled = true;
            Predmet3S.Location = new Point(451, 214);
            Predmet3S.Name = "Predmet3S";
            Predmet3S.Size = new Size(201, 23);
            Predmet3S.TabIndex = 40;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F);
            label20.Location = new Point(357, 217);
            label20.Name = "label20";
            label20.Size = new Size(67, 15);
            label20.TabIndex = 39;
            label20.Text = "3. Predmet:";
            // 
            // Predmet2S
            // 
            Predmet2S.DropDownStyle = ComboBoxStyle.DropDownList;
            Predmet2S.FormattingEnabled = true;
            Predmet2S.Location = new Point(451, 181);
            Predmet2S.Name = "Predmet2S";
            Predmet2S.Size = new Size(201, 23);
            Predmet2S.TabIndex = 38;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9F);
            label19.Location = new Point(357, 184);
            label19.Name = "label19";
            label19.Size = new Size(67, 15);
            label19.TabIndex = 37;
            label19.Text = "2. Predmet:";
            // 
            // Predmet1S
            // 
            Predmet1S.DropDownStyle = ComboBoxStyle.DropDownList;
            Predmet1S.FormattingEnabled = true;
            Predmet1S.Location = new Point(451, 148);
            Predmet1S.Name = "Predmet1S";
            Predmet1S.Size = new Size(201, 23);
            Predmet1S.TabIndex = 36;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F);
            label18.Location = new Point(357, 151);
            label18.Name = "label18";
            label18.Size = new Size(67, 15);
            label18.TabIndex = 35;
            label18.Text = "1. Predmet:";
            // 
            // JezikS
            // 
            JezikS.DropDownStyle = ComboBoxStyle.DropDownList;
            JezikS.FormattingEnabled = true;
            JezikS.Location = new Point(451, 115);
            JezikS.Name = "JezikS";
            JezikS.Size = new Size(201, 23);
            JezikS.TabIndex = 34;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9F);
            label17.Location = new Point(357, 118);
            label17.Name = "label17";
            label17.Size = new Size(77, 15);
            label17.TabIndex = 33;
            label17.Text = "Jezik nastave:";
            // 
            // TipMatureS
            // 
            TipMatureS.DropDownStyle = ComboBoxStyle.DropDownList;
            TipMatureS.FormattingEnabled = true;
            TipMatureS.Location = new Point(451, 82);
            TipMatureS.Name = "TipMatureS";
            TipMatureS.Size = new Size(201, 23);
            TipMatureS.TabIndex = 32;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F);
            label16.Location = new Point(357, 85);
            label16.Name = "label16";
            label16.Size = new Size(67, 15);
            label16.TabIndex = 31;
            label16.Text = "Tip mature:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F);
            label15.Location = new Point(357, 43);
            label15.Name = "label15";
            label15.Size = new Size(83, 15);
            label15.TabIndex = 30;
            label15.Text = "Naziv šablona:";
            // 
            // tNazivSablona
            // 
            tNazivSablona.Location = new Point(451, 40);
            tNazivSablona.Name = "tNazivSablona";
            tNazivSablona.Size = new Size(201, 23);
            tNazivSablona.TabIndex = 29;
            // 
            // TabelaSablona
            // 
            TabelaSablona.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TabelaSablona.Location = new Point(14, 40);
            TabelaSablona.Name = "TabelaSablona";
            TabelaSablona.ReadOnly = true;
            TabelaSablona.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TabelaSablona.Size = new Size(323, 228);
            TabelaSablona.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.Location = new Point(357, 22);
            label14.Name = "label14";
            label14.Size = new Size(174, 15);
            label14.TabIndex = 2;
            label14.Text = "KREIRANJE NOVOG ŠABLONA";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(14, 22);
            label13.Name = "label13";
            label13.Size = new Size(122, 15);
            label13.TabIndex = 1;
            label13.Text = "POSTOJEĆI ŠABLONI";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 611);
            Controls.Add(tabControl1);
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
        private Button Sledeci;
        private Button Prethodni;
        private TextBox tPrezime;
        private Label label14;
        private Label label13;
        private Label label15;
        private TextBox tNazivSablona;
        private DataGridView TabelaSablona;
        private Button ObrisiSablon;
        private Button SacuvajSablon;
        private ComboBox Predmet3S;
        private Label label20;
        private ComboBox Predmet2S;
        private Label label19;
        private ComboBox Predmet1S;
        private Label label18;
        private ComboBox JezikS;
        private Label label17;
        private ComboBox TipMatureS;
        private Label label16;
        private ComboBox Skola;
        private Label label21;
    }
}
