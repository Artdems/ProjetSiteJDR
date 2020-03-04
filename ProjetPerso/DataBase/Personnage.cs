using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetPerso.DataBase
{
    public class Personnage
    {
        public int ID { get; set; }
        public string Joueur { get; set; }

        public string Nom { get; set; }

        public string Pernoms { get; set; }

        public int Age { get; set; }

        public int Dexteriter { get; set; }

        public int Charisme { get; set; }
        public int Perseption { get; set; }

        public int Constitution { get; set; }

        public int Force { get; set; }

        public int Agiliter { get; set; }

        public int Vie { get; set; }

        public string Note { get; set; }

    }
}
