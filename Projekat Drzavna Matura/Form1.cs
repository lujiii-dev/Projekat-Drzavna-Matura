namespace Projekat_Drzavna_Matura
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void DodajNovog_Click(object sender, EventArgs e)
        {
            Sabloni.Text = "";
            tIme.Text = "";
            tPrezime.Text = "";
            Odeljenje.Text = "";
            Jezik.Text = "";
            TipMature.Text = "";
            Predmet1.Text = "";
            Predmet2.Text = "";
            Predmet3.Text = "";
        }

        private void TipMature_SelectedIndexChanged(object sender, EventArgs e)
        {
            Odeljenje.Items.Clear();
            Predmet3.Items.Clear();

            string izabraniTip = TipMature.SelectedItem.ToString();

            if (izabraniTip == "OPŠTA MATURA")
            {
                Odeljenje.Items.Add("IV-1");
                Odeljenje.Items.Add("IV-2");
                Odeljenje.Items.Add("IV-3");
                Odeljenje.Items.Add("IV-4");

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
                Odeljenje.Items.Add("III-1");
                Odeljenje.Items.Add("III-2");
                Odeljenje.Items.Add("III-3");
                Odeljenje.Items.Add("III-4");

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
                Odeljenje.Items.Add("IV-Muzičko");
                Odeljenje.Items.Add("IV-Likovno");

                Predmet3.Items.Add("Solfeđo i harmonija");
            }
        }

        private void Jezik_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Predmet1.SelectedIndex == -1)
                Predmet1.SelectedIndex = Jezik.SelectedIndex;
        }
    }
}
