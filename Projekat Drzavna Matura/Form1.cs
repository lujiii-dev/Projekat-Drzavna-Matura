using System.IO;

namespace Projekat_Drzavna_Matura
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            ProcitajSablon();

            TabelaSvihUnetihUcenika.Columns.Add("ImePrezime", "Ime i prezime");
            TabelaSvihUnetihUcenika.Columns.Add("Skola", "Škola");
            TabelaSvihUnetihUcenika.Columns.Add("Odeljenje", "Odeljenje");
            TabelaSvihUnetihUcenika.Columns.Add("TipMature", "Tip mature");
            TabelaSvihUnetihUcenika.Columns.Add("Jezik", "Jezik");
            TabelaSvihUnetihUcenika.Columns.Add("PrviPredmet", "1. Predmet");
            TabelaSvihUnetihUcenika.Columns.Add("DrugiPredmet", "2. Predmet");
            TabelaSvihUnetihUcenika.Columns.Add("TreciPredmet", "3. Predmet");

            TabelaSvihUnetihUcenika.Columns[0].Width = 125;
            TabelaSvihUnetihUcenika.Columns[1].Width = 245;
            TabelaSvihUnetihUcenika.Columns[2].Width = 65;
            TabelaSvihUnetihUcenika.Columns[3].Width = 126;
            TabelaSvihUnetihUcenika.Columns[4].Width = 155;
            TabelaSvihUnetihUcenika.Columns[5].Width = 155;
            TabelaSvihUnetihUcenika.Columns[6].Width = 90;
            TabelaSvihUnetihUcenika.Columns[7].Width = 273;

            OsveziTabelu();

            TabelaSablona.Columns.Add("Naziv", "Naziv");
            TabelaSablona.Columns.Add("Skola", "Škola");
            TabelaSablona.Columns.Add("Odeljenje", "Odeljenje");
            TabelaSablona.Columns.Add("TipMature", "Tip mature");
            TabelaSablona.Columns.Add("Jezik", "Jezik");
            TabelaSablona.Columns.Add("PrviPredmet", "1. Predmet");
            TabelaSablona.Columns.Add("DrugiPredmet", "2. Predmet");
            TabelaSablona.Columns.Add("TreciPredmet", "3. Predmet");

            TabelaSablona.Columns[0].Width = 125;
            TabelaSablona.Columns[1].Width = 245;
            TabelaSablona.Columns[2].Width = 65;
            TabelaSablona.Columns[3].Width = 126;
            TabelaSablona.Columns[4].Width = 155;
            TabelaSablona.Columns[5].Width = 155;
            TabelaSablona.Columns[6].Width = 90;
            TabelaSablona.Columns[7].Width = 273;

            SOsveziTabelu();
        }

        private void STipMature_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPredmet3.Items.Clear();

            if (STipMature.SelectedIndex == -1)
                return;

            string izabraniTip = STipMature.SelectedItem.ToString();

            if (izabraniTip == "OPŠTA MATURA")
            {
                SPredmet3.Items.Add("Biologija");
                SPredmet3.Items.Add("Geografija");
                SPredmet3.Items.Add("Engleski jezik");
                SPredmet3.Items.Add("Istorija");
                SPredmet3.Items.Add("Italijanski jezik");
                SPredmet3.Items.Add("Nemački jezik");
                SPredmet3.Items.Add("Ruski jezik");
                SPredmet3.Items.Add("Srpski kao nematernji jezik");
                SPredmet3.Items.Add("Fizika");
                SPredmet3.Items.Add("Francuski jezik");
                SPredmet3.Items.Add("Hemija");
                SPredmet3.Items.Add("Španski jezik");
            }
            else if (izabraniTip == "STRUČNA MATURA")
            {
                SPredmet3.Items.Add("Zootehničar");
                SPredmet3.Items.Add("Tehničar za biotehnologiju");
                SPredmet3.Items.Add("Tehničar poljoprivredne tehnike");
                SPredmet3.Items.Add("Tehničar hortikulture");
                SPredmet3.Items.Add("Tehničar za pejzažnu arhitekturu");
                SPredmet3.Items.Add("Šumarski tehničar");
                SPredmet3.Items.Add("Geološki tehničar za geotehniku i hidrogeologiju");
                SPredmet3.Items.Add("Geološki tehničar za istraživanje mineralnih sirovina");
                SPredmet3.Items.Add("Rudarski tehničar");
                SPredmet3.Items.Add("Rudarski tehničar za pripremu mineralnih sirovina");
                SPredmet3.Items.Add("Brodomašinski tehničar");
                SPredmet3.Items.Add("Mašinski tehničar za kompjutersko konstruisanje");
                SPredmet3.Items.Add("Mašinski tehničar merne i regulacione tehnike");
                SPredmet3.Items.Add("Mašinski tehničar motornih vozila");
                SPredmet3.Items.Add("Tehničar grejanja i klimatizacije");
                SPredmet3.Items.Add("Tehničar za kompjutersko upravljanje (CNC) mašina");
                SPredmet3.Items.Add("Tehničar za robotiku");
                SPredmet3.Items.Add("Tehničar mašinske energetike");
                SPredmet3.Items.Add("Tehničar optike");
                SPredmet3.Items.Add("Elektrotehničar automatike");
                SPredmet3.Items.Add("Elektrotehničar elektromotornih pogona");
                SPredmet3.Items.Add("Elektrotehničar elektronike");
                SPredmet3.Items.Add("Elektrotehničar energetike");
                SPredmet3.Items.Add("Elektrotehničar za termičke i rashladne uređaje");
                SPredmet3.Items.Add("Elektrotehničar informacionih tehnologija");
                SPredmet3.Items.Add("Elektrotehničar procesnog upravljanja");
                SPredmet3.Items.Add("Elektrotehničar računara");
                SPredmet3.Items.Add("Tehničar grafičke dorade");
                SPredmet3.Items.Add("Tehničar za zaštitu životne sredine");
                SPredmet3.Items.Add("Tehničar za industrijsku farmaceutsku tehnologiju");
                SPredmet3.Items.Add("Tehničar štampe");
                SPredmet3.Items.Add("Fotograf");
                SPredmet3.Items.Add("Hemijski laborant");
                SPredmet3.Items.Add("Hemijsko-tehnološki tehničar");
                SPredmet3.Items.Add("Tekstilni tehničar");
                SPredmet3.Items.Add("Građevinski tehničar za laboratorijska ispitivanja");
                SPredmet3.Items.Add("Građevinski tehničar za hidrogradnju");
                SPredmet3.Items.Add("Izvođač instalaterskih i završnih građevinskih radova");
                SPredmet3.Items.Add("Nautički tehničar – rečni smer");
                SPredmet3.Items.Add("Saobraćajno-transportni tehničar");
                SPredmet3.Items.Add("Tehničar vuče");
                SPredmet3.Items.Add("Tehničar PTT saobraćaja");
                SPredmet3.Items.Add("Tehničar unutrašnjeg transporta");
                SPredmet3.Items.Add("Transportni komercijalista");
                SPredmet3.Items.Add("Kulinarski tehničar");
                SPredmet3.Items.Add("Ugostiteljski tehničar");
                SPredmet3.Items.Add("Ekonomski tehničar");
                SPredmet3.Items.Add("Finansijski tehničar");
                SPredmet3.Items.Add("Carinski tehničar");
                SPredmet3.Items.Add("Ginekološko-akušerska sestra");
                SPredmet3.Items.Add("Zubni tehničar");
                SPredmet3.Items.Add("Medicinska sestra – vaspitač");
                SPredmet3.Items.Add("Pedijatrijska sestra – tehničar");
                SPredmet3.Items.Add("Sanitarno-ekološki tehničar");
                SPredmet3.Items.Add("Scenski masker i vlasuljar");
            }
            else if (izabraniTip == "UMETNIČKA MATURA")
            {
                SPredmet3.Items.Add("Solfeđo i harmonija");
            }
        }
        private void TipMature_SelectedIndexChanged(object sender, EventArgs e)
        {
            Predmet3.Items.Clear();

            if (TipMature.SelectedIndex == -1)
                return;

            string izabraniTip = TipMature.SelectedItem.ToString();

            if (izabraniTip == "OPŠTA MATURA")
            {
                Predmet3.Items.Add("Biologija");
                Predmet3.Items.Add("Geografija");
                Predmet3.Items.Add("Engleski jezik");
                Predmet3.Items.Add("Istorija");
                Predmet3.Items.Add("Italijanski jezik");
                Predmet3.Items.Add("Nemački jezik");
                Predmet3.Items.Add("Ruski jezik");
                Predmet3.Items.Add("Srpski kao nematernji jezik");
                Predmet3.Items.Add("Fizika");
                Predmet3.Items.Add("Francuski jezik");
                Predmet3.Items.Add("Hemija");
                Predmet3.Items.Add("Španski jezik");
            }
            else if (izabraniTip == "STRUČNA MATURA")
            {
                Predmet3.Items.Add("Zootehničar");
                Predmet3.Items.Add("Tehničar za biotehnologiju");
                Predmet3.Items.Add("Tehničar poljoprivredne tehnike");
                Predmet3.Items.Add("Tehničar hortikulture");
                Predmet3.Items.Add("Tehničar za pejzažnu arhitekturu");
                Predmet3.Items.Add("Šumarski tehničar");
                Predmet3.Items.Add("Geološki tehničar za geotehniku i hidrogeologiju");
                Predmet3.Items.Add("Geološki tehničar za istraživanje mineralnih sirovina");
                Predmet3.Items.Add("Rudarski tehničar");
                Predmet3.Items.Add("Rudarski tehničar za pripremu mineralnih sirovina");
                Predmet3.Items.Add("Brodomašinski tehničar");
                Predmet3.Items.Add("Mašinski tehničar za kompjutersko konstruisanje");
                Predmet3.Items.Add("Mašinski tehničar merne i regulacione tehnike");
                Predmet3.Items.Add("Mašinski tehničar motornih vozila");
                Predmet3.Items.Add("Tehničar grejanja i klimatizacije");
                Predmet3.Items.Add("Tehničar za kompjutersko upravljanje (CNC) mašina");
                Predmet3.Items.Add("Tehničar za robotiku");
                Predmet3.Items.Add("Tehničar mašinske energetike");
                Predmet3.Items.Add("Tehničar optike");
                Predmet3.Items.Add("Elektrotehničar automatike");
                Predmet3.Items.Add("Elektrotehničar elektromotornih pogona");
                Predmet3.Items.Add("Elektrotehničar elektronike");
                Predmet3.Items.Add("Elektrotehničar energetike");
                Predmet3.Items.Add("Elektrotehničar za termičke i rashladne uređaje");
                Predmet3.Items.Add("Elektrotehničar informacionih tehnologija");
                Predmet3.Items.Add("Elektrotehničar procesnog upravljanja");
                Predmet3.Items.Add("Elektrotehničar računara");
                Predmet3.Items.Add("Tehničar grafičke dorade");
                Predmet3.Items.Add("Tehničar za zaštitu životne sredine");
                Predmet3.Items.Add("Tehničar za industrijsku farmaceutsku tehnologiju");
                Predmet3.Items.Add("Tehničar štampe");
                Predmet3.Items.Add("Fotograf");
                Predmet3.Items.Add("Hemijski laborant");
                Predmet3.Items.Add("Hemijsko-tehnološki tehničar");
                Predmet3.Items.Add("Tekstilni tehničar");
                Predmet3.Items.Add("Građevinski tehničar za laboratorijska ispitivanja");
                Predmet3.Items.Add("Građevinski tehničar za hidrogradnju");
                Predmet3.Items.Add("Izvođač instalaterskih i završnih građevinskih radova");
                Predmet3.Items.Add("Nautički tehničar – rečni smer");
                Predmet3.Items.Add("Saobraćajno-transportni tehničar");
                Predmet3.Items.Add("Tehničar vuče");
                Predmet3.Items.Add("Tehničar PTT saobraćaja");
                Predmet3.Items.Add("Tehničar unutrašnjeg transporta");
                Predmet3.Items.Add("Transportni komercijalista");
                Predmet3.Items.Add("Kulinarski tehničar");
                Predmet3.Items.Add("Ugostiteljski tehničar");
                Predmet3.Items.Add("Ekonomski tehničar");
                Predmet3.Items.Add("Finansijski tehničar");
                Predmet3.Items.Add("Carinski tehničar");
                Predmet3.Items.Add("Ginekološko-akušerska sestra");
                Predmet3.Items.Add("Zubni tehničar");
                Predmet3.Items.Add("Medicinska sestra – vaspitač");
                Predmet3.Items.Add("Pedijatrijska sestra – tehničar");
                Predmet3.Items.Add("Sanitarno-ekološki tehničar");
                Predmet3.Items.Add("Scenski masker i vlasuljar");
            }
            else if (izabraniTip == "UMETNIČKA MATURA")
            {
                Predmet3.Items.Add("Solfeđo i harmonija");
            }
        }

        private void Jezik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Predmet1.SelectedIndex == -1)
                Predmet1.SelectedIndex = Jezik.SelectedIndex;
        }

        private void SDodajNovog_Click(object sender, EventArgs e)
        {
            SDodajRed();
            ProcitajSablon();
            SSkola.SelectedIndex = -1;
            tNazivSablona.Text = "";
            SOdeljenje.SelectedIndex = -1;
            SJezik.SelectedIndex = -1;
            STipMature.SelectedIndex = -1;
            SPredmet1.SelectedIndex = -1;
            SPredmet2.SelectedIndex = -1;
            SPredmet3.SelectedIndex = -1;

            SOsveziTabelu();
        }

        private void DodajNovog_Click(object sender, EventArgs e)
        {
            DodajRed();

            Skola.SelectedIndex = -1;
            Sabloni.SelectedIndex = -1;
            tIme.Text = "";
            tPrezime.Text = "";
            Odeljenje.SelectedIndex = -1;
            Jezik.SelectedIndex = -1;
            TipMature.SelectedIndex = -1;
            Predmet1.SelectedIndex = -1;
            Predmet2.SelectedIndex = -1;
            Predmet3.SelectedIndex = -1;

            OsveziTabelu();
        }

        private void Obrisi_Click(object sender, EventArgs e)
        {
            ObrisiRed('b');

            OsveziTabelu();
        }

        private void SObrisi_Click(object sender, EventArgs e)
        {
            SObrisiRed('b');
            ProcitajSablon();
            SOsveziTabelu();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            OsveziTabelu();
        }
        private void SRefresh_Click(object sender, EventArgs e)
        {
            SOsveziTabelu();
        }

        private void Izmeni_Click(object sender, EventArgs e)
        {
            if (TabelaSvihUnetihUcenika.CurrentRow == null)
            {
                MessageBox.Show("Izaberite red koji želite da izmenite!");
                return;
            }

            string[] podaci = null;

            if (File.Exists("ucenici.csv"))
            {
                string redZaBrisanje = File.ReadLines("ucenici.csv").Skip(TabelaSvihUnetihUcenika.CurrentRow.Index).FirstOrDefault();

                if (redZaBrisanje != null)
                {
                    podaci = redZaBrisanje.Split(';');
                }
            }

            if (podaci == null || podaci.Length < 8)
            {
                MessageBox.Show("Greška pri učitavanju podataka učenika!");
                return;
            }

            if (podaci[0] != "N/A" && podaci[0].Contains(' '))
            {
                tIme.Text = podaci[0].Split(' ')[0];
                tPrezime.Text = podaci[0].Split(' ')[1];
            }

            Skola.Text = podaci[1];
            Odeljenje.Text = podaci[2];
            TipMature.Text = podaci[3];
            Jezik.Text = podaci[4];
            Predmet1.Text = podaci[5];
            Predmet2.Text = podaci[6];
            Predmet3.Text = podaci[7];

            ObrisiRed('i');
        }

        private void SIzmeni_Click(object sender, EventArgs e)
        {
            if (TabelaSablona.CurrentRow == null)
            {
                MessageBox.Show("Izaberite red koji želite da izmenite!");
                return;
            }

            string[] podaci = null;

            if (File.Exists("sabloni.csv"))
            {
                string redZaBrisanje = File.ReadLines("sabloni.csv").Skip(TabelaSablona.CurrentRow.Index).FirstOrDefault();

                if (redZaBrisanje != null)
                {
                    podaci = redZaBrisanje.Split(';');
                }
            }

            if (podaci == null || podaci.Length < 8)
            {
                MessageBox.Show("Greška pri učitavanju podataka šablona!");
                return;
            }

            tNazivSablona.Text = podaci[0];
            SSkola.Text = podaci[1];
            SOdeljenje.Text = podaci[2];
            STipMature.Text = podaci[3];
            SJezik.Text = podaci[4];
            SPredmet1.Text = podaci[5];
            SPredmet2.Text = podaci[6];
            SPredmet3.Text = podaci[7];

            SObrisiRed('i');
            ProcitajSablon();
        }

        private void Primeni_Click(object sender, EventArgs e)
        {
            if (Sabloni.SelectedIndex == -1)
            {
                MessageBox.Show("Izaberite šablon koji želite da primenite!");
                return;
            }
            else
            {
                string[] podaci = null;

                if (File.Exists("sabloni.csv"))
                {
                    string redZaBrisanje = File.ReadLines("sabloni.csv").Skip(Sabloni.SelectedIndex).FirstOrDefault();

                    if (redZaBrisanje != null)
                    {
                        podaci = redZaBrisanje.Split(';');
                    }
                }

                if (podaci == null || podaci.Length < 8)
                {
                    MessageBox.Show("Greška pri učitavanju podataka šablona!");
                    return;
                }

                Skola.Text = podaci[1];
                Odeljenje.Text = podaci[2];
                TipMature.Text = podaci[3];
                Jezik.Text = podaci[4];
                Predmet1.Text = podaci[5];
                Predmet2.Text = podaci[6];
                Predmet3.Text = podaci[7];
            }
        }

        private void Sacuvaj_Click(object sender, EventArgs e)
        {
            DodajRed();

            OsveziTabelu();
        }
        private void SSacuvaj_Click(object sender, EventArgs e)
        {
            SDodajRed();
            ProcitajSablon();
            SOsveziTabelu();
        }

        public void DodajRed()
        {
            if (TipMature.SelectedIndex == -1 || Predmet1.SelectedIndex == -1 || Predmet2.SelectedIndex == -1 || Predmet3.SelectedIndex == -1 || Jezik.SelectedIndex == -1 || Odeljenje.SelectedIndex == -1 || Skola.SelectedIndex == -1)
            {
                MessageBox.Show("Popunite sve neophodne podatke (osim šablona) pre čuvanja!");
                return;
            }

            string ime = tIme.Text;
            string prezime = tPrezime.Text;

            if (ime == "")
            {
                ime = "N";
            }
            if (prezime == "")
            {
                prezime = "/A";
            }

            string skola = Skola.Text;
            string odeljenje = Odeljenje.Text;
            string tipMature = TipMature.Text;
            string jezik = Jezik.Text;
            string prviPredmet = Predmet1.Text;
            string drugiPredmet = Predmet2.Text;
            string treciPredmet = Predmet3.Text;
            string redZaUpis = $"{ime + " " + prezime};{skola};{odeljenje};{tipMature};{jezik};{prviPredmet};{drugiPredmet};{treciPredmet}";

            using (StreamWriter sw = new StreamWriter("ucenici.csv", true))
            {
                sw.WriteLine(redZaUpis);
            }

            MessageBox.Show("Podaci o učeniku su uspešno sačuvani!");
        }
        public void ObrisiRed(char tip)
        {
            if (TabelaSvihUnetihUcenika.SelectedRows.Count > 0)
            {
                DataGridViewRow redZaBrisanje = TabelaSvihUnetihUcenika.SelectedRows[0];
                TabelaSvihUnetihUcenika.Rows.Remove(redZaBrisanje);

                using (StreamWriter sw = new StreamWriter("ucenici.csv"))
                {
                    foreach (DataGridViewRow red in TabelaSvihUnetihUcenika.Rows)
                    {
                        if (!red.IsNewRow)
                        {
                            string imePrezime = red.Cells[0].Value?.ToString() ?? "";
                            string skola = red.Cells[1].Value?.ToString() ?? "";
                            string odeljenje = red.Cells[2].Value?.ToString() ?? "";
                            string tipMature = red.Cells[3].Value?.ToString() ?? "";
                            string jezik = red.Cells[4].Value?.ToString() ?? "";
                            string prviPredmet = red.Cells[5].Value?.ToString() ?? "";
                            string drugiPredmet = red.Cells[6].Value?.ToString() ?? "";
                            string treciPredmet = red.Cells[7].Value?.ToString() ?? "";

                            string redZaUpis = $"{imePrezime};{skola};{odeljenje};{tipMature};{jezik};{prviPredmet};{drugiPredmet};{treciPredmet}";
                            sw.WriteLine(redZaUpis);
                        }
                    }
                }

                if (tip != 'i')
                {
                    MessageBox.Show("Podaci o učeniku su uspešno obrisani!");
                }
            }
            else
            {
                if (tip == 'i')
                    MessageBox.Show("Izaberite red koji želite da izmenite!");
                else
                    MessageBox.Show("Izaberite red koji želite da obrišete!");
            }
        }

        public void SObrisiRed(char tip)
        {
            if (TabelaSablona.SelectedRows.Count > 0)
            {
                DataGridViewRow redZaBrisanje = TabelaSablona.SelectedRows[0];
                TabelaSablona.Rows.Remove(redZaBrisanje);

                using (StreamWriter sw = new StreamWriter("sabloni.csv"))
                {
                    foreach (DataGridViewRow red in TabelaSablona.Rows)
                    {
                        if (!red.IsNewRow)
                        {
                            string naziv = red.Cells[0].Value?.ToString() ?? "";
                            string skola = red.Cells[1].Value?.ToString() ?? "";
                            string odeljenje = red.Cells[2].Value?.ToString() ?? "";
                            string tipMature = red.Cells[3].Value?.ToString() ?? "";
                            string jezik = red.Cells[4].Value?.ToString() ?? "";
                            string prviPredmet = red.Cells[5].Value?.ToString() ?? "";
                            string drugiPredmet = red.Cells[6].Value?.ToString() ?? "";
                            string treciPredmet = red.Cells[7].Value?.ToString() ?? "";

                            string redZaUpis = $"{naziv};{skola};{odeljenje};{tipMature};{jezik};{prviPredmet};{drugiPredmet};{treciPredmet}";
                            sw.WriteLine(redZaUpis);
                        }
                    }
                }

                if (tip != 'i')
                {
                    MessageBox.Show("Podaci o učeniku su uspešno obrisani!");
                }
            }
            else
            {
                if (tip == 'i')
                    MessageBox.Show("Izaberite red koji želite da izmenite!");
                else
                    MessageBox.Show("Izaberite red koji želite da obrišete!");
            }
        }

        public void SDodajRed()
        {
            if (STipMature.SelectedIndex == -1 || SPredmet1.SelectedIndex == -1 || SPredmet2.SelectedIndex == -1 || SPredmet3.SelectedIndex == -1 || SJezik.SelectedIndex == -1 || SOdeljenje.SelectedIndex == -1 || SSkola.SelectedIndex == -1)
            {
                MessageBox.Show("Popunite sve podatke pre čuvanja!");
                return;
            }

            string naziv = tNazivSablona.Text;
            string skola = SSkola.Text;
            string odeljenje = SOdeljenje.Text;
            string tipMature = STipMature.Text;
            string jezik = SJezik.Text;
            string prviPredmet = SPredmet1.Text;
            string drugiPredmet = SPredmet2.Text;
            string treciPredmet = SPredmet3.Text;
            string redZaUpis = $"{naziv};{skola};{odeljenje};{tipMature};{jezik};{prviPredmet};{drugiPredmet};{treciPredmet}";

            using (StreamWriter sw = new StreamWriter("sabloni.csv", true))
            {
                sw.WriteLine(redZaUpis);
            }

            MessageBox.Show("Podaci o šablonu su uspešno sačuvani!");
        }

        private void OsveziTabelu()
        {
            TabelaSvihUnetihUcenika.Rows.Clear();

            if (File.Exists("ucenici.csv"))
            {
                string[] sviRedovi = File.ReadAllLines("ucenici.csv");

                foreach (string red in sviRedovi)
                {
                    string[] podaci = red.Split(';');

                    if (podaci.Length == 8)
                    {
                        TabelaSvihUnetihUcenika.Rows.Add(podaci[0], podaci[1], podaci[2], podaci[3], podaci[4], podaci[5], podaci[6], podaci[7]);
                    }
                }
            }
        }

        private void SOsveziTabelu()
        {
            TabelaSablona.Rows.Clear();

            if (File.Exists("sabloni.csv"))
            {
                string[] sviRedovi = File.ReadAllLines("sabloni.csv");

                foreach (string red in sviRedovi)
                {
                    string[] podaci = red.Split(';');

                    if (podaci.Length == 8)
                    {
                        TabelaSablona.Rows.Add(podaci[0], podaci[1], podaci[2], podaci[3], podaci[4], podaci[5], podaci[6], podaci[7]);
                    }
                }
            }
        }

        public void ProcitajSablon()
        {
            Sabloni.Items.Clear();

            if (File.Exists("sabloni.csv"))
            {
                string[] sviRedovi = File.ReadAllLines("sabloni.csv");

                foreach (string red in sviRedovi)
                {
                    string[] podaci = red.Split(';');

                    if (podaci.Length == 8)
                    {
                        Sabloni.Items.Add(podaci[0]);
                    }
                }
            }
        }

        private void TabelaSvihUnetihUcenika_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string rowNumber = (e.RowIndex + 1).ToString();

            using (SolidBrush brush = new SolidBrush(Color.Black))
            {
                e.Graphics.DrawString(rowNumber, this.Font, brush, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + 4);
            }
        }
    }
}
