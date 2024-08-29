namespace LukasQuiz
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
            label1 = new Label();
            cbSpieler = new ComboBox();
            label2 = new Label();
            tbSpielerSpeichern = new TextBox();
            btnSpielerSpeichern = new Button();
            btnSpielStarten = new Button();
            lbHighscore = new ListBox();
            label5 = new Label();
            label6 = new Label();
            lbSpielerHighscore = new ListBox();
            label7 = new Label();
            rBtnLandFrage = new RadioButton();
            rBtnHauptstädteFrage = new RadioButton();
            rBtnFlaggeFrage = new RadioButton();
            rBtnLandAntwort = new RadioButton();
            rBtnHauptstadtAntwort = new RadioButton();
            rBtnFlaggeAntwort = new RadioButton();
            Fragemodus = new GroupBox();
            groupBox1 = new GroupBox();
            cbSpielbereich = new ComboBox();
            label3 = new Label();
            panelQuiz = new Panel();
            lblAktuellerScore = new Label();
            btnSpielAbbrechen = new Button();
            lblScore = new Label();
            lblFlaggen = new Label();
            btnAntwort4 = new Button();
            btnAntwort2 = new Button();
            btnAntwort3 = new Button();
            btnAntwort1 = new Button();
            lblFrage = new Label();
            lblFrageHauptstadt = new Label();
            pbFlagge = new PictureBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            Fragemodus.SuspendLayout();
            groupBox1.SuspendLayout();
            panelQuiz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFlagge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 39);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 0;
            label1.Text = "Spieler auswählen";
            // 
            // cbSpieler
            // 
            cbSpieler.FormattingEnabled = true;
            cbSpieler.Location = new Point(26, 57);
            cbSpieler.Name = "cbSpieler";
            cbSpieler.Size = new Size(121, 23);
            cbSpieler.TabIndex = 1;
            cbSpieler.SelectedIndexChanged += cbSpieler_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 129);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 2;
            label2.Text = "Neuen Spieler erstellen";
            // 
            // tbSpielerSpeichern
            // 
            tbSpielerSpeichern.Location = new Point(26, 147);
            tbSpielerSpeichern.Name = "tbSpielerSpeichern";
            tbSpielerSpeichern.Size = new Size(121, 23);
            tbSpielerSpeichern.TabIndex = 3;
            // 
            // btnSpielerSpeichern
            // 
            btnSpielerSpeichern.Location = new Point(26, 200);
            btnSpielerSpeichern.Name = "btnSpielerSpeichern";
            btnSpielerSpeichern.Size = new Size(121, 23);
            btnSpielerSpeichern.TabIndex = 4;
            btnSpielerSpeichern.Text = "Speichern";
            btnSpielerSpeichern.UseVisualStyleBackColor = true;
            btnSpielerSpeichern.Click += btnSpielerSpeichern_Click;
            // 
            // btnSpielStarten
            // 
            btnSpielStarten.Location = new Point(434, 612);
            btnSpielStarten.Name = "btnSpielStarten";
            btnSpielStarten.Size = new Size(158, 74);
            btnSpielStarten.TabIndex = 9;
            btnSpielStarten.Text = "Spiel Starten";
            btnSpielStarten.UseVisualStyleBackColor = true;
            btnSpielStarten.Click += btnSpielStarten_Click;
            // 
            // lbHighscore
            // 
            lbHighscore.FormattingEnabled = true;
            lbHighscore.ItemHeight = 15;
            lbHighscore.Location = new Point(805, 57);
            lbHighscore.Name = "lbHighscore";
            lbHighscore.Size = new Size(209, 304);
            lbHighscore.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(805, 39);
            label5.Name = "label5";
            label5.Size = new Size(104, 15);
            label5.TabIndex = 11;
            label5.Text = "Gesamt Highscore";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(805, 405);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 12;
            label6.Text = "Spieler Highscore";
            // 
            // lbSpielerHighscore
            // 
            lbSpielerHighscore.FormattingEnabled = true;
            lbSpielerHighscore.ItemHeight = 15;
            lbSpielerHighscore.Location = new Point(805, 423);
            lbSpielerHighscore.Name = "lbSpielerHighscore";
            lbSpielerHighscore.Size = new Size(209, 139);
            lbSpielerHighscore.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(400, 57);
            label7.Name = "label7";
            label7.Size = new Size(128, 15);
            label7.TabIndex = 14;
            label7.Text = "Spielmodus auswählen";
            // 
            // rBtnLandFrage
            // 
            rBtnLandFrage.AutoSize = true;
            rBtnLandFrage.Location = new Point(21, 46);
            rBtnLandFrage.Name = "rBtnLandFrage";
            rBtnLandFrage.Size = new Size(61, 19);
            rBtnLandFrage.TabIndex = 15;
            rBtnLandFrage.TabStop = true;
            rBtnLandFrage.Text = "Länder";
            rBtnLandFrage.UseVisualStyleBackColor = true;
            rBtnLandFrage.CheckedChanged += rBtnLandFrage_Ausgewählt;
            // 
            // rBtnHauptstädteFrage
            // 
            rBtnHauptstädteFrage.AutoSize = true;
            rBtnHauptstädteFrage.Location = new Point(21, 71);
            rBtnHauptstädteFrage.Name = "rBtnHauptstädteFrage";
            rBtnHauptstädteFrage.Size = new Size(90, 19);
            rBtnHauptstädteFrage.TabIndex = 16;
            rBtnHauptstädteFrage.TabStop = true;
            rBtnHauptstädteFrage.Text = "Hauptstädte";
            rBtnHauptstädteFrage.UseVisualStyleBackColor = true;
            rBtnHauptstädteFrage.CheckedChanged += rBtnHauptstädteFrage_Ausgewählt;
            // 
            // rBtnFlaggeFrage
            // 
            rBtnFlaggeFrage.AutoSize = true;
            rBtnFlaggeFrage.Location = new Point(21, 96);
            rBtnFlaggeFrage.Name = "rBtnFlaggeFrage";
            rBtnFlaggeFrage.Size = new Size(67, 19);
            rBtnFlaggeFrage.TabIndex = 17;
            rBtnFlaggeFrage.TabStop = true;
            rBtnFlaggeFrage.Text = "Flaggen";
            rBtnFlaggeFrage.UseVisualStyleBackColor = true;
            rBtnFlaggeFrage.CheckedChanged += rBtnFlaggeFrage_Ausgewählt;
            // 
            // rBtnLandAntwort
            // 
            rBtnLandAntwort.AutoSize = true;
            rBtnLandAntwort.Location = new Point(18, 46);
            rBtnLandAntwort.Name = "rBtnLandAntwort";
            rBtnLandAntwort.Size = new Size(51, 19);
            rBtnLandAntwort.TabIndex = 18;
            rBtnLandAntwort.TabStop = true;
            rBtnLandAntwort.Text = "Land";
            rBtnLandAntwort.UseVisualStyleBackColor = true;
            // 
            // rBtnHauptstadtAntwort
            // 
            rBtnHauptstadtAntwort.AutoSize = true;
            rBtnHauptstadtAntwort.Location = new Point(18, 71);
            rBtnHauptstadtAntwort.Name = "rBtnHauptstadtAntwort";
            rBtnHauptstadtAntwort.Size = new Size(84, 19);
            rBtnHauptstadtAntwort.TabIndex = 19;
            rBtnHauptstadtAntwort.TabStop = true;
            rBtnHauptstadtAntwort.Text = "Hauptstadt";
            rBtnHauptstadtAntwort.UseVisualStyleBackColor = true;
            // 
            // rBtnFlaggeAntwort
            // 
            rBtnFlaggeAntwort.AutoSize = true;
            rBtnFlaggeAntwort.Location = new Point(18, 96);
            rBtnFlaggeAntwort.Name = "rBtnFlaggeAntwort";
            rBtnFlaggeAntwort.Size = new Size(60, 19);
            rBtnFlaggeAntwort.TabIndex = 20;
            rBtnFlaggeAntwort.TabStop = true;
            rBtnFlaggeAntwort.Text = "Flagge";
            rBtnFlaggeAntwort.UseVisualStyleBackColor = true;
            // 
            // Fragemodus
            // 
            Fragemodus.Controls.Add(rBtnLandFrage);
            Fragemodus.Controls.Add(rBtnHauptstädteFrage);
            Fragemodus.Controls.Add(rBtnFlaggeFrage);
            Fragemodus.Location = new Point(287, 89);
            Fragemodus.Name = "Fragemodus";
            Fragemodus.Size = new Size(131, 143);
            Fragemodus.TabIndex = 21;
            Fragemodus.TabStop = false;
            Fragemodus.Text = "Fragemodus";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rBtnLandAntwort);
            groupBox1.Controls.Add(rBtnHauptstadtAntwort);
            groupBox1.Controls.Add(rBtnFlaggeAntwort);
            groupBox1.Location = new Point(523, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(133, 143);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "Antwort Möglichkeiten";
            // 
            // cbSpielbereich
            // 
            cbSpielbereich.FormattingEnabled = true;
            cbSpielbereich.Location = new Point(384, 338);
            cbSpielbereich.Name = "cbSpielbereich";
            cbSpielbereich.Size = new Size(179, 23);
            cbSpielbereich.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(418, 311);
            label3.Name = "label3";
            label3.Size = new Size(130, 15);
            label3.TabIndex = 24;
            label3.Text = "Spielbereich auswählen";
            // 
            // panelQuiz
            // 
            panelQuiz.BackgroundImage = Properties.Resources.export;
            panelQuiz.BackgroundImageLayout = ImageLayout.Stretch;
            panelQuiz.Controls.Add(lblAktuellerScore);
            panelQuiz.Controls.Add(btnSpielAbbrechen);
            panelQuiz.Controls.Add(lblScore);
            panelQuiz.Controls.Add(lblFlaggen);
            panelQuiz.Controls.Add(btnAntwort4);
            panelQuiz.Controls.Add(btnAntwort2);
            panelQuiz.Controls.Add(btnAntwort3);
            panelQuiz.Controls.Add(btnAntwort1);
            panelQuiz.Controls.Add(lblFrage);
            panelQuiz.Controls.Add(lblFrageHauptstadt);
            panelQuiz.Controls.Add(pbFlagge);
            panelQuiz.Location = new Point(3, 0);
            panelQuiz.Name = "panelQuiz";
            panelQuiz.Size = new Size(1074, 782);
            panelQuiz.TabIndex = 25;
            // 
            // lblAktuellerScore
            // 
            lblAktuellerScore.AutoSize = true;
            lblAktuellerScore.Location = new Point(977, 24);
            lblAktuellerScore.Name = "lblAktuellerScore";
            lblAktuellerScore.Size = new Size(56, 15);
            lblAktuellerScore.TabIndex = 22;
            lblAktuellerScore.Text = "Punkte: 0";
            // 
            // btnSpielAbbrechen
            // 
            btnSpielAbbrechen.Location = new Point(951, 661);
            btnSpielAbbrechen.Name = "btnSpielAbbrechen";
            btnSpielAbbrechen.Size = new Size(100, 49);
            btnSpielAbbrechen.TabIndex = 20;
            btnSpielAbbrechen.Text = "Spiel abbrechen";
            btnSpielAbbrechen.UseVisualStyleBackColor = true;
            btnSpielAbbrechen.Click += btnSpielAbbrechen_Click;
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Location = new Point(914, 24);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(0, 15);
            lblScore.TabIndex = 19;
            // 
            // lblFlaggen
            // 
            lblFlaggen.AutoSize = true;
            lblFlaggen.Font = new Font("Segoe UI", 14F);
            lblFlaggen.Location = new Point(334, 373);
            lblFlaggen.Name = "lblFlaggen";
            lblFlaggen.Size = new Size(167, 25);
            lblFlaggen.TabIndex = 18;
            lblFlaggen.Text = "Fragen zu Flaggen";
            lblFlaggen.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAntwort4
            // 
            btnAntwort4.Location = new Point(623, 559);
            btnAntwort4.Name = "btnAntwort4";
            btnAntwort4.Size = new Size(221, 113);
            btnAntwort4.TabIndex = 15;
            btnAntwort4.Text = "button4";
            btnAntwort4.UseVisualStyleBackColor = true;
            btnAntwort4.Click += btnAntwort4_Click;
            // 
            // btnAntwort2
            // 
            btnAntwort2.Location = new Point(159, 559);
            btnAntwort2.Name = "btnAntwort2";
            btnAntwort2.Size = new Size(221, 113);
            btnAntwort2.TabIndex = 14;
            btnAntwort2.Text = "button3";
            btnAntwort2.UseVisualStyleBackColor = true;
            btnAntwort2.Click += btnAntwort2_Click;
            // 
            // btnAntwort3
            // 
            btnAntwort3.Location = new Point(623, 414);
            btnAntwort3.Name = "btnAntwort3";
            btnAntwort3.Size = new Size(221, 113);
            btnAntwort3.TabIndex = 13;
            btnAntwort3.Text = "button2";
            btnAntwort3.UseVisualStyleBackColor = true;
            btnAntwort3.Click += btnAntwort3_Click;
            // 
            // btnAntwort1
            // 
            btnAntwort1.Location = new Point(159, 414);
            btnAntwort1.Name = "btnAntwort1";
            btnAntwort1.Size = new Size(221, 113);
            btnAntwort1.TabIndex = 12;
            btnAntwort1.Text = "button1";
            btnAntwort1.UseVisualStyleBackColor = true;
            btnAntwort1.Click += btnAntwort1_Click_1;
            // 
            // lblFrage
            // 
            lblFrage.AutoSize = true;
            lblFrage.Font = new Font("Segoe UI", 18F);
            lblFrage.Location = new Point(307, 182);
            lblFrage.Name = "lblFrage";
            lblFrage.Size = new Size(198, 32);
            lblFrage.TabIndex = 2;
            lblFrage.Text = "Normale Flaggen";
            lblFrage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFrageHauptstadt
            // 
            lblFrageHauptstadt.AutoSize = true;
            lblFrageHauptstadt.Location = new Point(181, 381);
            lblFrageHauptstadt.Name = "lblFrageHauptstadt";
            lblFrageHauptstadt.Size = new Size(0, 15);
            lblFrageHauptstadt.TabIndex = 1;
            // 
            // pbFlagge
            // 
            pbFlagge.Location = new Point(307, 48);
            pbFlagge.Name = "pbFlagge";
            pbFlagge.Size = new Size(422, 309);
            pbFlagge.SizeMode = PictureBoxSizeMode.CenterImage;
            pbFlagge.TabIndex = 0;
            pbFlagge.TabStop = false;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.export;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1073, 722);
            Controls.Add(panelQuiz);
            Controls.Add(label3);
            Controls.Add(cbSpielbereich);
            Controls.Add(groupBox1);
            Controls.Add(Fragemodus);
            Controls.Add(label7);
            Controls.Add(lbSpielerHighscore);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lbHighscore);
            Controls.Add(btnSpielStarten);
            Controls.Add(btnSpielerSpeichern);
            Controls.Add(tbSpielerSpeichern);
            Controls.Add(label2);
            Controls.Add(cbSpieler);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Fragemodus.ResumeLayout(false);
            Fragemodus.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelQuiz.ResumeLayout(false);
            panelQuiz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbFlagge).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbSpieler;
        private Label label2;
        private TextBox tbSpielerSpeichern;
        private Button btnSpielerSpeichern;
        private Button btnSpielStarten;
        private ListBox lbHighscore;
        private Label label5;
        private Label label6;
        private ListBox lbSpielerHighscore;
        private Label label7;
        private RadioButton rBtnLandFrage;
        private RadioButton rBtnHauptstädteFrage;
        private RadioButton rBtnFlaggeFrage;
        private RadioButton rBtnLandAntwort;
        private RadioButton rBtnHauptstadtAntwort;
        private RadioButton rBtnFlaggeAntwort;
        private GroupBox Fragemodus;
        private GroupBox groupBox1;
        private ComboBox cbSpielbereich;
        private Label label3;
        private Panel panelQuiz;
        private Label lblFrageHauptstadt;
        private PictureBox pbFlagge;
        private Label lbFrageLaender;
        private Label lblFrage;
        private Button btnAntwortHauptstadt1;
        private Button btnAntwortLaender4;
        private Button btnAntwortLaender3;
        private Button btnAntwortLaender2;
        private Button btnAntwortLaender1;
        private Button btnAntwortHauptstadt4;
        private Button btnAntwortHauptstadt2;
        private Button btnAntwortHauptstadt3;
        private Button btnZurueck;
        private Button btnAntwort4;
        private Button btnAntwort2;
        private Button btnAntwort3;
        private Button btnAntwort1;
        private FileSystemWatcher fileSystemWatcher1;
        private Label lblFlaggen;
        private Label lblScore;
        private Button btnSpielAbbrechen;
        private Label lblAktuellerScore;
    }
}
