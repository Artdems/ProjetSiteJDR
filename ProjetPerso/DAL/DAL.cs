using ProjetPerso.DataBase;
using ProjetPerso.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetPerso.DAL
{
    public class DB
    {

         private DataContext client = new DataContext();

        public List<Personnage> GetAllPersonnages()
        {
            /*client.Add(new Personnage { Joueur = "Arthur", Pernoms = "Torgis", Nom = "Desmarais", Age = 23, Dexteriter = 0, Charisme = 1, Perseption = 2, Constitution = 3, Force = 4, Agiliter = 5, Vie = 20, Note = "Perso Teste" });
            client.Add(new Personnage { Joueur = "Nicolas", Pernoms = "Daerios", Nom = "Perdrix", Age = 21, Dexteriter = 6, Charisme = 7, Perseption = 8, Constitution = 9, Force = 10, Agiliter = 11, Vie = 20, Note = "Perso Teste 2" });
            client.Add(new Personnage { Joueur = "Jean", Pernoms = "Gatosec", Nom = "Rimlinger", Age = 24, Dexteriter = 12, Charisme = 13, Perseption = 14, Constitution = 15, Force = 16, Agiliter = 17, Vie = 20, Note = "Perso Teste 3" });
            client.Add(new Personnage { Joueur = "Alexie", Pernoms = "Xélias", Nom = "Perrot", Age = 22, Dexteriter = 18, Charisme = 19, Perseption = 20, Constitution = 21, Force = 22, Agiliter = 23, Vie = 20, Note = "Perso Teste 4" });
            client.SaveChanges();*/
            return (client.Personnages.ToList());
        }

        public Personnage GetPersonnage(int id)
        {
            return (client.Personnages.Where(b => b.ID.Equals(id)).First());
        }

        public void DeletePersonnage(int id)
        {
            Personnage perso = client.Personnages.Where(b => b.ID.Equals(id)).First();
            client.Remove(perso);

            client.SaveChanges();
        }

        public void CreatPersonnage(Personnage perso)
        {
            client.Personnages.Add(perso);

            client.SaveChanges();
        }
    }
}
