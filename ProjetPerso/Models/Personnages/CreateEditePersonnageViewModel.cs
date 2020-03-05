using ProjetPerso.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetPerso.Models.Personnages
{
    public class CreateEditePersonnageViewModel
    {
        public Personnage Personnages { get; set; }

        public bool Nouveau { get; set; }

        public CreateEditePersonnageViewModel(Personnage _perso = null)
        {
            if(_perso != null)
            {
                Personnages = _perso;
            }
            else
            {
                Personnages = new Personnage();
            }
        }
    }
}
