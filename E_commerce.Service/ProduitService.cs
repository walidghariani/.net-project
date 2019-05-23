using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_commerce.Data;
using E_commerce.Abstract;

namespace E_commerce.Service.Services
{
    class ProduitService : IProduitService
    {
        private IRepositorie<Produit> ProduitRepos;

        public bool addProduit(Produit produit)
        {
            return this.ProduitRepos.Ajouter(produit);
        }

        public bool editProduit(Produit produit)
        {
            return this.ProduitRepos.Modifier(produit);
        }

        public Produit getProduit(int id)
        {
            return this.ProduitRepos.Recherche(id);
        }

        public IQueryable<Produit> getProduits()
        {
            return this.ProduitRepos.Table;
        }

        public bool removeProduit(Produit produit)
        {
            return this.ProduitRepos.Supprimer(produit);
        }
    }
}
