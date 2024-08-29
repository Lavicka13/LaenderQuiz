using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukasQuiz
{
    public class Laender
    {
        private int LandID;
        private string Land;
        private string Hauptstadt;
        private int KontinentID;
        private string Abkuerzung;

        public Laender(int landID, string land, string hauptstadt, int kontinentID, string abkuerzung)
        {
            LandID1 = landID;
            Land1 = land;
            Hauptstadt1 = hauptstadt;
            KontinentID1 = kontinentID;
            Abkuerzung1 = abkuerzung;
        }

        public int LandID1 { get => LandID; set => LandID = value; }
        public string Land1 { get => Land; set => Land = value; }
        public string Hauptstadt1 { get => Hauptstadt; set => Hauptstadt = value; }
        public int KontinentID1 { get => KontinentID; set => KontinentID = value; }
        public string Abkuerzung1 { get => Abkuerzung; set => Abkuerzung = value; }
    }
}
