using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_commerce.Abstract;
using E_commerce.Data;

namespace E_commerce.Service
{
    class PanierService : IPanierService
    {
        private IRepositorie<Panier> PanierRepos;

        public PanierService(IRepositorie<Panier> panier)
        {
            this.PanierRepos = panier;
        }

        public bool addPanier(Panier panier)
        {
            return this.PanierRepos.Ajouter(panier);
        }

        public bool editPanier(Panier panier)
        {
            return this.PanierRepos.Modifier(panier);
        }

        public Panier getPanier(int id)
        {
            return this.PanierRepos.Recherche(id);
        }

        public IQueryable<Panier> getPaniers()
        {
            return this.PanierRepos.Table;
        }

        public bool removePanier(Panier panier)
        {
            return this.PanierRepos.Supprimer(panier);
        }
    }
}
