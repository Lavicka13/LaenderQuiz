using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace LukasQuiz
{
    public partial class Form1 : Form
    {
        private Datenbank db;
        private List<Spieler> liSp;
        private List<Laender> liLaender;
        private List<Ergebnis> liErgebnis;
        private Laender aktuelleFrage;
        private string richtigeAntwort;
        private int aktuellerScore;
        private int aktuelleRunde;

        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            db = new Datenbank();
            panelQuiz.Visible = false;
            dispSpieler();
            dispErgebnis();
            dispKontinente();
            dispSpielerHighscore();


        }
        private void GeneriereFrage()
        {
            liLaender = GetLaenderBySelectedContinent(); // Nur L�nder des ausgew�hlten Kontinents abrufen

            //Liste der L�nder basierend auf ausgew�hltem Kontinent abgerufen
            int frageIndex = rnd.Next(liLaender.Count);
            aktuelleFrage = liLaender[frageIndex];

            //Zuf�lligen Index erstellen
            string frageTyp = HoleAusgew�hltenFrageTyp();
            string antwortTyp = HoleAusgew�hltenAntwortTyp();

            //Je nach Kombination Frage- und Antworttyp wird das UI konfiguriert und die Fragen gesetzt
            if (frageTyp == "flagge" && antwortTyp == "land")
            {
                lblFlaggen.Text = "Welches Land geh�rt zu dieser Flagge?";
                pbFlagge.Image = Image.FromFile($"D:\\Desktop\\MouseWithoutBorders\\LukasQuiz\\LukasQuiz\\png1000px/{aktuelleFrage.Abkuerzung1}.png");
                pbFlagge.SizeMode = PictureBoxSizeMode.Zoom;
                pbFlagge.Visible = true;
                lblFrage.Visible = false;
                lblFlaggen.Visible = true;
            }
            else if (frageTyp == "flagge" && antwortTyp == "hauptstadt")
            {
                lblFlaggen.Text = "Welche Hauptstadt geh�rt zu dieser Flagge?";
                pbFlagge.Image = Image.FromFile($"D:\\Desktop\\MouseWithoutBorders\\LukasQuiz\\LukasQuiz\\png1000px/{aktuelleFrage.Abkuerzung1}.png");
                pbFlagge.SizeMode = PictureBoxSizeMode.Zoom;
                pbFlagge.Visible = true;
                lblFrage.Visible = false;
                lblFlaggen.Visible = true;
            }
            else if (frageTyp == "land" && antwortTyp == "hauptstadt")
            {
                lblFrage.Text = $"Welche Hauptstadt geh�rt zu {aktuelleFrage.Land1}?";
                pbFlagge.Visible = false;
                lblFrage.Visible = true;
                lblFlaggen.Visible = false;
            }
            else if (frageTyp == "land" && antwortTyp == "flagge")
            {
                lblFrage.Text = $"Welche Flagge hat das Land {aktuelleFrage.Land1}?";
                pbFlagge.Visible = false;
                lblFrage.Visible = true;
                lblFlaggen.Visible = false;
            }
            else if (frageTyp == "hauptstadt" && antwortTyp == "land")
            {
                lblFrage.Text = $"Welches Land hat die Hauptstadt {aktuelleFrage.Hauptstadt1}?";
                pbFlagge.Visible = false;
                lblFrage.Visible = true;
                lblFlaggen.Visible = false;
            }
            else if (frageTyp == "hauptstadt" && antwortTyp == "flagge")
            {
                lblFrage.Text = $"Welche Flagge geh�rt zu der Hauptstadt {aktuelleFrage.Hauptstadt1}?";
                pbFlagge.Visible = false;
                lblFrage.Visible = true;
                lblFlaggen.Visible = false;
            }
            //Richtige Antwort  entsprechend des Antworttyps wird gesetzt
            SetzeRichtigeAntwort(antwortTyp);

            AntwortenGenerieren();
        }

        // Methode zur Abrufung der L�nder basierend auf dem ausgew�hlten Kontinent
        private List<Laender> GetLaenderBySelectedContinent()
        {
            string selectedContinent = cbSpielbereich.SelectedItem.ToString();

            if (selectedContinent == "Weltweit")
            {
                return db.getLaender(); // Alle L�nder aus der Datenbank abrufen
            }
            else
            {
                // L�nder nur f�r den ausgew�hlten Kontinent abrufen
                Kontinente selectedKontinent = db.getKontinente().FirstOrDefault(k => k.Name1 == selectedContinent);
                if (selectedKontinent != null)
                {
                    return db.getLaender().Where(l => l.KontinentID1 == selectedKontinent.KontinenteID1).ToList();
                }
            }

            return new List<Laender>(); // R�ckgabe einer leeren Liste, falls kein Kontinent ausgew�hlt oder nicht gefunden
        }

        // Methode zur Setzung der Flaggenbilder anhand der ausgew�hlten Optionen
        private void SetzeFlaggenBilder()
        {
            string verzeichnisPfad = @"D:\Desktop\MouseWithoutBorders\LukasQuiz\LukasQuiz\png100px";
            List<string> flaggenDateien = Directory.GetFiles(verzeichnisPfad, "*.png").ToList();

            if (flaggenDateien.Count < 4)
            {
                MessageBox.Show("Nicht genug Flaggenbilder im Verzeichnis.");
                return;
            }

            // Liste f�r die ausgew�hlten Flaggen
            List<string> ausgew�hlteFlaggen = new List<string>();

            // Zuf�llig 3 verschiedene Flaggen ausw�hlen
            while (ausgew�hlteFlaggen.Count < 3)
            {
                int zufallsIndex = rnd.Next(flaggenDateien.Count);
                string zuf�lligeFlagge = flaggenDateien[zufallsIndex];
                if (!ausgew�hlteFlaggen.Contains(zuf�lligeFlagge))
                {
                    ausgew�hlteFlaggen.Add(zuf�lligeFlagge);
                }
            }

            // Die richtige Antwort wird hinzugef�gt
            string richtigeAntwortPfad = verzeichnisPfad + "\\" + richtigeAntwort.ToLower() + ".png";
            ausgew�hlteFlaggen.Add(richtigeAntwortPfad);


            // Liste wird gemischt
            ausgew�hlteFlaggen = ausgew�hlteFlaggen.OrderBy(a => rnd.Next()).ToList();

            // Setze die Bilder auf die Buttons
            btnAntwort1.Image = Image.FromFile(ausgew�hlteFlaggen[0]);
            btnAntwort2.Image = Image.FromFile(ausgew�hlteFlaggen[1]);
            btnAntwort3.Image = Image.FromFile(ausgew�hlteFlaggen[2]);
            btnAntwort4.Image = Image.FromFile(ausgew�hlteFlaggen[3]);


            // Setze die Tag-Werte f�r die Buttons entsprechend der richtigen Antwort
            btnAntwort1.Tag = Path.GetFileNameWithoutExtension(ausgew�hlteFlaggen[0]).Equals(richtigeAntwort, StringComparison.OrdinalIgnoreCase) ? "correct" : "wrong";
            btnAntwort2.Tag = Path.GetFileNameWithoutExtension(ausgew�hlteFlaggen[1]).Equals(richtigeAntwort, StringComparison.OrdinalIgnoreCase) ? "correct" : "wrong";
            btnAntwort3.Tag = Path.GetFileNameWithoutExtension(ausgew�hlteFlaggen[2]).Equals(richtigeAntwort, StringComparison.OrdinalIgnoreCase) ? "correct" : "wrong";
            btnAntwort4.Tag = Path.GetFileNameWithoutExtension(ausgew�hlteFlaggen[3]).Equals(richtigeAntwort, StringComparison.OrdinalIgnoreCase) ? "correct" : "wrong";

            //Bilder werden auf die Buttons gelegt
            btnAntwort1.BackgroundImageLayout = ImageLayout.Center;
            btnAntwort2.BackgroundImageLayout = ImageLayout.Center;
            btnAntwort3.BackgroundImageLayout = ImageLayout.Center;
            btnAntwort4.BackgroundImageLayout = ImageLayout.Center;

            //Buttontext wird gel�scht
            btnAntwort1.Text = "";
            btnAntwort2.Text = "";
            btnAntwort3.Text = "";
            btnAntwort4.Text = "";
        }

        // Methode zur Setzung der richtigen Antwort basierend auf dem Antworttyp
        private void SetzeRichtigeAntwort(string antwortTyp)
        {
            if (antwortTyp == "land")
            {
                richtigeAntwort = aktuelleFrage.Land1;
            }
            else if (antwortTyp == "hauptstadt")
            {
                richtigeAntwort = aktuelleFrage.Hauptstadt1;
            }
            else if (antwortTyp == "flagge")
            {
                richtigeAntwort = aktuelleFrage.Abkuerzung1; // Aktualisiert f�r Flaggenantworten
            }
        }
        //Methode zum ermitteln des Fragetyps
        private string HoleAusgew�hltenFrageTyp() // Hier wird der Fragetyp ermittelt
        {
            if (rBtnLandFrage.Checked) return "land";
            if (rBtnHauptst�dteFrage.Checked) return "hauptstadt";
            if (rBtnFlaggeFrage.Checked) return "flagge";
            return null;
        }
        //Methode zum ermitteln des Antworttyps
        private string HoleAusgew�hltenAntwortTyp() // Hier wird der Antworttyp ermittelt
        {
            if (rBtnLandAntwort.Checked) return "land";
            if (rBtnHauptstadtAntwort.Checked) return "hauptstadt";
            if (rBtnFlaggeAntwort.Checked) return "flagge";
            return null;
        }
        //Methode zm Generieren der m�glichen Antworten
        private void AntwortenGenerieren()
        {
            string frageTyp = HoleAusgew�hltenFrageTyp();
            string antwortTyp = HoleAusgew�hltenAntwortTyp();
            //Liste mit Antwortoptionen, richtige antwort an erster Stelle
            List<string> answerOptions = new List<string> { richtigeAntwort };

            while (answerOptions.Count < 4)
            {   //Zuf�llige L�nderauswahl
                Laender randomOption = liLaender[rnd.Next(liLaender.Count)];
                string option = antwortTyp == "land" ? randomOption.Land1 : (antwortTyp == "hauptstadt" ? randomOption.Hauptstadt1 : randomOption.Abkuerzung1);
                if (!answerOptions.Contains(option))
                {
                    answerOptions.Add(option);
                }
            }

            answerOptions = answerOptions.OrderBy(x => rnd.Next()).ToList();

            // Je nach Antworttyp wird entweder das Land, die Hauptstadt oder die Abk�rzung als Option hinzugef�gt
            if (frageTyp == "land" && antwortTyp == "flagge" || frageTyp == "hauptstadt" && antwortTyp == "flagge")
            {
                // Spezielle Logik f�r Flaggen
                SetzeFlaggenBilder();
            }
            else
            {
                //Antworten werden auf die Buttons gesetzt - bei Antworttyp Land und Hauptstadt
                btnAntwort1.Text = answerOptions[0];
                btnAntwort2.Text = answerOptions[1];
                btnAntwort3.Text = answerOptions[2];
                btnAntwort4.Text = answerOptions[3];

                // Setze die Tag-Werte f�r die Buttons entsprechend der richtigen Antwort
                btnAntwort1.Tag = answerOptions[0] == richtigeAntwort ? "correct" : "wrong";
                btnAntwort2.Tag = answerOptions[1] == richtigeAntwort ? "correct" : "wrong";
                btnAntwort3.Tag = answerOptions[2] == richtigeAntwort ? "correct" : "wrong";
                btnAntwort4.Tag = answerOptions[3] == richtigeAntwort ? "correct" : "wrong";
            }
        }

        private void QuizStarten()
        {
            panelQuiz.Visible = true;
            aktuellerScore = 0;
            aktuelleRunde = 1;
            GeneriereFrage();
            AntwortenGenerieren();
        }
        //Methode zum Antwortpr�fen
        private void �berpr�feAntwort(System.Windows.Forms.Button btn)
        {
            bool antwortRichtig = btn.Tag.ToString() == "correct";

            if (antwortRichtig)
            {
                btn.BackColor = Color.Green; // Hintergrund gr�n bei richtiger Antwort
                aktuellerScore++;
            }
            else
            {
                btn.BackColor = Color.Red; //Bei falscher Antwort Hintergrund rot

            }

            // Deaktiviere die Buttons, damit der Spieler keine weiteren Antworten ausw�hlen kann
            DeaktiviereAntwortButtons();

            //Aktuellen SpielScore anzeigen
            
            lblAktuellerScore.Text = "Punkte: " + aktuellerScore.ToString();
            // Verz�gerung f�r visuelle R�ckmeldung 
            Task.Delay(1000).ContinueWith(t =>
            {
                //N�chste Frage generieren
                if (aktuelleRunde < 10)
                {
                    aktuelleRunde++;
                    GeneriereFrage();
                }
                else
                {
                    QuizBeenden();
                }

                // Hintergrundfarbe von Buttons zur�cksetzen
                btnAntwort1.BackColor = SystemColors.Control;
                btnAntwort2.BackColor = SystemColors.Control;
                btnAntwort3.BackColor = SystemColors.Control;
                btnAntwort4.BackColor = SystemColors.Control;


                AktiviereAntwortButtons();
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }
        //Antwortbuttons werden kurz deaktiviert um eine erneute Antwort zu vermeiden       
        private void DeaktiviereAntwortButtons()
        {
            btnAntwort1.Enabled = false;
            btnAntwort2.Enabled = false;
            btnAntwort3.Enabled = false;
            btnAntwort4.Enabled = false;
        }
        //Buttons werden reaktiviert
        private void AktiviereAntwortButtons()
        {
            btnAntwort1.Enabled = true;
            btnAntwort2.Enabled = true;
            btnAntwort3.Enabled = true;
            btnAntwort4.Enabled = true;
        }
        //Antwort beim Klicken �berpr�fen
        private void btnAntwort1_Click_1(object sender, EventArgs e)
        {
            �berpr�feAntwort((System.Windows.Forms.Button)sender);
        }
        //Antwort beim Klicken �berpr�fen
        private void btnAntwort2_Click(object sender, EventArgs e)
        {
            �berpr�feAntwort((System.Windows.Forms.Button)sender);
        }
        //Antwort beim Klicken �berpr�fen
        private void btnAntwort3_Click(object sender, EventArgs e)
        {
            �berpr�feAntwort((System.Windows.Forms.Button)sender);
        }
        //Antwort beim Klicken �berpr�fen
        private void btnAntwort4_Click(object sender, EventArgs e)
        {
            �berpr�feAntwort((System.Windows.Forms.Button)sender);
        }
        //Spiel starten
        private void btnSpielStarten_Click(object sender, EventArgs e)
        {
            if (cbSpieler.SelectedIndex == -1)
            {
                MessageBox.Show("Bitte w�hlen Sie einen Spieler aus.", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //�berpr�fung ob Fragetyp ausgew�hlt wurde
            if (!IstEinRadioButtonAusgew�hlt(new[] { rBtnLandFrage, rBtnHauptst�dteFrage, rBtnFlaggeFrage }))
            {
                MessageBox.Show("Bitte w�hlen Sie einen Fragemodus aus.", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //�berpr�fung ob Antworttyp gew�hlt wurde, falls nicht zuf�llig den Antworttyp ermitteln
            if (!IstEinRadioButtonAusgew�hlt(new[] { rBtnLandAntwort, rBtnHauptstadtAntwort, rBtnFlaggeAntwort }))
            {
                DialogResult result = MessageBox.Show("Es wurde kein Antwortmodus ausgew�hlt. M�chten Sie, dass die Antwortm�glichkeiten zuf�llig gew�hlt werden?", "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // Zuf�llige Auswahl der Antwortmodi
                    List<RadioButton> antwortModi = new List<RadioButton> { rBtnLandAntwort, rBtnHauptstadtAntwort, rBtnFlaggeAntwort };
                    RadioButton zuf�lligerAntwortModus = antwortModi[rnd.Next(antwortModi.Count)];
                    zuf�lligerAntwortModus.Checked = true;
                }
                else
                {
                    return;
                }
            }
            QuizStarten();
        }
        //Methode um einen neuen Spieler zu speichern
        private void btnSpielerSpeichern_Click(object sender, EventArgs e)
        {
            string spielerName = tbSpielerSpeichern.Text.Trim();
            

            if (spielerName.Length <= 3)
            {
                MessageBox.Show("Der Spielername muss mindestens 3 Zeichen lang sein.", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Spieler s = new Spieler(-1, spielerName);
            db.saveSpieler(s);
            dispSpieler();
            cbSpieler.SelectedIndex = cbSpieler.Items.IndexOf(spielerName); //Neu erstellter Spieler wird in der ComboBox direkt ausgew�hlt
        }
        //Methode um Spieler in der ComboBox anzuzeigen
        private void dispSpieler()
        {
            //Spieler werden aus der Datenbank in eine Liste gespeichert
            liSp = db.getSpieler();
            cbSpieler.Items.Clear();

            foreach (Spieler s in liSp)
            {
                cbSpieler.Items.Add(s.Name1);
            }
        }
        //Festlegen, dass bestimmte Frage- und Antworttypkombinationen nicht m�glich sind.
        //z.B. Fragetyp Flaggen mit Antworttyp Flaggen 
        private void rBtnFlaggeFrage_Ausgew�hlt(object sender, EventArgs e)
        {
            if (rBtnFlaggeFrage.Checked)
            {
                rBtnFlaggeAntwort.Checked = false;
                rBtnFlaggeAntwort.Enabled = false;
            }
            else
            {
                rBtnFlaggeAntwort.Enabled = true;
            }
        }
        //Festlegen, dass bestimmte Frage- und Antworttypkombinationen nicht m�glich sind.
        //z.B. Fragetyp Flaggen mit Antworttyp Flaggen 
        private void rBtnLandFrage_Ausgew�hlt(object sender, EventArgs e)
        {
            if (rBtnLandFrage.Checked)
            {
                rBtnLandAntwort.Checked = false;
                rBtnLandAntwort.Enabled = false;
            }
            else
            {
                rBtnLandAntwort.Enabled = true;
            }
        }
        //Festlegen, dass bestimmte Frage- und Antworttypkombinationen nicht m�glich sind.
        //z.B. Fragetyp Flaggen mit Antworttyp Flaggen 
        private void rBtnHauptst�dteFrage_Ausgew�hlt(object sender, EventArgs e)
        {
            if (rBtnHauptst�dteFrage.Checked)
            {
                rBtnHauptstadtAntwort.Checked = false;
                rBtnHauptstadtAntwort.Enabled = false;
            }
            else
            {
                rBtnHauptstadtAntwort.Enabled = true;
            }
        }
        //Methode um Ergebnisse aller Spieler anzuzeigen
        private void dispErgebnis()
        {
            liErgebnis = db.getErgebnis();

            lbHighscore.Items.Clear();

            foreach (Ergebnis e in liErgebnis)
            {
                string datumOhneZeit = e.Datum1.ToString("dd-MM-yyyy");
                lbHighscore.Items.Add($"{e.SpielerID}: {e.Pkt1} Punkte am {datumOhneZeit}");
            }
        }
        //Methode um Ergebnisse eines einzelnen Spielers anzuzeigen
        private void dispSpielerHighscore()
        {
            if (cbSpieler.SelectedIndex == -1)
            {
                lbSpielerHighscore.Items.Clear();
                return;
            }

            string selectedSpielerName = cbSpieler.SelectedItem.ToString();
            Spieler selectedSpieler = liSp.FirstOrDefault(s => s.Name1.ToString() == selectedSpielerName);

            if (selectedSpieler == null)
            {
                lbSpielerHighscore.Items.Clear();
                return;
            }

            string spielerId = selectedSpieler.Name1;

            // Ergebnisse des ausgew�hlten Spielers abrufen
            List<Ergebnis> spielerErgebnisse = liErgebnis.Where(e => e.SpielerID == spielerId).ToList();

            lbSpielerHighscore.Items.Clear();

            foreach (Ergebnis e in spielerErgebnisse)
            {
                string datumOhneZeit = e.Datum1.ToString("yyyy-MM-dd"); // Datum ohne Uhrzeit
                lbSpielerHighscore.Items.Add($"{e.Pkt1} Punkte am {datumOhneZeit}");
            }
        }
        //Methode um Kontinente in der ComboBox anzuzeigen
        private void dispKontinente()
        {
            List<Kontinente> liKontinente = db.getKontinente();
            cbSpielbereich.Items.Clear();

            // "Weltweit"-Option hinzuf�gen
            cbSpielbereich.Items.Add("Weltweit");

            if (liKontinente.Count > 0)
            {
                foreach (Kontinente k in liKontinente)
                {
                    cbSpielbereich.Items.Add(k.Name1);
                }
            }

            cbSpielbereich.SelectedIndex = 0;
        }

        //Methode zur �berpr�fung von Radiobuttons
        private bool IstEinRadioButtonAusgew�hlt(RadioButton[] radioButtons)
        {
            foreach (RadioButton rb in radioButtons)
            {
                if (rb.Checked)
                {
                    return true;
                }
            }
            return false;
        }
        //Methode zum Beenden des Quizzes
        private void QuizBeenden()
        {
            //Buttons werden zur�ckgesetzt falls eine Runde davor Flaggen erraten wurden
            btnAntwort1.Image = null;
            btnAntwort2.Image = null;
            btnAntwort3.Image = null;
            btnAntwort4.Image = null;

            //Punktestand im Spiel zur�cksetzen
            lblAktuellerScore.Text = "Punkte: 0";

            panelQuiz.Visible = false;
            MessageBox.Show($"Quiz beendet! Dein Score: {aktuellerScore} / 10");

            if (cbSpieler.SelectedIndex != -1)
            {
                string spielerName = cbSpieler.SelectedItem.ToString();
                Spieler spieler = liSp.FirstOrDefault(s => s.Name1 == spielerName);

                if (spieler != null)
                {
                    Ergebnis ergebnis = new Ergebnis(-1, aktuellerScore, DateTime.Now, spieler.SpielerID1.ToString());
                    try
                    {
                        db.saveErgebnis(ergebnis);
                        dispErgebnis();
                        dispSpielerHighscore();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ein Fehler ist aufgetreten: {ex.Message}");
                    }

                }
            }
        }
        //Methode um beim ausw�hlen eines Spielers seine Ergebnisse anzuzeigen
        private void cbSpieler_SelectedIndexChanged(object sender, EventArgs e)
        {
            dispSpielerHighscore();
        }
        //Methode um das Spiel abzubrechen
        private void btnSpielAbbrechen_Click(object sender, EventArgs e)
        { 
            DialogResult result = MessageBox.Show("M�chten Sie das Quiz wirklich abbrechen?", "Quiz abbrechen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                panelQuiz.Visible = false;
                aktuellerScore = 0;
                aktuelleRunde = 1;
                lblAktuellerScore.Text = "Punkte: 0";
            }
        }
    }
}






