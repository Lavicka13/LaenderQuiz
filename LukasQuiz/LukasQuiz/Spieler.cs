using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukasQuiz
{
    public class Spieler
    {
        private int SpielerID;
        private string Name;

        public Spieler (int SpielerID, string Name)
        {
            this.SpielerID = SpielerID;
            this.Name = Name;
        }
        public int SpielerID1 { get => SpielerID; set => SpielerID = value; }
        public string Name1 { get => Name; set => Name = value; }
    }
}
