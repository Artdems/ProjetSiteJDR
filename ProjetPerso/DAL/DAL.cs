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
            return (client.Personnages.ToList());
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
