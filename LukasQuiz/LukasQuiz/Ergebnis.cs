using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukasQuiz
{
    public class Ergebnis
    {
        private int ErgebnisId;
        private int Pkt;
        private DateTime Datum;
        private string spielerID;
    

        public Ergebnis(int ergebnisId, int pkt, DateTime datum, string spielerID)
        {
            ErgebnisId1 = ergebnisId;
            Pkt1 = pkt;
            Datum1 = datum;
            this.spielerID = spielerID;
        }

        public int ErgebnisId1 { get => ErgebnisId; set => ErgebnisId = value; }
        public int Pkt1 { get => Pkt; set => Pkt = value; }
        public DateTime Datum1 { get => Datum; set => Datum = value; }
        public string SpielerID { get => spielerID; set => spielerID = value; }
    }



}
