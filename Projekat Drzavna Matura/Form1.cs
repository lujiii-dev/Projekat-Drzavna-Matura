using System.IO;

namespace Projekat_Drzavna_Matura
{
    public partial class Form : System.Windows.Forms.Form
    {
        int Pozicija = 0;
        public Form()
        {
            InitializeComponent();
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
                Predmet3.Items.Add("Objedinjeni test za obrazovne profile: Aranžer u trgovini i Trgovinski tehničar");
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

        private void Obrisi_Click(object sender, EventArgs e)
        {
            OsveziTabelu();

        }

        private void Sacuvaj_Click(object sender, EventArgs e)
        {
            DodajRed();

            OsveziTabelu();
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
                ime = "NA";
            }
            if (prezime == "")
            {
                prezime = "NA";
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

        private void Form_Load(object sender, EventArgs e)
        {
            TabelaSvihUnetihUcenika.Columns.Add("ImePrezime", "Ime i prezime");
            TabelaSvihUnetihUcenika.Columns.Add("Skola", "Škola");
            TabelaSvihUnetihUcenika.Columns.Add("Odeljenje", "Odeljenje");
            TabelaSvihUnetihUcenika.Columns.Add("TipMature", "Tip mature");
            TabelaSvihUnetihUcenika.Columns.Add("Jezik", "Jezik");
            TabelaSvihUnetihUcenika.Columns.Add("PrviPredmet", "1. Predmet");
            TabelaSvihUnetihUcenika.Columns.Add("DrugiPredmet", "2. Predmet");
            TabelaSvihUnetihUcenika.Columns.Add("TreciPredmet", "3. Predmet");


        }

        private void Prethodni_Click(object sender, EventArgs e)
        {
            if (Pozicija > 0)
            {
                Pozicija--;
                TabelaSvihUnetihUcenika.CurrentCell = TabelaSvihUnetihUcenika.Rows[Pozicija].Cells[0];
            }
        }

        private void Sledeci_Click(object sender, EventArgs e)
        {
            if (Pozicija < TabelaSvihUnetihUcenika.Rows.Count - 1)
            {
                Pozicija++;
                TabelaSvihUnetihUcenika.CurrentCell = TabelaSvihUnetihUcenika.Rows[Pozicija].Cells[0];
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            OsveziTabelu();
        }
    }
}
