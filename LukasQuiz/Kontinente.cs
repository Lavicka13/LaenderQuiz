using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukasQuiz
{
    public class Kontinente
    {
        private int KontinenteID;
        private string Name;

        public Kontinente(int kontinenteID, string name)
        {
            KontinenteID1 = kontinenteID;
            Name1 = name;
        }

        public int KontinenteID1 { get => KontinenteID; set => KontinenteID = value; }
        public string Name1 { get => Name; set => Name = value; }
    }
}
