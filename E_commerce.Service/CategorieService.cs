using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_commerce.Data;
using E_commerce.Abstract;

namespace E_commerce.Service
{
    class CategorieService : ICategorieService
    {
        private IRepositorie<Cataloge> CategorieRepos;

        public CategorieService(IRepositorie<Cataloge> cata)
        {
            this.CategorieRepos = cata;
        }
        public bool addCataloge(Cataloge cata)
        {
            IEnumerable<Cataloge> categories = CategorieRepos.getAll().Where(b => b.nom == cata.nom);
            if (categories.Equals(null))
            {
                return CategorieRepos.Ajouter(cata);
            }
            return false;
        }

        public bool editCataloge(Cataloge cata)
        {
            return CategorieRepos.Modifier(cata);
        }

        public Cataloge getCataloge(int id)
        {
            return CategorieRepos.Recherche(id);
        }

        public IQueryable<Cataloge> getCataloges()
        {
            return CategorieRepos.Table;
        }

        public bool removeCataloge(Cataloge cata)
        {
            return CategorieRepos.Supprimer(cata);
        }
    }
}
